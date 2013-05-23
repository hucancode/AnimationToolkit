using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimationToolkit
{
    public partial class frmLoad : Form
    {
        private Bitmap Animation;
        private Point gridSize;
        public frmMain parrent;
        public frmLoad()
        {
            InitializeComponent();
            Animation = new Bitmap(1, 1);
            gridSize = new Point();
        }

        public void loadBitmap(string fileName)
        {
            Animation.Dispose();
            Animation = new Bitmap(fileName);
            gridSize = new Point((int)(Animation.Width / 100), (int)(Animation.Height / 100));
            numFrameX.Value = gridSize.X;
            numFrameY.Value = gridSize.Y;
            int w = Animation.Width / gridSize.X,
                h = Animation.Height / gridSize.X;
            picPreview.Width = w;
            picPreview.Height = h;
            picPreview.Top = (pnlFrame.Height - h) / 2;
            picPreview.Left = (pnlFrame.Width - w) / 2;
            picPreview.Image = Animation;
        }
        private void refreshPicture()
        {
            int w = Animation.Width / gridSize.X,
                h = Animation.Height / gridSize.Y;
            picPreview.Width = w;
            picPreview.Height = h;
            picPreview.Top = (pnlFrame.Height - h) / 2;
            picPreview.Left = (pnlFrame.Width - w) /2;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            parrent.LoadPNG(Animation, gridSize);
            this.Close();
        }

        private void numFrameX_ValueChanged(object sender, EventArgs e)
        {
            if (numFrameX.Value <= 0) return;
            gridSize = new Point((int)numFrameX.Value, gridSize.Y);
            refreshPicture();
        }

        private void numFrameY_ValueChanged(object sender, EventArgs e)
        {
            if (numFrameY.Value <= 0) return;
            gridSize = new Point(gridSize.X, (int)numFrameY.Value);
            refreshPicture();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLoad_ResizeEnd(object sender, EventArgs e)
        {
            refreshPicture();
        }
    }
}
