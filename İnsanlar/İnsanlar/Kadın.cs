using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanlar
{
    internal class Kadın : İnsan
    {
        string makyaj;
        string sacrengi;

        public string MAKYAJ
        {
            get {  return makyaj; }
            set {  makyaj = value; }
        }
        public string SACRENGi
        {
            get { return sacrengi; }
            set {  sacrengi = value; }
        }
        public Kadın()
        {
            makyaj = "";
            sacrengi = "";
        }
    }
}
