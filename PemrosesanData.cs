using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmod5_103022300065
{
    internal class PemrosesanData
    {
        private dynamic T1;
        private dynamic T2;
        private dynamic T3;
        public void DapatkanNilaiTerbesar(dynamic T1,dynamic T2,dynamic T3)
        {
            if (T1 > T2 && T1 > T3)
            {
                Console.WriteLine("Nilai tebesar pada nilai pertama: " + T1);
            }
            else if (T2 > T1 && T2 > T3)
            {
                Console.WriteLine("Nilai terbesar pada nilai kedua: " + T2);
            }
            else if (T3 > T1 && T3 > T2)
            {
                
                 Console.WriteLine("Nilai terbesar pada nilai T3: " + T3);
            }
            else
            {
                Console.WriteLine("Nilai kosong");
            }

        }
    }
}
