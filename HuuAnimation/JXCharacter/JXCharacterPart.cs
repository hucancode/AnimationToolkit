using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;

namespace HuuAnimation.JXCharacter
{
    public class JXCharacterPart
    {
        protected Animation[] listAnimation;
        private string path;
        public JXCharacterPart(int i)
        {
            listAnimation = new Animation[i];
            path = "";
        }
        public JXCharacterPart(int i, string path)
        {
            listAnimation = new Animation[i];
            this.path = path;
        }
        public void Load(string path)
        {
            this.path = path;
        }
        public Animation getAction(int id)
        {
            if (path == "") return new Animation();
            DirectoryInfo info = new DirectoryInfo(path);
            FileInfo[] files = info.GetFiles("*.png");
            Animation result = new Animation();
            if (files.Length == listAnimation.Length)
            {
                string str = files[id-1].Name.Substring(0, files[id-1].Name.Length - 4).Split('@')[1];
                int x = int.Parse(str.Split('-')[2]);
                int y = int.Parse(str.Split('-')[3]);
                Point p = new Point(x, y);
                Bitmap sheet = new Bitmap(files[id-1].FullName);
                result = new Animation(sheet, p);
            }
            return result;
        }
    }
}
