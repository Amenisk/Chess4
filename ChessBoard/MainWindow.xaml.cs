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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChessBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string selectedChessman;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Chessmans_Selected(object sender, RoutedEventArgs e)
        {
            selectedChessman = ((sender as ListBox).SelectedItem as ListBoxItem).Name; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (selectedChessman != null)
            {
                (sender as Button).Content = selectedChessman;
            }
        }
    }
}
