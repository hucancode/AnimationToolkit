using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace HuuAnimation
{
    public class AnimationManager
    {
        public static Animation Combine(Animation a1, Animation a2)
        {
            if (a1.FrameCount != a2.FrameCount) return a1;
            int w = a1.FrameSize.X > a2.FrameSize.X ? a1.FrameSize.X : a2.FrameSize.X;
            int h = a1.FrameSize.Y > a2.FrameSize.Y ? a1.FrameSize.Y : a2.FrameSize.Y;
            Animation result = new Animation();
            for (int i = 0; i < a1.FrameCount; i++)
            {
                Bitmap bmp = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(a1.GetFrame(i),a1.GetOffset(i));
                g.DrawImage(a2.GetFrame(i),a2.GetOffset(i));
                result.AddBitmap(bmp);
            }
            return result;
        }
        public static Animation Combine(Animation[] listAnimation)
        {
            int w = 0, h = 0;
            for (int i = 0; i < listAnimation.Length; i++)
            {
                if (i > 0)
                {
                    if (listAnimation[i].FrameCount != listAnimation[i - 1].FrameCount)
                    {
                        return listAnimation[0];
                    }
                }
                if (listAnimation[i].FrameSize.X > w) w = listAnimation[i].FrameSize.X;
                if (listAnimation[i].FrameSize.Y > h) h = listAnimation[i].FrameSize.Y;            
            }
            Animation result = new Animation();
            for (int i = 0; i < listAnimation[0].FrameCount; i++)
            {
                Bitmap bmp = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(bmp);
                for (int j = 0; j < listAnimation.Length; j++)
                {
                    g.DrawImage(listAnimation[j].GetFrame(i), listAnimation[j].GetOffset(i));
                }
                result.AddBitmap(bmp);
            }
            return result;
        }
    }
}
