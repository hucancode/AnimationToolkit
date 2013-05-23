using System;
using System.Collections.Generic;
using System.Text;
using HuuAnimation.JXCharacter;
using System.Drawing;

namespace HuuAnimation
{
    
    public class JXAnimation
    {
        // character
        JXBody body;

        public JXBody Body
        {
            get { return body; }
            set { body = value; }
        }

        JXLeftHand leftHand;

        public JXLeftHand LeftHand
        {
            get { return leftHand; }
            set { leftHand = value; }
        }

        JXRightHand rightHand;

        public JXRightHand RightHand
        {
            get { return rightHand; }
            set { rightHand = value; }
        }

        JXHead head;

        public JXHead Head
        {
            get { return head; }
            set { head = value; }
        }

        // horse
        JXHorseHead horseHead;

        public JXHorseHead HorseHead
        {
            get { return horseHead; }
            set { horseHead = value; }
        }

        JXHorseTail horseTail;

        public JXHorseTail HorseTail
        {
            get { return horseTail; }
            set { horseTail = value; }
        }

        JXHorseBack horseBack;

        public JXHorseBack HorseBack
        {
            get { return horseBack; }
            set { horseBack = value; }
        }
        
        //weapon
        JXOneHandWeapon oneHandWeapon;

        public JXOneHandWeapon OneHandWeapon
        {
            get { return oneHandWeapon; }
            set { oneHandWeapon = value; }
        }

        JXTwoHandWeapon twoHandWeapon;

        public JXTwoHandWeapon TwoHandWeapon
        {
            get { return twoHandWeapon; }
            set { twoHandWeapon = value; }
        }

        JXDoubleWeaponLeft doubleWeaponLeft;

        public JXDoubleWeaponLeft DoubleWeaponLeft
        {
            get { return doubleWeaponLeft; }
            set { doubleWeaponLeft = value; }
        }

        JXDoubleWeaponRight doubleWeaponRight;

        public JXDoubleWeaponRight DoubleWeaponRight
        {
            get { return doubleWeaponRight; }
            set { doubleWeaponRight = value; }
        }


        public JXAnimation()
        {
            body = new JXBody();
            head = new JXHead();
            leftHand = new JXLeftHand();
            rightHand = new JXRightHand();

            horseBack = new JXHorseBack();
            horseHead = new JXHorseHead();
            horseTail = new JXHorseTail();

            oneHandWeapon = new JXOneHandWeapon();
            twoHandWeapon = new JXTwoHandWeapon();
            doubleWeaponLeft = new JXDoubleWeaponLeft();
            doubleWeaponRight = new JXDoubleWeaponRight();
        }

        public Animation GetAction(JXAction action)
        {
            Animation ani = new Animation();

            Animation currentHead = head.getAction(action.BodyID);
            Animation currentBody = body.getAction(action.BodyID);
            Animation currentLeftHand = leftHand.getAction(action.BodyID);
            Animation currentRightHand = rightHand.getAction(action.BodyID);

            if (action.HorseID == 0)// no horse
            {
                if (action.OneHandWeaponID == 0 && action.TwoHandWeaponID == 0 && action.DoubleWeaponID == 0)
                    // no weapon
                {
                    for (int j = 0; j < 8; j++)
                    {
                        for (int i = 0; i < action.FrameCount; i++)
                        {
                            int index = j * action.FrameCount + i;
                            List<Bitmap> lstBMP = new List<Bitmap>();
                            if (j == 0)
                            {
                                lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                            }
                            else if (j == 1 || j == 2 || j == 3)
                            {
                                lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                lstBMP.Add(currentLeftHand.GetFrameWithOffset(index)); 
                            }
                            else if (j == 4)
                            {
                                lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                lstBMP.Add(currentHead.GetFrameWithOffset(index));
                            }
                            else// if (j == 5 || j == 6 || j == 7)
                            {
                                lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                            }
                            Bitmap bmp = combine(lstBMP);
                            ani.AddBitmap(bmp);
                        }
                    }
                }
                else
                {
                    if (action.DoubleWeaponID == 0)// one or two hand weapon
                    {
                        Animation currentWeapon;
                        if (action.OneHandWeaponID != 0)
                        {
                            currentWeapon = oneHandWeapon.getAction(action.OneHandWeaponID);
                        }
                        else
                        {
                            currentWeapon = twoHandWeapon.getAction(action.TwoHandWeaponID);
                        }
                        for (int j = 0; j < 8; j++)
                        {
                            for (int i = 0; i < action.FrameCount; i++)
                            {
                                int index = j * action.FrameCount + i;
                                List<Bitmap> lstBMP = new List<Bitmap>();
                                if (j == 0)
                                {
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeapon.GetFrameWithOffset(index));
                                }
                                else if (j == 1 || j == 2 || j == 3)
                                {
                                    lstBMP.Add(currentWeapon.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                }
                                else if (j == 4)
                                {
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeapon.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                }
                                else// if (j == 5 || j == 6 || j == 7)
                                {
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeapon.GetFrameWithOffset(index));
                                }
                                Bitmap bmp = combine(lstBMP);
                                ani.AddBitmap(bmp);
                            }
                        }
                    }
                    else// double weapon
                    {
                        Animation currentWeaponLeft = doubleWeaponLeft.getAction(action.DoubleWeaponID);
                        Animation currentWeaponRight = doubleWeaponRight.getAction(action.DoubleWeaponID);
                        for (int j = 0; j < 8; j++)
                        {
                            for (int i = 0; i < action.FrameCount; i++)
                            {
                                int index = j * action.FrameCount + i;
                                List<Bitmap> lstBMP = new List<Bitmap>();
                                if (j == 0)
                                {
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponLeft.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponRight.GetFrameWithOffset(index));
                                }
                                else if (j == 1 || j == 2 || j == 3)
                                {
                                    lstBMP.Add(currentWeaponRight.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponLeft.GetFrameWithOffset(index));
                                }
                                else if (j == 4)
                                {
                                    lstBMP.Add(currentWeaponLeft.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponRight.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                }
                                else// if (j == 5 || j == 6 || j == 7)
                                {
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponLeft.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponRight.GetFrameWithOffset(index));
                                }
                                Bitmap bmp = combine(lstBMP);
                                ani.AddBitmap(bmp);
                            }
                        }
                    }
                }
            }
            else// horse
            {
                Animation currentHorseHead = horseHead.getAction(action.HorseID);
                Animation currentHorseBack = horseBack.getAction(action.HorseID);
                Animation currentHorseTail = horseTail.getAction(action.HorseID);
                if (action.OneHandWeaponID == 0 && action.TwoHandWeaponID == 0 && action.DoubleWeaponID == 0)
                    // no weapon, horse
                {
                    for (int j = 0; j < 8; j++)
                    {
                        for (int i = 0; i < action.FrameCount; i++)
                        {
                            int index = j * action.FrameCount + i;
                            List<Bitmap> lstBMP = new List<Bitmap>();
                            if (j == 0)
                            {
                                lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentHorseHead.GetFrameWithOffset(index));
                            }
                            else if (j == 1 || j == 2 || j == 3)
                            {
                                lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                lstBMP.Add(currentHorseHead.GetFrameWithOffset(index));
                                lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                            }
                            else if (j == 4)
                            {
                                lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                lstBMP.Add(currentHorseHead.GetFrameWithOffset(index));
                                lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                            }
                            else// if (j == 5 || j == 6 || j == 7)
                            {
                                lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                lstBMP.Add(currentHorseHead.GetFrameWithOffset(index));
                                lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                            }
                            Bitmap bmp = combine(lstBMP);
                            ani.AddBitmap(bmp);
                        }
                    }
                }
                else
                {
                    if (action.DoubleWeaponID == 0)// one or two hand weapon, horse
                    {
                        Animation currentWeapon;
                        if (action.OneHandWeaponID != 0)
                        {
                            currentWeapon = oneHandWeapon.getAction(action.OneHandWeaponID);
                        }
                        else
                        {
                            currentWeapon = twoHandWeapon.getAction(action.TwoHandWeaponID);
                        }
                        for (int j = 0; j < 8; j++)
                        {
                            for (int i = 0; i < action.FrameCount; i++)
                            {
                                int index = j * action.FrameCount + i;
                                List<Bitmap> lstBMP = new List<Bitmap>();
                                if (j == 0)
                                {
                                    lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeapon.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseHead.GetFrameWithOffset(index));
                                }
                                else if (j == 1 || j == 2 || j == 3)
                                {
                                    lstBMP.Add(currentWeapon.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                }
                                else if (j == 4)
                                {
                                    lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeapon.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                }
                                else// if (j == 5 || j == 6 || j == 7)
                                {
                                    lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeapon.GetFrameWithOffset(index));
                                }
                                Bitmap bmp = combine(lstBMP);
                                ani.AddBitmap(bmp);
                            }
                        }
                    }
                    else// double weapon, horse
                    {
                        Animation currentWeaponLeft = doubleWeaponLeft.getAction(action.DoubleWeaponID);
                        Animation currentWeaponRight = doubleWeaponRight.getAction(action.DoubleWeaponID);
                        for (int j = 0; j < 8; j++)
                        {
                            for (int i = 0; i < action.FrameCount; i++)
                            {
                                int index = j * action.FrameCount + i;
                                List<Bitmap> lstBMP = new List<Bitmap>();
                                if (j == 0)
                                {
                                    lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponLeft.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponRight.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseHead.GetFrameWithOffset(index));

                                }
                                else if (j == 1 || j == 2 || j == 3)
                                {
                                    lstBMP.Add(currentWeaponRight.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponLeft.GetFrameWithOffset(index));
                                }
                                else if (j == 4)
                                {
                                    lstBMP.Add(currentHorseHead.GetFrameWithOffset(index)); 
                                    lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponLeft.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponRight.GetFrameWithOffset(index));
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                }
                                else// if (j == 5 || j == 6 || j == 7)
                                {
                                    lstBMP.Add(currentHorseTail.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseBack.GetFrameWithOffset(index));
                                    lstBMP.Add(currentLeftHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponLeft.GetFrameWithOffset(index));
                                    lstBMP.Add(currentBody.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHead.GetFrameWithOffset(index));
                                    lstBMP.Add(currentHorseHead.GetFrameWithOffset(index)); 
                                    lstBMP.Add(currentRightHand.GetFrameWithOffset(index));
                                    lstBMP.Add(currentWeaponRight.GetFrameWithOffset(index));
                                    
                                }
                                Bitmap bmp = combine(lstBMP);
                                ani.AddBitmap(bmp);
                            }
                        }
                    }
                }
            }
            
            return ani;
        }

        private Bitmap combine(Bitmap bmp1, Bitmap bmp2)
        {
            int w = bmp1.Width > bmp2.Width ? bmp1.Width : bmp2.Width;
            int h = bmp1.Height > bmp2.Height ? bmp1.Height : bmp2.Height;
            Bitmap result = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(result);
            g.DrawImage(bmp1,new Point(0,0));
            g.DrawImage(bmp2, new Point(0, 0));
            return result;
        }
        private Bitmap combine(List<Bitmap> bmpList)
        {
            int w = 0, h = 0;
            for (int i = 0; i < bmpList.Count; i++)
            {
                if (bmpList[i].Width > w) w = bmpList[i].Width;
                if (bmpList[i].Height > h) h = bmpList[i].Height;
            }
            Bitmap result = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(result);
            for (int i = 0; i < bmpList.Count; i++)
            {
                g.DrawImage(bmpList[i], new Point(0, 0));
            }
            return result;
        }
        public void LoadBody(string path)
        {
            body.Load(path);
        }
        public void LoadLeftHand(string path)
        {
            leftHand.Load(path);
        }
        public void LoadRightHand(string path)
        {
            rightHand.Load(path);
        }
        public void LoadHead(string path)
        {
            head.Load(path);
        }
        public void LoadHorseHead(string path)
        {
            horseHead.Load(path);
        }
        public void LoadHorseTail(string path)
        {
            horseTail.Load(path);
        }
        public void LoadHorseBack(string path)
        {
            horseBack.Load(path);
        }
        public void LoadOneHandWeapon(string path)
        {
            oneHandWeapon.Load(path);
        }
        public void LoadTwoHandWeapon(string path)
        {
            twoHandWeapon.Load(path);
        }
        public void LoadDoubleWeaponLeft(string path)
        {
            doubleWeaponLeft.Load(path);
        }
        public void LoadDoubleWeaponRight(string path)
        {
            doubleWeaponRight.Load(path);
        }

    }
}
