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

namespace Carros
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
        List<string> teste = new List<string>();
        private void Adicionar(object sender, RoutedEventArgs e)
        {
            //
            lstLista.Items.Add(string.Format(cboxCarro.Text + " " + cboxCor.Text + " " + cboxMotor.Text));

        }

       
    }
}
