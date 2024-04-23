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

namespace DatabázeObchod
{
    /// <summary>
    /// Interakční logika pro EditovatOkno.xaml
    /// </summary>
    public partial class EditovatOkno : Window
    {
        public Zbozi Z { get; set; }
        public EditovatOkno()
        {
            Z = Z;
            InitializeComponent();
            DataContext = Z;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Uloz_Click(object sender, RoutedEventArgs e)
        {
            Z.Nazev = NovyNazev.Text;
            Z.Pocet = NovyPocet.Text;
            Z.Cena = NovaCena.Text;
            this.Close();
        }
    }
}
