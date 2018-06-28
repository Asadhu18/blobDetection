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
    public partial class BlobDetection : Form
    {
        public VideoCaptureDevice captureDevice;
        public FilterInfoCollection deviceList;

        
        public BlobDetection()
        {
            InitializeComponent();
        }

        

        private void scrollableImagePanel4_Load(object sender, EventArgs e)
        {

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
            Bitmap capturedColorImage = (Bitmap)videoSourcePlayer1.GetCurrentVideoFrame();
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
        public Bitmap blobDetection(Bitmap inImage, int Min, int Max) {
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
                    List<IntPoint> corners = PointsCloud.FindQuadrilateralCorners(edgePoints);
                    if (shapeCheck.IsQuadrilateral(edgePoints, out corners))
                    {
                        Rectangle testRectangle = new Rectangle(corners[0].X, corners[0].Y, (corners[1].X - corners[0].X), corners[3].Y - corners[0].Y);
                    }

                }
            }
            return tempBitmap;
        }
            
        private void blobDetect_Click(object sender, EventArgs e)
        {
           Bitmap grayImage = grayscaleImageConvert(captureImage());
           Bitmap blackandwhiteImage = blackandWhiteImageConvert(grayImage);
           Bitmap cannyImage = cannyImageConvert(grayImage);
           grayBlobPicturePanel.Image = blobDetection(grayImage,grayBlobMinSlider.Value,grayBlobMaxSlider.Value);
           cannyBlobPanel.Image = blobDetection(cannyImage, cannyBlobMinSlider.Value, cannyBlobMaxSlider.Value);
            blackandwhiteBlobPanel.Image = blobDetection(blackandwhiteImage, blackandwhiteBlobMinSlider.Value, blackandwhiteBlobMaxSlider.Value);

        }
    }
}
