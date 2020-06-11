using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    public class Kosong : IPresidenIndonesia
    {
        public void tampilkan()
        {
            Console.WriteLine("Profil Tidak Ditemukan");
        }
    }
}
