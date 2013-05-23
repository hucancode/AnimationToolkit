using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnimationToolkit
{
    public partial class frmResize : Form
    {
        public frmResize()
        {
            InitializeComponent();
        }

        frmMain parrent;
        int width, height;

        public bool Init(frmMain p, Point size)
        {
            parrent = p;
            width = size.X;
            height = size.Y;
            cboPixelPercent1.SelectedIndex = 0;
            cboPixelPercent2.SelectedIndex = 0;
            numWidth.Maximum = width*5;
            numHeight.Maximum = height*5;
            numWidth.Value = width;
            numHeight.Value = height;
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double ratio;
            if (cboPixelPercent1.SelectedIndex == 1)
            {
                ratio = (double)numWidth.Value / 100.0;
            }
            else
            {
                ratio = (double)numWidth.Value / width;
            }
            this.Close();
            parrent.ResizeFrame(ratio);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPixelPercent1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPixelPercent2.SelectedIndex = cboPixelPercent1.SelectedIndex;
            if (cboPixelPercent1.SelectedIndex == 1)
            {
                numWidth.Maximum = 500;
                numHeight.Maximum = 500;
                numWidth.Value = 100;
                numWidth.Value = 100;
            }
            else
            {
                numWidth.Maximum = width;
                numHeight.Maximum = height;
                numWidth.Value = width;
                numHeight.Value = height;
            }
        }

        private void cboPixelPercent2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPixelPercent1.SelectedIndex = cboPixelPercent2.SelectedIndex;
            if (cboPixelPercent2.SelectedIndex == 1)
            {
                numWidth.Maximum = 500;
                numHeight.Maximum = 500;
                numWidth.Value = 100;
                numWidth.Value = 100;
            }
            else
            {
                numWidth.Maximum = width*5;
                numHeight.Maximum = height*5;
                numWidth.Value = width;
                numHeight.Value = height;
            }
        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            if (cboPixelPercent1.SelectedIndex == 1)
            {
                numHeight.Value = numWidth.Value;
            }
            else
            {
                numHeight.Value = (decimal)((double)numWidth.Value / (double)width) * height;
            }
        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {
            if (cboPixelPercent1.SelectedIndex == 1)
            {
                numWidth.Value = numHeight.Value;
            }
            else
            {
                numWidth.Value = (decimal)((double)numHeight.Value / (double)height) * width;
            }
        }
    }
}
