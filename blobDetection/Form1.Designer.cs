namespace blobDetection
{
    partial class cannyMinBlobSize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.liveVideoSource = new System.Windows.Forms.Label();
            this.RecordBtn = new System.Windows.Forms.Button();
            this.videoSourceList = new System.Windows.Forms.ComboBox();
            this.grayScale = new System.Windows.Forms.Label();
            this.crossHareCheckBox = new CustomTools.ScrollableImagePanel();
            this.blackandwhitePanel = new CustomTools.ScrollableImagePanel();
            this.cannyPanel = new CustomTools.ScrollableImagePanel();
            this.blackandwhiteBlobPanel = new CustomTools.ScrollableImagePanel();
            this.cannyBlobPanel = new CustomTools.ScrollableImagePanel();
            this.redSlider = new System.Windows.Forms.HScrollBar();
            this.blueSlider = new System.Windows.Forms.HScrollBar();
            this.greenSlider = new System.Windows.Forms.HScrollBar();
            this.greyScaleBlobLabel = new System.Windows.Forms.Label();
            this.blackandwhiteLabel = new System.Windows.Forms.Label();
            this.cannyLabel = new System.Windows.Forms.Label();
            this.cannyBlobDetection = new System.Windows.Forms.Label();
            this.blackandwhiteBlobDetectionLabel = new System.Windows.Forms.Label();
            this.blobDetectionForm = new System.Windows.Forms.VScrollBar();
            this.blackandwhiteBlobMaxSlider = new System.Windows.Forms.VScrollBar();
            this.cannyBlobMaxSlider = new System.Windows.Forms.VScrollBar();
            this.cannyBlobMinSlider = new System.Windows.Forms.VScrollBar();
            this.blackandwhiteSlider = new System.Windows.Forms.HScrollBar();
            this.cannyMinSlider = new System.Windows.Forms.HScrollBar();
            this.grayBlobMinSlider = new System.Windows.Forms.VScrollBar();
            this.grayBlobMaxSlider = new System.Windows.Forms.VScrollBar();
            this.cannyMaxSlider = new System.Windows.Forms.HScrollBar();
            this.cannyMinimumThreshold = new System.Windows.Forms.Label();
            this.cannyMaxThreshold = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gamaSlider = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.blobDetect = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.capturedImagePanel = new CustomTools.ScrollableImagePanel();
            this.grayScalePanel = new CustomTools.ScrollableImagePanel();
            this.gamaSlider1 = new System.Windows.Forms.HScrollBar();
            this.label15 = new System.Windows.Forms.Label();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.contrastSlider = new System.Windows.Forms.HScrollBar();
            this.cannyHistogramBtn = new System.Windows.Forms.Button();
            this.blackandwhiteHistorgrambtn = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.horizontalColorBtn = new System.Windows.Forms.Button();
            this.verticalColorBtn = new System.Windows.Forms.Button();
            this.cannyHorizontalHistogramSlider = new System.Windows.Forms.HScrollBar();
            this.blackandwhiteHorizontalHistogramSlider = new System.Windows.Forms.HScrollBar();
            this.cannyVerticalHistogramSlider = new System.Windows.Forms.VScrollBar();
            this.blackandwhiteVerticalHistogramSlider = new System.Windows.Forms.VScrollBar();
            this.cannyVerticalNumRowNUD = new System.Windows.Forms.NumericUpDown();
            this.blackandwhiteVerticalNumRowNUD = new System.Windows.Forms.NumericUpDown();
            this.blackandwhiteHorizontalRowGapNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cannyHoriztonalNumRowNUD = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.crossHairCanny = new System.Windows.Forms.CheckBox();
            this.verticalHistogramCheckboxCanny = new System.Windows.Forms.CheckBox();
            this.horizontalHistogramCheckboxCanny = new System.Windows.Forms.CheckBox();
            this.crosshairCheckboxBW = new System.Windows.Forms.CheckBox();
            this.verticalHistogramCheckboxBW = new System.Windows.Forms.CheckBox();
            this.horizontalHistogramCheckboxBW = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cannyBoundryRangeCheckbox = new System.Windows.Forms.CheckBox();
            this.bwBoundryRangeCheckbox = new System.Windows.Forms.CheckBox();
            this.cannyAveragingConstantNUD = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.bwAveragingConstantNUD = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.bwVerticalAverageHistogramCheckbox = new System.Windows.Forms.CheckBox();
            this.bwHorizontalAverageHistogramCheckbox = new System.Windows.Forms.CheckBox();
            this.cannyAvgVerticalHistogramCheckBox = new System.Windows.Forms.CheckBox();
            this.cannyAvgHorziontalHistogramCheckbox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cannyVerticalNumRowNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackandwhiteVerticalNumRowNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackandwhiteHorizontalRowGapNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyHoriztonalNumRowNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyAveragingConstantNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bwAveragingConstantNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(7, 27);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(305, 245);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // liveVideoSource
            // 
            this.liveVideoSource.AutoSize = true;
            this.liveVideoSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveVideoSource.Location = new System.Drawing.Point(72, 0);
            this.liveVideoSource.Name = "liveVideoSource";
            this.liveVideoSource.Size = new System.Drawing.Size(109, 24);
            this.liveVideoSource.TabIndex = 1;
            this.liveVideoSource.Text = "Live Video";
            // 
            // RecordBtn
            // 
            this.RecordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordBtn.Location = new System.Drawing.Point(76, 278);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(135, 38);
            this.RecordBtn.TabIndex = 2;
            this.RecordBtn.Text = "Begin Recording";
            this.RecordBtn.UseVisualStyleBackColor = true;
            this.RecordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // videoSourceList
            // 
            this.videoSourceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoSourceList.FormattingEnabled = true;
            this.videoSourceList.Location = new System.Drawing.Point(76, 322);
            this.videoSourceList.Name = "videoSourceList";
            this.videoSourceList.Size = new System.Drawing.Size(135, 24);
            this.videoSourceList.TabIndex = 3;
            // 
            // grayScale
            // 
            this.grayScale.AutoSize = true;
            this.grayScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grayScale.Location = new System.Drawing.Point(360, 241);
            this.grayScale.Name = "grayScale";
            this.grayScale.Size = new System.Drawing.Size(174, 24);
            this.grayScale.TabIndex = 5;
            this.grayScale.Text = "Gray Scale Image";
            // 
            // crossHareCheckBox
            // 
            this.crossHareCheckBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.crossHareCheckBox.CanvasSize = new System.Drawing.Size(60, 40);
            this.crossHareCheckBox.Image = null;
            this.crossHareCheckBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.crossHareCheckBox.Location = new System.Drawing.Point(1131, 296);
            this.crossHareCheckBox.Name = "crossHareCheckBox";
            this.crossHareCheckBox.ROTATION = 0F;
            this.crossHareCheckBox.Size = new System.Drawing.Size(322, 250);
            this.crossHareCheckBox.TabIndex = 6;
            this.crossHareCheckBox.Zoom = 1F;
            // 
            // blackandwhitePanel
            // 
            this.blackandwhitePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.blackandwhitePanel.CanvasSize = new System.Drawing.Size(60, 40);
            this.blackandwhitePanel.Image = null;
            this.blackandwhitePanel.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.blackandwhitePanel.Location = new System.Drawing.Point(587, 480);
            this.blackandwhitePanel.Name = "blackandwhitePanel";
            this.blackandwhitePanel.ROTATION = 0F;
            this.blackandwhitePanel.Size = new System.Drawing.Size(330, 257);
            this.blackandwhitePanel.TabIndex = 7;
            this.blackandwhitePanel.Zoom = 1F;
            // 
            // cannyPanel
            // 
            this.cannyPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cannyPanel.CanvasSize = new System.Drawing.Size(60, 40);
            this.cannyPanel.Image = null;
            this.cannyPanel.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.cannyPanel.Location = new System.Drawing.Point(587, 31);
            this.cannyPanel.Name = "cannyPanel";
            this.cannyPanel.ROTATION = 0F;
            this.cannyPanel.Size = new System.Drawing.Size(330, 253);
            this.cannyPanel.TabIndex = 8;
            this.cannyPanel.Zoom = 1F;
            // 
            // blackandwhiteBlobPanel
            // 
            this.blackandwhiteBlobPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.blackandwhiteBlobPanel.CanvasSize = new System.Drawing.Size(60, 40);
            this.blackandwhiteBlobPanel.Image = null;
            this.blackandwhiteBlobPanel.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.blackandwhiteBlobPanel.Location = new System.Drawing.Point(1131, 572);
            this.blackandwhiteBlobPanel.Name = "blackandwhiteBlobPanel";
            this.blackandwhiteBlobPanel.ROTATION = 0F;
            this.blackandwhiteBlobPanel.Size = new System.Drawing.Size(322, 257);
            this.blackandwhiteBlobPanel.TabIndex = 9;
            this.blackandwhiteBlobPanel.Zoom = 1F;
            this.blackandwhiteBlobPanel.Load += new System.EventHandler(this.scrollableImagePanel4_Load);
            // 
            // cannyBlobPanel
            // 
            this.cannyBlobPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cannyBlobPanel.CanvasSize = new System.Drawing.Size(60, 40);
            this.cannyBlobPanel.Image = null;
            this.cannyBlobPanel.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.cannyBlobPanel.Location = new System.Drawing.Point(1131, 26);
            this.cannyBlobPanel.Name = "cannyBlobPanel";
            this.cannyBlobPanel.ROTATION = 0F;
            this.cannyBlobPanel.Size = new System.Drawing.Size(322, 248);
            this.cannyBlobPanel.TabIndex = 10;
            this.cannyBlobPanel.Zoom = 1F;
            // 
            // redSlider
            // 
            this.redSlider.Location = new System.Drawing.Point(364, 499);
            this.redSlider.Name = "redSlider";
            this.redSlider.Size = new System.Drawing.Size(207, 27);
            this.redSlider.TabIndex = 11;
            this.redSlider.Value = 21;
            this.redSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redSlider_Scroll);
            // 
            // blueSlider
            // 
            this.blueSlider.Location = new System.Drawing.Point(364, 543);
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Size = new System.Drawing.Size(207, 27);
            this.blueSlider.TabIndex = 12;
            this.blueSlider.Value = 7;
            this.blueSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueSlider_Scroll);
            // 
            // greenSlider
            // 
            this.greenSlider.Location = new System.Drawing.Point(364, 580);
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Size = new System.Drawing.Size(207, 27);
            this.greenSlider.TabIndex = 13;
            this.greenSlider.Value = 72;
            this.greenSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenSlider_Scroll);
            // 
            // greyScaleBlobLabel
            // 
            this.greyScaleBlobLabel.AutoSize = true;
            this.greyScaleBlobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greyScaleBlobLabel.Location = new System.Drawing.Point(1208, 277);
            this.greyScaleBlobLabel.Name = "greyScaleBlobLabel";
            this.greyScaleBlobLabel.Size = new System.Drawing.Size(166, 16);
            this.greyScaleBlobLabel.TabIndex = 14;
            this.greyScaleBlobLabel.Text = "Gray Scale Blob Detection";
            // 
            // blackandwhiteLabel
            // 
            this.blackandwhiteLabel.AutoSize = true;
            this.blackandwhiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackandwhiteLabel.Location = new System.Drawing.Point(677, 461);
            this.blackandwhiteLabel.Name = "blackandwhiteLabel";
            this.blackandwhiteLabel.Size = new System.Drawing.Size(146, 16);
            this.blackandwhiteLabel.TabIndex = 15;
            this.blackandwhiteLabel.Text = "Black and White Image";
            // 
            // cannyLabel
            // 
            this.cannyLabel.AutoSize = true;
            this.cannyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cannyLabel.Location = new System.Drawing.Point(660, 9);
            this.cannyLabel.Name = "cannyLabel";
            this.cannyLabel.Size = new System.Drawing.Size(183, 16);
            this.cannyLabel.TabIndex = 16;
            this.cannyLabel.Text = "Canny Edge Detection Image";
            // 
            // cannyBlobDetection
            // 
            this.cannyBlobDetection.AutoSize = true;
            this.cannyBlobDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cannyBlobDetection.Location = new System.Drawing.Point(1218, 7);
            this.cannyBlobDetection.Name = "cannyBlobDetection";
            this.cannyBlobDetection.Size = new System.Drawing.Size(137, 16);
            this.cannyBlobDetection.TabIndex = 17;
            this.cannyBlobDetection.Text = "Canny Blob Detection";
            // 
            // blackandwhiteBlobDetectionLabel
            // 
            this.blackandwhiteBlobDetectionLabel.AutoSize = true;
            this.blackandwhiteBlobDetectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackandwhiteBlobDetectionLabel.Location = new System.Drawing.Point(1178, 549);
            this.blackandwhiteBlobDetectionLabel.Name = "blackandwhiteBlobDetectionLabel";
            this.blackandwhiteBlobDetectionLabel.Size = new System.Drawing.Size(196, 16);
            this.blackandwhiteBlobDetectionLabel.TabIndex = 18;
            this.blackandwhiteBlobDetectionLabel.Text = "Black and White Blob Detection";
            // 
            // blobDetectionForm
            // 
            this.blobDetectionForm.Location = new System.Drawing.Point(1469, 600);
            this.blobDetectionForm.Maximum = 50;
            this.blobDetectionForm.Name = "blobDetectionForm";
            this.blobDetectionForm.Size = new System.Drawing.Size(17, 205);
            this.blobDetectionForm.TabIndex = 19;
            this.blobDetectionForm.Value = 50;
            this.blobDetectionForm.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blackandwhiteBlobMinSlider_Scroll);
            // 
            // blackandwhiteBlobMaxSlider
            // 
            this.blackandwhiteBlobMaxSlider.Location = new System.Drawing.Point(1507, 600);
            this.blackandwhiteBlobMaxSlider.Minimum = 51;
            this.blackandwhiteBlobMaxSlider.Name = "blackandwhiteBlobMaxSlider";
            this.blackandwhiteBlobMaxSlider.Size = new System.Drawing.Size(17, 205);
            this.blackandwhiteBlobMaxSlider.TabIndex = 20;
            this.blackandwhiteBlobMaxSlider.Value = 51;
            this.blackandwhiteBlobMaxSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blackandwhiteBlobMaxSlider_Scroll);
            // 
            // cannyBlobMaxSlider
            // 
            this.cannyBlobMaxSlider.Location = new System.Drawing.Point(1507, 55);
            this.cannyBlobMaxSlider.Minimum = 51;
            this.cannyBlobMaxSlider.Name = "cannyBlobMaxSlider";
            this.cannyBlobMaxSlider.Size = new System.Drawing.Size(17, 205);
            this.cannyBlobMaxSlider.TabIndex = 21;
            this.cannyBlobMaxSlider.Value = 51;
            this.cannyBlobMaxSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cannyBlobMaxSlider_Scroll);
            // 
            // cannyBlobMinSlider
            // 
            this.cannyBlobMinSlider.Location = new System.Drawing.Point(1469, 55);
            this.cannyBlobMinSlider.Maximum = 50;
            this.cannyBlobMinSlider.Name = "cannyBlobMinSlider";
            this.cannyBlobMinSlider.Size = new System.Drawing.Size(17, 205);
            this.cannyBlobMinSlider.TabIndex = 22;
            this.cannyBlobMinSlider.Value = 50;
            this.cannyBlobMinSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cannyBlobMinSlider_Scroll);
            // 
            // blackandwhiteSlider
            // 
            this.blackandwhiteSlider.Location = new System.Drawing.Point(663, 762);
            this.blackandwhiteSlider.Maximum = 256;
            this.blackandwhiteSlider.Minimum = 20;
            this.blackandwhiteSlider.Name = "blackandwhiteSlider";
            this.blackandwhiteSlider.Size = new System.Drawing.Size(237, 17);
            this.blackandwhiteSlider.TabIndex = 23;
            this.blackandwhiteSlider.Value = 200;
            this.blackandwhiteSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blackandwhiteSlider_Scroll);
            // 
            // cannyMinSlider
            // 
            this.cannyMinSlider.Location = new System.Drawing.Point(680, 309);
            this.cannyMinSlider.Maximum = 80;
            this.cannyMinSlider.Minimum = 20;
            this.cannyMinSlider.Name = "cannyMinSlider";
            this.cannyMinSlider.Size = new System.Drawing.Size(237, 17);
            this.cannyMinSlider.TabIndex = 24;
            this.cannyMinSlider.Value = 20;
            this.cannyMinSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cannyMinSlider_Scroll);
            // 
            // grayBlobMinSlider
            // 
            this.grayBlobMinSlider.Location = new System.Drawing.Point(1461, 317);
            this.grayBlobMinSlider.Maximum = 50;
            this.grayBlobMinSlider.Name = "grayBlobMinSlider";
            this.grayBlobMinSlider.Size = new System.Drawing.Size(17, 205);
            this.grayBlobMinSlider.TabIndex = 25;
            this.grayBlobMinSlider.Value = 50;
            this.grayBlobMinSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.grayBlobMinSlider_Scroll);
            // 
            // grayBlobMaxSlider
            // 
            this.grayBlobMaxSlider.Location = new System.Drawing.Point(1499, 317);
            this.grayBlobMaxSlider.Minimum = 51;
            this.grayBlobMaxSlider.Name = "grayBlobMaxSlider";
            this.grayBlobMaxSlider.Size = new System.Drawing.Size(17, 205);
            this.grayBlobMaxSlider.TabIndex = 26;
            this.grayBlobMaxSlider.Value = 51;
            this.grayBlobMaxSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.grayBlobMaxSlider_Scroll);
            // 
            // cannyMaxSlider
            // 
            this.cannyMaxSlider.Location = new System.Drawing.Point(675, 341);
            this.cannyMaxSlider.Maximum = 200;
            this.cannyMaxSlider.Minimum = 81;
            this.cannyMaxSlider.Name = "cannyMaxSlider";
            this.cannyMaxSlider.Size = new System.Drawing.Size(242, 17);
            this.cannyMaxSlider.TabIndex = 27;
            this.cannyMaxSlider.Value = 81;
            this.cannyMaxSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cannyMaxSlider_Scroll);
            // 
            // cannyMinimumThreshold
            // 
            this.cannyMinimumThreshold.AutoSize = true;
            this.cannyMinimumThreshold.Location = new System.Drawing.Point(601, 309);
            this.cannyMinimumThreshold.Name = "cannyMinimumThreshold";
            this.cannyMinimumThreshold.Size = new System.Drawing.Size(74, 13);
            this.cannyMinimumThreshold.TabIndex = 28;
            this.cannyMinimumThreshold.Text = "Min Threshold";
            // 
            // cannyMaxThreshold
            // 
            this.cannyMaxThreshold.AutoSize = true;
            this.cannyMaxThreshold.Location = new System.Drawing.Point(598, 341);
            this.cannyMaxThreshold.Name = "cannyMaxThreshold";
            this.cannyMaxThreshold.Size = new System.Drawing.Size(77, 13);
            this.cannyMaxThreshold.TabIndex = 29;
            this.cannyMaxThreshold.Text = "Max Threshold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 766);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Theshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1470, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Blob Size:";
            // 
            // gamaSlider
            // 
            this.gamaSlider.AutoSize = true;
            this.gamaSlider.Location = new System.Drawing.Point(1462, 304);
            this.gamaSlider.Name = "gamaSlider";
            this.gamaSlider.Size = new System.Drawing.Size(54, 13);
            this.gamaSlider.TabIndex = 32;
            this.gamaSlider.Text = "Blob Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1470, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Blob Size:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1466, 820);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1454, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1466, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1504, 823);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1496, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1496, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Max";
            // 
            // blobDetect
            // 
            this.blobDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blobDetect.Location = new System.Drawing.Point(21, 753);
            this.blobDetect.Name = "blobDetect";
            this.blobDetect.Size = new System.Drawing.Size(135, 30);
            this.blobDetect.TabIndex = 40;
            this.blobDetect.Text = "Detect Blobs";
            this.blobDetect.UseVisualStyleBackColor = true;
            this.blobDetect.Click += new System.EventHandler(this.blobDetect_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(86, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 24);
            this.label11.TabIndex = 42;
            this.label11.Text = "Captured Image";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(327, 499);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Red";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(327, 542);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 44;
            this.label13.Text = "Blue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(325, 580);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 45;
            this.label14.Text = "Green";
            // 
            // capturedImagePanel
            // 
            this.capturedImagePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.capturedImagePanel.CanvasSize = new System.Drawing.Size(60, 40);
            this.capturedImagePanel.Image = null;
            this.capturedImagePanel.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.capturedImagePanel.Location = new System.Drawing.Point(7, 499);
            this.capturedImagePanel.Name = "capturedImagePanel";
            this.capturedImagePanel.ROTATION = 0F;
            this.capturedImagePanel.Size = new System.Drawing.Size(305, 245);
            this.capturedImagePanel.TabIndex = 46;
            this.capturedImagePanel.Zoom = 1F;
            // 
            // grayScalePanel
            // 
            this.grayScalePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grayScalePanel.CanvasSize = new System.Drawing.Size(60, 40);
            this.grayScalePanel.Image = null;
            this.grayScalePanel.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.grayScalePanel.Location = new System.Drawing.Point(332, 268);
            this.grayScalePanel.Name = "grayScalePanel";
            this.grayScalePanel.ROTATION = 0F;
            this.grayScalePanel.Size = new System.Drawing.Size(243, 218);
            this.grayScalePanel.TabIndex = 47;
            this.grayScalePanel.Zoom = 1F;
            // 
            // gamaSlider1
            // 
            this.gamaSlider1.Location = new System.Drawing.Point(66, 786);
            this.gamaSlider1.Maximum = 200;
            this.gamaSlider1.Name = "gamaSlider1";
            this.gamaSlider1.Size = new System.Drawing.Size(230, 17);
            this.gamaSlider1.TabIndex = 48;
            this.gamaSlider1.Value = 100;
            this.gamaSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gamaSlider1_Scroll);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 787);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 49;
            this.label15.Text = "Gama";
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrastLabel.Location = new System.Drawing.Point(6, 821);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(57, 16);
            this.contrastLabel.TabIndex = 50;
            this.contrastLabel.Text = "Contrast";
            // 
            // contrastSlider
            // 
            this.contrastSlider.Location = new System.Drawing.Point(66, 820);
            this.contrastSlider.Maximum = 255;
            this.contrastSlider.Name = "contrastSlider";
            this.contrastSlider.Size = new System.Drawing.Size(230, 17);
            this.contrastSlider.TabIndex = 51;
            this.contrastSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.contrastSlider_Scroll);
            // 
            // cannyHistogramBtn
            // 
            this.cannyHistogramBtn.Location = new System.Drawing.Point(967, 25);
            this.cannyHistogramBtn.Name = "cannyHistogramBtn";
            this.cannyHistogramBtn.Size = new System.Drawing.Size(121, 23);
            this.cannyHistogramBtn.TabIndex = 52;
            this.cannyHistogramBtn.Text = "Generate Histogram";
            this.cannyHistogramBtn.UseVisualStyleBackColor = true;
            this.cannyHistogramBtn.Click += new System.EventHandler(this.cannyHistogramBtn_Click);
            // 
            // blackandwhiteHistorgrambtn
            // 
            this.blackandwhiteHistorgrambtn.Location = new System.Drawing.Point(967, 486);
            this.blackandwhiteHistorgrambtn.Name = "blackandwhiteHistorgrambtn";
            this.blackandwhiteHistorgrambtn.Size = new System.Drawing.Size(121, 23);
            this.blackandwhiteHistorgrambtn.TabIndex = 53;
            this.blackandwhiteHistorgrambtn.Text = "Generate Histogram";
            this.blackandwhiteHistorgrambtn.UseVisualStyleBackColor = true;
            this.blackandwhiteHistorgrambtn.Click += new System.EventHandler(this.blackandwhiteHistorgrambtn_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(188, 762);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 17);
            this.checkBox2.TabIndex = 57;
            this.checkBox2.Text = "Gausian Sharpen";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // horizontalColorBtn
            // 
            this.horizontalColorBtn.Location = new System.Drawing.Point(937, 93);
            this.horizontalColorBtn.Name = "horizontalColorBtn";
            this.horizontalColorBtn.Size = new System.Drawing.Size(87, 51);
            this.horizontalColorBtn.TabIndex = 60;
            this.horizontalColorBtn.Text = "Horizontal Histogram Color";
            this.horizontalColorBtn.UseVisualStyleBackColor = true;
            this.horizontalColorBtn.Click += new System.EventHandler(this.horizontalColorBtn_Click);
            // 
            // verticalColorBtn
            // 
            this.verticalColorBtn.Location = new System.Drawing.Point(1037, 93);
            this.verticalColorBtn.Name = "verticalColorBtn";
            this.verticalColorBtn.Size = new System.Drawing.Size(88, 51);
            this.verticalColorBtn.TabIndex = 61;
            this.verticalColorBtn.Text = "Vertical Histogram Color";
            this.verticalColorBtn.UseVisualStyleBackColor = true;
            this.verticalColorBtn.Click += new System.EventHandler(this.verticalColorBtn_Click);
            // 
            // cannyHorizontalHistogramSlider
            // 
            this.cannyHorizontalHistogramSlider.Location = new System.Drawing.Point(587, 287);
            this.cannyHorizontalHistogramSlider.Maximum = 640;
            this.cannyHorizontalHistogramSlider.Name = "cannyHorizontalHistogramSlider";
            this.cannyHorizontalHistogramSlider.Size = new System.Drawing.Size(330, 11);
            this.cannyHorizontalHistogramSlider.TabIndex = 62;
            this.cannyHorizontalHistogramSlider.Value = 320;
            this.cannyHorizontalHistogramSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cannyHorizontalHistogramSlider_Scroll);
            // 
            // blackandwhiteHorizontalHistogramSlider
            // 
            this.blackandwhiteHorizontalHistogramSlider.Location = new System.Drawing.Point(587, 740);
            this.blackandwhiteHorizontalHistogramSlider.Maximum = 640;
            this.blackandwhiteHorizontalHistogramSlider.Name = "blackandwhiteHorizontalHistogramSlider";
            this.blackandwhiteHorizontalHistogramSlider.Size = new System.Drawing.Size(330, 11);
            this.blackandwhiteHorizontalHistogramSlider.TabIndex = 63;
            this.blackandwhiteHorizontalHistogramSlider.Value = 320;
            this.blackandwhiteHorizontalHistogramSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blackandwhiteHorizontalHistogramSlider_Scroll);
            // 
            // cannyVerticalHistogramSlider
            // 
            this.cannyVerticalHistogramSlider.Location = new System.Drawing.Point(918, 31);
            this.cannyVerticalHistogramSlider.Maximum = 480;
            this.cannyVerticalHistogramSlider.Name = "cannyVerticalHistogramSlider";
            this.cannyVerticalHistogramSlider.Size = new System.Drawing.Size(17, 253);
            this.cannyVerticalHistogramSlider.TabIndex = 64;
            this.cannyVerticalHistogramSlider.Value = 240;
            this.cannyVerticalHistogramSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cannyVerticalHistogramSlider_Scroll);
            // 
            // blackandwhiteVerticalHistogramSlider
            // 
            this.blackandwhiteVerticalHistogramSlider.Location = new System.Drawing.Point(919, 480);
            this.blackandwhiteVerticalHistogramSlider.Maximum = 480;
            this.blackandwhiteVerticalHistogramSlider.Name = "blackandwhiteVerticalHistogramSlider";
            this.blackandwhiteVerticalHistogramSlider.Size = new System.Drawing.Size(17, 253);
            this.blackandwhiteVerticalHistogramSlider.TabIndex = 65;
            this.blackandwhiteVerticalHistogramSlider.Value = 240;
            this.blackandwhiteVerticalHistogramSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blackandwhiteVerticalHistogramSlider_Scroll);
            // 
            // cannyVerticalNumRowNUD
            // 
            this.cannyVerticalNumRowNUD.Location = new System.Drawing.Point(937, 67);
            this.cannyVerticalNumRowNUD.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.cannyVerticalNumRowNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cannyVerticalNumRowNUD.Name = "cannyVerticalNumRowNUD";
            this.cannyVerticalNumRowNUD.Size = new System.Drawing.Size(87, 20);
            this.cannyVerticalNumRowNUD.TabIndex = 66;
            this.cannyVerticalNumRowNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // blackandwhiteVerticalNumRowNUD
            // 
            this.blackandwhiteVerticalNumRowNUD.Location = new System.Drawing.Point(931, 529);
            this.blackandwhiteVerticalNumRowNUD.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.blackandwhiteVerticalNumRowNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.blackandwhiteVerticalNumRowNUD.Name = "blackandwhiteVerticalNumRowNUD";
            this.blackandwhiteVerticalNumRowNUD.Size = new System.Drawing.Size(87, 20);
            this.blackandwhiteVerticalNumRowNUD.TabIndex = 67;
            this.blackandwhiteVerticalNumRowNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // blackandwhiteHorizontalRowGapNUD
            // 
            this.blackandwhiteHorizontalRowGapNUD.Location = new System.Drawing.Point(1030, 530);
            this.blackandwhiteHorizontalRowGapNUD.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.blackandwhiteHorizontalRowGapNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.blackandwhiteHorizontalRowGapNUD.Name = "blackandwhiteHorizontalRowGapNUD";
            this.blackandwhiteHorizontalRowGapNUD.Size = new System.Drawing.Size(95, 20);
            this.blackandwhiteHorizontalRowGapNUD.TabIndex = 68;
            this.blackandwhiteHorizontalRowGapNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(929, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Vertical Row Gap";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(934, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "Vertical Row Gap";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // cannyHoriztonalNumRowNUD
            // 
            this.cannyHoriztonalNumRowNUD.Location = new System.Drawing.Point(1037, 67);
            this.cannyHoriztonalNumRowNUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cannyHoriztonalNumRowNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cannyHoriztonalNumRowNUD.Name = "cannyHoriztonalNumRowNUD";
            this.cannyHoriztonalNumRowNUD.Size = new System.Drawing.Size(88, 20);
            this.cannyHoriztonalNumRowNUD.TabIndex = 71;
            this.cannyHoriztonalNumRowNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cannyHoriztonalNumRowNUD.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1025, 513);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "Horizontal Row Gap";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1027, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 13);
            this.label18.TabIndex = 73;
            this.label18.Text = "Horizontal Row Gap";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // crossHairCanny
            // 
            this.crossHairCanny.AutoSize = true;
            this.crossHairCanny.Location = new System.Drawing.Point(939, 151);
            this.crossHairCanny.Name = "crossHairCanny";
            this.crossHairCanny.Size = new System.Drawing.Size(69, 17);
            this.crossHairCanny.TabIndex = 74;
            this.crossHairCanny.Text = "Crosshair";
            this.crossHairCanny.UseVisualStyleBackColor = true;
            // 
            // verticalHistogramCheckboxCanny
            // 
            this.verticalHistogramCheckboxCanny.AutoSize = true;
            this.verticalHistogramCheckboxCanny.Location = new System.Drawing.Point(938, 174);
            this.verticalHistogramCheckboxCanny.Name = "verticalHistogramCheckboxCanny";
            this.verticalHistogramCheckboxCanny.Size = new System.Drawing.Size(111, 17);
            this.verticalHistogramCheckboxCanny.TabIndex = 75;
            this.verticalHistogramCheckboxCanny.Text = "Vertical Histogram";
            this.verticalHistogramCheckboxCanny.UseVisualStyleBackColor = true;
            // 
            // horizontalHistogramCheckboxCanny
            // 
            this.horizontalHistogramCheckboxCanny.AutoSize = true;
            this.horizontalHistogramCheckboxCanny.Location = new System.Drawing.Point(937, 197);
            this.horizontalHistogramCheckboxCanny.Name = "horizontalHistogramCheckboxCanny";
            this.horizontalHistogramCheckboxCanny.Size = new System.Drawing.Size(123, 17);
            this.horizontalHistogramCheckboxCanny.TabIndex = 76;
            this.horizontalHistogramCheckboxCanny.Text = "Horizontal Histogram";
            this.horizontalHistogramCheckboxCanny.UseVisualStyleBackColor = true;
            this.horizontalHistogramCheckboxCanny.CheckedChanged += new System.EventHandler(this.horizontalHistogramCheckboxCanny_CheckedChanged);
            // 
            // crosshairCheckboxBW
            // 
            this.crosshairCheckboxBW.AutoSize = true;
            this.crosshairCheckboxBW.Location = new System.Drawing.Point(941, 625);
            this.crosshairCheckboxBW.Name = "crosshairCheckboxBW";
            this.crosshairCheckboxBW.Size = new System.Drawing.Size(69, 17);
            this.crosshairCheckboxBW.TabIndex = 77;
            this.crosshairCheckboxBW.Text = "Crosshair";
            this.crosshairCheckboxBW.UseVisualStyleBackColor = true;
            // 
            // verticalHistogramCheckboxBW
            // 
            this.verticalHistogramCheckboxBW.AutoSize = true;
            this.verticalHistogramCheckboxBW.Location = new System.Drawing.Point(941, 648);
            this.verticalHistogramCheckboxBW.Name = "verticalHistogramCheckboxBW";
            this.verticalHistogramCheckboxBW.Size = new System.Drawing.Size(111, 17);
            this.verticalHistogramCheckboxBW.TabIndex = 78;
            this.verticalHistogramCheckboxBW.Text = "Vertical Histogram";
            this.verticalHistogramCheckboxBW.UseVisualStyleBackColor = true;
            // 
            // horizontalHistogramCheckboxBW
            // 
            this.horizontalHistogramCheckboxBW.AutoSize = true;
            this.horizontalHistogramCheckboxBW.Location = new System.Drawing.Point(941, 671);
            this.horizontalHistogramCheckboxBW.Name = "horizontalHistogramCheckboxBW";
            this.horizontalHistogramCheckboxBW.Size = new System.Drawing.Size(129, 17);
            this.horizontalHistogramCheckboxBW.TabIndex = 79;
            this.horizontalHistogramCheckboxBW.Text = "Horizonatal Histogram";
            this.horizontalHistogramCheckboxBW.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 51);
            this.button1.TabIndex = 80;
            this.button1.Text = "Horizontal Histogram Color";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1028, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 51);
            this.button2.TabIndex = 81;
            this.button2.Text = "Vertical Histogram Color";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cannyBoundryRangeCheckbox
            // 
            this.cannyBoundryRangeCheckbox.AutoSize = true;
            this.cannyBoundryRangeCheckbox.Location = new System.Drawing.Point(937, 220);
            this.cannyBoundryRangeCheckbox.Name = "cannyBoundryRangeCheckbox";
            this.cannyBoundryRangeCheckbox.Size = new System.Drawing.Size(105, 17);
            this.cannyBoundryRangeCheckbox.TabIndex = 82;
            this.cannyBoundryRangeCheckbox.Text = "Boundry Ranges";
            this.cannyBoundryRangeCheckbox.UseVisualStyleBackColor = true;
            // 
            // bwBoundryRangeCheckbox
            // 
            this.bwBoundryRangeCheckbox.AutoSize = true;
            this.bwBoundryRangeCheckbox.Location = new System.Drawing.Point(941, 694);
            this.bwBoundryRangeCheckbox.Name = "bwBoundryRangeCheckbox";
            this.bwBoundryRangeCheckbox.Size = new System.Drawing.Size(105, 17);
            this.bwBoundryRangeCheckbox.TabIndex = 83;
            this.bwBoundryRangeCheckbox.Text = "Boundry Ranges";
            this.bwBoundryRangeCheckbox.UseVisualStyleBackColor = true;
            // 
            // cannyAveragingConstantNUD
            // 
            this.cannyAveragingConstantNUD.Location = new System.Drawing.Point(1037, 280);
            this.cannyAveragingConstantNUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cannyAveragingConstantNUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cannyAveragingConstantNUD.Name = "cannyAveragingConstantNUD";
            this.cannyAveragingConstantNUD.Size = new System.Drawing.Size(88, 20);
            this.cannyAveragingConstantNUD.TabIndex = 84;
            this.cannyAveragingConstantNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(939, 283);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 85;
            this.label19.Text = "Averging Constant";
            // 
            // bwAveragingConstantNUD
            // 
            this.bwAveragingConstantNUD.Location = new System.Drawing.Point(1031, 757);
            this.bwAveragingConstantNUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.bwAveragingConstantNUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.bwAveragingConstantNUD.Name = "bwAveragingConstantNUD";
            this.bwAveragingConstantNUD.Size = new System.Drawing.Size(88, 20);
            this.bwAveragingConstantNUD.TabIndex = 86;
            this.bwAveragingConstantNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(933, 760);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 87;
            this.label20.Text = "Averging Constant";
            // 
            // bwVerticalAverageHistogramCheckbox
            // 
            this.bwVerticalAverageHistogramCheckbox.AutoSize = true;
            this.bwVerticalAverageHistogramCheckbox.Location = new System.Drawing.Point(941, 716);
            this.bwVerticalAverageHistogramCheckbox.Name = "bwVerticalAverageHistogramCheckbox";
            this.bwVerticalAverageHistogramCheckbox.Size = new System.Drawing.Size(154, 17);
            this.bwVerticalAverageHistogramCheckbox.TabIndex = 88;
            this.bwVerticalAverageHistogramCheckbox.Text = "Vertical Average Histogram";
            this.bwVerticalAverageHistogramCheckbox.UseVisualStyleBackColor = true;
            // 
            // bwHorizontalAverageHistogramCheckbox
            // 
            this.bwHorizontalAverageHistogramCheckbox.AutoSize = true;
            this.bwHorizontalAverageHistogramCheckbox.Location = new System.Drawing.Point(941, 737);
            this.bwHorizontalAverageHistogramCheckbox.Name = "bwHorizontalAverageHistogramCheckbox";
            this.bwHorizontalAverageHistogramCheckbox.Size = new System.Drawing.Size(166, 17);
            this.bwHorizontalAverageHistogramCheckbox.TabIndex = 89;
            this.bwHorizontalAverageHistogramCheckbox.Text = "Horizontal Average Histogram";
            this.bwHorizontalAverageHistogramCheckbox.UseVisualStyleBackColor = true;
            // 
            // cannyAvgVerticalHistogramCheckBox
            // 
            this.cannyAvgVerticalHistogramCheckBox.AutoSize = true;
            this.cannyAvgVerticalHistogramCheckBox.Location = new System.Drawing.Point(937, 241);
            this.cannyAvgVerticalHistogramCheckBox.Name = "cannyAvgVerticalHistogramCheckBox";
            this.cannyAvgVerticalHistogramCheckBox.Size = new System.Drawing.Size(154, 17);
            this.cannyAvgVerticalHistogramCheckBox.TabIndex = 90;
            this.cannyAvgVerticalHistogramCheckBox.Text = "Vertical Average Histogram";
            this.cannyAvgVerticalHistogramCheckBox.UseVisualStyleBackColor = true;
            // 
            // cannyAvgHorziontalHistogramCheckbox
            // 
            this.cannyAvgHorziontalHistogramCheckbox.AutoSize = true;
            this.cannyAvgHorziontalHistogramCheckbox.Location = new System.Drawing.Point(937, 262);
            this.cannyAvgHorziontalHistogramCheckbox.Name = "cannyAvgHorziontalHistogramCheckbox";
            this.cannyAvgHorziontalHistogramCheckbox.Size = new System.Drawing.Size(166, 17);
            this.cannyAvgHorziontalHistogramCheckbox.TabIndex = 91;
            this.cannyAvgHorziontalHistogramCheckbox.Text = "Horizontal Average Histogram";
            this.cannyAvgHorziontalHistogramCheckbox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(873, 809);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 20);
            this.textBox1.TabIndex = 92;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(773, 812);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 93;
            this.label21.Text = "0";
            // 
            // cannyMinBlobSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 846);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cannyAvgHorziontalHistogramCheckbox);
            this.Controls.Add(this.cannyAvgVerticalHistogramCheckBox);
            this.Controls.Add(this.bwHorizontalAverageHistogramCheckbox);
            this.Controls.Add(this.bwVerticalAverageHistogramCheckbox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.bwAveragingConstantNUD);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cannyAveragingConstantNUD);
            this.Controls.Add(this.bwBoundryRangeCheckbox);
            this.Controls.Add(this.cannyBoundryRangeCheckbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.horizontalHistogramCheckboxBW);
            this.Controls.Add(this.verticalHistogramCheckboxBW);
            this.Controls.Add(this.crosshairCheckboxBW);
            this.Controls.Add(this.horizontalHistogramCheckboxCanny);
            this.Controls.Add(this.verticalHistogramCheckboxCanny);
            this.Controls.Add(this.crossHairCanny);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cannyHoriztonalNumRowNUD);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blackandwhiteHorizontalRowGapNUD);
            this.Controls.Add(this.blackandwhiteVerticalNumRowNUD);
            this.Controls.Add(this.cannyVerticalNumRowNUD);
            this.Controls.Add(this.blackandwhiteVerticalHistogramSlider);
            this.Controls.Add(this.cannyVerticalHistogramSlider);
            this.Controls.Add(this.blackandwhiteHorizontalHistogramSlider);
            this.Controls.Add(this.cannyHorizontalHistogramSlider);
            this.Controls.Add(this.verticalColorBtn);
            this.Controls.Add(this.horizontalColorBtn);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.blackandwhiteHistorgrambtn);
            this.Controls.Add(this.cannyHistogramBtn);
            this.Controls.Add(this.contrastSlider);
            this.Controls.Add(this.contrastLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gamaSlider1);
            this.Controls.Add(this.grayScalePanel);
            this.Controls.Add(this.capturedImagePanel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.blobDetect);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gamaSlider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cannyMaxThreshold);
            this.Controls.Add(this.cannyMinimumThreshold);
            this.Controls.Add(this.cannyMaxSlider);
            this.Controls.Add(this.grayBlobMaxSlider);
            this.Controls.Add(this.grayBlobMinSlider);
            this.Controls.Add(this.cannyMinSlider);
            this.Controls.Add(this.blackandwhiteSlider);
            this.Controls.Add(this.cannyBlobMinSlider);
            this.Controls.Add(this.cannyBlobMaxSlider);
            this.Controls.Add(this.blackandwhiteBlobMaxSlider);
            this.Controls.Add(this.blobDetectionForm);
            this.Controls.Add(this.blackandwhiteBlobDetectionLabel);
            this.Controls.Add(this.cannyBlobDetection);
            this.Controls.Add(this.cannyLabel);
            this.Controls.Add(this.blackandwhiteLabel);
            this.Controls.Add(this.greyScaleBlobLabel);
            this.Controls.Add(this.greenSlider);
            this.Controls.Add(this.blueSlider);
            this.Controls.Add(this.redSlider);
            this.Controls.Add(this.cannyBlobPanel);
            this.Controls.Add(this.blackandwhiteBlobPanel);
            this.Controls.Add(this.cannyPanel);
            this.Controls.Add(this.blackandwhitePanel);
            this.Controls.Add(this.crossHareCheckBox);
            this.Controls.Add(this.grayScale);
            this.Controls.Add(this.videoSourceList);
            this.Controls.Add(this.RecordBtn);
            this.Controls.Add(this.liveVideoSource);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Name = "cannyMinBlobSize";
            this.Text = "Blob Detection Application";
            this.Load += new System.EventHandler(this.BlobDetection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cannyVerticalNumRowNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackandwhiteVerticalNumRowNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackandwhiteHorizontalRowGapNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyHoriztonalNumRowNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyAveragingConstantNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bwAveragingConstantNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Label liveVideoSource;
        private System.Windows.Forms.Button RecordBtn;
        private System.Windows.Forms.ComboBox videoSourceList;
        private System.Windows.Forms.Label grayScale;
        private CustomTools.ScrollableImagePanel crossHareCheckBox;
        private CustomTools.ScrollableImagePanel blackandwhitePanel;
        private CustomTools.ScrollableImagePanel cannyPanel;
        private CustomTools.ScrollableImagePanel blackandwhiteBlobPanel;
        private CustomTools.ScrollableImagePanel cannyBlobPanel;
        private System.Windows.Forms.HScrollBar redSlider;
        private System.Windows.Forms.HScrollBar blueSlider;
        private System.Windows.Forms.HScrollBar greenSlider;
        private System.Windows.Forms.Label greyScaleBlobLabel;
        private System.Windows.Forms.Label blackandwhiteLabel;
        private System.Windows.Forms.Label cannyLabel;
        private System.Windows.Forms.Label cannyBlobDetection;
        private System.Windows.Forms.Label blackandwhiteBlobDetectionLabel;
        private System.Windows.Forms.VScrollBar blobDetectionForm;
        private System.Windows.Forms.VScrollBar blackandwhiteBlobMaxSlider;
        private System.Windows.Forms.VScrollBar cannyBlobMaxSlider;
        private System.Windows.Forms.VScrollBar cannyBlobMinSlider;
        private System.Windows.Forms.HScrollBar blackandwhiteSlider;
        private System.Windows.Forms.HScrollBar cannyMinSlider;
        private System.Windows.Forms.VScrollBar grayBlobMinSlider;
        private System.Windows.Forms.VScrollBar grayBlobMaxSlider;
        private System.Windows.Forms.HScrollBar cannyMaxSlider;
        private System.Windows.Forms.Label cannyMinimumThreshold;
        private System.Windows.Forms.Label cannyMaxThreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gamaSlider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button blobDetect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private CustomTools.ScrollableImagePanel capturedImagePanel;
        private CustomTools.ScrollableImagePanel grayScalePanel;
        private System.Windows.Forms.HScrollBar gamaSlider1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.HScrollBar contrastSlider;
        private System.Windows.Forms.Button cannyHistogramBtn;
        private System.Windows.Forms.Button blackandwhiteHistorgrambtn;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button horizontalColorBtn;
        private System.Windows.Forms.Button verticalColorBtn;
        private System.Windows.Forms.HScrollBar cannyHorizontalHistogramSlider;
        private System.Windows.Forms.HScrollBar blackandwhiteHorizontalHistogramSlider;
        private System.Windows.Forms.VScrollBar cannyVerticalHistogramSlider;
        private System.Windows.Forms.VScrollBar blackandwhiteVerticalHistogramSlider;
        private System.Windows.Forms.NumericUpDown cannyVerticalNumRowNUD;
        private System.Windows.Forms.NumericUpDown blackandwhiteVerticalNumRowNUD;
        private System.Windows.Forms.NumericUpDown blackandwhiteHorizontalRowGapNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown cannyHoriztonalNumRowNUD;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox crossHairCanny;
        private System.Windows.Forms.CheckBox verticalHistogramCheckboxCanny;
        private System.Windows.Forms.CheckBox horizontalHistogramCheckboxCanny;
        private System.Windows.Forms.CheckBox crosshairCheckboxBW;
        private System.Windows.Forms.CheckBox verticalHistogramCheckboxBW;
        private System.Windows.Forms.CheckBox horizontalHistogramCheckboxBW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cannyBoundryRangeCheckbox;
        private System.Windows.Forms.CheckBox bwBoundryRangeCheckbox;
        private System.Windows.Forms.NumericUpDown cannyAveragingConstantNUD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown bwAveragingConstantNUD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox bwVerticalAverageHistogramCheckbox;
        private System.Windows.Forms.CheckBox bwHorizontalAverageHistogramCheckbox;
        private System.Windows.Forms.CheckBox cannyAvgVerticalHistogramCheckBox;
        private System.Windows.Forms.CheckBox cannyAvgHorziontalHistogramCheckbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label21;
    }
}

