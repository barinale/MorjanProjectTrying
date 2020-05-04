using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morjanproject
{
    sealed class boss : emplayer
    {
        private static int percentage;
        private int perctnagebos;
        private List<boss> bosses = new List<boss>();
        public boss() { }
        public boss(string name, string lastname, DateTime brithday,  int percentage) {
            base.name = name; base.lastname = lastname; base.ID = countempleyer; base.brithday = brithday; base.dateEntrez = DateTime.Now;
            base.salire = salire; emplayer.countempleyer++;
            this.perctnagebos = percentage;  }
        public void addbose() {
            Console.WriteLine("please your name"); string name = Console.ReadLine(); Console.WriteLine("please your last name"); string lastname = Console.ReadLine();
            Console.WriteLine("Please Date Briday Year"); int year = int.Parse(Console.ReadLine()); Console.WriteLine("please dat brithday Mounth"); int mouth = int.Parse(Console.ReadLine());
            Console.WriteLine("day of brithday"); int day = int.Parse(Console.ReadLine()); int per;
            do { Console.WriteLine(" still desponible is {0}% how you take", boss.percentage - 100); per = int.Parse(Console.ReadLine());
            } while (per > 100 -boss.percentage  || per < 0); boss.percentage += per;

            bosses.Add(new boss(name,lastname,new DateTime(year,mouth,day),per));
        }
        public void afficheall() { foreach (boss ss in bosses) {Console.WriteLine(ss.ToString()); } }






        

      
    }
}
