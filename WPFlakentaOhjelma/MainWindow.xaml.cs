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

namespace WPFlakentaOhjelma
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double luku1 = Double.Parse(textBox_1.Text);
            double luku2 = Double.Parse(textBox_2.Text);

            Laskenta laske = new Laskenta();
            double tulos = laske.YhteenLasku(luku1, luku2);
            
            textBox_tulos.Text = tulos.ToString();
        }
    }
}
