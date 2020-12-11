using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace bitirme_new
{
    /// <summary>
    /// Interaction logic for i_Meal.xaml
    /// </summary>
    public partial class i_Meal : Window
    {
        int a = 0;
        int b = 0;
        int c = 0;
        
        SqlConnection con;
        SqlCommand cmd;
        public i_Meal()
        {
            InitializeComponent();
        }

        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            Main_Menu main_Menu = new Main_Menu();
            main_Menu.Show();
            this.Close();
        }

        

        private void Addition1_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            count1.Text = a.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR(order_name, price) VALUES(@order_name, @price);";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", imeal1.Content);
            cmd.Parameters.AddWithValue("@price", price1.Content);
            cmd.Parameters.AddWithValue("@count", count1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Remove1_Click(object sender, RoutedEventArgs e)
        {
            a = a - 1;
            count1.Text = a.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                        DELETE FROM ORDR WHERE count=0";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", imeal1.Content);
            cmd.Parameters.AddWithValue("@price", price1.Content);
            cmd.Parameters.AddWithValue("@count", count1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Addition2_Click(object sender, RoutedEventArgs e)
        {
            b = b + 1;
            count2.Text = b.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR(order_name, price) VALUES(@order_name, @price);";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", imeal2.Content);
            cmd.Parameters.AddWithValue("@price", price2.Content);
            cmd.Parameters.AddWithValue("@count", count2.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Remove2_Click(object sender, RoutedEventArgs e)
        {
            b = b - 1;
            count2.Text = b.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                        DELETE FROM ORDR WHERE count=0";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", imeal2.Content);
            cmd.Parameters.AddWithValue("@price", price2.Content);
            cmd.Parameters.AddWithValue("@count", count2.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Addition3_Click(object sender, RoutedEventArgs e)
        {

            c = c + 1;
            count3.Text = c.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR(order_name, price) VALUES(@order_name, @price);";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", imeal3.Content);
            cmd.Parameters.AddWithValue("@price", price3.Content);
            cmd.Parameters.AddWithValue("@count", count3.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Remove3_Click(object sender, RoutedEventArgs e)
        {
            c = c - 1;
            count3.Text = c.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                        DELETE FROM ORDR WHERE count=0";
            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", imeal3.Content);
            cmd.Parameters.AddWithValue("@price", price3.Content);
            cmd.Parameters.AddWithValue("@count", count3.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void GoBasket_Click(object sender, RoutedEventArgs e)
        {
            Basket b = new Basket();
            b.Show();
            this.Close();
        }
    }
}
