using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IHM
{
    /// <summary>
    /// Logique d'interaction pour CreationQuizz.xaml
    /// </summary>
    public partial class CreationQuizz : Window
    {
        public CreationQuizz()
        {
            InitializeComponent();

        }

        private void AjCategorie(object sender, RoutedEventArgs e)
        {
            try
            {
                Categorie newCat = new Categorie();
                EditCategorie third = new EditCategorie(newCat);
                if (third.ShowDialog() == true)
                {
                    Catalogue.Instance.AddCategorie(newCat);
                    DrawCat();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void DrawCat()
        {
            var list = Catalogue.Instance.ListerCategories();
            LBCat.Items.Clear();
            foreach (var item in list)
                LBCat.Items.Add(item);
        }
    }
}
