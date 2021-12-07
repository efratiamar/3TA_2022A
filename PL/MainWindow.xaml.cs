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

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BLApi.IBL bl = new BL.BLImp();
        BO.Student curStu;
        public MainWindow()
        {
            InitializeComponent();

            statusComboBox.ItemsSource = Enum.GetValues(typeof(BO.StudentStatus));

            studentDataGrid.DataContext = bl.GetAllStudents();
            studentDataGrid.IsReadOnly = true;
        }

        private void studentDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            curStu = (studentDataGrid.SelectedItem as BO.Student);
            gridOneStudent.DataContext = curStu;

            MessageBox.Show(curStu.ToString());
        }
    }
}
