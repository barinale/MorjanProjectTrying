using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace morjanproject
{
    class prduit 
    {
        private string name, morjanName, categorie;
        private float prix;
        private uint Qauntiti;
        
       private List<string > categories = new List<string>();
        private static List<prduit> products = new List<prduit>();


        public prduit() { categories.Add("informatique"); categories.Add("Food"); categories.Add("kitchen"); }
        public prduit(int x,string name, float prix, uint qauntiti, string morjanname) {
            this.categorie = rtgategeurais(x); ; this.name = name; this.prix = prix; this.Qauntiti = qauntiti; this.morjanName = morjanname;
        }

        public new string ToString() { return categories +";"+name + ";" + prix + ";" + Qauntiti + ";" + morjanName; }

        public void ajouterproducui(prduit cc) { products.Add(cc); }
        public void afficheall() { foreach (prduit pc in products) { Console.WriteLine(pc.ToString()); } }
        public void miseAjour() { StreamWriter cc = new StreamWriter(@"C:\Users\barinale\Desktop\textproduit.txt", true); 
            foreach (prduit rr in products) { cc.WriteLine(rr.ToString());} cc.Close();}

        public void addnewcategories(string name) { categories.Add(name); }public string rtgategeurais(int n) { return categories[n-1]; }
        public void afficheallproduit() { int i = 0; foreach (string name in categories) { Console.WriteLine("{0} : {1}", i, name); i++; } }



        


    }
    
}
