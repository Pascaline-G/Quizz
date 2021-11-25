using Metier;
using Microsoft.Win32;
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
    /// Logique d'interaction pour EditCategorie.xaml
    /// </summary>
    public partial class EditCategorie : Window
    {
        private Categorie categorie;    
        public EditCategorie(Categorie cat)
        {
            InitializeComponent();
            categorie = cat;
            TBNom.Text = cat.Nom;
            TBpathImage.Text = cat.IconPath;
        }

        private void parcourir(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                TBpathImage.Text = openFileDialog.FileName;
                ImageIcon.Source = new BitmapImage(fileUri);
            }
        }

        private void Valider(object sender, RoutedEventArgs e)
        {
            try
            {
                categorie.Nom = TBNom.Text;
                categorie.IconPath = TBpathImage.Text;
                DialogResult = true;
                Close();
            } catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }
    }
}
