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
using MedicineBLL;
using MedicineEntity;
using MedicineException;

namespace MedicineManager
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        MedicineBLL.MedicineBLL medicineBLL = new MedicineBLL.MedicineBLL();
        Medicine med = new Medicine();
        //this method is a click event of the button control
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (AddDetails())
            {
                MessageBox.Show("medicine Details Added Successfully \n medicineID =" + med.MedicineID);
            }
            else
            {
                MessageBox.Show("not added");
            }
            if (txtMedName.Text == string.Empty|| txtBatchNo.Text == string.Empty)
            {
                MessageBox.Show("please insert fields");
            }
            
        }
        //this method will pas the data which was accepted by the user nd returns the bools value
        public bool AddDetails()
        {
            med.MedicineName = txtMedName.Text;
            med.Type = CbType.Text;
            med.Manufacturer = CbManufacturer.Text;
            med.BatchNo = txtBatchNo.Text;
            med.ManufactureDate = Convert.ToDateTime(dpManDate.Text);
            med.ExpiryDate = Convert.ToDateTime(dpExpiryDate.Text);
            med.Price = double.Parse(txtPrice.Text);
            bool isAdded = medicineBLL.AddMedicineBLL(med);
            return isAdded;

        }
    }
}
