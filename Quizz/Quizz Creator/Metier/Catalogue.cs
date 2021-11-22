using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Catalogue
    {
        private static Catalogue catalogue = null;
        private List<Categorie> ListeCategorie;

        private Catalogue()
        {
            ListeCategorie = new List<Categorie>();
        }

        public static Catalogue Instance
        {
            get
            {
                if (catalogue == null)
                    catalogue = new Catalogue();
                return catalogue;
            }
        }

        public Categorie[] ListerCategories()
        {
            return ListeCategorie.ToArray();
        }

        public void AddCategorie(Categorie cat)
        {
            ListeCategorie.Add(cat);
        }
    }
}
