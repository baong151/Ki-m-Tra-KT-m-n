using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kiemtraketthucmon
{
    class Dongvat
    {
        private string Keu;

        public string DongvatKeu
        {
            get
            {
                return Keu;
            }
            set
            {
                Keu = value;
            }
        }

        public Dongvat()
        {
        }

        private string MauLong;

        public string DongvatMauLong
        {
            get
            {
                return MauLong;
            }
            set
            {
                MauLong = value;
            }
        }



        public virtual void Talk()
        {
            if (DongvatKeu.Equals("Gâu gâu") && (DongvatMauLong.Equals("Đen")))
                MessageBox.Show(this.DongvatKeu + " Tôi là chó lông màu:" + this.DongvatMauLong);
            else if (DongvatKeu.Equals("Meo meo") && (DongvatMauLong.Equals("Trắng")))
                MessageBox.Show(this.DongvatKeu + " Tôi là mèo lông màu:" + this.DongvatMauLong);
        }
    }
}
