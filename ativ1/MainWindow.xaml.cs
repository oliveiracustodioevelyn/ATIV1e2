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

namespace ativ1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string usuario = TxtEmail.Text;
            string senha = TxtSenha.Password.ToString();
            if (usuario == "evelyncustodio321@gmail.com")
                MessageBox.Show("E-mail Válida", "Confirmação de Login", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            else
                MessageBox.Show("E-mail Inválido", "Confirmação de Login", MessageBoxButton.OKCancel, MessageBoxImage.Error);

            if (senha == "123")
                MessageBox.Show("Senha Válida", "Confirmação de Login", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            else
                MessageBox.Show("Senha Inválida", "Confirmação de Login", MessageBoxButton.OKCancel, MessageBoxImage.Error);

            TelaInicial tela = new TelaInicial();
            tela.ShowDialog();

            
        }



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}
