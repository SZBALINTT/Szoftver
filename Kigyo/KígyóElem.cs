using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kigyo
{
    internal class KígyóElem : PictureBox
    {
        public static int méret = 20;
        
        public KígyóElem()
        {
            Width = KígyóElem.méret;
            Height = KígyóElem.méret;
            BackColor = Color.OliveDrab;
            
        }


    }
}
