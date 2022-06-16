//Ziyatdinov Kamil 220 group "Chess 4" 16.06.2022

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
                    MoveChessman(sender as Button);
                }
                else
                {
                    (sender as Button).Content = selectedChessman;
                    chessman = ChessmanMaker.MakeFigure(selectedChessman, (sender as Button).Name);
                }

                PouringCorrectMoves();
            }
        }

        private void MoveChessman(Button btn)
        {
            if (chessman.isRightMove(btn.Name))
            {
                ClearField();
                chessman.Move(btn.Name);
                btn.Content = selectedChessman;
            }
            else
            {
                MessageBox.Show("Incorrect move!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
        }

        private void PouringCorrectMoves()
        {
            foreach (UIElement el in Chess.Children)
            {
                if (el is Button)
                {
                    if ((el as Button).Name != "btnClear" 
                        && chessman.isRightMove((el as Button).Name))
                    {
                        (el as Button).Background = Brushes.Green;
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
                    ClearButton(el as Button);
                }
            }
        }
        private void ClearButton(Button btn)
        {
            if (btn.Name != btnClear.Name)
            {
                if ((btn.Name[0] + btn.Name[1]) % 2 == 0)
                {
                    btn.Background = Brushes.Black;
                }
                else
                {
                    btn.Background = Brushes.White;
                }

                btn.Content = "";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearField();
        }
    }
}
