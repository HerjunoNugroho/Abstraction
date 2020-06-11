using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract Class
//namespace AbstractionAbstractClass

//Abstraction Interface
namespace AbstractionInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class
            //PresidenIndonesia presiden;

            //Abstraction Interface
            IPresidenIndonesia presiden;
            Console.WriteLine("Profil Presiden Indonesia");
            Console.WriteLine("1. Soekarno");
            Console.WriteLine("2. Soeharto");
            Console.WriteLine("3. B.J.Habibie");
            Console.WriteLine("4. Abdurrahman Wahid");
            Console.WriteLine("5. Megawati Soekarnoputri");
            Console.WriteLine("6. Susilo Bambang Yudhoyono");
            Console.WriteLine("7. Joko Widodo\n");

            Console.WriteLine("Pilih Prof [1..7]: ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            if (pilihan == 1)
                presiden = new Soekarno();
            else if (pilihan == 2)
                presiden = new Soeharto();
            else if (pilihan == 3)
                presiden = new Habibie();
            else if (pilihan == 4)
                presiden = new GusDur();
            else if (pilihan == 5)
                presiden = new Megawati();
            else if (pilihan == 6)
                presiden = new SBY();
            else if (pilihan == 7)
                presiden = new Jokowi();
            else
                presiden = new Kosong();

            presiden.tampilkan();

            Console.ReadKey();
        }
    }
}
