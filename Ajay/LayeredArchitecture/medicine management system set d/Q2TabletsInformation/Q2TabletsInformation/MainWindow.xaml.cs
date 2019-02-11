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
using System.Data.SqlClient;
using System.Data;

namespace Q2TabletsInformation
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
            //calling DisplayDetails method in windowLoaded Event..i.e., this method will be called when window is loaded
            DisplayDetails();
        }

        //this method is to create connection to the SqlServer and retrieve the data form it
        public void DisplayDetails()
        {
            string ConnectionString = @"Data Source=NDAMSSQL\SQLILEARN;Initial Catalog=Training_14Nov18_Mumbai;Persist Security Info=True;User ID=sqluser;Password=sqluser";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("DisplayMedicine_032",Connection);
            command.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //loading data from reader to DataTable
                table.Load(reader);
                // for displaying data into grid view 
                dgMedicine.DataContext = table;

            }
            catch(SqlException se)
            {
                throw se;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

        }
    }
}
