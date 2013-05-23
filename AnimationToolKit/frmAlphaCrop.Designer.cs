namespace AnimationToolkit
{
    partial class frmAlphaCrop
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStepForward = new System.Windows.Forms.Button();
            this.btnStepBackward = new System.Windows.Forms.Button();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.picFrame = new System.Windows.Forms.PictureBox();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.chkEnableAlphaCrop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(216, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(297, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            // 
            // btnStepForward
            // 
            this.btnStepForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStepForward.Location = new System.Drawing.Point(93, 227);
            this.btnStepForward.Name = "btnStepForward";
            this.btnStepForward.Size = new System.Drawing.Size(75, 23);
            this.btnStepForward.TabIndex = 7;
            this.btnStepForward.Text = "Next";
            this.btnStepForward.UseVisualStyleBackColor = true;
            this.btnStepForward.Click += new System.EventHandler(this.btnStepForward_Click);
            // 
            // btnStepBackward
            // 
            this.btnStepBackward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStepBackward.Location = new System.Drawing.Point(12, 227);
            this.btnStepBackward.Name = "btnStepBackward";
            this.btnStepBackward.Size = new System.Drawing.Size(75, 23);
            this.btnStepBackward.TabIndex = 6;
            this.btnStepBackward.Text = "Prev";
            this.btnStepBackward.UseVisualStyleBackColor = true;
            this.btnStepBackward.Click += new System.EventHandler(this.btnStepBackward_Click);
            // 
            // picColor
            // 
            this.picColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picColor.Location = new System.Drawing.Point(300, 30);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(72, 28);
            this.picColor.TabIndex = 1;
            this.picColor.TabStop = false;
            // 
            // picFrame
            // 
            this.picFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFrame.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picFrame.Location = new System.Drawing.Point(11, 61);
            this.picFrame.Name = "picFrame";
            this.picFrame.Size = new System.Drawing.Size(361, 160);
            this.picFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFrame.TabIndex = 0;
            this.picFrame.TabStop = false;
            this.picFrame.Click += new System.EventHandler(this.picFrame_Click);
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(37, 35);
            this.numA.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(39, 20);
            this.numA.TabIndex = 0;
            this.numA.ValueChanged += new System.EventHandler(this.numA_ValueChanged);
            // 
            // numR
            // 
            this.numR.Location = new System.Drawing.Point(103, 35);
            this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(39, 20);
            this.numR.TabIndex = 1;
            this.numR.ValueChanged += new System.EventHandler(this.numR_ValueChanged);
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(173, 35);
            this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(39, 20);
            this.numG.TabIndex = 2;
            this.numG.ValueChanged += new System.EventHandler(this.numG_ValueChanged);
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(240, 35);
            this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(39, 20);
            this.numB.TabIndex = 3;
            this.numB.ValueChanged += new System.EventHandler(this.numB_ValueChanged);
            // 
            // chkEnableAlphaCrop
            // 
            this.chkEnableAlphaCrop.AutoSize = true;
            this.chkEnableAlphaCrop.Location = new System.Drawing.Point(12, 12);
            this.chkEnableAlphaCrop.Name = "chkEnableAlphaCrop";
            this.chkEnableAlphaCrop.Size = new System.Drawing.Size(112, 17);
            this.chkEnableAlphaCrop.TabIndex = 8;
            this.chkEnableAlphaCrop.Text = "Enable alpha crop";
            this.chkEnableAlphaCrop.UseVisualStyleBackColor = true;
            // 
            // frmAlphaCrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.chkEnableAlphaCrop);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numG);
            this.Controls.Add(this.numR);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.btnStepBackward);
            this.Controls.Add(this.btnStepForward);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.picFrame);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "frmAlphaCrop";
            this.Text = "Alpha Config";
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFrame;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStepForward;
        private System.Windows.Forms.Button btnStepBackward;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.CheckBox chkEnableAlphaCrop;
    }
}