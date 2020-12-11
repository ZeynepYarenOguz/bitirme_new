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
using System.Configuration;
using System.Data;

namespace bitirme_new
{
    /// <summary>
    /// Interaction logic for Pizzas.xaml
    /// </summary>
    public partial class Pizzas : Window
    {
        SqlConnection con;
        SqlCommand cmd;
        int a = 0;
        int b = 0;
        int c = 0;
       


        public Pizzas()
        {
            InitializeComponent();
           


        }

        private void BtnMainCourses_Click(object sender, RoutedEventArgs e)
        {
            MainCourses mainCourses = new MainCourses();
            mainCourses.Show();
            this.Close();
        }

       
      
        private void Addition_Click(object sender, RoutedEventArgs e)

        {
            a = a + 1;
            count1.Text = a.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR(order_name, price) VALUES(@order_name, @price);";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", pizza1.Content);
            cmd.Parameters.AddWithValue("@price", price1.Content);
            cmd.Parameters.AddWithValue("@count", count1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }

       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a = a - 1;
            count1.Text = a.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                        DELETE FROM ORDR WHERE count=0";


            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", pizza1.Content);
            cmd.Parameters.AddWithValue("@price", price1.Content);
            cmd.Parameters.AddWithValue("@count", count1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void Addition_Copy_Click(object sender, RoutedEventArgs e)
        {
            b = b + 1;
            count2.Text = b.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR(order_name, price) VALUES(@order_name, @price);";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", pizza2.Content);
            cmd.Parameters.AddWithValue("@price", price2.Content);
            cmd.Parameters.AddWithValue("@count", count2.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            b = b - 1;
            count2.Text = b.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                        DELETE FROM ORDR WHERE count=0";


            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", pizza2.Content);
            cmd.Parameters.AddWithValue("@price", price2.Content);
            cmd.Parameters.AddWithValue("@count", count2.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Addition_Copy1_Click(object sender, RoutedEventArgs e)
        {
            c = c + 1;
            count3.Text = c.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR(order_name, price) VALUES(@order_name, @price);";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", pizza3.Content);
            cmd.Parameters.AddWithValue("@price", price3.Content);
            cmd.Parameters.AddWithValue("@count", count3.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            c = c - 1;
            count3.Text = c.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                        DELETE FROM ORDR WHERE count=0";


            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", pizza3.Content);
            cmd.Parameters.AddWithValue("@price", price3.Content);
            cmd.Parameters.AddWithValue("@count", count3.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void GoBasket_Click(object sender, RoutedEventArgs e)
        {
            Basket basket = new Basket();
            basket.Show();

        }
    }
}
