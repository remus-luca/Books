using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Books
{
    public partial class Form2 : Form
    {
        public int BookID;
        bool isNewBook;
        public Form2()
        {
            InitializeComponent();
            isNewBook = true;
        }

        public Form2(Book book)
        {
            InitializeComponent();
            BookID = book.BookID;
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtYear.Text = book.YearOfPublication;
            txtPublisher.Text = book.Publisher;
            isNewBook = false;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MK5GMMO\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (isNewBook == true)
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
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE BooksTable SET Title=@Title,Author=@Author,YearOfPublication=@YearOfPublication,Publisher=@Publisher WHERE BookID=@BookID", con);
                    cmd.Parameters.AddWithValue("@BookID", BookID);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@YearOfPublication", txtYear.Text);
                    cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ResetFormControls();
                    this.Close();
                }

            }
        }

        private bool isValid()
        {
            if (txtTitle.Text == string.Empty)
            {
                MessageBox.Show("Title is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtAuthor.Text == string.Empty)
            {
                MessageBox.Show("Author is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtYear.Text == string.Empty)
            {
                MessageBox.Show("Year is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtPublisher.Text == string.Empty)
            {
                MessageBox.Show("Publisher is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {

            string x = e.KeyChar.ToString();
            if (x == "\b" || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            txtYear.MaxLength = 4;
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
            if (x == "\b" || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsLetter(e.KeyChar);
            }


        }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
            if (x == "\b" || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsLetter(e.KeyChar);
            }
        }

        private void txtPublisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            string x = e.KeyChar.ToString();
            if (x == "\b" || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsLetter(e.KeyChar);
            }
        }

        private void txtPublisher_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
