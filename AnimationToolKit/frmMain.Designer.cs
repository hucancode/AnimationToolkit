using System.Windows.Forms;
namespace AnimationToolkit
{
    partial class frmMain
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
            this.lstPictureList = new System.Windows.Forms.ListBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numForcedX = new System.Windows.Forms.NumericUpDown();
            this.numForcedY = new System.Windows.Forms.NumericUpDown();
            this.chkForcedX = new System.Windows.Forms.CheckBox();
            this.chkForcedY = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numBorder = new System.Windows.Forms.NumericUpDown();
            this.chkBorder = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numGrid = new System.Windows.Forms.NumericUpDown();
            this.chkGrid = new System.Windows.Forms.CheckBox();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnStepForward = new System.Windows.Forms.Button();
            this.btnStepBackward = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.barImageProcess = new System.Windows.Forms.ProgressBar();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.bcwImageProcess = new System.ComponentModel.BackgroundWorker();
            this.mnMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLoadPNG = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLoadMNG = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSavePNG = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaveFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaveXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFrameControl = new System.Windows.Forms.ToolStripMenuItem();
            this.mnProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRemoveAt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAlphaCrop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnResize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnimationControl = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnForward = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBackward = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFrameEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.grpFrameControl = new System.Windows.Forms.GroupBox();
            this.chkSquareFrame = new System.Windows.Forms.CheckBox();
            this.grpAnimationControl = new System.Windows.Forms.GroupBox();
            this.pnlPicContainer = new System.Windows.Forms.Panel();
            this.picShadowAnimation = new System.Windows.Forms.PictureBox();
            this.picAnimation = new System.Windows.Forms.PictureBox();
            this.picSheet = new System.Windows.Forms.PictureBox();
            this.dlgSaveFrame = new System.Windows.Forms.FolderBrowserDialog();
            this.tsLoadPNG = new System.Windows.Forms.ToolStripButton();
            this.tsLoadMNG = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSavePNG = new System.Windows.Forms.ToolStripButton();
            this.tsSaveFrame = new System.Windows.Forms.ToolStripButton();
            this.tsSaveXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsRemoveAt = new System.Windows.Forms.ToolStripButton();
            this.tsRemoveAll = new System.Windows.Forms.ToolStripButton();
            this.tsProcess = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAlphaCrop = new System.Windows.Forms.ToolStripButton();
            this.tsResize = new System.Windows.Forms.ToolStripButton();
            this.tsMainToolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.numForcedX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForcedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrid)).BeginInit();
            this.mnMainMenuStrip.SuspendLayout();
            this.grpFrameControl.SuspendLayout();
            this.grpAnimationControl.SuspendLayout();
            this.pnlPicContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShadowAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSheet)).BeginInit();
            this.tsMainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPictureList
            // 
            this.lstPictureList.FormattingEnabled = true;
            this.lstPictureList.Location = new System.Drawing.Point(149, 15);
            this.lstPictureList.Name = "lstPictureList";
            this.lstPictureList.Size = new System.Drawing.Size(271, 134);
            this.lstPictureList.TabIndex = 0;
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "All format|*.PNG;*.BMP;*.JPG|PNG|*.PNG|BMP|*.BMP|JPG|*.JPG";
            this.dlgOpen.Multiselect = true;
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Interval = 50;
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Forced X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Forced Y:";
            // 
            // numForcedX
            // 
            this.numForcedX.Location = new System.Drawing.Point(65, 48);
            this.numForcedX.Name = "numForcedX";
            this.numForcedX.Size = new System.Drawing.Size(41, 20);
            this.numForcedX.TabIndex = 2;
            // 
            // numForcedY
            // 
            this.numForcedY.Location = new System.Drawing.Point(65, 72);
            this.numForcedY.Name = "numForcedY";
            this.numForcedY.Size = new System.Drawing.Size(41, 20);
            this.numForcedY.TabIndex = 4;
            // 
            // chkForcedX
            // 
            this.chkForcedX.AutoSize = true;
            this.chkForcedX.Location = new System.Drawing.Point(129, 52);
            this.chkForcedX.Name = "chkForcedX";
            this.chkForcedX.Size = new System.Drawing.Size(15, 14);
            this.chkForcedX.TabIndex = 3;
            this.chkForcedX.UseVisualStyleBackColor = true;
            // 
            // chkForcedY
            // 
            this.chkForcedY.AutoSize = true;
            this.chkForcedY.Location = new System.Drawing.Point(129, 74);
            this.chkForcedY.Name = "chkForcedY";
            this.chkForcedY.Size = new System.Drawing.Size(15, 14);
            this.chkForcedY.TabIndex = 5;
            this.chkForcedY.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Border:";
            // 
            // numBorder
            // 
            this.numBorder.Location = new System.Drawing.Point(65, 96);
            this.numBorder.Name = "numBorder";
            this.numBorder.Size = new System.Drawing.Size(41, 20);
            this.numBorder.TabIndex = 6;
            this.numBorder.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // chkBorder
            // 
            this.chkBorder.AutoSize = true;
            this.chkBorder.Checked = true;
            this.chkBorder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBorder.Location = new System.Drawing.Point(129, 98);
            this.chkBorder.Name = "chkBorder";
            this.chkBorder.Size = new System.Drawing.Size(15, 14);
            this.chkBorder.TabIndex = 7;
            this.chkBorder.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grid:";
            // 
            // numGrid
            // 
            this.numGrid.Location = new System.Drawing.Point(65, 22);
            this.numGrid.Name = "numGrid";
            this.numGrid.Size = new System.Drawing.Size(41, 20);
            this.numGrid.TabIndex = 0;
            this.numGrid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkGrid
            // 
            this.chkGrid.AutoSize = true;
            this.chkGrid.Checked = true;
            this.chkGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGrid.Location = new System.Drawing.Point(129, 26);
            this.chkGrid.Name = "chkGrid";
            this.chkGrid.Size = new System.Drawing.Size(15, 14);
            this.chkGrid.TabIndex = 1;
            this.chkGrid.UseVisualStyleBackColor = true;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPlayPause.Location = new System.Drawing.Point(6, 478);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(42, 24);
            this.btnPlayPause.TabIndex = 5;
            this.btnPlayPause.Text = "w";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnStepForward
            // 
            this.btnStepForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStepForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStepForward.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnStepForward.Location = new System.Drawing.Point(104, 478);
            this.btnStepForward.Name = "btnStepForward";
            this.btnStepForward.Size = new System.Drawing.Size(42, 24);
            this.btnStepForward.TabIndex = 7;
            this.btnStepForward.Text = "à";
            this.btnStepForward.UseVisualStyleBackColor = true;
            this.btnStepForward.Click += new System.EventHandler(this.btnStepForward_Click);
            // 
            // btnStepBackward
            // 
            this.btnStepBackward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStepBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStepBackward.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnStepBackward.Location = new System.Drawing.Point(55, 478);
            this.btnStepBackward.Name = "btnStepBackward";
            this.btnStepBackward.Size = new System.Drawing.Size(42, 24);
            this.btnStepBackward.TabIndex = 6;
            this.btnStepBackward.Text = "ß";
            this.btnStepBackward.UseVisualStyleBackColor = true;
            this.btnStepBackward.Click += new System.EventHandler(this.btnStepBackward_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(161, 211);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(32, 21);
            this.lblPercentage.TabIndex = 22;
            this.lblPercentage.Text = "0%";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPercentage.Visible = false;
            // 
            // barImageProcess
            // 
            this.barImageProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.barImageProcess.Location = new System.Drawing.Point(112, 235);
            this.barImageProcess.Name = "barImageProcess";
            this.barImageProcess.Size = new System.Drawing.Size(113, 31);
            this.barImageProcess.TabIndex = 21;
            this.barImageProcess.Visible = false;
            // 
            // btnCenter
            // 
            this.btnCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCenter.BackColor = System.Drawing.SystemColors.Control;
            this.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCenter.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnCenter.Location = new System.Drawing.Point(266, 49);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(28, 28);
            this.btnCenter.TabIndex = 4;
            this.btnCenter.Text = "[";
            this.btnCenter.UseVisualStyleBackColor = false;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnDown.Location = new System.Drawing.Point(266, 83);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(28, 28);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "ê";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRight.Location = new System.Drawing.Point(300, 50);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(28, 28);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "è";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnLeft.Location = new System.Drawing.Point(232, 49);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(28, 28);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "ç";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Font = new System.Drawing.Font("Wingdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUp.Location = new System.Drawing.Point(266, 15);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(28, 28);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "é";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // bcwImageProcess
            // 
            this.bcwImageProcess.WorkerReportsProgress = true;
            this.bcwImageProcess.WorkerSupportsCancellation = true;
            // 
            // mnMainMenuStrip
            // 
            this.mnMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuFrameControl,
            this.mnuAnimationControl,
            this.mnuFrameEditor,
            this.mnuHelp});
            this.mnMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnMainMenuStrip.Name = "mnMainMenuStrip";
            this.mnMainMenuStrip.Size = new System.Drawing.Size(792, 24);
            this.mnMainMenuStrip.TabIndex = 1;
            this.mnMainMenuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLoadPNG,
            this.mnLoadMNG,
            this.mnSavePNG,
            this.mnSaveFrame,
            this.mnSaveXML,
            this.mnExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnLoadPNG
            // 
            this.mnLoadPNG.Image = global::AnimationToolkit.Properties.Resources.arrow_down;
            this.mnLoadPNG.Name = "mnLoadPNG";
            this.mnLoadPNG.Size = new System.Drawing.Size(220, 22);
            this.mnLoadPNG.Text = "Load PNG";
            this.mnLoadPNG.Click += new System.EventHandler(this.mnLoadAnimation_Click);
            // 
            // mnLoadMNG
            // 
            this.mnLoadMNG.Image = global::AnimationToolkit.Properties.Resources.color;
            this.mnLoadMNG.Name = "mnLoadMNG";
            this.mnLoadMNG.Size = new System.Drawing.Size(220, 22);
            this.mnLoadMNG.Text = "Load MNG";
            this.mnLoadMNG.Click += new System.EventHandler(this.mnLoadMNG_Click);
            // 
            // mnSavePNG
            // 
            this.mnSavePNG.Image = global::AnimationToolkit.Properties.Resources.save;
            this.mnSavePNG.Name = "mnSavePNG";
            this.mnSavePNG.Size = new System.Drawing.Size(220, 22);
            this.mnSavePNG.Text = "Save PNG- Animation sheet";
            this.mnSavePNG.Click += new System.EventHandler(this.mnSavePNG_Click);
            // 
            // mnSaveFrame
            // 
            this.mnSaveFrame.Image = global::AnimationToolkit.Properties.Resources.disk;
            this.mnSaveFrame.Name = "mnSaveFrame";
            this.mnSaveFrame.Size = new System.Drawing.Size(220, 22);
            this.mnSaveFrame.Text = "Save PNG- Frame by frame";
            this.mnSaveFrame.Click += new System.EventHandler(this.mnSaveFrame_Click);
            // 
            // mnSaveXML
            // 
            this.mnSaveXML.Image = global::AnimationToolkit.Properties.Resources.xml;
            this.mnSaveXML.Name = "mnSaveXML";
            this.mnSaveXML.Size = new System.Drawing.Size(220, 22);
            this.mnSaveXML.Text = "Save XML";
            this.mnSaveXML.Click += new System.EventHandler(this.mnSaveXML_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(220, 22);
            this.mnExit.Text = "Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnuFrameControl
            // 
            this.mnuFrameControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProcess,
            this.mnAdd,
            this.mnRemoveAt,
            this.mnRemoveAll,
            this.mnAlphaCrop,
            this.mnResize});
            this.mnuFrameControl.Name = "mnuFrameControl";
            this.mnuFrameControl.Size = new System.Drawing.Size(93, 20);
            this.mnuFrameControl.Text = "Frame control";
            // 
            // mnProcess
            // 
            this.mnProcess.Image = global::AnimationToolkit.Properties.Resources.play;
            this.mnProcess.Name = "mnProcess";
            this.mnProcess.Size = new System.Drawing.Size(152, 22);
            this.mnProcess.Text = "Process";
            this.mnProcess.Click += new System.EventHandler(this.mnProcess_Click);
            // 
            // mnAdd
            // 
            this.mnAdd.Image = global::AnimationToolkit.Properties.Resources.plus;
            this.mnAdd.Name = "mnAdd";
            this.mnAdd.Size = new System.Drawing.Size(152, 22);
            this.mnAdd.Text = "Add";
            this.mnAdd.Click += new System.EventHandler(this.mnAdd_Click);
            // 
            // mnRemoveAt
            // 
            this.mnRemoveAt.Image = global::AnimationToolkit.Properties.Resources.minus;
            this.mnRemoveAt.Name = "mnRemoveAt";
            this.mnRemoveAt.Size = new System.Drawing.Size(152, 22);
            this.mnRemoveAt.Text = "Remove";
            this.mnRemoveAt.Click += new System.EventHandler(this.mnRemoveAt_Click);
            // 
            // mnRemoveAll
            // 
            this.mnRemoveAll.Image = global::AnimationToolkit.Properties.Resources.button_cancel;
            this.mnRemoveAll.Name = "mnRemoveAll";
            this.mnRemoveAll.Size = new System.Drawing.Size(152, 22);
            this.mnRemoveAll.Text = "Remove all";
            this.mnRemoveAll.Click += new System.EventHandler(this.mnRemoveAll_Click);
            // 
            // mnAlphaCrop
            // 
            this.mnAlphaCrop.Image = global::AnimationToolkit.Properties.Resources.measure_crop;
            this.mnAlphaCrop.Name = "mnAlphaCrop";
            this.mnAlphaCrop.Size = new System.Drawing.Size(152, 22);
            this.mnAlphaCrop.Text = "Alpha crop";
            this.mnAlphaCrop.Click += new System.EventHandler(this.mnAlphaCrop_Click);
            // 
            // mnResize
            // 
            this.mnResize.Image = global::AnimationToolkit.Properties.Resources.statistics;
            this.mnResize.Name = "mnResize";
            this.mnResize.Size = new System.Drawing.Size(152, 22);
            this.mnResize.Text = "Resize";
            this.mnResize.Click += new System.EventHandler(this.mnResize_Click);
            // 
            // mnuAnimationControl
            // 
            this.mnuAnimationControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPlay,
            this.mnForward,
            this.mnBackward});
            this.mnuAnimationControl.Name = "mnuAnimationControl";
            this.mnuAnimationControl.Size = new System.Drawing.Size(118, 20);
            this.mnuAnimationControl.Text = "Animation Control";
            // 
            // mnPlay
            // 
            this.mnPlay.Name = "mnPlay";
            this.mnPlay.Size = new System.Drawing.Size(152, 22);
            this.mnPlay.Text = "Play/ Pause";
            this.mnPlay.Click += new System.EventHandler(this.mnPlay_Click);
            // 
            // mnForward
            // 
            this.mnForward.Name = "mnForward";
            this.mnForward.Size = new System.Drawing.Size(152, 22);
            this.mnForward.Text = "Forward";
            this.mnForward.Click += new System.EventHandler(this.mnForward_Click);
            // 
            // mnBackward
            // 
            this.mnBackward.Name = "mnBackward";
            this.mnBackward.Size = new System.Drawing.Size(152, 22);
            this.mnBackward.Text = "Backward";
            this.mnBackward.Click += new System.EventHandler(this.mnBackward_Click);
            // 
            // mnuFrameEditor
            // 
            this.mnuFrameEditor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCenter,
            this.mnUp,
            this.mnDown,
            this.mnLeft,
            this.mnRight});
            this.mnuFrameEditor.Name = "mnuFrameEditor";
            this.mnuFrameEditor.Size = new System.Drawing.Size(86, 20);
            this.mnuFrameEditor.Text = "Frame editor";
            // 
            // mnCenter
            // 
            this.mnCenter.Name = "mnCenter";
            this.mnCenter.Size = new System.Drawing.Size(109, 22);
            this.mnCenter.Text = "Center";
            this.mnCenter.Click += new System.EventHandler(this.mnCenter_Click);
            // 
            // mnUp
            // 
            this.mnUp.Name = "mnUp";
            this.mnUp.Size = new System.Drawing.Size(109, 22);
            this.mnUp.Text = "Up";
            this.mnUp.Click += new System.EventHandler(this.mnUp_Click);
            // 
            // mnDown
            // 
            this.mnDown.Name = "mnDown";
            this.mnDown.Size = new System.Drawing.Size(109, 22);
            this.mnDown.Text = "Down";
            this.mnDown.Click += new System.EventHandler(this.mnDown_Click);
            // 
            // mnLeft
            // 
            this.mnLeft.Name = "mnLeft";
            this.mnLeft.Size = new System.Drawing.Size(109, 22);
            this.mnLeft.Text = "Left";
            this.mnLeft.Click += new System.EventHandler(this.mnLeft_Click);
            // 
            // mnRight
            // 
            this.mnRight.Name = "mnRight";
            this.mnRight.Size = new System.Drawing.Size(109, 22);
            this.mnRight.Text = "Right";
            this.mnRight.Click += new System.EventHandler(this.mnRight_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnAbout
            // 
            this.mnAbout.Name = "mnAbout";
            this.mnAbout.Size = new System.Drawing.Size(107, 22);
            this.mnAbout.Text = "About";
            this.mnAbout.Click += new System.EventHandler(this.mnAbout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // grpFrameControl
            // 
            this.grpFrameControl.Controls.Add(this.chkSquareFrame);
            this.grpFrameControl.Controls.Add(this.label4);
            this.grpFrameControl.Controls.Add(this.lstPictureList);
            this.grpFrameControl.Controls.Add(this.label1);
            this.grpFrameControl.Controls.Add(this.label2);
            this.grpFrameControl.Controls.Add(this.label3);
            this.grpFrameControl.Controls.Add(this.numForcedX);
            this.grpFrameControl.Controls.Add(this.chkBorder);
            this.grpFrameControl.Controls.Add(this.numGrid);
            this.grpFrameControl.Controls.Add(this.chkForcedY);
            this.grpFrameControl.Controls.Add(this.numForcedY);
            this.grpFrameControl.Controls.Add(this.chkGrid);
            this.grpFrameControl.Controls.Add(this.numBorder);
            this.grpFrameControl.Controls.Add(this.chkForcedX);
            this.grpFrameControl.Location = new System.Drawing.Point(12, 52);
            this.grpFrameControl.Name = "grpFrameControl";
            this.grpFrameControl.Size = new System.Drawing.Size(426, 154);
            this.grpFrameControl.TabIndex = 3;
            this.grpFrameControl.TabStop = false;
            this.grpFrameControl.Text = "Frame Control";
            // 
            // chkSquareFrame
            // 
            this.chkSquareFrame.AutoSize = true;
            this.chkSquareFrame.Location = new System.Drawing.Point(9, 129);
            this.chkSquareFrame.Name = "chkSquareFrame";
            this.chkSquareFrame.Size = new System.Drawing.Size(89, 17);
            this.chkSquareFrame.TabIndex = 8;
            this.chkSquareFrame.Text = "Square frame";
            this.chkSquareFrame.UseVisualStyleBackColor = true;
            // 
            // grpAnimationControl
            // 
            this.grpAnimationControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAnimationControl.Controls.Add(this.lblPercentage);
            this.grpAnimationControl.Controls.Add(this.btnPlayPause);
            this.grpAnimationControl.Controls.Add(this.barImageProcess);
            this.grpAnimationControl.Controls.Add(this.btnUp);
            this.grpAnimationControl.Controls.Add(this.btnStepBackward);
            this.grpAnimationControl.Controls.Add(this.btnStepForward);
            this.grpAnimationControl.Controls.Add(this.btnCenter);
            this.grpAnimationControl.Controls.Add(this.btnLeft);
            this.grpAnimationControl.Controls.Add(this.btnRight);
            this.grpAnimationControl.Controls.Add(this.btnDown);
            this.grpAnimationControl.Controls.Add(this.pnlPicContainer);
            this.grpAnimationControl.Location = new System.Drawing.Point(444, 52);
            this.grpAnimationControl.Name = "grpAnimationControl";
            this.grpAnimationControl.Size = new System.Drawing.Size(336, 509);
            this.grpAnimationControl.TabIndex = 0;
            this.grpAnimationControl.TabStop = false;
            this.grpAnimationControl.Text = "Animation control";
            // 
            // pnlPicContainer
            // 
            this.pnlPicContainer.Controls.Add(this.picShadowAnimation);
            this.pnlPicContainer.Controls.Add(this.picAnimation);
            this.pnlPicContainer.Location = new System.Drawing.Point(56, 117);
            this.pnlPicContainer.Name = "pnlPicContainer";
            this.pnlPicContainer.Size = new System.Drawing.Size(241, 186);
            this.pnlPicContainer.TabIndex = 23;
            // 
            // picShadowAnimation
            // 
            this.picShadowAnimation.BackColor = System.Drawing.Color.Transparent;
            this.picShadowAnimation.Location = new System.Drawing.Point(13, 4);
            this.picShadowAnimation.Name = "picShadowAnimation";
            this.picShadowAnimation.Size = new System.Drawing.Size(101, 87);
            this.picShadowAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picShadowAnimation.TabIndex = 5;
            this.picShadowAnimation.TabStop = false;
            this.picShadowAnimation.Visible = false;
            // 
            // picAnimation
            // 
            this.picAnimation.BackColor = System.Drawing.Color.Transparent;
            this.picAnimation.Location = new System.Drawing.Point(120, 75);
            this.picAnimation.Name = "picAnimation";
            this.picAnimation.Size = new System.Drawing.Size(110, 101);
            this.picAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAnimation.TabIndex = 4;
            this.picAnimation.TabStop = false;
            this.picAnimation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAnimation_MouseDown);
            this.picAnimation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picAnimation_MouseUp);
            // 
            // picSheet
            // 
            this.picSheet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picSheet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSheet.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.picSheet.Location = new System.Drawing.Point(12, 212);
            this.picSheet.Name = "picSheet";
            this.picSheet.Size = new System.Drawing.Size(426, 349);
            this.picSheet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSheet.TabIndex = 20;
            this.picSheet.TabStop = false;
            this.picSheet.Click += new System.EventHandler(this.picSheet_Click);
            // 
            // tsLoadPNG
            // 
            this.tsLoadPNG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLoadPNG.Image = global::AnimationToolkit.Properties.Resources.arrow_down;
            this.tsLoadPNG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLoadPNG.Name = "tsLoadPNG";
            this.tsLoadPNG.Size = new System.Drawing.Size(23, 22);
            this.tsLoadPNG.Text = "Load PNG";
            this.tsLoadPNG.Click += new System.EventHandler(this.tsLoadPNG_Click);
            // 
            // tsLoadMNG
            // 
            this.tsLoadMNG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLoadMNG.Image = global::AnimationToolkit.Properties.Resources.color;
            this.tsLoadMNG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLoadMNG.Name = "tsLoadMNG";
            this.tsLoadMNG.Size = new System.Drawing.Size(23, 22);
            this.tsLoadMNG.Text = "Load MNG";
            this.tsLoadMNG.Click += new System.EventHandler(this.tsLoadMNG_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSavePNG
            // 
            this.tsSavePNG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSavePNG.Image = global::AnimationToolkit.Properties.Resources.save;
            this.tsSavePNG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSavePNG.Name = "tsSavePNG";
            this.tsSavePNG.Size = new System.Drawing.Size(23, 22);
            this.tsSavePNG.Text = "Save PNG- Animation sheet";
            this.tsSavePNG.Click += new System.EventHandler(this.tsSavePNG_Click);
            // 
            // tsSaveFrame
            // 
            this.tsSaveFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSaveFrame.Image = global::AnimationToolkit.Properties.Resources.disk;
            this.tsSaveFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveFrame.Name = "tsSaveFrame";
            this.tsSaveFrame.Size = new System.Drawing.Size(23, 22);
            this.tsSaveFrame.Text = "Save PNG- Frame by frame";
            this.tsSaveFrame.Click += new System.EventHandler(this.tsSaveFrame_Click);
            // 
            // tsSaveXML
            // 
            this.tsSaveXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSaveXML.Image = global::AnimationToolkit.Properties.Resources.xml;
            this.tsSaveXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveXML.Name = "tsSaveXML";
            this.tsSaveXML.Size = new System.Drawing.Size(23, 22);
            this.tsSaveXML.Text = "Save xml";
            this.tsSaveXML.Click += new System.EventHandler(this.tsSaveXML_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsAdd
            // 
            this.tsAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAdd.Image = global::AnimationToolkit.Properties.Resources.plus;
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(23, 22);
            this.tsAdd.Text = "Add";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsRemoveAt
            // 
            this.tsRemoveAt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRemoveAt.Image = global::AnimationToolkit.Properties.Resources.minus;
            this.tsRemoveAt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRemoveAt.Name = "tsRemoveAt";
            this.tsRemoveAt.Size = new System.Drawing.Size(23, 22);
            this.tsRemoveAt.Text = "Remove at";
            this.tsRemoveAt.Click += new System.EventHandler(this.tsRemoveAt_Click);
            // 
            // tsRemoveAll
            // 
            this.tsRemoveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRemoveAll.Image = global::AnimationToolkit.Properties.Resources.button_cancel;
            this.tsRemoveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRemoveAll.Name = "tsRemoveAll";
            this.tsRemoveAll.Size = new System.Drawing.Size(23, 22);
            this.tsRemoveAll.Text = "Remove all";
            this.tsRemoveAll.Click += new System.EventHandler(this.tsRemoveAll_Click);
            // 
            // tsProcess
            // 
            this.tsProcess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsProcess.Image = global::AnimationToolkit.Properties.Resources.play;
            this.tsProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsProcess.Name = "tsProcess";
            this.tsProcess.Size = new System.Drawing.Size(23, 22);
            this.tsProcess.Text = "Process";
            this.tsProcess.Click += new System.EventHandler(this.tsProcess_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsAlphaCrop
            // 
            this.tsAlphaCrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAlphaCrop.Image = global::AnimationToolkit.Properties.Resources.measure_crop;
            this.tsAlphaCrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlphaCrop.Name = "tsAlphaCrop";
            this.tsAlphaCrop.Size = new System.Drawing.Size(23, 22);
            this.tsAlphaCrop.Text = "Alpha crop";
            this.tsAlphaCrop.Click += new System.EventHandler(this.tsAlphaCrop_Click);
            // 
            // tsResize
            // 
            this.tsResize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsResize.Image = global::AnimationToolkit.Properties.Resources.statistics;
            this.tsResize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsResize.Name = "tsResize";
            this.tsResize.Size = new System.Drawing.Size(23, 22);
            this.tsResize.Text = "Resize";
            this.tsResize.Click += new System.EventHandler(this.tsResize_Click);
            // 
            // tsMainToolStrip
            // 
            this.tsMainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLoadPNG,
            this.tsLoadMNG,
            this.toolStripSeparator1,
            this.tsSavePNG,
            this.tsSaveFrame,
            this.tsSaveXML,
            this.toolStripSeparator2,
            this.tsAdd,
            this.tsRemoveAt,
            this.tsRemoveAll,
            this.tsProcess,
            this.toolStripSeparator4,
            this.tsAlphaCrop,
            this.tsResize});
            this.tsMainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.tsMainToolStrip.Name = "tsMainToolStrip";
            this.tsMainToolStrip.Size = new System.Drawing.Size(792, 25);
            this.tsMainToolStrip.TabIndex = 2;
            this.tsMainToolStrip.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.grpAnimationControl);
            this.Controls.Add(this.grpFrameControl);
            this.Controls.Add(this.tsMainToolStrip);
            this.Controls.Add(this.picSheet);
            this.Controls.Add(this.mnMainMenuStrip);
            this.MainMenuStrip = this.mnMainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animation Toolkit";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.numForcedX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForcedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrid)).EndInit();
            this.mnMainMenuStrip.ResumeLayout(false);
            this.mnMainMenuStrip.PerformLayout();
            this.grpFrameControl.ResumeLayout(false);
            this.grpFrameControl.PerformLayout();
            this.grpAnimationControl.ResumeLayout(false);
            this.grpAnimationControl.PerformLayout();
            this.pnlPicContainer.ResumeLayout(false);
            this.pnlPicContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShadowAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSheet)).EndInit();
            this.tsMainToolStrip.ResumeLayout(false);
            this.tsMainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPictureList;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.PictureBox picAnimation;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numForcedX;
        private System.Windows.Forms.NumericUpDown numForcedY;
        private System.Windows.Forms.CheckBox chkForcedX;
        private System.Windows.Forms.CheckBox chkForcedY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBorder;
        private System.Windows.Forms.CheckBox chkBorder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numGrid;
        private System.Windows.Forms.CheckBox chkGrid;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnStepForward;
        private System.Windows.Forms.Button btnStepBackward;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.PictureBox picSheet;
        private System.ComponentModel.BackgroundWorker bcwImageProcess;
        private System.Windows.Forms.ProgressBar barImageProcess;
        private System.Windows.Forms.Label lblPercentage;
        private MenuStrip mnMainMenuStrip;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFrameControl;
        private ToolStripMenuItem mnuAnimationControl;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnLoadPNG;
        private ToolStripMenuItem mnSavePNG;
        private ToolStripMenuItem mnSaveXML;
        private ToolStripMenuItem mnExit;
        private ToolStripMenuItem mnAdd;
        private ToolStripMenuItem mnRemoveAt;
        private ToolStripMenuItem mnRemoveAll;
        private ToolStripMenuItem mnProcess;
        private ToolStripMenuItem mnPlay;
        private ToolStripMenuItem mnForward;
        private ToolStripMenuItem mnBackward;
        private ToolStripMenuItem mnAbout;
        private ToolStripSeparator toolStripSeparator3;
        private GroupBox grpFrameControl;
        private GroupBox grpAnimationControl;
        private ToolStripMenuItem mnuFrameEditor;
        private ToolStripMenuItem mnCenter;
        private ToolStripMenuItem mnUp;
        private ToolStripMenuItem mnDown;
        private ToolStripMenuItem mnLeft;
        private ToolStripMenuItem mnRight;
        private CheckBox chkSquareFrame;
        private ToolStripMenuItem mnAlphaCrop;
        private ToolStripMenuItem mnResize;
        private ToolStripMenuItem mnSaveFrame;
        private ToolStripMenuItem mnLoadMNG;
        private Panel pnlPicContainer;
        private PictureBox picShadowAnimation;
        private FolderBrowserDialog dlgSaveFrame;
        private ToolStripButton tsLoadPNG;
        private ToolStripButton tsLoadMNG;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsSavePNG;
        private ToolStripButton tsSaveFrame;
        private ToolStripButton tsSaveXML;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsAdd;
        private ToolStripButton tsRemoveAt;
        private ToolStripButton tsRemoveAll;
        private ToolStripButton tsProcess;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsAlphaCrop;
        private ToolStripButton tsResize;
        private ToolStrip tsMainToolStrip;
    }
}

