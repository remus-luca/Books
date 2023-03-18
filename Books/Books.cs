using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Books
{
    public partial class Books : Form
    {
        public int BookID;
        public Books()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MK5GMMO\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True");


        private void Books_Load(object sender, EventArgs e)
        {
            GetBooks();
        }

        private void inputSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            if (inputSearch.Text == string.Empty)
            {
                GetBooks();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from BooksTable where Title Like @search + '%' or Author Like '%' + @search + '%' or" + "  YearOfPublication Like @search + '%' or Publisher Like @search + '%'", con);
            cmd.Parameters.AddWithValue("search", inputSearch.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            booksTable.DataSource = dt;
        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }

        private void GetBooks()
        {
            SqlCommand cmd = new SqlCommand("Select * from dbo.BooksTable", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            booksTable.DataSource = dt;
        }

        private void booksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                BookID = Convert.ToInt32(booksTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            else
            {
                BookID = Convert.ToInt32(booksTable.Rows[0].Cells[0].Value);
            }
        }

        private void booksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            GetBooks();
        }

        private void buttonModify_Click(object sender, EventArgs e)
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

        private void buttonDelete_Click(object sender, EventArgs e)
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
    }
}

