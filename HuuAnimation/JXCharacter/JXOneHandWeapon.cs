using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HuuAnimation.JXCharacter
{
    public class JXOneHandWeapon : JXCharacterPart
    {
        public JXOneHandWeapon()
            : base(18)
        { }
        public JXOneHandWeapon(string path)
            : base(18, path)
        { }
    }
}
