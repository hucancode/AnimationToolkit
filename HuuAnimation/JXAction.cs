using System;
using System.Collections.Generic;
using System.Text;

namespace HuuAnimation
{
    public class JXAction
    {
        #region Properties

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int frameCount;

        public int FrameCount
        {
            get { return frameCount; }
            set { frameCount = value; }
        }

        private int bodyID;

        public int BodyID
        {
            get { return bodyID; }
            set { bodyID = value; }
        }

        private int oneHandWeaponID;

        public int OneHandWeaponID
        {
            get { return oneHandWeaponID; }
            set { oneHandWeaponID = value; }
        }

        private int twoHandWeaponID;

        public int TwoHandWeaponID
        {
            get { return twoHandWeaponID; }
            set { twoHandWeaponID = value; }
        }

        private int doubleWeaponID;

        public int DoubleWeaponID
        {
            get { return doubleWeaponID; }
            set { doubleWeaponID = value; }
        }

        private int horseID;

        public int HorseID
        {
            get { return horseID; }
            set { horseID = value; }
        }
        #endregion

        public JXAction()
        {
            id = 1;
            frameCount = 18;
            bodyID = 1;
            oneHandWeaponID = 0;
            twoHandWeaponID = 0;
            doubleWeaponID = 0;
            horseID = 0;
        }

        public JXAction(int i, int frame, int body, int oneHand, int twoHand, int double_, int horse)
        {
            id = i;
            frameCount = frame;
            bodyID = body;
            oneHandWeaponID = oneHand;
            twoHandWeaponID = twoHand;
            doubleWeaponID = double_;
            horseID = horse;
        }

        // 38 male action

        public static JXAction MaleAttackNoWeapon() { return new JXAction(1, 18, 1, 0, 0, 0, 0); }
        public static JXAction MaleAttackOneHandWeapon() { return new JXAction(2, 16, 2, 1, 0, 0, 0); }
        public static JXAction MaleAttackOneHandWeaponCritical() { return new JXAction(3, 14, 3, 2, 0, 0, 0); }
        public static JXAction MaleAttackTwoHandWeapon() { return new JXAction(4, 12, 4, 0, 1, 0, 0); }
        public static JXAction MaleAttackTwoHandWeaponCritical() { return new JXAction(5, 12, 5, 0, 2, 0, 0); }
        public static JXAction MaleAttackDoubleWeapon() { return new JXAction(6, 16, 6, 0, 0, 1, 0); }
        public static JXAction MaleAttackDoubleWeaponCritical() { return new JXAction(7, 12, 7, 0, 0, 2, 0); }
        public static JXAction MaleFallNoWeapon() { return new JXAction(8, 12, 8, 0, 0, 0, 0); }
        public static JXAction MaleFallOneHandWeapon() { return new JXAction(9, 11, 9, 3, 0, 0, 0); }
        public static JXAction MaleFallTwoHandWeapon() { return new JXAction(10, 15, 10, 0, 3, 0, 0); }
        public static JXAction MaleFallDoubleWeapon() { return new JXAction(11, 18, 11, 0, 0, 3, 0); }
        
        public static JXAction MaleHurtNoWeapon() { return new JXAction(40, 9, 19, 0, 0, 0, 0); }
        public static JXAction MaleHurtOneHandWeapon() { return new JXAction(41, 8, 20, 11, 0, 0, 0); }
        public static JXAction MaleHurtTwoHandWeapon() { return new JXAction(42, 7, 21, 0, 11, 0, 0); }
        public static JXAction MaleHurtDoubleWeapon() { return new JXAction(43, 12, 22, 0, 0, 11, 0); }
        public static JXAction MaleJump() { return new JXAction(44, 20, 23, 0, 0, 0, 0); }
        public static JXAction MaleAttackflyingDagger() { return new JXAction(45, 16, 24, 0, 0, 0, 0); }
        public static JXAction MaleMagicNoWeapon() { return new JXAction(46, 12, 25, 0, 0, 0, 0); }
        public static JXAction MaleMagicOneHandWeapon() { return new JXAction(47, 12, 26, 12, 0, 0, 0); }
        public static JXAction MaleMagicTwoHandWeapon() { return new JXAction(48, 13, 27, 0, 12, 0, 0); }
        public static JXAction MaleMagicDoubleWeapon() { return new JXAction(49, 16, 28, 0, 0, 12, 0); }
        
        public static JXAction MaleRunNoWeapon() { return new JXAction(54, 11, 30, 0, 0, 0, 0); }
        public static JXAction MaleRunOneHandWeapon() { return new JXAction(55, 11, 31, 14, 0, 0, 0); }
        public static JXAction MaleRunTwoHandWeapon() { return new JXAction(56, 11, 32, 0, 14, 0, 0); }
        public static JXAction MaleRunDoubleWeapon() { return new JXAction(57, 11, 33, 0, 0, 14, 0); }
        public static JXAction MaleIdleNoWeapon() { return new JXAction(58, 15, 34, 0, 0, 0, 0); }
        public static JXAction MaleIdleOneHandWeapon() { return new JXAction(59, 15, 35, 15, 0, 0, 0); }
        public static JXAction MaleIdleTwoHandWeapon() { return new JXAction(60, 15, 35, 0, 15, 0, 0); }
        public static JXAction MaleIdleDoubleWeapon() { return new JXAction(61, 15, 35, 0, 0, 15, 0); }
        public static JXAction MaleFightIdleNoWeapon() { return new JXAction(62, 11, 36, 0, 0, 0, 0); }
        public static JXAction MaleFightIdleOneHandWeapon() { return new JXAction(63, 11, 37, 17, 0, 0, 0); }
        public static JXAction MaleFightIdleTwoHandWeapon() { return new JXAction(64, 11, 38, 0, 17, 0, 0); }
        public static JXAction MaleFightIdleDoubleWeapon() { return new JXAction(65, 11, 39, 0, 0, 17, 0); }
        public static JXAction MaleWalkNoWeapon() { return new JXAction(66, 15, 40, 0, 0, 0, 0); }
        public static JXAction MaleWalkOneHandWeapon() { return new JXAction(67, 15, 41, 18, 0, 0, 0); }
        public static JXAction MaleWalkTwoHandWeapon() { return new JXAction(68, 15, 42, 0, 18, 0, 0); }
        public static JXAction MaleWalkDoubleWeapon() { return new JXAction(69, 15, 43, 0, 0, 18, 0); }
        public static JXAction MaleZen() { return new JXAction(70, 9, 44, 0, 0, 0, 0); }

        // 38 female action

        public static JXAction FemaleAttackNoWeapon() { return new JXAction(1, 12, 1, 0, 0, 0, 0); }
        public static JXAction FemaleAttackOneHandWeapon() { return new JXAction(2, 13, 2, 1, 0, 0, 0); }
        public static JXAction FemaleAttackOneHandWeaponCritical() { return new JXAction(3, 13, 3, 2, 0, 0, 0); }
        public static JXAction FemaleAttackTwoHandWeapon() { return new JXAction(4, 13, 4, 0, 1, 0, 0); }
        public static JXAction FemaleAttackTwoHandWeaponCritical() { return new JXAction(5, 12, 5, 0, 2, 0, 0); }
        public static JXAction FemaleAttackDoubleWeapon() { return new JXAction(6, 16, 6, 0, 0, 1, 0); }
        public static JXAction FemaleAttackDoubleWeaponCritical() { return new JXAction(7, 12, 7, 0, 0, 2, 0); }
        public static JXAction FemaleFallNoWeapon() { return new JXAction(8, 13, 8, 0, 0, 0, 0); }
        public static JXAction FemaleFallOneHandWeapon() { return new JXAction(9, 15, 9, 3, 0, 0, 0); }
        public static JXAction FemaleFallTwoHandWeapon() { return new JXAction(10, 10, 10, 0, 3, 0, 0); }
        public static JXAction FemaleFallDoubleWeapon() { return new JXAction(11, 10, 11, 0, 0, 3, 0); }
        
        public static JXAction FemaleHurtNoWeapon() { return new JXAction(40, 8, 19, 0, 0, 0, 0); }
        public static JXAction FemaleHurtOneHandWeapon() { return new JXAction(41, 8, 20, 11, 0, 0, 0); }
        public static JXAction FemaleHurtTwoHandWeapon() { return new JXAction(42, 6, 21, 0, 11, 0, 0); }
        public static JXAction FemaleHurtDoubleWeapon() { return new JXAction(43, 6, 22, 0, 0, 11, 0); }
        public static JXAction FemaleJump() { return new JXAction(44, 14, 23, 0, 0, 0, 0); }
        public static JXAction FemaleAttackflyingDagger() { return new JXAction(45, 12, 24, 0, 0, 0, 0); }
        public static JXAction FemaleMagicNoWeapon() { return new JXAction(46, 12, 25, 0, 0, 0, 0); }
        public static JXAction FemaleMagicOneHandWeapon() { return new JXAction(47, 10, 26, 12, 0, 0, 0); }
        public static JXAction FemaleMagicTwoHandWeapon() { return new JXAction(48, 12, 27, 0, 12, 0, 0); }
        public static JXAction FemaleMagicDoubleWeapon() { return new JXAction(49, 10, 28, 0, 0, 12, 0); }
        
        public static JXAction FemaleRunNoWeapon() { return new JXAction(54, 12, 30, 0, 0, 0, 0); }
        public static JXAction FemaleRunOneHandWeapon() { return new JXAction(55, 12, 31, 14, 0, 0, 0); }
        public static JXAction FemaleRunTwoHandWeapon() { return new JXAction(56, 12, 32, 0, 14, 0, 0); }
        public static JXAction FemaleRunDoubleWeapon() { return new JXAction(57, 12, 33, 0, 0, 14, 0); }
        public static JXAction FemaleIdleNoWeapon() { return new JXAction(58, 10, 34, 0, 0, 0, 0); }
        public static JXAction FemaleIdleOneHandWeapon() { return new JXAction(59, 8, 35, 15, 0, 0, 0); }
        public static JXAction FemaleIdleTwoHandWeapon() { return new JXAction(60, 8, 35, 0, 15, 0, 0); }
        public static JXAction FemaleIdleDoubleWeapon() { return new JXAction(61, 8, 35, 0, 0, 15, 0); }
        public static JXAction FemaleFightIdleNoWeapon() { return new JXAction(62, 8, 36, 0, 0, 0, 0); }
        public static JXAction FemaleFightIdleOneHandWeapon() { return new JXAction(63, 12, 37, 17, 0, 0, 0); }
        public static JXAction FemaleFightIdleTwoHandWeapon() { return new JXAction(64, 8, 38, 0, 17, 0, 0); }
        public static JXAction FemaleFightIdleDoubleWeapon() { return new JXAction(65, 8, 39, 0, 0, 17, 0); }
        public static JXAction FemaleWalkNoWeapon() { return new JXAction(66, 12, 40, 0, 0, 0, 0); }
        public static JXAction FemaleWalkOneHandWeapon() { return new JXAction(67, 12, 41, 18, 0, 0, 0); }
        public static JXAction FemaleWalkTwoHandWeapon() { return new JXAction(68, 12, 42, 0, 18, 0, 0); }
        public static JXAction FemaleWalkDoubleWeapon() { return new JXAction(69, 12, 43, 0, 0, 18, 0); }
        public static JXAction FemaleZen() { return new JXAction(70, 12, 44, 0, 0, 0, 0); }

        // 32 horse action, when ride horse, male & fem are the same

        public static JXAction AttackHorseNoWeapon() { return new JXAction(12, 12, 12, 0, 0, 0, 1); }
        public static JXAction AttackHorseOneHandWeapon() { return new JXAction(13, 12, 12, 4, 0, 0, 1); }
        public static JXAction AttackHorseTwoHandWeapon() { return new JXAction(14, 12, 12, 0, 4, 0, 1); }
        public static JXAction AttackHorseDoubleWeapon() { return new JXAction(15, 12, 12, 0, 0, 4, 1); }
        public static JXAction AttackHorseNoWeaponCritical() { return new JXAction(16, 14, 13, 0, 0, 0, 2); }
        public static JXAction AttackHorseOneHandWeaponCritical() { return new JXAction(17, 14, 13, 5, 0, 0, 2); }
        public static JXAction AttackHorseTwoHandWeaponCritical() { return new JXAction(18, 14, 13, 0, 5, 0, 2); }
        public static JXAction AttackHorseDoubleWeaponCritical() { return new JXAction(19, 14, 13, 0, 0, 5, 2); }
        public static JXAction FallHorseNoWeapon() { return new JXAction(20, 14, 14, 0, 0, 0, 3); }
        public static JXAction FallHorseOneHandWeapon() { return new JXAction(21, 14, 14, 6, 0, 0, 3); }
        public static JXAction FallHorseTwoHandWeapon() { return new JXAction(22, 14, 14, 0, 6, 0, 3); }
        public static JXAction FallHorseDoubleWeapon() { return new JXAction(23, 14, 14, 0, 0, 6, 3); }
        public static JXAction HurtHorseNoWeapon() { return new JXAction(24, 6, 15, 0, 0, 0, 4); }
        public static JXAction HurtHorseOneHandWeapon() { return new JXAction(25, 6, 15, 7, 0, 0, 4); }
        public static JXAction HurtHorseTwoHandWeapon() { return new JXAction(26, 6, 15, 0, 7, 0, 4); }
        public static JXAction HurtHorseDoubleWeapon() { return new JXAction(27, 6, 15, 0, 0, 7, 4); }
        public static JXAction MagicHorseNoWeapon() { return new JXAction(28, 12, 16, 0, 0, 0, 5); }
        public static JXAction MagicHorseOneHandWeapon() { return new JXAction(29, 12, 16, 8, 0, 0, 5); }
        public static JXAction MagicHorseTwoHandWeapon() { return new JXAction(30, 12, 16, 0, 8, 0, 5); }
        public static JXAction MagicHorseDoubleWeapon() { return new JXAction(31, 12, 16, 0, 0, 8, 5); }
        public static JXAction RunHorseNoWeapon() { return new JXAction(32, 10, 17, 0, 0, 0, 6); }
        public static JXAction RunHorseOneHandWeapon() { return new JXAction(33, 10, 17, 9, 0, 0, 6); }
        public static JXAction RunHorseTwoHandWeapon() { return new JXAction(34, 10, 17, 0, 9, 0, 6); }
        public static JXAction RunHorseDoubleWeapon() { return new JXAction(35, 10, 17, 0, 0, 9, 6); }
        public static JXAction WalkHorseNoWeapon() { return new JXAction(36, 12, 18, 0, 0, 0, 7); }
        public static JXAction WalkHorseOneHandWeapon() { return new JXAction(37, 12, 18, 10, 0, 0, 7); }
        public static JXAction WalkHorseTwoHandWeapon() { return new JXAction(38, 12, 18, 0, 10, 0, 7); }
        public static JXAction WalkHorseDoubleWeapon() { return new JXAction(39, 12, 18, 0, 0, 10, 7); }
        public static JXAction IdleHorseNoWeapon() { return new JXAction(50, 14, 29, 0, 0, 0, 8); }
        public static JXAction IdleHorseOneHandWeapon() { return new JXAction(51, 14, 29, 13, 0, 0, 8); }
        public static JXAction IdleHorseTwoHandWeapon() { return new JXAction(52, 14, 29, 0, 13, 0, 8); }
        public static JXAction IdleHorseDoubleWeapon() { return new JXAction(53, 14, 29, 0, 0, 13, 8); }
    }
}
