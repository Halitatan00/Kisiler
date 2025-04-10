using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnsanlar
{
    internal class Erkek : İnsan
    {
        string askerlikdurumu;
        public string ASKERLİKDURUMU
        {
            get { return askerlikdurumu; }
            set { askerlikdurumu = value; }
        }
        public Erkek()
        {
            askerlikdurumu = "";
        }
      }
 }

