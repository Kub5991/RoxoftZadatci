using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil a = new Automobil();
            bool DaNe = false;

            while (!DaNe)
            {
                try
                {
                    Console.WriteLine("Unesi naziv automobila: ");
                    a.Naziv = Console.ReadLine();

                    Console.WriteLine("Unesi osnovnu cijenu automobila: ");
                    a.OsnovnaCijena = double.Parse(Console.ReadLine());

                    Console.WriteLine("Unesi godinu proizvodnje automobila: ");
                    int godinaProizvodnje = int.Parse(Console.ReadLine());
                    if (godinaProizvodnje <= DateTime.Now.Year)
                    {
                        a.NaPromjenuGodine += new Automobil.NaPromjenuGodineProizvodnjeDelegat(NaPromjenuGodine);
                        a.GodinaProizvodnje = godinaProizvodnje;
                        DaNe = true;
                    }
                    else
                        Console.WriteLine("Koristi program za " + (godinaProizvodnje- DateTime.Now.Year) + " god!!!");
 
                }
                catch (FormatException e)
                {
                    Console.WriteLine("--------Krivi unos!--------" + "\n{0}", e);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("Naziv automobila: " + a.Naziv);
            Console.WriteLine("Godina proizvodnje: " + a.GodinaProizvodnje);
            Console.WriteLine("Osnovna cijena: " + a.OsnovnaCijena);
            Console.WriteLine("Ukupna cijena vozila: " + a.UkupnaCijena());

            Console.ReadKey();

        }

        static void NaPromjenuGodine(object sender, EventArgs e)
        {
            Automobil a = (Automobil)sender;
            Console.WriteLine("--------Automobil--------");
            Console.WriteLine("Starost automobila je {0} god.", a.Starost());
        }
    }
}
