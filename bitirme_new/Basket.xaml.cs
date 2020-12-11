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

using System.Data.SqlClient;
using System.Data;

namespace bitirme_new
{
    /// <summary>
    /// Interaction logic for Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        public Basket()
        {
            InitializeComponent();
            DisplayGrid();

        }
        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Main_Menu n = new Main_Menu();
            n.Show();
            this.Close();
        }

        private void DataGridBasket_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayGrid();
            dataGridBasket.Columns[0].Header = "Order Number";
            dataGridBasket.Columns[1].Header = "Order Name";
            dataGridBasket.Columns[2].Header = "Price";
            dataGridBasket.Columns[3].Header = "Total Price";
            dataGridBasket.Columns[4].Header = "Count";
        }
        public void DisplayGrid()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select *From ORDR", con);
                DataTable table = new DataTable();
                da.Fill(table);

                dataGridBasket.ItemsSource = table.DefaultView;
                con.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("List cannot be found");
            }
        }

        private void RemoveFromBasket_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection con1 = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True"); ;
            SqlCommand cmd1 = new SqlCommand();

            while (dataGridBasket.SelectedItems.Count >= 1)
            {
                DataRowView row = (DataRowView)dataGridBasket.SelectedItem;
               



                //int Selected_Row= Convert.ToInt32(dataGridBasket..Cells[0].Value);
               


                string r = @"DELETE FROM ORDR WHERE order_id=@order_id "; 

                cmd1 = new SqlCommand(r, con1);


                cmd1.Parameters.AddWithValue("@order_id",row.Row.ItemArray[0].ToString());
                //cmd1.Parameters.AddWithValue("@Price", dataGridBasket.CurrentItem ?? (object)DBNull.Value);
                //cmd1.Parameters.AddWithValue("@Count", dataGridBasket.CurrentItem ?? (object)DBNull.Value);


                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
                row.Row.Delete();

            }

        }



    }
}
       
