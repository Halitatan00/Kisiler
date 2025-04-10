using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanlar
{
    internal class İnsan
    {
        string ad;
        string soyad;
        int yas;
        string cinsiyet;

        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int YAS
        {
            get { return yas; }
            set { yas = value; }
        }
        public string CİNSİYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        public İnsan() { 
            ad = string.Empty;
            soyad = string.Empty;
            yas = 0;
            cinsiyet = string.Empty;
        }
    }
}
