using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;

namespace MS_Chart
{
    public partial class MSChart : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Foodmart"].ConnectionString;
        SqlConnection conn;    //declaring a connection         

        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public MSChart()
        {
            InitializeComponent();
        }
        private void MSChart_Load(object sender, EventArgs e)
        {

            connectionString = ConfigurationManager.ConnectionStrings["Foodmart"].ConnectionString;                        

             cmd = new SqlCommand();
            conn = new SqlConnection(connectionString);
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = @"SELECT product_subcategory from product_class;";
            // addall product class
            
            reader= cmd. ExecuteReader();
            
            DataTable dt = new DataTable();            
            dt.Columns.Add("product_subcategory", typeof(string));

            dt.Rows.Add("ALL");
            dt.Load(reader);
           
            comboBoxPClass.DisplayMember = "product_subcategory";
            comboBoxPClass.DataSource = dt;

            

            reader.Close();
            conn.Close();
        }

        private void buttProductClass_Click(object sender, EventArgs e)
        {
            String productClass = comboBoxPClass.Text; 
            //connect again
            connectionString = ConfigurationManager.ConnectionStrings["Foodmart"].ConnectionString;

            cmd = new SqlCommand();
            conn = new SqlConnection(connectionString);
            cmd.Connection = conn;
            conn.Open();

            


            if (comboBoxPClass.Text==null || comboBoxPClass.Text.Equals("ALL"))
            {
                cmd.CommandText = @"SELECT product_name from product ORDER BY product_name ASC;";
                // add  all product

                reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("product_name", typeof(string));

                dt.Rows.Add("ALL");
                dt.Load(reader);

                comboBoxProduct.DisplayMember = "product_name";
                comboBoxProduct.DataSource = dt;

               // comboBoxProduct.Items.Clear();

            }
            else
            {
                 //comboBoxProduct.Items.Clear();

                cmd.CommandText = @"SELECT product.product_Name from product 
                              INNER JOIN product_class ON
                              product_class.product_class_id=product.product_class_id 
                             WHERE product_subcategory= ' "+ productClass + "' ORDER BY product_Name ASC;";
                // add  all product

                reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Columns.Add("product_name", typeof(string));

                table.Rows.Add("ALL");
                table.Load(reader);

                comboBoxProduct.DisplayMember = "product_name";
                comboBoxProduct.DataSource = table;


            }

            reader.Close();
            conn.Close();

        }

        private void buttProduct_Click(object sender, EventArgs e)
        {
            string city = comboBoxCity.Text;

            connectionString = ConfigurationManager.ConnectionStrings["Foodmart"].ConnectionString;

            cmd = new SqlCommand();
            conn = new SqlConnection(connectionString);
            cmd.Connection = conn;
            conn.Open();




            if (comboBoxCity.Text == null || comboBoxCity.Text.Equals("ALL"))
            {
                cmd.CommandText = @"SELECT sales_city from region ORDER BY sales_city ASC;";
                // add  all product

                reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("sales_city", typeof(string));

                dt.Rows.Add("ALL");
                dt.Load(reader);

                comboBoxCity.DisplayMember = "sales_city";
                comboBoxCity.DataSource = dt;

            }

            reader.Close();
            conn.Close();
        }

        private void buttCity_Click(object sender, EventArgs e)
        {

        }

        private void buttLoadDB_Click(object sender, EventArgs e)
        {
            
             connectionString = ConfigurationManager.ConnectionStrings["Foodmart"].ConnectionString;                  
                       
             cmd = new SqlCommand();
            conn = new SqlConnection(connectionString);
            cmd.Connection = conn;
            conn.Open();                      
           
            cmd.CommandText = @"SELECT time_by_day.the_month , sum(store_sales) AS total_sales FROM sales_fact_1998 
                                INNER JOIN time_by_day ON  sales_fact_1998.time_id = time_by_day.time_id
                                 GROUP BY time_by_day.the_month ORDER BY DATEPART(mm,CAST(the_month+ ' 1900' AS DATETIME)) asc;";
           
            CoulmChart.DataSource = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                       
           
            CoulmChart.Series[0].XValueMember = "the_month";
            CoulmChart.Series[0].YValueMembers = "total_sales";
            
            CoulmChart.DataBind();
            
           

            conn.Close();
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}


 //Data Source =.; Initial Catalog = Foodmart; Integrated Security = True"/>-->
  //Persist Security Info=False;Integrated Security = true; Initial Catalog = Foodmart; server=(local)"-->