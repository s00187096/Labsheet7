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

namespace Labsheet7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //this method will run when the window loads
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //create 3 objects
            expense e1 = new expense()
            {
                Category = "Travel",
                Amount = 19.95m,
                ExpenseDate = new DateTime(2019, 6, 30)
            };

            expense e2 = new expense()
            {
                Category = "Entertainment",
                Amount = 99.95m,
                ExpenseDate = new DateTime(2019, 7, 30)
            };

            expense e3 = new expense()
            {
                Category = "Offce",
                Amount = 9.95m,
                ExpenseDate = new DateTime(2019, 6, 25)
            };

            // add those to a list
            List<expense> expenses = new List<expense>();
            expenses.Add(e1);
            expenses.Add(e2);
            expenses.Add(e3);

            // display list of list box
            lbxexpenses.ItemsSource = expenses;

        }
        //method to add expense items
        private void BtnAdd_Click(object sender,RoutedEventArgs e)
        {

        }

    }
}
