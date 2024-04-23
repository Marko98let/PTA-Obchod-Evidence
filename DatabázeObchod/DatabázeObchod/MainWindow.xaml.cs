using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DatabázeObchod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Zbozi> zbozilist {  get; set; }
        public MainWindow()
        {
            zbozilist = new();
            InitializeComponent();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            PridatOkno dialog = new(zbozilist);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();
        }
        private void Dialog_Closing(object? sender, EventArgs e)
        {
            seznam.ItemsSource = null;
            seznam.ItemsSource = zbozilist;
        }

        private void EDIT_Click(object sender, RoutedEventArgs e)
        {
            EditovatOkno editovatOkno = new EditovatOkno();
            Zbozi? hledany = seznam?.SelectedItem as Zbozi;

            if (hledany != null)
            {
                editovatOkno.Closing += Dialog_Closing;
            }
        }

        private void DEL_Click(object sender, RoutedEventArgs e)
        {
            if (seznam.SelectedItem != null)
            {
                seznam.Items.RemoveAt
                (seznam.Items.IndexOf(seznam.SelectedItem));
            }

        }

        private void SHOW_Click(object sender, RoutedEventArgs e)
        {
            Zbozi? info = seznam?.SelectedItem as Zbozi ?? new Zbozi ("","",-1,"");
            MessageBox.Show($"{info.Nazev} {info.Pocet} {info.Cena}");
        }
    }
}