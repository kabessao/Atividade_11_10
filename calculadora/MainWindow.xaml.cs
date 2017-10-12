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
        #region Construtor


        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion


        #region Operação
        /// <summary>
        /// Pega o texto dentro do botão para saber qual operação matematica usar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        #endregion

        #region Botão de Igual
        private void Igual(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtValor1.Text))
            {
                txtValor2.Text = VerOpção(txtValor1.Text);
                txtValor1.Text = "";
            }
        }
        #endregion

        #region Numeros
        private void Numero(object sender, RoutedEventArgs e)
        {
            if (txtValor2.Text.Length == 25)
                return;
            if (txtValor2.Text != "0")
                txtValor2.Text += (sender as Button).Content.ToString();
            else
                txtValor2.Text = (sender as Button).Content.ToString();


        }
        #endregion

        #region Função VerOpção
        private string VerOpção(string op)
        {
            string opcao = "0";

            if (op.Length >= 3)
                opcao = op.Substring(op.Length - 1);

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
                if (valor1 != 0 || valor2 != 0)
                {
                    return $"{valor1 / valor2}";
                }
            }

            return "0";

        }
        #endregion

        #region LimparTudo
        private void LimparTudo(object sender, RoutedEventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "0";
            //limpar tudo
        }
        #endregion

        #region Apagar
        private void Apagar(object sender, RoutedEventArgs e)
        {
            if (txtValor2.Text == "" && txtValor1.Text != "")
            {
                txtValor2.Text = txtValor1.Text.Remove(txtValor1.Text.Length - 2);
                txtValor1.Text = "";
            }
            else if (txtValor2.Text != "")
            {
                txtValor2.Text = txtValor2.Text.Substring(0, txtValor2.Text.Length - 1);
            }

            //Apagar
        }
        #endregion

        #region Trocar Mais ou Menos
        private void MaisOuMenos(object sender, RoutedEventArgs e)
        {
            if (txtValor2.Text.IndexOf('-') == -1)
            {
                txtValor2.Text = "-" + txtValor2.Text;
            }
            else if (txtValor2.Text.IndexOf('-') > -1)
            {
                txtValor2.Text = txtValor2.Text.Substring(1);
            }
            //mais ou menos
        }
        #endregion

        #region Adicionar ponto
        private void Ponto(object sender, RoutedEventArgs e)
        {
            if (txtValor2.Text.IndexOf('.') == -1)
                txtValor2.Text += ".";
            //ponto
        }
        #endregion

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            txtTeste.Text = e.Key.ToString();
        }
    }
}
