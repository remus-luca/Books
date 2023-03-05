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
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete the book?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.BooksTable WHERE BookID = @BookID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@BookID", this.BookID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetBooks();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BookID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }
            else
            {
                BookID = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            SqlDataReader sReader;
            SqlCommand cmd = new SqlCommand("Select * from dbo.BooksTable WHERE BookID=@BookID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@BookID", this.BookID);
            con.Open();
            sReader = cmd.ExecuteReader();

            while (sReader.Read())
            {
                book.BookID = Convert.ToInt32(sReader["BookID"]);
                book.Title = Convert.ToString(sReader["Title"]);
                book.Author = Convert.ToString(sReader["Author"]);
                book.YearOfPublication = Convert.ToString(sReader["YearOfPublication"]);
                book.Publisher = Convert.ToString(sReader["Publisher"]);

            }
            con.Close();
            Form2 form = new Form2(book);
            form.ShowDialog();
            GetBooks();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == string.Empty)
            {
                GetBooks();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from BooksTable where Title Like @search + '%' or Author Like @search + '%' or" + " YearOfPublication Like @search + '%' or Publisher Like @search + '%'", con);
            cmd.Parameters.AddWithValue("search", txtSearch.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

