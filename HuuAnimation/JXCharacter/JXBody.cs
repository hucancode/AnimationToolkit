using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;

namespace HuuAnimation.JXCharacter
{
    public class JXBody : JXCharacterPart
    {
        public JXBody()
            : base(44)
        { }
        public JXBody(string path)
            : base(44, path)
        { }
    }
}
