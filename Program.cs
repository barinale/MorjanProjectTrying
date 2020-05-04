using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morjanproject
{
    class Program
    {
        static void Main(string[] args)
        {
            string nan; boss bb = new boss();
            do{
                bb.addbose();
                Console.WriteLine("************");
                bb.afficheall();
                nan = Console.ReadLine();
            }while(nan!="s");


            int choix; Morjan cc = new Morjan(); prduit pp = new prduit(); emplayer em = new emplayer();
           do
           {
               Console.WriteLine("Hello world Morjan Morroco \nChose From the Menu \n 1:Add New Morjan \n 2: gerer stock des produit"+
                   "\n 3:add employer");
            
                choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("where is new Morjan"); string name = Console.ReadLine();
                        Console.WriteLine("what is name of boss of this morjan"); string bos = Console.ReadLine();
                        cc.ajouter(name, bos); cc.saveFile();
                        break;
                    case 2: int i;
                        Console.WriteLine("choose any morjan from list ");
                        cc.afficheall("city");i = int.Parse(Console.ReadLine());
                        Morjan indecmr =cc.morjanIndec(i-1);indecmr.addprdot();pp.miseAjour();
                        pp.afficheall();
                        Console.ReadKey();break;
                        
                    case 3:
                        em.addemployer();
                        em.saveemployer();
                        break;
                    case 0: break;
                    default:
                        Console.WriteLine("youre wrong");
                        break;

                } Console.Clear();
            } while (choix != 0);
           
            Console.ReadKey();

        }
    }
}
