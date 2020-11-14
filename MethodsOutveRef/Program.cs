using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOutveRef
{
    class Program
    {
        static void Main(string[] args) //davranış, behavior
        {
            string ad = "Leo";
            string soyad = "Alsaç";
            DisplayName(ad, soyad);

            Console.WriteLine(GetPi());

            int sonuc = Add(5, 7);
            Console.WriteLine("Add(number1, number2): " + sonuc);

            int no1 = 5;
            int no2 = 7;
            int res = AddWithValue(no1, no2);
            Console.WriteLine(no1);

            AddWithOut(out no1, no2);
            Console.WriteLine(no1);

            //int n1;   // out da ilk değer set edilme zorunluluğu yoktur.
            //int n2 = 17;
            //int r = AddWithOut(out n1, n2);
            //Console.WriteLine(n1);


            int s1 = 0;
            int s2 = 17;
            int rr = AddWithRef(ref s1, s2);
            Console.WriteLine(s1);

            DisplayAdSoyad("Çağıl", "Alsaç");
            DisplayAdSoyad("Leo", "Alsaç", "İskoç");
            //ADD lı olanlar method overload. 

            Console.WriteLine(Add(1, 2, 3));

            MultiPly(5, 4, 3, 2, 1);


            Console.ReadLine();
        }


        static void DisplayAdSoyad(string name, string surname, string prefix = "T.C.")
        {
            Console.WriteLine(prefix + " " + name + " " + surname);  //default parametre prefix
        }
        static int AddWithRef(ref int number1, int number2)
        {
            number1 = 100;
            return number1 + number2;
        }

        static int AddWithValue(int number1, int number2)  //referans tipi gibi davranıyor.
        {
            number1 = 100;
            return number1 + number2;
        }

        static int AddWithOut(out int number1, int number2)
        {
            number1 = 100;
            return number1 + number2;
        }

        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        static double Add(double number1, int number2)
        {
            return number1 + number2;
        }
        static int Add(int number1, int number2, int number3)   //int den itibaren nu satırdaki kısım imza
        {
            return number1 + number2 + number3;
        }

        static void MultiPly(params double[] sayilar) //parametre sayısı belli olmadan göndereceksen
        {
            double sonuc = 1;
            foreach (double sayi in sayilar)
            {
                sonuc *= sayi;
            }
            Console.WriteLine("Multiply: " + sonuc);
        }
        static void DisplayCagilAlsac() //geriye bir şey döndürmüzyoruz sadece bilgilendirme amaçlı//display
        {
            Console.WriteLine("Çağıl Alsaç");
        }

        static void DisplayName(string name, string surname)
        {
            Console.WriteLine(name + " " + surname);
        }

        static double GetPi() //geri dönüş
        {
            return Math.PI;
        }

    }
}
