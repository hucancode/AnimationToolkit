using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HuuAnimation;

namespace AnimationToolkit
{
    public partial class frmAlphaCrop : Form
    {
        Animation animation;
        frmMain parrent;
        public frmAlphaCrop()
        {
            InitializeComponent();
        }
        public void Init(frmMain pa, Animation ani,Color alpha,bool enable)
        {
            animation = ani;
            parrent = pa;
            picFrame.Image = animation.GetCurrentFrame();
            numA.Value = alpha.A;
            numR.Value = alpha.R;
            numG.Value = alpha.G;
            numB.Value = alpha.B;
            chkEnableAlphaCrop.Checked = enable;
        }

        private void btnStepBackward_Click(object sender, EventArgs e)
        {
            animation.ReverseTick();
            picFrame.Image = animation.GetCurrentFrame();
        }

        private void btnStepForward_Click(object sender, EventArgs e)
        {
            animation.Tick();
            picFrame.Image = animation.GetCurrentFrame();
        }

        private void picFrame_Click(object sender, EventArgs e)
        {
            if (animation.FrameCount == 0) return;
            Bitmap bmp = (Bitmap)picFrame.Image;
            int offsetX = (picFrame.Width - bmp.Width) / 2;
            int offsetY = (picFrame.Height - bmp.Height) / 2;

            int clickPosX = this.PointToClient(MousePosition).X - picFrame.Left;
            int clickPosY = this.PointToClient(MousePosition).Y - picFrame.Top;
            
            int x = clickPosX - offsetX;
            int y = clickPosY - offsetY;

            Color c;
            if (x < bmp.Width && y < bmp.Height && x > 0 && y > 0)
                c = bmp.GetPixel(x, y);
            else
                c = Color.FromArgb(0, 0, 0, 0);
            numA.Value = c.A;
            numR.Value = c.R;
            numG.Value = c.G;
            numB.Value = c.B;
        }

        private void numA_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void numR_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void numG_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void numB_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }
        private void UpdateColor()
        {
            picColor.BackColor = Color.FromArgb((int)numA.Value, (int)numR.Value, (int)numG.Value, (int)numB.Value);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            parrent.AlphaCropConfig(picColor.BackColor, chkEnableAlphaCrop.Checked);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
