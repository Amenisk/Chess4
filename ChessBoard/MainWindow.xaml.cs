using ChessCore;
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
        Chessman chessman;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Chessmans_Selected(object sender, RoutedEventArgs e)
        {
            selectedChessman = ((sender as ListBox).SelectedItem as ListBoxItem).Name;
            chessman = null;
            ClearField();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (selectedChessman != null)
            {
                if (chessman != null)
                {
                    if (chessman.isRightMove((sender as Button).Name))
                    {
                        ClearField();
                        chessman.Move((sender as Button).Name);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect move!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                }
                else
                {
                    chessman = ChessmanMaker.MakeFigure(selectedChessman, (sender as Button).Name);
                }

                (sender as Button).Content = selectedChessman;

                foreach (UIElement el in Chess.Children)
                {
                    if (el is Button)
                    {
                        if(chessman.isRightMove((el as Button).Name))
                        {
                            (el as Button).Background = Brushes.Green;
                        }
                    }
                }
            }
        }

        private void ClearField()
        {
            foreach (UIElement el in Chess.Children)
            {
                if (el is Button)
                {
                    if (((el as Button).Name[0] + (el as Button).Name[1]) % 2 == 0)
                    {
                        (el as Button).Background = Brushes.Black;
                    }
                    else
                    {
                        (el as Button).Background = Brushes.White;
                    }

                    (el as Button).Content = "";
                }
            }
        }                                                                   
    }
}
