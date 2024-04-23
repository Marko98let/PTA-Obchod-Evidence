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
    /// Interakční logika pro PridatOkno.xaml
    /// </summary>
    public partial class PridatOkno : Window
    {
        List<Zbozi> _zbozil;
        public PridatOkno(List <Zbozi> zbozilist)
        {
            _zbozil = zbozilist;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private int GetID() => _zbozil.Count + 1;

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string nazev = NazevT.Text;
            string pocet = PocetT.Text;
            string cena = CenaT.Text;

            Zbozi nove = new Zbozi("Jablko","Jedno",GetID(),"Dvacet Euro");
        }
    }
}
