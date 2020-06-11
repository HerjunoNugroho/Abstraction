using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterface
{
    public class SBY : IPresidenIndonesia
    {
        public void tampilkan()
        {
            Console.WriteLine("Presiden pertama Republik Indonesia adalah Ir. Soekarno atau lebih dikenal dengan sebutan Bung Karno.");
            Console.WriteLine("Bung Karno lahir di Blitar, Jawa Timur 6 Juni 1901 dan meninggal di Jakarta, 21 Juni 1970 pada umur 69 tahun.");
            Console.WriteLine("Bersama dengan Wakil Presiden pertama Indonesia Mohammad Hatta, Bung Karno");
            Console.WriteLine("merupakan salah satu Proklamator Kemerdekaan Indonesia pada 17 Agustus 1945.");
            Console.WriteLine("Soekarno jugalah yang pertama kali mencetuskan konsep mengenai Pancasila sebagai dasar negara (ideologi) Indonesia.");
        }
    }
}