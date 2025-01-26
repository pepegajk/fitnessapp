using System.Windows;

namespace FitnessMasterApp
{
    public partial class TrainerDashboard : Window
    {
        public TrainerDashboard()
        {
            InitializeComponent();
        }

        private void ScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход в окно "Расписание"
            ClassSchedule scheduleWindow = new ClassSchedule();
            scheduleWindow.Show();
            this.Close();
        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход в окно "Клиенты"
            CustomerList customerList = new CustomerList();
            customerList.Show();
            this.Close();
        }
    }
}