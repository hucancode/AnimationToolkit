using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using HuuAnimation;
using System.Xml;
using System.Text;
using SprinterMNG;

namespace AnimationToolkit
{
    public partial class frmMain : Form
    {
        Animation Animation;
        Color alphaColor;
        bool enableAlphaCrop;
        public frmMain()
        {
            InitializeComponent();
            MessageBox.Show("this message editted from local");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text += " " + Application.ProductVersion.ToString();
            Animation = new Animation();
            alphaColor = Color.FromArgb(0, 0, 0, 0);
            enableAlphaCrop = false;
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            doAdd();
        }
        private void doAdd()
        {
            dlgOpen.Filter = "All format|*.PNG;*.BMP;*.JPG|PNG|*.PNG|BMP|*.BMP|JPG|*.JPG";
            dlgOpen.Multiselect = true;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                int i = lstPictureList.Items.Count;
                foreach (string item in dlgOpen.FileNames)
                {
                    Bitmap bmp = new Bitmap(item);
                    Bitmap tmp = new Bitmap(bmp);
                    bmp.Dispose();
                    bmp = tmp;
                    Animation.AddBitmap(bmp);
                    lstPictureList.Items.Add("["+i.ToString()+"] "+bmp.Width.ToString() + " " + bmp.Height.ToString());
                    i++;
                }
            }
        }

        private void tsRemoveAt_Click(object sender, EventArgs e)
        {
            doRemoveAt();
        }

        private void doRemoveAt()
        {
            if (lstPictureList.SelectedIndex < 0)
                return;
            int i = lstPictureList.SelectedIndex;
            lstPictureList.Items.RemoveAt(i);
            Animation.RemoveBitmap(i);
        }

        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            Animation.Tick();
            picAnimation.Image = Animation.GetCurrentFrame();
            Point p = Animation.GetCurrentOffset();
            picAnimation.Left = p.X;
            picAnimation.Top = p.Y;
            if (lstPictureList.SelectedIndex < lstPictureList.Items.Count - 1)
            {
                lstPictureList.SelectedIndex++;
            }
            else
            {
                lstPictureList.SelectedIndex = 0;
            }
        }

        private void tsProcess_Click(object sender, EventArgs e)
        {
            doProcess();
        }

        private void doProcess()
        {
            if (Animation.FrameCount == 0) return;
            if (chkSquareFrame.Checked)
            {
                if (Animation.FrameSize.X != Animation.FrameSize.Y)
                {
                    if (Animation.FrameSize.X < Animation.FrameSize.Y)
                    {
                        Animation.FrameSize = new Point(Animation.FrameSize.Y, Animation.FrameSize.Y);
                    }
                    else
                    {
                        Animation.FrameSize = new Point(Animation.FrameSize.X, Animation.FrameSize.X);
                    }
                }
            }
            pnlPicContainer.Width = Animation.FrameSize.X;
            pnlPicContainer.Height = Animation.FrameSize.Y;
            pnlPicContainer.Left = (grpAnimationControl.Width - pnlPicContainer.Width) / 2;
            pnlPicContainer.Top = (grpAnimationControl.Height - pnlPicContainer.Height) / 2;
            tmrAnimation.Start();
            Point p = getGridSize();
            if (chkBorder.Checked)
            {
                if (chkGrid.Checked)
                {
                    picSheet.Image = Animation.GetAnimationSheet((int)numBorder.Value, (int)numGrid.Value, p);
                }
                else
                {
                    picSheet.Image = Animation.GetAnimationSheet((int)numBorder.Value, p);
                }
            }
            else
            {
                picSheet.Image = Animation.GetAnimationSheet(p);
            }
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            pnlPicContainer.Left = (grpAnimationControl.Width - pnlPicContainer.Width) / 2;
            pnlPicContainer.Top = (grpAnimationControl.Height - pnlPicContainer.Height) / 2;
        }

        private void picAnimation_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void picAnimation_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void tsRemoveAll_Click(object sender, EventArgs e)
        {
            doRemoveAll();
        }

        private void doRemoveAll()
        {
            lstPictureList.Items.Clear();
            Animation.ClearAll();
            tmrAnimation.Stop();
        }

        private void picSheet_Click(object sender, EventArgs e)
        {
            if (picSheet.SizeMode == PictureBoxSizeMode.Zoom)
            {
                picSheet.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (picSheet.SizeMode == PictureBoxSizeMode.CenterImage)
            {
                picSheet.SizeMode = PictureBoxSizeMode.Normal;
            }
            else if (picSheet.SizeMode == PictureBoxSizeMode.Normal)
            {
                picSheet.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnStepBackward_Click(object sender, EventArgs e)
        {
            doStepBackward();
        }

        private void doStepBackward()
        {
            if (Animation.FrameCount == 0) return;
            tmrAnimation.Stop();
            btnPlayPause.Text = "w";
            Animation.ReverseTick();

            picAnimation.Image = Animation.GetCurrentFrame();
            Point p = Animation.GetCurrentOffset();
            picAnimation.Left = p.X;
            picAnimation.Top = p.Y;
            if (lstPictureList.SelectedIndex > 0)
            {
                lstPictureList.SelectedIndex--;
            }
            else
            {
                lstPictureList.SelectedIndex = lstPictureList.Items.Count - 1;
            }
        }

        private void btnStepForward_Click(object sender, EventArgs e)
        {
            doStepForward();
        }

        private void doStepForward()
        {
            if (Animation.FrameCount == 0) return;
            tmrAnimation.Stop();
            btnPlayPause.Text = "w";
            Animation.Tick();

            picAnimation.Image = Animation.GetCurrentFrame();
            Point p = Animation.GetCurrentOffset();
            picAnimation.Left = p.X;
            picAnimation.Top = p.Y;
            if (lstPictureList.SelectedIndex < lstPictureList.Items.Count - 1)
            {
                lstPictureList.SelectedIndex++;
            }
            else
            {
                lstPictureList.SelectedIndex = 0;
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            doPlayPause();
        }

        private void doPlayPause()
        {
            if (Animation.FrameCount == 0) return;
            if (tmrAnimation.Enabled)
            {
                tmrAnimation.Stop();
                btnPlayPause.Text = "w";
            }
            else
            {
                tmrAnimation.Start();
                btnPlayPause.Text = "u";
            }
        }

        private void tsLoadPNG_Click(object sender, EventArgs e)
        {
            doLoadPNG();
        }

        private void doLoadPNG()
        {
            dlgOpen.Filter = "PNG|*.PNG";
            dlgOpen.Multiselect = false;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                frmLoad FormLoad = new frmLoad();
                FormLoad.Show();
                FormLoad.loadBitmap(dlgOpen.FileName);
                FormLoad.parrent = this;
            }
        }

        private void tsLoadMNG_Click(object sender, EventArgs e)
        {
            doLoadMNG();
        }

        private void doLoadMNG()
        {
            dlgOpen.Filter = "MNG|*.MNG";
            dlgSave.DefaultExt = ".MNG";
            dlgOpen.Multiselect = false;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                MNG mng = new MNG();
                if(!mng.Load(dlgOpen.FileName))
                    MessageBox.Show("Can not load \n"+dlgOpen.FileName,Application.ProductName);
                int c = lstPictureList.Items.Count;
                for (int i = 0; i < mng.NumEmbeddedPNG; i++)
                {
                    Bitmap bmp = mng.ToBitmap(i);
                    Point p = mng.GetOffset(i);
                    Animation.AddBitmap(bmp, p);
                    lstPictureList.Items.Add("[" + c.ToString() + "] " + bmp.Width.ToString() + " " + bmp.Height.ToString());
                    c++;
                }
            }
        }

        private void tsSavePNG_Click(object sender, EventArgs e)
        {
            doSavePNG();
        }

        private void doSavePNG()
        {
            if (Animation.FrameCount == 0) return;
            Point p = getGridSize();
            if (chkBorder.Checked)
            {
                if (chkGrid.Checked)
                {
                    picSheet.Image = Animation.GetAnimationSheet((int)numBorder.Value, (int)numGrid.Value, p);
                }
                else
                {
                    picSheet.Image = Animation.GetAnimationSheet((int)numBorder.Value, p);
                }
            }
            else
            {
                picSheet.Image = Animation.GetAnimationSheet(p);
            }
            dlgSave.Filter = "PNG|*.PNG";
            dlgSave.DefaultExt = ".PNG";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                picSheet.Image.Save(dlgSave.FileName, ImageFormat.Png);
            }
        }

        private Point getGridSize()
        {
            Point gridSize = new Point();
            if (chkForcedX.Checked)
            {
                if (chkForcedY.Checked)
                {
                    gridSize.X = (int)numForcedX.Value;
                    gridSize.Y = (int)numForcedY.Value;
                }
                else
                {
                    gridSize.X = (int)numForcedX.Value;
                    gridSize.Y = (int)Math.Ceiling((double)Animation.FrameCount / gridSize.X);
                }
            }
            else
            {
                if (chkForcedY.Checked)
                {
                    gridSize.Y = (int)numForcedY.Value;
                    gridSize.X = (int)Math.Ceiling((double)Animation.FrameCount / gridSize.Y);
                }
                else
                {
                    gridSize.X = (int)Math.Sqrt(Animation.FrameCount);
                    gridSize.Y = (int)Math.Ceiling((double)Animation.FrameCount / gridSize.X);
                }
            }
            return gridSize;
        }

        private void tsSaveFrame_Click(object sender, EventArgs e)
        {
            doSaveFrame();
        }

        private void doSaveFrame()
        {
            if (Animation.FrameCount == 0) return;
            if (dlgSaveFrame.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < Animation.FrameCount; i++)
                {
                    Bitmap bmp = Animation.GetFrameWithOffset(i);
                    bmp.Save(dlgSaveFrame.SelectedPath + "/F" + i.ToString() + ".png", ImageFormat.Png);
                }
            }
        }

        private void tsSaveXML_Click(object sender, EventArgs e)
        {
            doSaveXML();
        }

        private void doSaveXML()
        {
            if (Animation.FrameCount == 0) return;
            dlgSave.Filter = "XML|*.XML";
            dlgSave.DefaultExt = ".XML";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                FileInfo f = new FileInfo(dlgSave.FileName);
                string name = f.Name.Substring(0, f.Name.Length - 4);
                for (int i = 0; i < Animation.FrameCount; i++)
                {
                    Bitmap bmp = Animation.GetFrame(i);
                    Directory.CreateDirectory(f.Directory + "/" + name + "/");
                    bmp.Save(f.Directory + "/" + name + "/" + name + i.ToString() + ".png", ImageFormat.Png);
                }
                XmlTextWriter writer = new XmlTextWriter(f.FullName, Encoding.UTF8);
                XmlDocument doc = Animation.GetXMLDocument(name, getGridSize());
                doc.Save(writer);
            }
        }

        private void tsAlphaCrop_Click(object sender, EventArgs e)
        {
            doAlphaCrop();
        }

        private void doAlphaCrop()
        {
            if (Animation.FrameCount == 0) return;
            frmAlphaCrop alpha = new frmAlphaCrop();
            alpha.Init(this, Animation, alphaColor, enableAlphaCrop);
            alpha.Show();
        }

        public void AlphaCropConfig(Color c, bool enable)
        {
            alphaColor = c;
            enableAlphaCrop = enable;
        }

        private void tsResize_Click(object sender, EventArgs e)
        {
            doResize();
        }

        private void doResize()
        {
            if (Animation.FrameCount == 0) return;
            frmResize resize = new frmResize();
            if (resize.Init(this, Animation.FrameSize))
                resize.Show();
        }

        public void ResizeFrame(double ratio)
        {
            Animation.Resize(ratio);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            doLeftPixel();
        }

        private void doLeftPixel()
        {
            if (Animation.FrameCount == 0) return;
            tmrAnimation.Stop();
            btnPlayPause.Text = "w";
            Animation.TransformOffset(Animation.Frame, new Point(-1, 0));
            picAnimation.Left--;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            doUpPixel();
        }

        private void doUpPixel()
        {
            if (Animation.FrameCount == 0) return;
            tmrAnimation.Stop();
            btnPlayPause.Text = "w";
            Animation.TransformOffset(Animation.Frame, new Point(0, -1));
            picAnimation.Top--;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            doRightPixel();
        }

        private void doRightPixel()
        {
            if (Animation.FrameCount == 0) return;
            tmrAnimation.Stop();
            btnPlayPause.Text = "w";
            Animation.TransformOffset(Animation.Frame, new Point(1, 0));
            picAnimation.Left++;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            doDownPixel();
        }

        private void doDownPixel()
        {
            if (Animation.FrameCount == 0) return;
            tmrAnimation.Stop();
            btnPlayPause.Text = "w";
            Animation.TransformOffset(Animation.Frame, new Point(0, 1));
            picAnimation.Top++;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            doCenterPixel();
        }

        private void doCenterPixel()
        {
            if (Animation.FrameCount == 0) return;
            tmrAnimation.Stop();
            btnPlayPause.Text = "w";
            Animation.CenterFrame();
            picAnimation.Top = Animation.GetCurrentOffset().Y;
            picAnimation.Left = Animation.GetCurrentOffset().X;
        }

        public void LoadPNG(Bitmap bmp, Point gridSize)
        {
            int w = bmp.Width / gridSize.X, h = bmp.Height / gridSize.Y;
            for (int j = 0; j < gridSize.Y; j++)
            {
                int c = lstPictureList.Items.Count;
                for (int i = 0; i < gridSize.X; i++)
                {
                    Bitmap b = new Bitmap(w, h);
                    Graphics g = Graphics.FromImage(b);
                    g.DrawImage(bmp, 0, 0,
                        new Rectangle(i * w, j * h, w, h), GraphicsUnit.Pixel);
                    Animation.AddBitmap(b);
                    lstPictureList.Items.Add("[" + c.ToString() + "] " + b.Width.ToString() + " " + b.Height.ToString());
                    c++;
                }
            }
        }

        private void mnLoadAnimation_Click(object sender, EventArgs e)
        {
            doLoadPNG();
        }

        private void mnLoadMNG_Click(object sender, EventArgs e)
        {
            doLoadMNG();
        }

        private void mnSavePNG_Click(object sender, EventArgs e)
        {
            doSavePNG();
        }

        private void mnSaveFrame_Click(object sender, EventArgs e)
        {
            doSaveFrame();
        }

        private void mnSaveXML_Click(object sender, EventArgs e)
        {
            doSaveXML();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnProcess_Click(object sender, EventArgs e)
        {
            doProcess();
        }

        private void mnAdd_Click(object sender, EventArgs e)
        {
            doAdd();
        }

        private void mnRemoveAt_Click(object sender, EventArgs e)
        {
            doRemoveAt();
        }

        private void mnRemoveAll_Click(object sender, EventArgs e)
        {
            doRemoveAll();
        }

        private void mnAlphaCrop_Click(object sender, EventArgs e)
        {
            doAlphaCrop();
        }

        private void mnResize_Click(object sender, EventArgs e)
        {
            doResize();
        }

        private void mnPlay_Click(object sender, EventArgs e)
        {
            doPlayPause();
        }

        private void mnForward_Click(object sender, EventArgs e)
        {
            doStepForward();
        }

        private void mnBackward_Click(object sender, EventArgs e)
        {
            doStepBackward();
        }

        private void mnCenter_Click(object sender, EventArgs e)
        {
            doCenterPixel();
        }

        private void mnUp_Click(object sender, EventArgs e)
        {
            doUpPixel();
        }

        private void mnLeft_Click(object sender, EventArgs e)
        {
            doLeftPixel();
        }

        private void mnDown_Click(object sender, EventArgs e)
        {
            doDownPixel();
        }

        private void mnRight_Click(object sender, EventArgs e)
        {
            doRightPixel();
        }

        private void mnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Text + "\nCoded by ngọa hổ(aka hu)\nngoaho91@gmail.com\n\nMNG library by SprinterDave", "?");
        }

        
    }
}
