using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kigyo
{
    internal class Határ:PictureBox
    {
        public static int méret = 20;
        public static int pálya = 50;
        public Határ()
        {
            Width = Határ.méret;
            Height = Határ.méret;
            BackColor = Color.Brown;
            
        }
    }
}
