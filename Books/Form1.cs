using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Books
{
    public partial class Form1 : Form
    {
        public int BookID;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MK5GMMO\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            GetBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetBooks();
        }
        private void GetBooks()
        {
            SqlCommand cmd = new SqlCommand("Select * from dbo.BooksTable", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //SqlCommand cmd = new SqlCommand("DELETE FROM dbo.BooksTable WHERE BookID = @BookID", con);
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("@BookID", this.BookID);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();



            //SqlConnection con = new SqlConnection(conString);
            //string sql = "DELETE FROM BooksTable";
            //SqlCommand cmd = new SqlCommand(sql, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();


            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MK5GMMO\SQLEXPRESS;Initial Catalog=Book_DB;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("DELETE FROM dbo.BookTable WHERE BookID=@ID", con);
            //cmd.CommandType = CommandType.Text();
            //cmd.Parameters.AddWithValue("@ID", this.BookID);
            // Form2 form = new Form2(BookID);


            //con.Open();
            //SqlCommand cmd = new SqlCommand("DELETE FROM dbo.BooksTable WHERE BookID = @BookID", con);
            //cmd.Parameters.AddWithValue("@BookID", this.BookID);
            //cmd.ExecuteNonQuery();
            //con.Close();
            //GetBooks();


        }
    }
}
