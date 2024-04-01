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

namespace PhoneRepairApp
{
    public partial class MainWindow : Window
    {
        RemontPhoneEntities db = new RemontPhoneEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl)
            {
                TabItem selectedTab = e.AddedItems[0] as TabItem;
                switch (selectedTab.Header.ToString())
                {
                    case "Специалисты":
                        SpecialistsFrame.Source = new System.Uri("SpecialistsForm.xaml", System.UriKind.Relative);
                        break;
                    case "Модели телефонов":
                        PhoneModelsFrame.Source = new System.Uri("PhoneModelsForm.xaml", System.UriKind.Relative);
                        break;
                    case "Заказы на ремонт":
                        RepairOrdersFrame.Source = new System.Uri("RepairOrdersForm.xaml", System.UriKind.Relative);
                        break;
                }
            }
        }

       
    }
}
