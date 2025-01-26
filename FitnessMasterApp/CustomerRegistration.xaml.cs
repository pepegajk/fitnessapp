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
using System.Windows.Shapes;

namespace FitnessMasterApp
{
    /// <summary>
    /// Логика взаимодействия для CustomerRegistration.xaml
    /// </summary>
    public partial class CustomerRegistration : Window
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string familia = familiaTextBox.Text;
            string othcestvo = othcestvoTextBox.Text;
            string login = LoginTextBox.Text;
            string password = PasswordBox.Password;
            

            // Пример проверки данных
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Здесь логика сохранения данных (например, в базу данных)
            MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

            // Возврат на экран авторизации
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход назад к авторизации
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }

       
    }
}
