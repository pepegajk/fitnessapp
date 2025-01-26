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
    /// Логика взаимодействия для DirectorNavigation.xaml
    /// </summary>
    public partial class DirectorNavigation : Window
    {
        public DirectorNavigation()
        {
            InitializeComponent();
        }

        private void ReportsButton_Click(object sender, RoutedEventArgs e)
        {
            // Открыть окно отчетов
            Reports reportsWindow = new Reports();
            reportsWindow.Show();
        }

        private void ScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            // Открыть окно расписания
            ClassSchedule scheduleWindow = new ClassSchedule();
            scheduleWindow.Show();
        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            // Открыть окно клиентов
            CustomerList clientsWindow = new CustomerList();
            clientsWindow.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Закрыть окно и выйти из приложения
            Application.Current.Shutdown();
        }
    }
}
