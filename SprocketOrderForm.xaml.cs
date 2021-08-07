using Microsoft.Win32;
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
using System.IO;

namespace Slotkin_P5
{
    /// <summary>
    /// Interaction logic for SprocketOrderForm.xaml
    /// </summary>
    public partial class SprocketOrderForm : Window
    {
        //initialize list
        public SprocketOrderForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Window window = new SprocketForm();
            window.Show();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult confirm = System.Windows.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (confirm == MessageBoxResult.Yes)
            {
                lbOrderInfo.Items.Remove(lbOrderInfo.SelectedItem);
            }
            else { Close(); }
           
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            SprocketOrder order = new SprocketOrder();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Document"; 
            dialog.DefaultExt = ".txt"; 
            dialog.Filter = "Text documents (.txt)|*.txt";
            Nullable<bool> result = dialog.ShowDialog();
            if (result == true)
            {
                string filename = dialog.FileName;
                if (filename != null)
                {
                    StreamWriter writer = new StreamWriter(filename);
                    writer.WriteLine(order.ToString() + lbOrderInfo);  
                }
            }
        }
    }
}
