using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviZadatak
{
    class Automobil
    {
        public delegate void NaPromjenuGodineProizvodnjeDelegat(object sender, EventArgs e);
        public event NaPromjenuGodineProizvodnjeDelegat NaPromjenuGodine;
        
        public string Naziv { get; set; }
        public double OsnovnaCijena { get; set; }

        private int godinaProizvodnje = 0;
        public int GodinaProizvodnje
        {
            get
            {
                return godinaProizvodnje;
            }
            set
            {
                godinaProizvodnje = value;
                if(NaPromjenuGodine!=null)
                {
                    NaPromjenuGodine(this, new EventArgs());
                }
            }
        }
               
        public int Starost()
        {
            return (DateTime.Now.Year - GodinaProizvodnje);
        }

        public double UkupnaCijena()
        {
            if (OsnovnaCijena <= 70000)
            {
                return OsnovnaCijena * 1.3;
            }
            else if (OsnovnaCijena > 70000 && OsnovnaCijena < 100000)
            {
                return OsnovnaCijena * 1.4;
            }
            else
                return OsnovnaCijena * 1.5;
        }
                       
    }
}
