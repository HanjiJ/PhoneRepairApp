using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PhoneRepairApp
{
    public partial class RepairOrdersForm : Page
    {
        RemontPhoneEntities db;
        public RepairOrdersForm()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            db = new RemontPhoneEntities();
            repairOrdersDataGrid.ItemsSource = db.repair_orders.ToList();
        }

        private void SaveChangesButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                db.SaveChanges();
                MessageBox.Show("Изменения успешно сохранены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
            }
        }
    }
}
