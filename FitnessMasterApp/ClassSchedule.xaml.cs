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
    /// Логика взаимодействия для ClassSchedule.xaml
    /// </summary>
    public partial class ClassSchedule : Window
    {
        public ClassSchedule()
        {
            InitializeComponent();
            LoadSchedule();
            LoadFilters();
        }

        private void LoadSchedule()
        {
            // Заглушка для данных расписания
            ScheduleDataGrid.ItemsSource = new List<dynamic>
            {
                new { ClassID = 1, ClassName = "Йога", TrainerName = "Иван Иванов", RoomName = "Зал 1", ClassTime = "2025-01-30 10:00", ParticipantsCount = 10 },
                new { ClassID = 2, ClassName = "Плавание", TrainerName = "Мария Смирнова", RoomName = "Бассейн", ClassTime = "2025-01-30 12:00", ParticipantsCount = 8 }
            };
        }

        private void LoadFilters()
        {
            // Заглушка для фильтров
            TrainerFilter.ItemsSource = new List<string> { "Все", "Иван Иванов", "Мария Смирнова" };
            RoomFilter.ItemsSource = new List<string> { "Все", "Зал 1", "Бассейн" };
        }

        private void FilterScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Фильтр применен (пример)");
        }

        private void AddScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добавить занятие");
        }

        private void EditScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Изменить занятие");
        }

        private void DeleteScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Удалить занятие");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Возврат к окну директора
            DirectorNavigation directorNavigation = new DirectorNavigation();
            directorNavigation.Show();
            this.Close();
        }


    }
}
