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

namespace Bevasarlolista
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int counter = 0;

        void Add(object sender, RoutedEventArgs e)
        {
            if (TB_input.Text == "")
            {
                MessageBox.Show("Üres a termék helye, butus :p");
            }
            else
            {
                LB_bevásárló.Items.Add(TB_input.Text);
                TB_input.Text = "";
                counter++;
                L_itemcount.Content = "Tárgyak száma: " + counter;

            }
        }
        void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
             if (e.Key == Key.Return)
             {
                if (TB_input.Text == "")
                {
                    MessageBox.Show("Üres a termék helye, butus :p");
                }
                else
                {
                    LB_bevásárló.Items.Add(TB_input.Text);
                    TB_input.Text = "";
                    counter++;
                    L_itemcount.Content = "Tárgyak száma: "+ counter;

                }
            }
        }

        private void KILL(object sender, RoutedEventArgs e)
        {
            if (LB_bevásárló.SelectedItem != null)
            {
                string target = LB_bevásárló.SelectedItem.ToString();

                LB_bevásárló.Items.Remove(LB_bevásárló.SelectedItem);
                counter--;
                L_itemcount.Content = "Tárgyak száma: " + counter;

            }
            else
            {
                MessageBox.Show("Jelölj ki valamit, butus :p");
            }
        }

        private void Murder(object sender, RoutedEventArgs e)
        {
            LB_bevásárló.Items.Clear();
            counter = 0;
            L_itemcount.Content = "Tárgyak száma: " + counter;

        }
    }

}