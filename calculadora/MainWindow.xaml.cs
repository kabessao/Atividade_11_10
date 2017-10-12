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

namespace calculadora
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

        private void Operacao(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValor1.Text))
            {
                txtValor1.Text = txtValor2.Text + " " + (sender as Button).Content.ToString();
                txtValor2.Text = "0";
            }
            else if (txtValor2.Text != "0")
            {
                txtValor1.Text = VerOpção(txtValor1.Text) + " " + (sender as Button).Content.ToString();
                txtValor2.Text = "0";
            }

            if (!string.IsNullOrWhiteSpace(txtValor2.Text))
            {
                txtValor1.Text = txtValor1.Text.Remove(txtValor1.Text.Length - 1) + (sender as Button).Content.ToString();
            }

        }

        private void Igual(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtValor1.Text))
            {
                txtValor2.Text = VerOpção(txtValor1.Text);
                txtValor1.Text = "";
            }
        }

        private void Numero(object sender, RoutedEventArgs e)
        {
            if (txtValor2.Text != "0")
                txtValor2.Text += (sender as Button).Content.ToString();
            else
                txtValor2.Text = (sender as Button).Content.ToString();
        }

        private string VerOpção(string op)
        {

            string opcao = op.Substring(op.Length - 1);
            double valor1 = double.Parse(txtValor1.Text.ToString().Substring(0, txtValor1.Text.Length - 1)),
                valor2 = double.Parse(txtValor2.Text);
            if (op.IndexOf('+') > 0)
            {
                return $"{valor1 + valor2}";
            }
            else if (op.IndexOf('-') > 0)
            {
                return $"{valor1 - valor2}";
            }
            else if (op.IndexOf('x') > 0)
            {
                return $"{valor1 * valor2}";
            }
            else if (op.IndexOf('/') > 0)
            {
                if (valor1 != 0 && valor2 != 0)
                {
                    return $"{valor1 / valor2}";
                }
            }

            return "0";

        }
    }
}
