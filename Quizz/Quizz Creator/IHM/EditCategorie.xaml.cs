﻿using Metier;
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
        public EditCategorie(Categorie Cat)
        {
            InitializeComponent();
        }
    }
}
