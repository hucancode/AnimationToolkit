using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace HuuAnimation
{
    /// <summary>
    /// Alpha crop, coded by ngoa ho, April 2012
    /// </summary>
    class AlphaCrop
    {
        private Color alphaColor;
        public AlphaCrop(Color alpha)
        {
            alphaColor = alpha;
        }
        struct Range
        {
            public int Min;
            public int Max;
        }

        public Rectangle DoCrop(Bitmap bmp)
        {
            // the algorithm is:
            // browse the bitmap using binary search idea.
            // - when catch a pixel(not transparent, or white, or special color, etc), 
            // mark it as border if the last border is smaller than this point.
            // - do not browse any range smaller than current border
            // - when no range for browse, break the loop
            // - do it 4 times, for top, bottom, left, right border.
            Queue<Range> scanQueue = new Queue<Range>();
            Range vertical = new Range();
            vertical.Min = bmp.Height - 1;
            Range horizonal = new Range();
            horizonal.Min = bmp.Width - 1;
            int m;
            Range initRange = new Range();

            #region Find TOP border
            //MessageBox.Show("Find TOP border!");
            initRange.Min = 0;
            initRange.Max = bmp.Height - 1;
            scanQueue.Enqueue(initRange);
            while (true)
            {
                if (scanQueue.Count == 0) break;
                Range r = scanQueue.Dequeue();
                // ensure that we're on the right way
                if (r.Min > vertical.Min) continue;
                //MessageBox.Show("Scan " + r.Min.ToString() + "- " + r.Max.ToString());
                m = (r.Max - r.Min) / 2 + r.Min;
                // if catch a valid pixel
                if (Scan(bmp, initRange, m, true))
                {
                    //MessageBox.Show("Catch at "+m.ToString());
                    // go up
                    vertical.Min = m;
                    if (r.Min == r.Max || m == r.Min)
                        continue;
                    Range newRange = new Range();
                    newRange.Min = r.Min;
                    newRange.Max = m - 1;
                    scanQueue.Enqueue(newRange);
                }
                // if catch nothing
                else
                {
                    if (r.Min == r.Max)
                        continue;
                    if (m == r.Min)
                    {
                        Range downRange = new Range();
                        downRange.Min = m + 1;
                        downRange.Max = r.Max;
                        scanQueue.Enqueue(downRange);
                    }
                    else if (m == r.Max)
                    {
                        Range upRange = new Range();
                        upRange.Min = r.Min;
                        upRange.Max = m - 1;
                        scanQueue.Enqueue(upRange);
                    }
                    else
                    {
                        // seperate 2 way, up and down
                        Range upRange = new Range();
                        upRange.Min = r.Min;
                        upRange.Max = m - 1;
                        scanQueue.Enqueue(upRange);
                        Range downRange = new Range();
                        downRange.Min = m + 1;
                        downRange.Max = r.Max;
                        scanQueue.Enqueue(downRange);
                    }
                }
            }
            //MessageBox.Show("Found top border at " + vertical.Min.ToString()); 
            #endregion

            #region Find BOTTOM border
            //MessageBox.Show("Find BOTTOM border!");
            initRange.Min = 0;
            initRange.Max = bmp.Height - 1;
            scanQueue.Enqueue(initRange);
            // find bottom  border(vertical.max)
            while (true)
            {
                if (scanQueue.Count == 0) break;
                Range r = scanQueue.Dequeue();
                // ensure that we're on the right way
                if (r.Max < vertical.Max) continue;
                //MessageBox.Show("Scan " + r.Min.ToString() + "- " + r.Max.ToString());
                m = (r.Max - r.Min) / 2 + r.Min;
                // if catch a valid pixel
                if (Scan(bmp, initRange, m, true))
                {
                    //MessageBox.Show("Catch at " + m.ToString());
                    // go down
                    vertical.Max = m;
                    if (r.Min == r.Max || m == r.Max)
                        continue;
                    Range newRange = new Range();
                    newRange.Min = m + 1;
                    newRange.Max = r.Max;
                    scanQueue.Enqueue(newRange);
                }
                // if catch nothing
                else
                {
                    if (r.Min == r.Max)
                        continue;
                    if (m == r.Min)
                    {
                        Range downRange = new Range();
                        downRange.Min = m + 1;
                        downRange.Max = r.Max;
                        scanQueue.Enqueue(downRange);
                    }
                    else if (m == r.Max)
                    {
                        Range upRange = new Range();
                        upRange.Min = r.Min;
                        upRange.Max = m - 1;
                        scanQueue.Enqueue(upRange);
                    }
                    else
                    {
                        // seperate 2 way, up and down
                        Range upRange = new Range();
                        upRange.Min = r.Min;
                        upRange.Max = m - 1;
                        scanQueue.Enqueue(upRange);
                        Range downRange = new Range();
                        downRange.Min = m + 1;
                        downRange.Max = r.Max;
                        scanQueue.Enqueue(downRange);
                    }
                }
            }
            //MessageBox.Show("Found bottom border at " + vertical.Max.ToString()); 
            #endregion

            #region Find LEFT border
            //MessageBox.Show("Find LEFT border!");
            initRange.Min = 0;
            initRange.Max = bmp.Width - 1;
            scanQueue.Enqueue(initRange);
            // find bottom  border(vertical.max)
            while (true)
            {
                if (scanQueue.Count == 0) break;
                Range r = scanQueue.Dequeue();
                // ensure that we're on the right way
                if (r.Min > horizonal.Min) continue;
                //MessageBox.Show("Scan " + r.Min.ToString() + "- " + r.Max.ToString());
                m = (r.Max - r.Min) / 2 + r.Min;
                // if catch a valid pixel
                if (Scan(bmp, vertical, m, false))
                {
                    //MessageBox.Show("Catch at " + m.ToString());
                    // go left
                    horizonal.Min = m;
                    if (r.Min == r.Max || m == r.Min)
                        continue;
                    Range newRange = new Range();
                    newRange.Min = r.Min;
                    newRange.Max = m - 1;
                    scanQueue.Enqueue(newRange);
                }
                // if catch nothing
                else
                {
                    if (r.Min == r.Max)
                        continue;
                    if (m == r.Min)
                    {
                        Range rightRange = new Range();
                        rightRange.Min = m + 1;
                        rightRange.Max = r.Max;
                        scanQueue.Enqueue(rightRange);
                    }
                    else if (m == r.Max)
                    {
                        Range lefrRange = new Range();
                        lefrRange.Min = r.Min;
                        lefrRange.Max = m - 1;
                        scanQueue.Enqueue(lefrRange);
                    }
                    else
                    {
                        // seperate 2 way, left and right
                        Range leftRange = new Range();
                        leftRange.Min = r.Min;
                        leftRange.Max = m - 1;
                        scanQueue.Enqueue(leftRange);
                        Range rightRange = new Range();
                        rightRange.Min = m + 1;
                        rightRange.Max = r.Max;
                        scanQueue.Enqueue(rightRange);
                    }
                }
            }
            //MessageBox.Show("Found left border at " + horizonal.Min.ToString());
            #endregion

            #region Find RIGHT border
            //MessageBox.Show("Find RIGHT border!");
            initRange.Min = 0;
            initRange.Max = bmp.Width - 1;
            scanQueue.Enqueue(initRange);
            // find bottom  border(vertical.max)
            while (true)
            {
                if (scanQueue.Count == 0) break;
                Range r = scanQueue.Dequeue();
                // ensure that we're on the right way
                if (r.Max < horizonal.Max) continue;
                //MessageBox.Show("Scan " + r.Min.ToString() + "- " + r.Max.ToString());
                m = (r.Max - r.Min) / 2 + r.Min;
                // if catch a valid pixel
                if (Scan(bmp, vertical, m, false))
                {
                    //MessageBox.Show("Catch at " + m.ToString());
                    // go left
                    horizonal.Max = m;
                    if (r.Min == r.Max || m == r.Max)
                        continue;
                    Range newRange = new Range();
                    newRange.Min = m + 1;
                    newRange.Max = r.Max;
                    scanQueue.Enqueue(newRange);
                }
                // if catch nothing
                else
                {
                    if (r.Min == r.Max)
                        continue;
                    if (m == r.Min)
                    {
                        Range rightRange = new Range();
                        rightRange.Min = m + 1;
                        rightRange.Max = r.Max;
                        scanQueue.Enqueue(rightRange);
                    }
                    else if (m == r.Max)
                    {
                        Range lefrRange = new Range();
                        lefrRange.Min = r.Min;
                        lefrRange.Max = m - 1;
                        scanQueue.Enqueue(lefrRange);
                    }
                    else
                    {
                        // seperate 2 way, left and right
                        Range leftRange = new Range();
                        leftRange.Min = r.Min;
                        leftRange.Max = m - 1;
                        scanQueue.Enqueue(leftRange);
                        Range rightRange = new Range();
                        rightRange.Min = m + 1;
                        rightRange.Max = r.Max;
                        scanQueue.Enqueue(rightRange);
                    }
                }
            }
            //MessageBox.Show("Found right border at " + horizonal.Max.ToString());
            #endregion

            if (horizonal.Max < horizonal.Min) horizonal.Max = horizonal.Min + 1;
            if (vertical.Max < vertical.Min) vertical.Max = vertical.Min + 1;
            return new Rectangle(horizonal.Min, vertical.Min, horizonal.Max - horizonal.Min + 1, vertical.Max - vertical.Min + 1);
        }

        private bool Scan(Bitmap bmp, Range range, int pivot, bool vertical)
        {
            if (vertical)
                for (int i = range.Min; i <= range.Max; i++)
                {
                    Color c = bmp.GetPixel(i, pivot);
                    if (alphaColor.A != c.A || alphaColor.R != c.R || alphaColor.G != c.G || alphaColor.B != c.B)
                        return true;
                }
            else
                for (int i = range.Min; i <= range.Max; i++)
                {
                    Color c = bmp.GetPixel(i, pivot);
                    if (alphaColor.A != c.A || alphaColor.R != c.R || alphaColor.G != c.G || alphaColor.B != c.B)
                        return true;
                }
            return false;
        }
    }
}
