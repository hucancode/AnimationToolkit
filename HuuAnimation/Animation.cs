using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using SprinterMNG;
using System.Xml;
using System.IO;

namespace HuuAnimation
{
    public class Animation
    {
        private List<Bitmap> listBitmap;

        private List<Point> listOffset;

        private Point frameSize;

        public Point FrameSize
        {
            get { return frameSize; }
            set { frameSize = value; }
        }

        public int FrameCount
        {
            get { return listBitmap.Count; }
        }

        private int frame;

        public int Frame
        {
            get { return frame; }
            set { frame = value; }
        }

        public Animation()
        {
            listBitmap = new List<Bitmap>();
            listOffset = new List<Point>();
        }

        public Animation(List<Bitmap> listBMP)
        {
            frame = 0;
            listBitmap = new List<Bitmap>();
            listOffset = new List<Point>();
            Point frameSize = new Point(listBMP[0].Width, listBMP[0].Height);
            foreach (Bitmap item in listBMP)
            {
                AddBitmap(item);
            }
            
        }

        public Animation(List<Bitmap> listBMP, List<Point> listOff)
        {
            frame = 0;
            listBitmap = new List<Bitmap>();
            listOffset = new List<Point>();
            Point frameSize = new Point(listBMP[0].Width, listBMP[0].Height);
            for (int i = 0; i < listBMP.Count; i++)
            {
                AddBitmap(listBMP[i], listOff[i]);
            }
        }

        public Animation(MNG mng)
        {
            frame = 0;
            listBitmap = new List<Bitmap>();
            listOffset = new List<Point>();
            Point frameSize = new Point(mng.Width, mng.Height);
            for (int i = 0; i < mng.NumEmbeddedPNG; i++)
            {
                Bitmap bmp = mng.ToBitmap(i);
                Point p = mng.GetOffset(i);
                AddBitmap(bmp, p);
            }
        }

        public Animation(string xml)
        {
            frame = 0;
            listBitmap = new List<Bitmap>();
            listOffset = new List<Point>();
            Point frameSize = new Point(0, 0);
            FileInfo f = new FileInfo(xml); 
            XmlTextReader reader = new XmlTextReader(xml);
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "frames")
                    {
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                if (reader.Name == "frame")
                                {
                                    string path = reader.GetAttribute("file");
                                    int ox = int.Parse(reader.GetAttribute("offset_x"));
                                    int oy = int.Parse(reader.GetAttribute("offset_y"));
                                    Bitmap bmp = new Bitmap(f.DirectoryName + "\\" + path);
                                    Point p = new Point(ox, oy);
                                    AddBitmap(bmp, p);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else if (reader.Name == "sequences")
                    {
                        // do something with sequence
                    }

                }
            }
        }

        public Animation(Bitmap sheet, Point gridSize)
        {
            frame = 0;
            listBitmap = new List<Bitmap>();
            listOffset = new List<Point>();
            int w = sheet.Width / gridSize.X, h = sheet.Height / gridSize.Y;
            Point frameSize = new Point(w, h);

            for (int j = 0; j < gridSize.Y; j++)
            {
                for (int i = 0; i < gridSize.X; i++)
                {
                    Bitmap b = new Bitmap(w, h);
                    Graphics g = Graphics.FromImage(b);
                    g.DrawImage(sheet, 0, 0,
                        new Rectangle(i * w, j * h, w, h), GraphicsUnit.Pixel);
                    AddBitmap(b);
                }
            }
        }

        public void AddBitmap(Bitmap BMP)
        {
            if (frameSize.X < BMP.Width) frameSize = new Point(BMP.Width, frameSize.Y);
            if (frameSize.Y < BMP.Height) frameSize = new Point(frameSize.X, BMP.Height);

            Point Off = new Point((frameSize.X - BMP.Width) / 2, (frameSize.Y - BMP.Height) / 2);
            AddBitmap(BMP, Off);
        }

        public void AddBitmap(Bitmap BMP, Point Off)
        {
            listBitmap.Add(BMP);
            listOffset.Add(Off);
            if (BMP.Width + Off.X > frameSize.X) frameSize = new Point(BMP.Width + Off.X, frameSize.Y);
            if (BMP.Height + Off.Y > frameSize.Y) frameSize = new Point(frameSize.X, BMP.Height + Off.Y);
        }

        private Point getRealSize(int i)
        {
            Point size = new Point(listBitmap[i].Width, listBitmap[i].Height);
            Point offset = listOffset[i];
            size.Offset(offset);
            return size;
        }
        public void RemoveBitmap(int index)
        {
            listBitmap.RemoveAt(index);
            Point p = getRealSize(index);
            listOffset.RemoveAt(index);
            if (p.X == frameSize.X)
            {
                int maxX = getRealSize(0).X;
                bool sizeChanged = true;
                for (int i = 0; i < listOffset.Count; i++)
                {
                    Point item = getRealSize(i);
                    if (item.X == p.X)
                    {
                        sizeChanged = false;
                        break;
                    }
                    if (item.X > maxX) maxX = item.X;
                }
                if (sizeChanged)
                {
                    frameSize = new Point(maxX, frameSize.Y);
                }
            }
            if (p.Y == frameSize.Y)
            {
                int maxY = getRealSize(0).Y;
                bool sizeChanged = true;
                for (int i = 0; i < listOffset.Count; i++)
                {
                    Point item = getRealSize(i);
                    if (item.Y == p.Y)
                    {
                        sizeChanged = false;
                        break;
                    }
                    if (item.Y > maxY) maxY = item.Y;
                }
                if (sizeChanged)
                {
                    frameSize = new Point(frameSize.X, maxY);
                }
            }
            if (frame == listBitmap.Count)
                frame = 0;
        }

        public void ClearAll()
        {
            listBitmap.Clear();
            listOffset.Clear();
            frameSize = new Point(0, 0);
            frame = 0;
        }

        public void TransformOffset(int i, Point vector)
        {
            listOffset[i].Offset(vector);
            checkFrameSizeIncrease(i);
            checkFrameSizeDecrease();
        }
        private void checkFrameSizeIncrease(int i)
        {
            if (listBitmap[i].Width + listOffset[i].X > frameSize.X)
                frameSize = new Point(listBitmap[i].Width + listOffset[i].X, frameSize.Y);
            if (listBitmap[i].Height + listOffset[i].Y > frameSize.Y)
                frameSize = new Point(frameSize.X, listBitmap[i].Height + listOffset[i].Y);
        }
        private void checkFrameSizeDecrease()
        {
            int maxX = getRealSize(0).X;
            bool sizeChanged = true;
            for (int i = 0; i < listOffset.Count; i++)
            {
                Point item = getRealSize(i);
                if (item.X == frameSize.X)
                {
                    sizeChanged = false;
                    break;
                }
                if (item.X > maxX) maxX = item.X;
            }
            if (sizeChanged)
            {
                frameSize = new Point(maxX, frameSize.Y);
            }
            int maxY = getRealSize(0).Y;
            sizeChanged = true;
            for (int i = 0; i < listOffset.Count; i++)
            {
                Point item = getRealSize(i);
                if (item.Y == frameSize.Y)
                {
                    sizeChanged = false;
                    break;
                }
                if (item.Y > maxY) maxY = item.Y;
            }
            if (sizeChanged)
            {
                frameSize = new Point(frameSize.X, maxY);
            }
        }

        public void TransformOffset(Point vector)
        {
            TransformOffset(frame, vector);
        }

        public void CenterFrame(int i)
        {
            Point Off = new Point((frameSize.X - listBitmap[i].Width) / 2, (frameSize.Y - listBitmap[i].Height) / 2);
            checkFrameSizeIncrease(i);
            checkFrameSizeDecrease();
        }
        public void CenterFrame()
        {
            CenterFrame(frame);
        }

        public void Tick()
        {
            frame++;
            if (frame >= listBitmap.Count)
                frame = 0;
        }

        public void ReverseTick()
        {
            frame--;
            if (frame <= 0)
                frame = listBitmap.Count;
        }

        public Bitmap GetFrame(int i)
        {
            if (listBitmap.Count == 0) return new Bitmap(1, 1);
            return listBitmap[i];
        }

        public Bitmap GetCurrentFrame()
        {
            return GetFrame(frame);
        }

        public Point GetOffset(int i)
        {
            if (listOffset.Count == 0) return new Point(0, 0);
            return listOffset[i];
        }

        public Point GetCurrentOffset()
        {
            return GetOffset(frame);
        }

        public Bitmap GetCurrentFrameWithOffset()
        {
            return GetFrameWithOffset(frame);
        }
        public Bitmap GetFrameWithOffset(int i)
        {
            Bitmap bmp = new Bitmap(frameSize.X, frameSize.Y);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(listBitmap[i], listOffset[i]);
            return bmp;
        }
        public Bitmap GetAnimationSheet()
        {
            Point gridSize = new Point();
            gridSize.X = (int)Math.Sqrt(listBitmap.Count);
            gridSize.Y = (int)Math.Ceiling((double)listBitmap.Count / gridSize.X);
            if (frameSize.X == 0 || gridSize.X == 0 || frameSize.Y == 0 || gridSize.Y == 0)
                return new Bitmap(1, 1);
            Bitmap sheet = new Bitmap(frameSize.X * gridSize.X, frameSize.Y * gridSize.Y);
            Graphics g = Graphics.FromImage(sheet);
            // draw image
            for (int j = 0; j < gridSize.Y; j++)
            {
                for (int i = 0; i < gridSize.X; i++)
                {
                    // draw at row j, col i
                    int index = gridSize.X * j + i;
                    if (index >= listBitmap.Count) break;
                    Point p = new Point();
                    p.X = i * frameSize.X;
                    p.Y = j * frameSize.Y;
                    p.Offset(listOffset[index]);
                    g.DrawImage(listBitmap[index], p);
                }
            }
            return sheet;
        }

        public Bitmap GetAnimationSheet(Point gridSize)
        {
            return GetAnimationSheet(0, 0, gridSize);
        }

        public Bitmap GetAnimationSheet(int border, int grid)
        {
            Point gridSize = new Point();
            gridSize.X = (int)Math.Sqrt(listBitmap.Count);
            gridSize.Y = (int)Math.Ceiling((double)listBitmap.Count / gridSize.X);
            return GetAnimationSheet(border,grid,gridSize);
        }

        public Bitmap GetAnimationSheet(int border, int grid, Point gridSize)
        {
            if (frameSize.X == 0 || gridSize.X == 0 || frameSize.Y == 0 || gridSize.Y == 0)
                return new Bitmap(1,1);
            Bitmap sheet = new Bitmap((frameSize.X + border) * gridSize.X,
                (frameSize.Y + border) * gridSize.Y);
            Graphics g = Graphics.FromImage(sheet);
            // draw grid line
            if (grid > 0)
            {
                Pen p = new Pen(Color.FromArgb(255, 0, 0, 0), grid);
                for (int i = 0; i < gridSize.X; i++)
                {
                    int x = i * (frameSize.X + border);
                    g.DrawLine(p, new Point(x, 0), new Point(x, sheet.Height));
                }
                for (int i = 0; i < gridSize.Y; i++)
                {
                    int y = i * (frameSize.Y + border);
                    g.DrawLine(p, new Point(0, y), new Point(sheet.Width, y));
                }
            }
            // draw image
            for (int j = 0; j < gridSize.Y; j++)
            {
                for (int i = 0; i < gridSize.X; i++)
                {
                    // draw at row j, col i
                    int index = gridSize.X * j + i;
                    if (index >= listBitmap.Count) break;
                    Point p = new Point();
                    p.X = i * (frameSize.X + border);
                    p.Y = j * (frameSize.Y + border);
                    p.Offset(listOffset[index]);
                    g.DrawImage(listBitmap[index], p);
                }
            }
            return sheet;
        }
        public Bitmap GetAnimationSheet(int border, Point gridSize)
        {
            if (frameSize.X == 0 || gridSize.X == 0 || frameSize.Y == 0 || gridSize.Y == 0)
                return new Bitmap(1, 1);
            Bitmap sheet = new Bitmap((frameSize.X + border) * gridSize.X,
                (frameSize.Y + border) * gridSize.Y);
            Graphics g = Graphics.FromImage(sheet);
            // draw image
            for (int j = 0; j < gridSize.Y; j++)
            {
                for (int i = 0; i < gridSize.X; i++)
                {
                    // draw at row j, col i
                    int index = gridSize.X * j + i;
                    if (index >= listBitmap.Count) break;
                    Point p = new Point();
                    p.X = i * (frameSize.X + border);
                    p.Y = j * (frameSize.Y + border);
                    p.Offset(listOffset[index]);
                    g.DrawImage(listBitmap[index], p);
                }
            }
            return sheet;
        }

        public XmlDocument GetXMLDocument(string defaultFileName)
        {
            Point gridSize = new Point();
            gridSize.X = (int)Math.Sqrt(listBitmap.Count);
            gridSize.Y = (int)Math.Ceiling((double)listBitmap.Count / gridSize.X);
            return GetXMLDocument(defaultFileName, gridSize);
        }
        public XmlDocument GetXMLDocument(string defaultFileName, Point gridSize)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement rootTAG = doc.CreateElement("animation");
            XmlElement framesTAG = doc.CreateElement("frames");
            XmlElement sequencesTAG = doc.CreateElement("sequences");
            for (int i = 0; i < listBitmap.Count; i++)
            {
                string name = "frame_" + i.ToString();
                string file = defaultFileName + "\\" + defaultFileName + i.ToString() + ".png";
                string offset_x = listOffset[i].X.ToString();
                string offset_y = listOffset[i].Y.ToString();
                XmlElement frameTAG = doc.CreateElement("frame");
                frameTAG.SetAttribute("name", name);
                frameTAG.SetAttribute("file", file);
                frameTAG.SetAttribute("offset_x", offset_x);
                frameTAG.SetAttribute("offset_y", offset_y);
                framesTAG.AppendChild(frameTAG);
            }
            for (int j = 0; j < gridSize.Y; j++)
            {
                XmlElement sequenceTAG = doc.CreateElement("sequence");
                sequenceTAG.SetAttribute("name", "direction_" + j.ToString());
                for (int i = 0; i < gridSize.X; i++)
                {
                    int index = j * gridSize.X + i;
                    string name = "frame_" + index.ToString();
                    string time = "50";
                    XmlElement frameTAG = doc.CreateElement("frame");
                    frameTAG.SetAttribute("name", name);
                    frameTAG.SetAttribute("time", time);
                    sequenceTAG.AppendChild(frameTAG);
                }
                sequencesTAG.AppendChild(sequenceTAG);
            }
            rootTAG.AppendChild(framesTAG);
            rootTAG.AppendChild(sequencesTAG);
            doc.AppendChild(rootTAG);
            //XmlTextWriter writer = new XmlTextWriter("yep.xml", Encoding.UTF8);
            //doc.Save(writer);
            //doc.WriteContentTo(writer);
            return doc;
        }

        public void AlphaCrop(Color c)
        {
            AlphaCrop alphaCrop = new AlphaCrop(c);
            for (int i = 0; i < listBitmap.Count; i++)
            {
                Bitmap item = listBitmap[i];
                Rectangle rect = alphaCrop.DoCrop(item);
                Bitmap newBitmap = new Bitmap(rect.Width, rect.Height);
                Graphics g = Graphics.FromImage(newBitmap);
                g.DrawImage(item,
                    new Rectangle(0, 0, newBitmap.Width, newBitmap.Height),
                    rect,
                    GraphicsUnit.Pixel
                    );
                listBitmap[i].Dispose();
                listBitmap[i] = newBitmap;
                listOffset[i].Offset(new Point(rect.X, rect.Y));
            }
        }

        public void Resize(double ratio)
        {
            if (ratio <= 0) return;
            frameSize = new Point((int)(frameSize.X * ratio), (int)(frameSize.Y * ratio));
            for (int i = 0; i < listBitmap.Count; i++)
            {
                Bitmap destBMP = new Bitmap(listBitmap[i],
                    (int)(listBitmap[i].Width * ratio), (int)(listBitmap[i].Height * ratio));
                listBitmap[i].Dispose();
                listBitmap[i] = destBMP;
                listOffset[i] = new Point((int)(listOffset[i].X * ratio), (int)(listOffset[i].Y * ratio));
            }
        }
    }
}
