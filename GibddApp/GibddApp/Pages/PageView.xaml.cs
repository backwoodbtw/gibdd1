using GibddApp.Classes;
using System.Data.SqlClient;
using System.Configuration;
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
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace GibddApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageView.xaml
    /// </summary>
    public partial class PageView : Page
    {
        private GIBDDDatabaseEntities context;


        public PageView()
        {
            InitializeComponent();
            context = new GIBDDDatabaseEntities();

        }
        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            // Здесь можно добавить код для поиска в базе данных
            // Пример: dataGrid.ItemsSource = SearchDataInDatabase(searchTextBox.Text);

            string searchText = searchTextBox.Text;

            var водители = context.Водители
            .Where(водитель => водитель.ФИО.Contains(searchText) ||
                               водитель.НомерВУ.Contains(searchText))
            .ToList();

            dataGridDrivers.ItemsSource = водители;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new GIBDDDatabaseEntities())  // Используйте свой класс-контекст
            {
                // Пример запроса - загрузить все записи из таблицы Водители
                var водители = context.Водители.ToList();
                var автомобили = context.Автомобили.ToList();

                // Привязать данные к элементу управления DataGrid
                dataGridDrivers.ItemsSource = водители;
                dataGridCars.ItemsSource = автомобили;
            }
            
        }
    }
}
