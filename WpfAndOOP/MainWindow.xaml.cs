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

namespace WpfAndOOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            aTb.Text = string.Empty;
            bTb.Text = string.Empty;
            cTb.Text = string.Empty;
        }

        private void newBtn_Click(object sender, RoutedEventArgs e)
        {
            //List<int> lista = new List<int>();
            //lista.Add(2);
            //lista.Add(5);
            //lista.Add(324);
            //Console.WriteLine(lista[2]);
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.WriteLine(lista[i]);
            //}
            //lista.RemoveAt(1);

            lb.Items.Add(new Triangle(1,1,1));
        }

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Triangle triangle = lb.Items[lb.SelectedIndex] as Triangle;

            aTb.Text = triangle.A.ToString();
            bTb.Text = triangle.B.ToString();
            cTb.Text = triangle.C.ToString();

        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            Triangle triangle = lb.Items[lb.SelectedIndex] as Triangle;

            triangle.A = int.Parse(aTb.Text);
            triangle.B = int.Parse(bTb.Text);
            triangle.C = int.Parse(cTb.Text);
            lb.Items.Refresh();
        }
    }
}
