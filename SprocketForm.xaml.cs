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

namespace Slotkin_P5
{
    /// <summary>
    /// Interaction logic for SprocketForm.xaml
    /// </summary>
    public partial class SprocketForm : Window
    {
        public SprocketForm()
        {
            InitializeComponent();

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //Instantiate a class object
            SprocketOrder order = new SprocketOrder();

            //Set the values from our controls into the class
            order.ItemID = .Text;    
            st.LastName = tbLastName.Text;
            st.StudentNumber = tbIDNum.Text;
            st.Major = tbMajor.Text;
            List<Assignment> scores = new List<Assignment>();


            st.Scores = scores;

            //Set the results from the class into a control on the form
            txbResults.Text = st.ToString();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            tbItemID.Text = string.Empty;
            comboItemType.SelectedItem = null;
            tbTeeth.Text = string.Empty;
            tbNumOfItems.Text = string.Empty;
            Close(); 
        }
    }
}
