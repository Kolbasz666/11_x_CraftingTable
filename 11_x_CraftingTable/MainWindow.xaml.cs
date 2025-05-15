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

namespace _11_x_CraftingTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] ActiveMatrix = new int[3, 3];
        public MainWindow()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            Everything.Background = new SolidColorBrush(Color.FromRgb(198, 198, 198));
            Result.Background = new SolidColorBrush(Color.FromRgb(139, 139, 139));
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Border oneBorder = new Border() { Padding = new Thickness(2), Background = new SolidColorBrush(Color.FromRgb(198,198,198)) };
                    Label oneLabel = new Label() { VerticalContentAlignment = VerticalAlignment.Center, HorizontalContentAlignment = HorizontalAlignment.Center, Tag = new Item() { row = j, col = i, colorNumber = 0}, Background = new SolidColorBrush(Color.FromRgb(139,139,139)) };
                    Grid.SetColumn(oneBorder, i);
                    Grid.SetRow(oneBorder, j);
                    oneBorder.Child = oneLabel;
                    Kolbasz.Children.Add(oneBorder);
                    oneLabel.MouseLeftButtonUp += LeftClick;
                    oneLabel.MouseRightButtonUp += RightClick;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Border oneBorder = new Border() { Padding = new Thickness(2), Background = new SolidColorBrush(Color.FromRgb(198, 198, 198)) };
                    Label oneLabel = new Label() { VerticalContentAlignment = VerticalAlignment.Center, HorizontalContentAlignment = HorizontalAlignment.Center, Tag = new Item() { row = j, col = i, colorNumber = 0 }, Background = new SolidColorBrush(Color.FromRgb(139, 139, 139)) };
                    Grid.SetColumn(oneBorder, i);
                    Grid.SetRow(oneBorder, j);
                    oneBorder.Child = oneLabel;
                    Inventory.Children.Add(oneBorder);
                    oneLabel.MouseLeftButtonUp += LeftClick;
                    oneLabel.MouseRightButtonUp += RightClick;
                }
            }
        }
        void RightClick(object sender, EventArgs e) {
            Label oneLabel = sender as Label;
            Item oneItem = oneLabel.Tag as Item;
            oneItem.colorNumber = 0;
            oneLabel.Background = new SolidColorBrush(Colors.White);
        }
        void LeftClick(object sender, EventArgs e)
        {
            Label oneLabel = sender as Label;
            //int number = int.Parse(oneLabel.Tag.ToString());
            Item oneItem = oneLabel.Tag as Item;
            oneItem.colorNumber++;
            if (oneItem.colorNumber == 1)
                oneLabel.Background = new SolidColorBrush(Colors.Gray);
            else if (oneItem.colorNumber == 2)
                oneLabel.Background = new SolidColorBrush(Colors.Brown);
            else if (oneItem.colorNumber == 3)
                oneLabel.Background = new SolidColorBrush(Colors.Gold);
            else if (oneItem.colorNumber == 4)
                oneLabel.Background = new SolidColorBrush(Colors.Aqua);
            else if (oneItem.colorNumber == 5)
            {
                oneLabel.Background = new SolidColorBrush(Colors.White);
                oneItem.colorNumber = 0;
            }

            ActiveMatrix[oneItem.row, oneItem.col] = oneItem.colorNumber;
        }

        void EventAmivelKiertekeljukAMatrixot(object sender, KeyEventArgs args)
        {
            if (args.Key == Key.Enter)
            {

            }
        }
    }
}
