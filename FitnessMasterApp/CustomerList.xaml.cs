using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace FitnessMasterApp
{
    public partial class CustomerList : Window
    {
        public CustomerList()
        {
            InitializeComponent();
            LoadClients();
        }

        private List<dynamic> clientsData;

        private void LoadClients()
        {
            // Заглушка для данных клиентов
            clientsData = new List<dynamic>
            {
                new { ClientID = 1, FullName = "Иван Иванов", BirthDate = "1990-01-01", Phone = "+79991112233", Email = "ivanov@mail.com", MembershipType = "Месячный", MembershipStatus = "Активен", GroupID = 101 },
                new { ClientID = 2, FullName = "Мария Смирнова", BirthDate = "1985-06-15", Phone = "+79992223344", Email = "smirnova@mail.com", MembershipType = "Годовой", MembershipStatus = "Истек", GroupID = 102 }
            };

            // Устанавливаем данные в DataGrid
            ClientsDataGrid.ItemsSource = clientsData;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = SearchTextBox.Text.ToLower();

            // Фильтрация данных по совпадению с любым полем
            var filteredData = clientsData.Where(client =>
                client.FullName.ToLower().Contains(searchQuery) ||
                client.Phone.ToLower().Contains(searchQuery) ||
                client.Email.ToLower().Contains(searchQuery) ||
                client.MembershipType.ToLower().Contains(searchQuery) ||
                client.MembershipStatus.ToLower().Contains(searchQuery)).ToList();

            ClientsDataGrid.ItemsSource = filteredData;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClientsDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Выберите клиента для редактирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Логика для редактирования клиента (заглушка)
            MessageBox.Show("Редактирование клиента (пример).", "Редактирование", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ClientsDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Выберите клиента для удаления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Удаление выбранного клиента
            var selectedClient = (dynamic)ClientsDataGrid.SelectedItem;
            clientsData.Remove(selectedClient);

            // Обновляем источник данных
            ClientsDataGrid.ItemsSource = clientsData.ToList();
            MessageBox.Show("Клиент удален.", "Удаление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Возврат в окно директора
            DirectorNavigation directorNavigation = new DirectorNavigation();
            directorNavigation.Show();
            this.Close();
        }
    }
}