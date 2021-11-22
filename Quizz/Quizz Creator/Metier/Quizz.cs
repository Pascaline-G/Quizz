using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Quizz
    {
        private String nom; //Nom du quizz
        private String iconPath; //Chemin de l'icone du quizz
        private List<IQuestion> ListeQuestion;

        public String Nom { get; set; }
        public String IconPath { get; set; }
        public int GetNbQuestion()
        {
            return ListeQuestion.Count();
        }

        public Quizz(String name = "?", String path = "")
        {
            nom = name;
            iconPath = path;
            ListeQuestion = new List<IQuestion>();
        }

        public IQuestion[] ListerQuizz()
        {
            return ListeQuestion.ToArray();
        }

        public void AddQuizz(IQuestion quest)
        {
            ListeQuestion.Add(quest);
        }
    }
}
