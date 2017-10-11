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

namespace SemNomeAinda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region construtor  
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        
        private void Somar(object sender, RoutedEventArgs e)
        {
            double numero1 = double.Parse(txtPrimeiro.Text), numero2 = double.Parse(txtSegundo.Text), resultado = numero1 + numero2;
            lblResultado.Text = $"{resultado}";
        }



        #region botão de limpar

        bool teste1 = false, teste2 = false;
        private void Teste1(object sender, TextChangedEventArgs e)
        {
            double t;
            teste1 = double.TryParse((sender as TextBox).Text, out t);
            Testar();
        }

       

        private void Teste2(object sender, TextChangedEventArgs e)
        {
            double t;
            teste2 = double.TryParse((sender as TextBox).Text, out t);
            Testar();
        }
        private void Testar()
        {
            btnSomar.IsEnabled = (teste1 && teste2);
        }
        #endregion
    }
}
