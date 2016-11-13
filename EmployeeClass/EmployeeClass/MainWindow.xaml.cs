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

namespace EmployeeClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new Employee();
            DataContext = vm;
        }

        private void BtnDisplay_Click(object sender, RoutedEventArgs e)
        {
            //Employee 1 object
            Employee Employee1 = new Employee(vm.Name, vm.IdNumber, vm.Position, vm.Department);
         
        }
    }
}
