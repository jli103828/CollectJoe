using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectJoe
{
    static class Eastereggs
    {
        private static int[] _boxIndexForCelia = { 62, 63, 64, 66, 67, 68, 70, 74, 77, 81, 86, 90, 94, 96, 98, 101, 106, 107, 108, 110, 114, 116, 117, 118, 121, 126, 130, 134, 136, 138, 142, 143, 144, 146, 147, 148, 150, 151, 152, 154, 156, 158 };


        public static void Celia(frmField form) {
            form.DrawOnField(_boxIndexForCelia);
        }

        public static void Over9000() {
            MessageBox.Show("IT'S OVER 9000!","OVER 9000!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
