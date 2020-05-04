using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace morjanproject
{
    class emplayer
    {
        protected static uint countempleyer =0;/*for counting how empleyer is regist and for giving employer id*/
        protected string name;
        protected string lastname;
        protected uint ID;
        protected int salire;
        protected DateTime dateEntrez;
        private Morjan morjan= new Morjan();
        protected string nameMorjan;
        protected DateTime brithday;
        private List<emplayer> employers = new List<emplayer>();

        public emplayer() { miseour(); }
        public emplayer(string name, string lastname,DateTime brithday,int salire,string nameville) {
            this.name = name; this.lastname = lastname; countempleyer++; this.ID = countempleyer; this.brithday = brithday; this.dateEntrez = DateTime.Now;
            this.salire = salire; this.nameMorjan = nameville;
        }
        /*for mise a jour from file and create employer from file*/
        public emplayer(string name, string lastname, DateTime brithday, int salire, DateTime daternte,string nameVille) {
            this.name = name; this.lastname = lastname; countempleyer++; this.ID = countempleyer; this.brithday = brithday; this.dateEntrez = daternte;
            this.salire = salire; this.nameMorjan = nameVille;
        }

        
        /*add employer**/
        public void addemployer()
        {
            string nname, llastname; int ssalire; string name; DateTime br; Console.WriteLine("please entre morjan city that you want to add employer to them");
            begin: morjan.afficheall("city"); int w = int.Parse(Console.ReadLine()); try { name = morjan.morjanIndec(w).Ville; }
            catch { Console.WriteLine("you out of the range try againe"); goto begin; }
            Console.WriteLine("entrez name"); nname =Console.ReadLine();
        Console.WriteLine("entrez your lastname"); llastname = Console.ReadLine(); Console.WriteLine("Salaire"); ssalire = int.Parse(Console.ReadLine());
        Console.WriteLine("entree year brithday"); int year = int.Parse(Console.ReadLine()); Console.WriteLine("entrez mounth"); int mounth = int.Parse(Console.ReadLine());
        Console.WriteLine("entrez day"); int day = int.Parse(Console.ReadLine()); 
            br = new DateTime(year,mounth,day);
        employers.Add(new emplayer(nname, llastname, br, ssalire,name));}

        public void saveemployer() { StreamWriter aa = new StreamWriter(@"C:\Users\barinale\Desktop\employer.txt");
        foreach (emplayer nn in employers) { aa.WriteLine(nn.ToString()); }
        aa.Close();
        }
        public void miseour(){
            StreamReader aa = new StreamReader(@"C:\Users\barinale\Desktop\employer.txt");
            string line; string[] mot;
            while ((line = aa.ReadLine()) != null) {
                string[] date1, date2; mot = line.Split(';'); date1 = mot[7].Split('/'); date2 = mot[4].Split('/');
                employers.Add(new emplayer(mot[0], mot[1], new DateTime(int.Parse(date1[2]), int.Parse(date1[0]), int.Parse(date1[1])),
                    int.Parse(mot[3]), new DateTime(int.Parse(date2[2]), int.Parse(date2[0]), int.Parse(date2[1])), mot[6]));
            }
            aa.Close();
        }

        /*calcule age */
        public int calculeage()
        {
            int age; age = DateTime.Now.Year - brithday.Year;
            if (brithday.DayOfYear > DateTime.Now.DayOfYear) age = age - 1; return age;
        }

        public new string ToString()
        {
            return /*name*/ name +  /*lastname :*/ ";" + lastname + /* ID : */ ";" + ID + /* salire */";" + salire +  /*DateEntrez*/";" + dateEntrez.ToString("MM/dd/yyyy")
                + /* age */";" + calculeage() + /* Cityof Morjan */";" + nameMorjan +/*datebrithday*/";" + brithday.ToString("MM/dd/yyyy");
        }
        
    }


}
