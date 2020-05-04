using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace morjanproject
{
    class Morjan
    {
        private string ville;
        private string nameEtrason;
        private List<emplayer> empleyrs = new List<emplayer>();
        private List<Morjan> morjanMaroc = new List<Morjan>();
        public string Ville { get { return ville; } }

        prduit pr = new prduit();
        public Morjan() { misejour(); }
        public Morjan(string ville, string nameEtrason) { this.ville = ville; this.nameEtrason = nameEtrason; }
        public void ajouter(string villes, string nameErason) { morjanMaroc.Add(new Morjan(villes,nameErason)); }
        public new string ToString() { return ville+";"+ nameEtrason; }
        public  string ToString(string city){ return ville ; }
 
        public void addprdot() {/*ADD PRODUCT--------------*/
            string name; int catg; float prix; uint Quantiti;  catg =int.Parse(choixcateg());
            Console.WriteLine("name of new product");name = Console.ReadLine();Console.WriteLine("entre prix of procut");
            prix = float.Parse(Console.ReadLine()); Console.WriteLine("how many items of the prduct");Quantiti = uint.Parse(Console.ReadLine());
            pr.ajouterproducui(new prduit(catg, name, prix, Quantiti, ville));
        }
        /**for categeria*//****i was here and i found some any probleme ******/
        public string choixcateg()
        {
            string chois;int choix; 
            start:
            Console.WriteLine("choisair from list categro de produit");
            Console.WriteLine("entrez N for Adding new produt");
            pr.afficheallproduit();
            chois =Console.ReadLine();
            var isNumeric = int.TryParse(chois, out choix);
            if (isNumeric)
            {
                try { pr.rtgategeurais(choix); }
                catch { Console.WriteLine("you out of the area please entre againe"); goto start; }
                return choix.ToString();
            }
            else { Console.WriteLine("entree new catogerei"); string name = Console.ReadLine();
                pr.addnewcategories(name); goto start; }

           
            
            
           
        
        }
        public void saveFile()/*Save all morjan in file*/
        {StreamWriter cc = new StreamWriter(@"C:\Users\barinale\Desktop\textmorjan.txt");
            foreach (Morjan rr in morjanMaroc) { cc.WriteLine(rr.ToString()); } cc.Close(); }

        public void misejour() {/*Mise joiur all morjan in file */
            StreamReader cc = new StreamReader(@"C:\Users\barinale\Desktop\textmorjan.txt"); string[] morjan;string line;
            while ((line = cc.ReadLine()) != null) { morjan = line.Split(';'); morjanMaroc.Add(new Morjan(morjan[0],morjan[1])); }
            cc.Close();
        }

        public void afficheall(string city)
        {/*Affiche all disponible morjan with just city name or with full name and city**/
            int i = 1;
            foreach (Morjan cc in morjanMaroc) { if (city != null) { Console.WriteLine(i+" : "+cc.ToString("city")); } 
            else { Console.WriteLine(cc.ToString()); }i++; }; } 
        /*return class by indeice*/
        public Morjan morjanIndec(int i) { return morjanMaroc[i]; }

    }
}