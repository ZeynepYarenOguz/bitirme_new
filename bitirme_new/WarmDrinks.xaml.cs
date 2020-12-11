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
    /// Interaction logic for WarmDrinks.xaml
    /// </summary>
    public partial class WarmDrinks : Window
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int f = 0;
        int g = 0;

        SqlConnection con;
        SqlCommand cmd;
        public WarmDrinks()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainDrinks d = new MainDrinks();
            d.Show();
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
            cmd.Parameters.AddWithValue("@order_name", warm1.Content);
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
            cmd.Parameters.AddWithValue("@order_name", warm1.Content);
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
            cmd.Parameters.AddWithValue("@order_name", warm2.Content);
            cmd.Parameters.AddWithValue("@price", price2.Content);
            cmd.Parameters.AddWithValue("@count", count2.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void REmove2_Click(object sender, RoutedEventArgs e)
        {
            b = b - 1;
            count2.Text = b.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");
            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                        DELETE FROM ORDR WHERE count=0";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", warm2.Content);
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
            cmd.Parameters.AddWithValue("@order_name", warm3.Content);
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
            cmd.Parameters.AddWithValue("@order_name", warm3.Content);
            cmd.Parameters.AddWithValue("@price", price3.Content);
            cmd.Parameters.AddWithValue("@count", count3.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Addition4_Click(object sender, RoutedEventArgs e)
        {
            d = d + 1;
            count4.Text = d.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR(order_name, price) VALUES(@order_name, @price);";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", warm4.Content);
            cmd.Parameters.AddWithValue("@price", price4.Content);
            cmd.Parameters.AddWithValue("@count", count4.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Remove4_Click(object sender, RoutedEventArgs e)
        {
            d = d - 1;
            count4.Text = d.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                        DELETE FROM ORDR WHERE count=0";
            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name",warm4.Content);
            cmd.Parameters.AddWithValue("@price", price4.Content);
            cmd.Parameters.AddWithValue("@count", count4.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Addition5_Click(object sender, RoutedEventArgs e)
        {
            f = f + 1;
            count5.Text = f.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR(order_name, price) VALUES(@order_name, @price);";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", warm5.Content);
            cmd.Parameters.AddWithValue("@price", price5.Content);
            cmd.Parameters.AddWithValue("@count", count5.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Remove5_Click(object sender, RoutedEventArgs e)
        {
            f = f - 1;
            count5.Text = f.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                        DELETE FROM ORDR WHERE count=0";
            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", warm5.Content);
            cmd.Parameters.AddWithValue("@price", price5.Content);
            cmd.Parameters.AddWithValue("@count", count5.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Addition6_Click(object sender, RoutedEventArgs e)
        {
            g = g + 1;
            count6.Text = g.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                    ELSE
                        INSERT INTO ORDR(order_name, price) VALUES(@order_name, @price);";

            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", warm6.Content);
            cmd.Parameters.AddWithValue("@price", price6.Content);
            cmd.Parameters.AddWithValue("@count", count6.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Remove6_Click(object sender, RoutedEventArgs e)
        {
            g = g - 1;
            count6.Text = g.ToString();
            con = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=SelfOrder_Customer;Integrated Security=True");

            string record = @"IF EXISTS(SELECT * FROM ORDR WHERE order_name = @order_name)
                        UPDATE ORDR SET count = @count WHERE order_name = @order_name
                        DELETE FROM ORDR WHERE count=0";
            cmd = new SqlCommand(record, con);
            cmd.Parameters.AddWithValue("@order_name", warm6.Content);
            cmd.Parameters.AddWithValue("@price", price6.Content);
            cmd.Parameters.AddWithValue("@count", count6.Text);

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

