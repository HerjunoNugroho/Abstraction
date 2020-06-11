using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAbstractClass
{
    public class SBY : PresidenIndonesia
    {
        public override void tampilkan()
        {
            Console.WriteLine("Susilo Bambang Yudhoyono (SBY) adalah Presiden Indonesia ke-6. Ia menjadi presiden pertama di Indonesia yang dipilih melalui jalur Pemilihan Umum (Pemilu).");
            Console.WriteLine("Ketika itu, ia bersama Wakil Presiden Jusuf Kalla terpilih dalam Pemilu Presiden perdana tahun 2004.");
            Console.WriteLine("Ia berhasil melanjutkan pemerintahannya untuk periode kedua dengan kembali memenangkan Pemilu Presiden 2009, bersama Wakil Presiden Boediono.");
            Console.WriteLine("Dalam karier politik, SBY tampil sebagai salah satu pendiri Partai Demokrat dan masih eksis hingga sekarang.");
        }
    }
}