using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Books
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MK5GMMO\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO BooksTable (Title,Author,YearOfPublication,Publisher) Values (@Title, @Author, @YearOfPublication, @Publisher)", con);
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
            cmd.Parameters.AddWithValue("@YearOfPublication", txtYear.Text);
            cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            ResetFormControls();
            this.Close();
        }
        private void ResetFormControls()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtPublisher.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("UPDATE BooksTable SET txtTitle=@Title,txtAuthor=@Author,txtYear=@YearOfPublication,txtPublisher=@Publisher WHERE BookID=@BookID", con);
            //cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            //cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
            //cmd.Parameters.AddWithValue("@YearOfPublication", txtYear.Text);
            //cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
    }
}
