namespace AnimationToolkit
{
    partial class frmLoad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.numFrameX = new System.Windows.Forms.NumericUpDown();
            this.numFrameY = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(216, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frame X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frame Y";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(3, 3);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(200, 123);
            this.picPreview.TabIndex = 3;
            this.picPreview.TabStop = false;
            // 
            // pnlFrame
            // 
            this.pnlFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFrame.Controls.Add(this.picPreview);
            this.pnlFrame.Location = new System.Drawing.Point(12, 41);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(360, 180);
            this.pnlFrame.TabIndex = 4;
            // 
            // numFrameX
            // 
            this.numFrameX.Location = new System.Drawing.Point(64, 12);
            this.numFrameX.Name = "numFrameX";
            this.numFrameX.Size = new System.Drawing.Size(77, 20);
            this.numFrameX.TabIndex = 0;
            this.numFrameX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFrameX.ValueChanged += new System.EventHandler(this.numFrameX_ValueChanged);
            // 
            // numFrameY
            // 
            this.numFrameY.Location = new System.Drawing.Point(195, 12);
            this.numFrameY.Name = "numFrameY";
            this.numFrameY.Size = new System.Drawing.Size(77, 20);
            this.numFrameY.TabIndex = 1;
            this.numFrameY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFrameY.ValueChanged += new System.EventHandler(this.numFrameY_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(297, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.numFrameY);
            this.Controls.Add(this.numFrameX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlFrame);
            this.Name = "frmLoad";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load animation sheet";
            this.ResizeEnd += new System.EventHandler(this.frmLoad_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFrameX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrameY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Panel pnlFrame;
        private System.Windows.Forms.NumericUpDown numFrameX;
        private System.Windows.Forms.NumericUpDown numFrameY;
        private System.Windows.Forms.Button btnCancel;
    }
}