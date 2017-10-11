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

        bool teste1 = false, teste2 = false;
        private void Somar(object sender, RoutedEventArgs e)
        {
            lblResultado.Text = $"{double.Parse(txtPrimeiro.Text) + double.Parse(txtSegundo.Text)}";
        }

        private void Teste1(object sender, TextChangedEventArgs e)
        {
            double t;
            teste1 = double.TryParse((sender as TextBox).Text, out t);
            Testar();
        }

        private void Testar()
        {
            btnSomar.IsEnabled = (teste1 && teste2);
        }

        private void Teste2(object sender, TextChangedEventArgs e)
        {
            double t;
            teste2 = double.TryParse((sender as TextBox).Text, out t);
            Testar();
        }
    }
}
