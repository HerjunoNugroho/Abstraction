using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    public class Habibie : IPresidenIndonesia
    {
        public void tampilkan()
        {
            Console.WriteLine("Pasca lengsernya Presiden Soeharto, Bacharuddin Jusuf (B.J) Habibie diangkat menjadi Presiden Republik Indonesia ke-3.");
            Console.WriteLine("Selain itu, selama 20 tahun pernah menjabat Menteri Negara Ristek/Kepala BPPT, dan memimpin 10 perusahana BUMN industri strategis.");
            Console.WriteLine("Semasa hidupnya, B.J Habibie telah mengukir banyak prestasi dan menciptakan karya untuk Indonesia.");
            Console.WriteLine("Presiden ketiga RI B.J Habibie lahir di Parepare, Sulawesi Selatan, 25 Juni 1936.");
            Console.WriteLine("Beliau menghembuskan napas terakhir pada 11 September 2019 di Rumah Sakit Pusat Angkatan Darat Gatot Soebroto Jakarta.");
        }
    }
}