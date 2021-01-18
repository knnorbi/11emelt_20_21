using Microsoft.Win32;
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

namespace OOP_example
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

        private void save_btn_Click(object sender, RoutedEventArgs e)
        {
            if (student_cb.IsChecked == true)
            {
                people_lb.Items.Add(new Student(name_tb.Text));
            }
            else
            {
                people_lb.Items.Add(new Teacher(name_tb.Text));
            }
            name_tb.Text = string.Empty;
        }

        private void people_lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person selected = people_lb.SelectedItem as Person;

            if (selected == null)
            {
                return;
            }

            email_label.Content = selected.Email;
        }

        private void savefile_btn_Click(object sender, RoutedEventArgs e)
        {
            ISaveable selected = people_lb.SelectedItem as ISaveable;

            if (selected == null)
            {
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == true)
            {
                selected.Save(saveFileDialog.FileName);
            }
        }
    }
}
