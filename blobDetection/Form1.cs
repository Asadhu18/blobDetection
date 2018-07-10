using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Math;
using AForge.Math.Geometry;
using AForge.Imaging;
using AForge.Imaging.Filters;




namespace blobDetection
{
    public partial class cannyMinBlobSize : Form
    {
        public VideoCaptureDevice captureDevice;
        public FilterInfoCollection deviceList;
        public Color verticalColor = new Color();
        public Color horizontalColor = new Color();
        public int blackandwhiteHistogramToggle = 1;
        public int cannyHistogramToggle = 1;


        public cannyMinBlobSize()
        {
            InitializeComponent();
        }

        private void scrollableImagePanel4_Load(object sender, EventArgs e)
        {

        }

        private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];
            return array;
        }
    
        private void BlobDetection_Load(object sender, EventArgs e)
        {
            deviceList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (deviceList.Count == 0)
            {
                throw new Exception();
            }
            videoSourceList.Items.Clear();

            foreach (FilterInfo device in deviceList)
            {
                videoSourceList.Items.Add(device.Name);
            }
            videoSourceList.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();
        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(deviceList[videoSourceList.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = captureDevice;
            videoSourcePlayer1.Start();
        }

        public Bitmap captureImage()
        {
            GammaCorrection gamaFilter = new GammaCorrection((gamaSlider1.Value)/100.0);
            ContrastCorrection contrastFilter = new ContrastCorrection(contrastSlider.Value);
            GaussianSharpen gausianSharpenFilter = new GaussianSharpen();
            Bitmap capturedColorImage = (Bitmap)videoSourcePlayer1.GetCurrentVideoFrame();
            
            capturedColorImage = gamaFilter.Apply(capturedColorImage);
            capturedColorImage = contrastFilter.Apply(capturedColorImage);
            capturedImagePanel.Image = capturedColorImage;
            return capturedColorImage;
        }

        public Bitmap grayscaleImageConvert(Bitmap colorImage)
        {
            double redValue = redSlider.Value / 100.0;
            double blueValue = blueSlider.Value / 100.0;
            double greenValue = greenSlider.Value / 100.0;
            Grayscale grayscaleFilter = new Grayscale(redValue,blueValue,greenValue);
            Bitmap grayScaleBitmap = grayscaleFilter.Apply(colorImage);
            grayScalePanel.Image = grayScaleBitmap;
            return grayScaleBitmap;
        }

        public Bitmap blackandWhiteImageConvert(Bitmap grayImage)
        {
            Threshold thresholdFilter = new Threshold();
            thresholdFilter.ThresholdValue = blackandwhiteSlider.Value;
            Bitmap blackandwhiteBitmap = thresholdFilter.Apply(grayImage);
            blackandwhitePanel.Image = blackandwhiteBitmap;
            return blackandwhiteBitmap;
        }

        public Bitmap cannyImageConvert(Bitmap grayImage)
        {
            CannyEdgeDetector edgeDectector = new CannyEdgeDetector();
            edgeDectector.HighThreshold = (byte)cannyMaxSlider.Value;
            edgeDectector.LowThreshold = (byte)cannyMinSlider.Value;
            edgeDectector.Apply(grayImage);
            Bitmap cannyBitmap = edgeDectector.Apply(grayImage);
            cannyPanel.Image = cannyBitmap;
            return cannyBitmap;
        }

        public Bitmap blobDetection(Bitmap inImage, int Min, int Max)
        {
            Pen fuschiaPen = new Pen(Color.Fuchsia, 3.0f);
            Pen aquaPen = new Pen(Color.Aqua, 5.0f);
            Pen redPen = new Pen(Color.Red, 3.0f);
            Pen orangePen = new Pen(Color.Orange, 3.0f);

            Bitmap workingFrame = inImage;
            System.Drawing.Imaging.BitmapData bmpData = workingFrame.LockBits(new Rectangle(0, 0, workingFrame.Width, workingFrame.Height), System.Drawing.Imaging.ImageLockMode.ReadWrite, workingFrame.PixelFormat);
            workingFrame.UnlockBits(bmpData);

            //Identifing the Blobs in target picture
            BlobCounter blobCounter = new BlobCounter();

            blobCounter.FilterBlobs = true;

            blobCounter.MinHeight = Min;
            blobCounter.MinWidth = Min;
            blobCounter.MaxHeight = Max;
            blobCounter.MaxWidth = Max;

            blobCounter.ProcessImage(bmpData);
            Blob[] blobs = blobCounter.GetObjectsInformation();


            //Classifying the objects{}
            AForge.Math.Geometry.SimpleShapeChecker shapeCheck = new SimpleShapeChecker();
            Bitmap tempBitmap = new Bitmap(workingFrame.Width, workingFrame.Height);
            Graphics g = Graphics.FromImage(tempBitmap);
            g.DrawImage(workingFrame, 0, 0);

            int blobLength = blobs.Length;
            for (int i = 0; i < blobLength; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);
                AForge.Point center;
                float radius;

                if (shapeCheck.IsCircle(edgePoints, out center, out radius))
                {
                    float tempLocationX = (float)(center.X - radius);
                    float tempLocationY = (float)(center.Y - radius);
                    float diameter = radius * 2.0f;
                    g.DrawEllipse(fuschiaPen, tempLocationX, tempLocationY, diameter, diameter);
                }
                else
                {
                    List<IntPoint> corners = new List<IntPoint>();
                    if (edgePoints.Count > 1)
                    {
                        corners = PointsCloud.FindQuadrilateralCorners(edgePoints);

                        if (shapeCheck.IsQuadrilateral(edgePoints, out corners))
                        {
                            Rectangle testRectangle = new Rectangle(corners[0].X, corners[0].Y, (corners[1].X - corners[0].X), corners[3].Y - corners[0].Y);
                            g.DrawRectangle(redPen, testRectangle);

                            if (shapeCheck.CheckPolygonSubType(corners) == PolygonSubType.Rectangle)
                            {
                                g.DrawPolygon(aquaPen, ToPointsArray(corners));

                            }
                            else
                            {
                                g.DrawPolygon(orangePen, ToPointsArray(corners));
                            }
                        }
                    }

                }
                
            }
            return tempBitmap;
        }

        public Bitmap extractHistogramData(System.Drawing.Image inImage, int inVerticalStartRow, int inVerticalRowGap, int inHorizontalStartRow,int inHorizontalRowGap, int inAvergingConstant)
        {

            int minValVindex = 0;
            int minValHindex = 0;
            float maxValH = 0;
            float maxValV = 0;
            float minValH = 10000000;
            float minValV = 100000000;
            
            int height = inImage.Height;
            int width = inImage.Width;
            System.Drawing.Point[] horizontalPoints = new System.Drawing.Point[width];
            System.Drawing.Point[] verticalPoints = new System.Drawing.Point[height];

            Bitmap tempBitmap = new Bitmap(inImage.Width, inImage.Height);
            Graphics g = Graphics.FromImage(tempBitmap);
            g.DrawImage(inImage, 0, 0);

            Pen redPen = new Pen(Color.Yellow, 5F);
            Pen fuschiaPen = new Pen(Brushes.Fuchsia, 5.0F);
            Pen bluePen = new Pen(Color.FromArgb(60, 0, 0, 255), .5F);
            Pen verticalHistogramPen = new Pen(horizontalColor,2f);
            Pen horizontalHistogramPen = new Pen(verticalColor, 2f);


            int verticalLineStart = inVerticalStartRow;
            int verticalSumSpace = inVerticalRowGap;
            int horizontalLineStart = inHorizontalStartRow;
            int horizontalSumSpace = inHorizontalRowGap;

            float[] sumArrayHorizontal = new float[width + 1];
            float[] sumArrayVertical = new float[height + 1];


            Bitmap imageClone = (Bitmap)inImage;
            Rectangle imageRectangle = new Rectangle(0, 0, width, height);
            System.Drawing.Imaging.BitmapData imageData = imageClone.LockBits(imageRectangle, System.Drawing.Imaging.ImageLockMode.ReadWrite, imageClone.PixelFormat);
            IntPtr imagePointer = imageData.Scan0;
            int stride = imageData.Stride;
            byte[] imageByteArray = new byte[stride * imageData.Height];
            System.Runtime.InteropServices.Marshal.Copy(imageData.Scan0, imageByteArray, 0, imageByteArray.Length);
            imageClone.UnlockBits(imageData);



            //Prep Pointers for horizontal Row Data
            int vPointer1 = verticalLineStart * stride;
            int vPointer2 = vPointer1 + (stride * verticalSumSpace);
            int vPointer3 = vPointer2 + (stride * verticalSumSpace);
            int vPointer4 = vPointer3 + (stride * verticalSumSpace);
            int vPointer5 = vPointer4 + (stride * verticalSumSpace);
            int vPointer6 = vPointer5 + (stride * verticalSumSpace);
            int vPointer7 = vPointer6 + (stride * verticalSumSpace);
            int vPointer8 = vPointer7 + (stride * verticalSumSpace);
            int vPointer9 = vPointer8 + (stride * verticalSumSpace);
            int vPointer10 = vPointer9 + (stride * verticalSumSpace);

            for (int xOffset = 0; xOffset < width; xOffset++)
            {//Summing Horizontal Pixel Data
                sumArrayHorizontal[xOffset] += imageByteArray[vPointer1 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[vPointer2 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[vPointer3 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[vPointer4 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[vPointer5 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[vPointer6 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[vPointer7 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[vPointer8 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[vPointer9 + xOffset];
                sumArrayHorizontal[xOffset] += imageByteArray[vPointer10 + xOffset];
            }

            int hPointer1 = horizontalLineStart*height;
            int hPointer2 = hPointer1 + (height * horizontalSumSpace);
            int hPointer3 = hPointer2 + (height * horizontalSumSpace);
            int hPointer4 = hPointer3 + (height * horizontalSumSpace);
            int hPointer5 = hPointer4 + (height * horizontalSumSpace);
            int hPointer6 = hPointer5 + (height * horizontalSumSpace);
            int hPointer7 = hPointer6 + (height * horizontalSumSpace);
            int hPointer8 = hPointer7 + (height * horizontalSumSpace);
            int hPointer9 = hPointer8 + (height * horizontalSumSpace);
            int hPointer10 = hPointer9 + (height * horizontalSumSpace);

            //for (int yOffset = 0; yOffset < height; yOffset++)
            //{//Summing Horizontal Pixel Data
            //    sumArrayVertical[yOffset] += imageByteArray[hPointer1 + yOffset];
            //    sumArrayVertical[yOffset] += imageByteArray[hPointer2 + yOffset];
            //    sumArrayVertical[yOffset] += imageByteArray[hPointer3 + yOffset];
            //    sumArrayVertical[yOffset] += imageByteArray[hPointer4 + yOffset];
            //    sumArrayVertical[yOffset] += imageByteArray[hPointer5 + yOffset];
            //    sumArrayVertical[yOffset] += imageByteArray[hPointer6 + yOffset];
            //    sumArrayVertical[yOffset] += imageByteArray[hPointer7 + yOffset];
            //    sumArrayVertical[yOffset] += imageByteArray[hPointer8 + yOffset];
            //    sumArrayVertical[yOffset] += imageByteArray[hPointer9 + yOffset];
            //    sumArrayVertical[yOffset] += imageByteArray[hPointer10 + yOffset];
            //}

            //horiztonal sum array
            //Sums row data
            //Repeat for each collumn

            //for (int rowOffset = 0; rowOffset < height; rowOffset++)
            //{
            //    for (int yOffset = 0; yOffset < width; yOffset++)
            //    {//Summing Vertical Pixel Data
            //        sumArrayVertical[rowOffset] += imageByteArray[yOffset + (width * (rowOffset))];
            //    }
            //}
            //for (int rowOffset = 0; rowOffset < height; rowOffset++)
            //{
            //    for (int yOffset = 0; yOffset < horizontalSum; yOffset++)
            //    {//Summing Vertical Pixel Data
            //        sumArrayVertical[rowOffset] += imageByteArray[yOffset + (width * (rowOffset))];
            //    }
            //}
            for (int k = 0; k < height; k++)
            {
                for (int h = 0; h < horizontalSumSpace; h++)
                {

                    sumArrayVertical[k] = imageByteArray[(horizontalLineStart + h) + (stride * k)];
                    
                }
            }


            for (int count = 0; count < width; count++)
            {//Finding Max Horizontal Value
                if (sumArrayHorizontal[count] > maxValH)
                {
                    maxValH = sumArrayHorizontal[count];
                }
            }
            for (int count = 0; count < width; count++)
            {//Finding min Horizontal Value
                if (sumArrayHorizontal[count] < minValH)
                {
                    minValH = sumArrayHorizontal[count];
                    minValHindex = count;
                }
            }

            for (int count = 0; count < height; count++)
            {//Finding Max vertical Value

                if (sumArrayVertical[count] > maxValV)
                {
                    maxValV = sumArrayVertical[count];
                }
            }

            for (int count = 0; count < height; count++)
            {//Finding min vertical Value
                if (sumArrayVertical[count] < minValV)
                {
                    minValV = sumArrayVertical[count];
                    minValVindex = count;
                }
            }

            float divisorH = (float)((maxValH / (inImage.Height)));
            float divisorV = (float)(maxValV / (inImage.Width ));
            float[] histogramHorizontalData = new float[width + 1];
            float[] histogramVerticalData = new float[height + 1];

            for (int y = 0; y < width; y++)
            {//Scaling Data to fit vertical window, 100 pixels tall
                histogramHorizontalData[y] = (float)sumArrayHorizontal[y] / divisorH;
            }

            for (int b = 0; b < height; b++)
            {
               
                histogramVerticalData[b] = sumArrayVertical[b] / divisorV;
                
            }
            
            for (int z = 0; z < width-1; z++)
            {
                //horizontalPoints[z] = new System.Drawing.Point(z,(int)sumArrayHorizontal[z]);
                if(verticalHistogramCheckboxBW.Checked||verticalHistogramCheckboxCanny.Checked)
                    g.DrawLine(horizontalHistogramPen, z, height-histogramHorizontalData[z], z, height-histogramHorizontalData[z+1]);
            }

            for (int a = 0; a < height-1; a++)
            {
                //g.DrawLine(horizontalHistogramPen, width, a, histogramVerticalData[a], a);
                if (horizontalHistogramCheckboxCanny.Checked || horizontalHistogramCheckboxBW.Checked)
                    g.DrawLine(verticalHistogramPen, width - histogramVerticalData[a],a, width - histogramVerticalData[a + 1],a);
            }
            g.DrawLines(horizontalHistogramPen,  horizontalPoints);

            if (cannyBoundryRangeCheckbox.Checked || bwBoundryRangeCheckbox.Checked)
            {
                g.DrawLine(fuschiaPen, 0, (int)(vPointer1 / stride), width, (int)(vPointer1 / stride));
                g.DrawLine(fuschiaPen, 0, (int)(vPointer10 / stride), width, (int)(vPointer10 / stride));
                g.DrawLine(fuschiaPen, (int)(horizontalLineStart), 0, (int)(horizontalLineStart), height);
                g.DrawLine(fuschiaPen, (int)(horizontalLineStart + (horizontalSumSpace)), 0, (int)(horizontalLineStart + (horizontalSumSpace)), height);
            }
            if (crosshairCheckboxBW.Checked || crossHairCanny.Checked)
            {
                tempBitmap = drawCrossHair(histogramVerticalData, histogramHorizontalData, inAvergingConstant, tempBitmap);
            }
            
            //g.DrawLine(fuschiaPen, minValHindex, 0, minValHindex, height);
            //g.DrawLine(fuschiaPen, 0, minValVindex, width, minValVindex);
            Size roiSize = new Size(100, 100);
            //Rectangle regionOfIntrest = motionTracker(histogramHorizontalData, histogramVerticalData);
            //g.DrawRectangle(redPen,regionOfIntrest);
            return (Bitmap) tempBitmap;
            
        }

        public void detectBlobs()
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            Bitmap cannyImage = cannyImageConvert(grayImage);
            crossHareCheckBox.Image = blobDetection(grayImage, (grayBlobMinSlider.Maximum - grayBlobMinSlider.Value), grayBlobMaxSlider.Value);
            cannyBlobPanel.Image = blobDetection(cannyImage, (cannyBlobMinSlider.Maximum - cannyBlobMinSlider.Value), cannyBlobMaxSlider.Value);
            blackandwhiteBlobPanel.Image = blobDetection(blackandwhiteImage, (blobDetectionForm.Maximum - blobDetectionForm.Value), blackandwhiteBlobMaxSlider.Value);
        }

        private void blobDetect_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //detectBlobs();
        }

        private void cannyHistogramBtn_Click(object sender, EventArgs e)
        {
            cannyHistogramToggle++;
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap cannyImage = cannyImageConvert(grayImage);
            cannyVerticalHistogramSlider.Maximum = 480 - ((int)cannyVerticalNumRowNUD.Value * 10);
            cannyHorizontalHistogramSlider.Maximum = 640 - ((int)cannyHoriztonalNumRowNUD.Value * 10);
            cannyPanel.Image = extractHistogramData(cannyImage, (cannyVerticalHistogramSlider.Value), (int)cannyVerticalNumRowNUD.Value, cannyHorizontalHistogramSlider.Value, (int)cannyHoriztonalNumRowNUD.Value,(int) blobDetectionForm.Value);

        }

        private void redSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            Bitmap cannyImage = cannyImageConvert(grayImage);
            crossHareCheckBox.Image = blobDetection(grayImage, (grayBlobMinSlider.Maximum - grayBlobMinSlider.Value), grayBlobMaxSlider.Value);
            bwBoundryRangeCheckbox.Image = blobDetection(blackandwhiteImage, (blobDetectionForm.Maximum - blobDetectionForm.Value), blackandwhiteBlobMaxSlider.Value);
        }

        private void blueSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            Bitmap cannyImage = cannyImageConvert(grayImage);
            crossHareCheckBox.Image = blobDetection(grayImage, (grayBlobMinSlider.Maximum - grayBlobMinSlider.Value), grayBlobMaxSlider.Value);
            cannyBlobPanel.Image = blobDetection(cannyImage, (cannyBlobMinSlider.Maximum - cannyBlobMinSlider.Value), cannyBlobMaxSlider.Value);
            bwBoundryRangeCheckbox.Image = blobDetection(blackandwhiteImage, (blobDetectionForm.Maximum - blobDetectionForm.Value), blackandwhiteBlobMaxSlider.Value);
        }

        private void greenSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            Bitmap cannyImage = cannyImageConvert(grayImage); crossHareCheckBox.Image = blobDetection(grayImage, grayBlobMinSlider.Value, grayBlobMaxSlider.Value);
            crossHareCheckBox.Image = blobDetection(grayImage, (grayBlobMinSlider.Maximum - grayBlobMinSlider.Value), grayBlobMaxSlider.Value);
            cannyBlobPanel.Image = blobDetection(cannyImage, (cannyBlobMinSlider.Maximum - cannyBlobMinSlider.Value), cannyBlobMaxSlider.Value);
            bwBoundryRangeCheckbox.Image = blobDetection(blackandwhiteImage, (blobDetectionForm.Maximum - blobDetectionForm.Value), blackandwhiteBlobMaxSlider.Value);
        }

        private void cannyMinSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap cannyImage = cannyImageConvert(grayImage);
            cannyBlobPanel.Image = blobDetection(cannyImage, (cannyBlobMinSlider.Maximum - cannyBlobMinSlider.Value), cannyBlobMaxSlider.Value);
        }

        private void cannyMaxSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap cannyImage = cannyImageConvert(grayImage);
            cannyBlobPanel.Image = blobDetection(cannyImage, (cannyBlobMinSlider.Maximum - cannyBlobMinSlider.Value), cannyBlobMaxSlider.Value);
        }

        private void blackandwhiteSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            blackandwhiteBlobPanel.Image = blobDetection(blackandwhiteImage, (blobDetectionForm.Maximum - blobDetectionForm.Value), blackandwhiteBlobMaxSlider.Value);
        }

        private void cannyBlobMinSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap cannyImage = cannyImageConvert(grayImage);
            cannyBlobPanel.Image = blobDetection(cannyImage, (cannyBlobMinSlider.Maximum - cannyBlobMinSlider.Value), cannyBlobMaxSlider.Value);
        }

        private void cannyBlobMaxSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap cannyImage = cannyImageConvert(grayImage);
            cannyBlobPanel.Image = blobDetection(cannyImage, (cannyBlobMinSlider.Maximum - cannyBlobMinSlider.Value), cannyBlobMaxSlider.Value);
        }

        private void grayBlobMinSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            crossHareCheckBox.Image = blobDetection(grayImage, (grayBlobMinSlider.Maximum - grayBlobMinSlider.Value), grayBlobMaxSlider.Value);
        }

        private void grayBlobMaxSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            crossHareCheckBox.Image = blobDetection(grayImage, (grayBlobMinSlider.Maximum - grayBlobMinSlider.Value), grayBlobMaxSlider.Value);
        }

        private void blackandwhiteBlobMinSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            bwBoundryRangeCheckbox.Image = blobDetection(blackandwhiteImage, (blobDetectionForm.Maximum - blobDetectionForm.Value), blackandwhiteBlobMaxSlider.Value);
        }

        private void blackandwhiteBlobMaxSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            bwBoundryRangeCheckbox.Image = blobDetection(blackandwhiteImage, (blobDetectionForm.Maximum - blobDetectionForm.Value), blackandwhiteBlobMaxSlider.Value);
        }

        private void gamaSlider1_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            Bitmap cannyImage = cannyImageConvert(grayImage);
            crossHareCheckBox.Image = blobDetection(grayImage, (grayBlobMinSlider.Maximum - grayBlobMinSlider.Value), grayBlobMaxSlider.Value);
            cannyBlobPanel.Image = blobDetection(cannyImage, (cannyBlobMinSlider.Maximum - cannyBlobMinSlider.Value), cannyBlobMaxSlider.Value);
            bwBoundryRangeCheckbox.Image = blobDetection(blackandwhiteImage, (blobDetectionForm.Maximum - blobDetectionForm.Value), blackandwhiteBlobMaxSlider.Value);
        }

        private void contrastSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            Bitmap cannyImage = cannyImageConvert(grayImage);
            crossHareCheckBox.Image = blobDetection(grayImage, (grayBlobMinSlider.Maximum - grayBlobMinSlider.Value), grayBlobMaxSlider.Value);
            cannyBlobPanel.Image = blobDetection(cannyImage, (cannyBlobMinSlider.Maximum - cannyBlobMinSlider.Value), cannyBlobMaxSlider.Value);
            bwBoundryRangeCheckbox.Image = blobDetection(blackandwhiteImage, (blobDetectionForm.Maximum - blobDetectionForm.Value), blackandwhiteBlobMaxSlider.Value);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            GaussianSharpen gausianSharpenFilter = new GaussianSharpen();
            Bitmap orignalImage = captureImage();
            orignalImage = gausianSharpenFilter.Apply(orignalImage);
            Bitmap grayImage = grayscaleImageConvert(orignalImage);
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            Bitmap cannyImage = cannyImageConvert(grayImage);
            crossHareCheckBox.Image = blobDetection(grayImage, (grayBlobMinSlider.Maximum - grayBlobMinSlider.Value), grayBlobMaxSlider.Value);
            cannyBlobPanel.Image = blobDetection(cannyImage, (cannyBlobMinSlider.Maximum - cannyBlobMinSlider.Value), cannyBlobMaxSlider.Value);
            blackandwhiteBlobPanel.Image = blobDetection(blackandwhiteImage, (blobDetectionForm.Maximum - blobDetectionForm.Value), blackandwhiteBlobMaxSlider.Value);
        }

        private void blackandwhiteHistorgrambtn_Click(object sender, EventArgs e)
        {
            blackandwhiteHistogramToggle++;
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            blackandwhiteVerticalHistogramSlider.Maximum = 480 - ((int)blackandwhiteVerticalNumRowNUD.Value * 10);
            blackandwhiteHorizontalHistogramSlider.Maximum = 640 - ((int)blackandwhiteHorizontalRowGapNUD.Value * 10);
            blackandwhitePanel.Image = extractHistogramData(blackandwhiteImage, (int)blackandwhiteVerticalHistogramSlider.Value, (int)blackandwhiteVerticalNumRowNUD.Value, blackandwhiteHorizontalHistogramSlider.Value, (int)blackandwhiteHorizontalRowGapNUD.Value, (int)bwAveragingConstantNUD.Value);
        }

        private void horizontalColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorPallet = new ColorDialog();

            if (colorPallet.ShowDialog() == DialogResult.OK)
            {
                horizontalColor = colorPallet.Color;
                horizontalColorBtn.BackColor = colorPallet.Color;
                
            }
        }

        private void verticalColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorPallet = new ColorDialog();

            if (colorPallet.ShowDialog() == DialogResult.OK)
            {
                verticalColor = colorPallet.Color;
                verticalColorBtn.BackColor = colorPallet.Color;
            }
        }

        public void createCannyHistogram()
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap cannyImage = cannyImageConvert(grayImage);
            //cannyVerticalHistogramSlider.Maximum = 480 - ((int)cannyVerticalNumRowNUD.Value * 10);
            //cannyHorizontalHistogramSlider.Maximum = 640 - ((int)cannyHoriztonalNumRowNUD.Value * 10);
            cannyVerticalHistogramSlider.Maximum = 480 - ((int)cannyVerticalNumRowNUD.Value);
            cannyHorizontalHistogramSlider.Maximum = 640 - ((int)cannyHoriztonalNumRowNUD.Value);
            cannyPanel.Image = extractHistogramData(cannyImage, (cannyVerticalHistogramSlider.Value), (int)cannyVerticalNumRowNUD.Value, cannyHorizontalHistogramSlider.Value, (int)cannyHoriztonalNumRowNUD.Value,(int)blobDetectionForm.Value);
        }

        public void createBlackandWhiteHistogram()
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            blackandwhiteVerticalHistogramSlider.Maximum = 480 - ((int)blackandwhiteVerticalNumRowNUD.Value * 10);
            blackandwhiteHorizontalHistogramSlider.Maximum = 640 - ((int)blackandwhiteHorizontalRowGapNUD.Value * 10);
            blackandwhitePanel.Image = extractHistogramData(blackandwhiteImage, (int)blackandwhiteVerticalHistogramSlider.Value, (int)blackandwhiteVerticalNumRowNUD.Value, blackandwhiteHorizontalHistogramSlider.Value, (int)blackandwhiteHorizontalRowGapNUD.Value, (int)bwAveragingConstantNUD.Value);
        }

        private void cannyVerticalHistogramSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap cannyImage = cannyImageConvert(grayImage);
            cannyVerticalHistogramSlider.Maximum = 480 - ((int)cannyVerticalNumRowNUD.Value * 10);
            cannyHorizontalHistogramSlider.Maximum = 640 - ((int)cannyHoriztonalNumRowNUD.Value*10);
            cannyPanel.Image = extractHistogramData(cannyImage, (cannyVerticalHistogramSlider.Value), (int)cannyVerticalNumRowNUD.Value, cannyHorizontalHistogramSlider.Value,(int)cannyHoriztonalNumRowNUD.Value, (int)blobDetectionForm.Value);
        }

        private void blackandwhiteVerticalHistogramSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            blackandwhiteVerticalHistogramSlider.Maximum = 480 - ((int)blackandwhiteVerticalNumRowNUD.Value * 10);
            blackandwhiteHorizontalHistogramSlider.Maximum = 640 - ((int)blackandwhiteHorizontalRowGapNUD.Value*10);
            blackandwhitePanel.Image = extractHistogramData(blackandwhiteImage, (int)blackandwhiteVerticalHistogramSlider.Value, (int)blackandwhiteVerticalNumRowNUD.Value,blackandwhiteHorizontalHistogramSlider.Value,(int)blackandwhiteHorizontalRowGapNUD.Value, (int)bwAveragingConstantNUD.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void blackandwhiteHorizontalHistogramSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
            blackandwhiteVerticalHistogramSlider.Maximum = 480 - ((int)blackandwhiteVerticalNumRowNUD.Value * 10);
            blackandwhiteHorizontalHistogramSlider.Maximum = 630 - ((int)blackandwhiteHorizontalRowGapNUD.Value * 10);
            blackandwhitePanel.Image = extractHistogramData(blackandwhiteImage, (int)blackandwhiteVerticalHistogramSlider.Value, (int)blackandwhiteVerticalNumRowNUD.Value, blackandwhiteHorizontalHistogramSlider.Value, (int)blackandwhiteHorizontalRowGapNUD.Value, (int)bwAveragingConstantNUD.Value);
        }

        private void cannyHorizontalHistogramSlider_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap grayImage = grayscaleImageConvert(captureImage());
            Bitmap cannyImage = cannyImageConvert(grayImage);
            cannyVerticalHistogramSlider.Maximum = 480 - ((int)cannyVerticalNumRowNUD.Value * 10);
            cannyHorizontalHistogramSlider.Maximum = 640 - ((int)cannyHoriztonalNumRowNUD.Value * 10);
            cannyPanel.Image = extractHistogramData(cannyImage, (cannyVerticalHistogramSlider.Value), (int)cannyVerticalNumRowNUD.Value, cannyHorizontalHistogramSlider.Value, (int)cannyHoriztonalNumRowNUD.Value, (int)cannyAveragingConstantNUD.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            detectBlobs();
            if (blackandwhiteHistogramToggle % 2 == 0)
            {
                createBlackandWhiteHistogram();
            }
            if(cannyHistogramToggle %2 == 0)
            {
                createCannyHistogram();
            }
        }
        public Rectangle motionTracker(float[] horizontalArray, float[] verticalArray)
        {

     
            float firstXpeak = 0.0f;
            float secondXpeak = 0.0f;
            float firstYpeak = 0.0f;
            float secondYpeak = 0.0f;
            for (int i = 0; i < horizontalArray.Length; i++)
            {
                if (horizontalArray[i] != 480)
                {
                    firstXpeak = i;
                }
            }
            for (int j = 0; j < verticalArray.Length; j++)
            {
                if (verticalArray[j] != 640)
                {
                    firstYpeak = j;
                }
            }
            for (int k = verticalArray.Length; k <= 0; k--)
            {
                if (verticalArray[k] != 640)
                {
                    secondYpeak = k;
                }
            }
            for (int l = horizontalArray.Length; l <= 0; l--)
            {
                if (horizontalArray[l] !=480)
                {
                    secondXpeak = l;
                }
            }
            System.Drawing.Point originPoint = new System.Drawing.Point((int)secondXpeak, (int)secondYpeak);

            Size roiSize = new Size((int)(firstXpeak), (int)(firstYpeak));
            Rectangle intersectionRectangle = new Rectangle(originPoint, roiSize);
            return intersectionRectangle;

        }
        public Bitmap drawCrossHair(float[] verticalPixelValues, float[] horizontalPixelValues, int averagingConstant, Bitmap originalImage) {

            float[] avgVerticalValues = new float[(int)(verticalPixelValues.Length / averagingConstant)];
            float[] avgHorizontalValues = new float[(int)(horizontalPixelValues.Length / averagingConstant)];
            int avgVerticalValuesIndexPosition = 0;
            int avgHorizontalValuesIndexPosition = 0;
            List<int> verticalZeroValues = new List<int>();
            List<int> horizontalZeroValues = new List<int>();
            int verticalMidpoint = 0;
            int horizontalMidpoint = 0;
            float verticalSum = 0;
            float horizontalSum = 0;

            //averging values for horizontal and vertical
            for (int verticalIndexPosition = 0; verticalIndexPosition < (verticalPixelValues.Length - 1); verticalIndexPosition++)
            {

                verticalSum += (int)verticalPixelValues[verticalIndexPosition];
                if (verticalIndexPosition % averagingConstant == 0 && verticalIndexPosition != 0)
                {
                    avgVerticalValues[avgVerticalValuesIndexPosition] = (float)(verticalSum / averagingConstant);
                    avgVerticalValuesIndexPosition++;
                    verticalSum = 0;
                }
            }
            for (int horizontalIndexPosition = 0; horizontalIndexPosition < (horizontalPixelValues.Length - 1); horizontalIndexPosition++)
            {
                horizontalSum += (int)horizontalPixelValues[horizontalIndexPosition];
                if (horizontalIndexPosition % averagingConstant == 0 && horizontalIndexPosition != 0)
                {
                    avgHorizontalValues[avgHorizontalValuesIndexPosition] = (float)(horizontalSum / averagingConstant);
                    avgHorizontalValuesIndexPosition++;
                    horizontalSum = 0;
                }
            }
            //Finding where the peaks end
            for (int i = 0; i < (avgVerticalValues.Length - 1); i++)
            {
                if (avgVerticalValues[i] == 0)
                {
                    verticalZeroValues.Add(i * averagingConstant);
                }
            }

            for (int i = 0; i < (avgHorizontalValues.Length - 1); i++)
            {
                if (avgHorizontalValues[i] == 0)
                {
                    horizontalZeroValues.Add(i * averagingConstant);
                }
            }
            if (verticalZeroValues.Count > 0 && horizontalZeroValues.Count > 0)
            {
                verticalMidpoint = ((verticalZeroValues[0] + verticalZeroValues[verticalZeroValues.Count - 1]) / 2);
                horizontalMidpoint = ((horizontalZeroValues[0] + horizontalZeroValues[horizontalZeroValues.Count - 1]) / 2);
            }
            Bitmap tempBitmap = new Bitmap(originalImage.Width, originalImage.Height);
            Graphics g = Graphics.FromImage(tempBitmap);
            g.DrawImage(originalImage, 0, 0);
            Pen redPen = new Pen(Color.Red, 2.0f);
            Pen cyanPen = new Pen(Color.Cyan, 2.0f);

            g.DrawLine(redPen, 0, verticalMidpoint, Width, verticalMidpoint);
            g.DrawLine(redPen, horizontalMidpoint, 0, horizontalMidpoint, Height);
            g.DrawEllipse(redPen, horizontalMidpoint - 15, verticalMidpoint - 15, 30, 30);
            if (avgHorizontalValues.Length>1&&avgVerticalValues.Length>1)
            {
                if (cannyAvgHorziontalHistogramCheckbox.Checked || bwHorizontalAverageHistogramCheckbox.Checked)
                {
                    int hDrawPosition = 0;
                    for (int z = 1; z < avgHorizontalValues.Length - 1; z++)
                    {
                        for (int a = 1; a < averagingConstant; a++)
                        {
                            hDrawPosition++;
                            g.DrawLine(redPen, hDrawPosition, avgHorizontalValues[z], hDrawPosition, avgHorizontalValues[z + 1]);
                        }
                    }
                }
                if (cannyAvgVerticalHistogramCheckBox.Checked || bwVerticalAverageHistogramCheckbox.Checked)
                {
                    int vDrawPosition = 0;
                    for (int y = 1; y < avgVerticalValues.Length - 1; y++)
                    {
                        for (int b = 1; b < averagingConstant; b++)
                        {
                            vDrawPosition++;
                            g.DrawLine(cyanPen, avgVerticalValues[y], vDrawPosition, avgVerticalValues[y + 1], vDrawPosition);
                        }
                    }
                }
            }
            System.Drawing.Point centerPoint = new System.Drawing.Point(horizontalMidpoint, verticalMidpoint);
            
            label21.Text = (horizontalAlignment(centerPoint, 20, tempBitmap).ToString());
            return tempBitmap;

        }
    public int horizontalAlignment(System.Drawing.Point inCenter,int inDistanceFromCenter,Bitmap inImage)
    {
            float xValue = inCenter.X;
            
            int topLine = (int)inCenter.X - inDistanceFromCenter;
            int bottomLine = (int)inCenter.X + inDistanceFromCenter;
            int topIndexFirstBlackPixel = 0;
            int bottomIndexFirstBlackPixel = 0;
            int width = inImage.Width;
            int height = inImage.Height;
            float[] topLineValues = new float[width - 1];
            float[] bottomLineValues = new float[width - 1];
            Bitmap imageClone = (Bitmap)inImage;
            Rectangle imageRectangle = new Rectangle(0, 0, width, height);
            System.Drawing.Imaging.BitmapData imageData = imageClone.LockBits(imageRectangle, System.Drawing.Imaging.ImageLockMode.ReadWrite, imageClone.PixelFormat);
            IntPtr imagePointer = imageData.Scan0;
            int stride = imageData.Stride;
            byte[] imageByteArray = new byte[stride * imageData.Height];
            System.Runtime.InteropServices.Marshal.Copy(imageData.Scan0, imageByteArray, 0, imageByteArray.Length);
            imageClone.UnlockBits(imageData);
            Graphics g = Graphics.FromImage(inImage);
            Pen greenPen = new Pen(Color.Green, 5.0f);
            g.DrawLine(greenPen,0,topLine,width,topLine);
            g.DrawLine(greenPen, 0, bottomLine, width, bottomLine);
            if (topLine > 0 && bottomLine > 0&&bottomLine<480&&topLine<480)
            {
                for (int i = 0; i < width - 1; i++)
                {
                    topLineValues[i] = imageByteArray[(topLine * stride) + i];
                    bottomLineValues[i] = imageByteArray[(bottomLine * stride) + i];
                }
            }
            for (int j = 0; j < topLineValues.Length; j++)
            {
                if (topLineValues[j] == 0)
                {
                    topIndexFirstBlackPixel = j;
                    break;
                }
            }
            for (int k = 0; k < bottomLineValues.Length; k++)
            {
                if (bottomLineValues[k] == 0)
                {
                    bottomIndexFirstBlackPixel = k;
                    break;
                }
            }
            int deltaX = Math.Abs(topIndexFirstBlackPixel - bottomIndexFirstBlackPixel);
            
            return deltaX;

        }

        private void horizontalHistogramCheckboxCanny_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
