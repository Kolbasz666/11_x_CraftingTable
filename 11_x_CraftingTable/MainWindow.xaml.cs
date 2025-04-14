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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Border oneBorder = new Border() { Padding = new Thickness(5), Background = new SolidColorBrush(Colors.Brown) };
                    Label oneLabel = new Label() { VerticalContentAlignment = VerticalAlignment.Center, HorizontalContentAlignment = HorizontalAlignment.Center, Tag = new Item() { row = j, col = i, colorNumber = 0}, Background = new SolidColorBrush(Colors.AliceBlue) };
                    Grid.SetColumn(oneBorder, i);
                    Grid.SetRow(oneBorder, j);
                    oneBorder.Child = oneLabel;
                    Kolbasz.Children.Add(oneBorder);
                    oneLabel.MouseLeftButtonUp += LeftClick;
                    oneLabel.MouseRightButtonUp += RightClick;
                }
            }
        }
        void RightClick(object sender, EventArgs e) {
            Label oneLabel = sender as Label;
            oneLabel.Tag = 0;
            oneLabel.Background = new SolidColorBrush(Colors.White);
        }
        void LeftClick(object sender, EventArgs e)
        {
            Label oneLabel = sender as Label;
            int number = int.Parse(oneLabel.Tag.ToString());
            number++;
            oneLabel.Tag = number;
            if (number == 1)
                oneLabel.Background = new SolidColorBrush(Colors.Gray);
            else if (number == 2)
                oneLabel.Background = new SolidColorBrush(Colors.Brown);
            else if (number == 3)
                oneLabel.Background = new SolidColorBrush(Colors.Gold);
            else if (number == 4)
                oneLabel.Background = new SolidColorBrush(Colors.Aqua);
            else if (number == 5)
            {
                oneLabel.Background = new SolidColorBrush(Colors.White);
                oneLabel.Tag = 0;
            }

        }
    }
}
