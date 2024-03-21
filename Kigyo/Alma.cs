using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kigyo
{
    internal class Alma:PictureBox
    {
        public static int méret = 20;
        public Alma()
        {
            Width = Alma.méret;
            Height = Alma.méret;
            BackColor = Color.Red;
        }
    }
}
