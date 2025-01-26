using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using OfficeOpenXml;

namespace FitnessMasterApp
{
    public partial class Reports : Window
    {
        public Reports()
        {
            InitializeComponent();
            LoadReports();
        }

        private void LoadReports()
        {
            // Заглушка для данных отчетов
            ReportsDataGrid.ItemsSource = new List<dynamic>
            {
                new { ReportID = 1, ReportName = "Иван Иванов", CreationDate = "2025-01-10", ReportType = "Абонемент", sumrep = 1000 },
                new { ReportID = 2, ReportName = "Мария Смирнова", CreationDate = "2025-01-11", ReportType = "Разовое посещение", sumrep = 500 }
            };
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Создаем диалог сохранения файла
                Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Сохранить отчет"
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    string filePath = saveFileDialog.FileName;

                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Reports");

                        // Записываем заголовки
                        worksheet.Cells[1, 1].Value = "Номер отчета";
                        worksheet.Cells[1, 2].Value = "ФИО клиента";
                        worksheet.Cells[1, 3].Value = "Дата продажи";
                        worksheet.Cells[1, 4].Value = "Тип продажи";
                        worksheet.Cells[1, 5].Value = "Сумма продажи";

                        // Записываем данные
                        var items = (dynamic)ReportsDataGrid.ItemsSource;
                        int row = 2;
                        foreach (var item in items)
                        {
                            worksheet.Cells[row, 1].Value = item.ReportID;
                            worksheet.Cells[row, 2].Value = item.ReportName;
                            worksheet.Cells[row, 3].Value = item.CreationDate;
                            worksheet.Cells[row, 4].Value = item.ReportType;
                            worksheet.Cells[row, 5].Value = item.sumrep;
                            row++;
                        }

                        // Сохраняем файл
                        File.WriteAllBytes(filePath, package.GetAsByteArray());
                        MessageBox.Show("Данные успешно экспортированы в Excel!", "Экспорт", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Открываем диалог выбора файла
                Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Загрузить отчет"
                };

                if (openFileDialog.ShowDialog() == true)
                {
                    string filePath = openFileDialog.FileName;
                    var importedData = new List<dynamic>();

                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        var worksheet = package.Workbook.Worksheets[0];
                        int row = 2; // Начинаем с 2-й строки (первая — заголовки)

                        
                        while (worksheet.Cells[row, 1].Value != null)
                        {
                            importedData.Add(new
                            {
                                ReportID = int.Parse(worksheet.Cells[row, 1].Text),
                                ReportName = worksheet.Cells[row, 2].Text,
                                CreationDate = worksheet.Cells[row, 3].Text,
                                ReportType = worksheet.Cells[row, 4].Text,
                                sumrep = decimal.Parse(worksheet.Cells[row, 5].Text)
                            });
                            row++;
                        }
                    }

                    // Обновляем источник данных
                    ReportsDataGrid.ItemsSource = importedData;
                    MessageBox.Show("Данные успешно загружены из файла Excel!", "Импорт", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка импорта: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Возврат в окно навигации директора
            DirectorNavigation directorNavigation = new DirectorNavigation();
            directorNavigation.Show();
            this.Close();
        }

        private void FilterReportsButton_Click(object sender, RoutedEventArgs e)
        {
            // Пример фильтрации: показать только отчеты с суммой больше 500
            var originalData = new List<dynamic>
            {
                new { ReportID = 1, ReportName = "Иван Иванов", CreationDate = "2025-01-10", ReportType = "Абонемент", sumrep = 1000 },
                new { ReportID = 2, ReportName = "Мария Смирнова", CreationDate = "2025-01-11", ReportType = "Разовое посещение", sumrep = 500 }
            };

            // Применить фильтр
            var filteredData = originalData.Where(report => report.sumrep > 500).ToList();
            ReportsDataGrid.ItemsSource = filteredData;

            MessageBox.Show("Фильтр применен: только отчеты с суммой больше 500.", "Фильтрация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}