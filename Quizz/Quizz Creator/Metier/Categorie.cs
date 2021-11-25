using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Categorie
    {
        private String nom; //Nom de la catégorie
        private String iconPath; //Chemin de l'icone de la catégorie
        private List<Quizz> ListeQuizz;

        public String Nom{ get; set; }
        public String IconPath { get; set; }
        public int GetNbQuizz()
        {
            return ListeQuizz.Count();
        }

        public Categorie(String name = "?", String path = "Images/Icones/default.png")
        {
            Nom = name;
            IconPath = path;
            ListeQuizz = new List<Quizz>();
        }

        public Quizz[] ListerQuizz()
        {
            return ListeQuizz.ToArray();
        }

        public void AddQuizz(Quizz quizz)
        {
            foreach(Quizz q in ListeQuizz)
            {
                if(q.Nom == quizz.Nom)
                {
                    throw new Exception("Nom déjà utilisé. Veuillez en choisir un autre");
                }
            }
            ListeQuizz.Add(quizz);
        }

        public void RemoveQuizz(Quizz quizz)
        {
            ListeQuizz.Remove(quizz);
        }

    }
}
