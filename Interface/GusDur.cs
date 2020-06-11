using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    public class GusDur : IPresidenIndonesia
    {
        public void tampilkan()
        {
            Console.WriteLine("Abdurrahman Wahid atau akrab disapa Gus Dur adalah tokoh Muslim Indonesia dan pemimpin politik yang menjadi Presiden Indonesia ke-4.");
            Console.WriteLine("Ia menggantikan Presiden B.J Habibie setelah dipilih oleh Majelis Permusyawaratan Rakyat (MPR).");
            Console.WriteLine("Hidup di lingkungan agamais sedari kecil tentu saja membuat Gus Dur sangat kental dengan karakter Islami yang kuat.");
            Console.WriteLine("Gus Dur lahir di Jombang, Jawa Timur pada 7 September 1940. Ia meninggal dunia di Jakarta, 30 Desember 2009 pada usia 69 tahun.");
        }
    }
}
