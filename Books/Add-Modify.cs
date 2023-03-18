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
            inputTitle.Text = book.Title;
            inputAuthor.Text = book.Author;
            inputYear.Text = book.YearOfPublication;
            inputPublisher.Text = book.Publisher;
            isNewBook = false;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MK5GMMO\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True");

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (isNewBook == true)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO BooksTable (Title,Author,YearOfPublication,Publisher) Values (@Title, @Author, @YearOfPublication, @Publisher)", con);
                    cmd.Parameters.AddWithValue("@Title", inputTitle.Text);
                    cmd.Parameters.AddWithValue("@Author", inputAuthor.Text);
                    cmd.Parameters.AddWithValue("@YearOfPublication", inputYear.Text);
                    cmd.Parameters.AddWithValue("@Publisher", inputPublisher.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ResetFormControls();
                    this.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE BooksTable SET Title=@Title,Author=@Author,YearOfPublication=@YearOfPublication,Publisher=@Publisher WHERE BookID=@BookID", con);
                    cmd.Parameters.AddWithValue("@BookID", BookID);
                    cmd.Parameters.AddWithValue("@Title", inputTitle.Text);
                    cmd.Parameters.AddWithValue("@Author", inputAuthor.Text);
                    cmd.Parameters.AddWithValue("@YearOfPublication", inputYear.Text);
                    cmd.Parameters.AddWithValue("@Publisher", inputPublisher.Text);
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
            if (inputTitle.Text == string.Empty)
            {
                MessageBox.Show("Title is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (inputAuthor.Text == string.Empty)
            {
                MessageBox.Show("Author is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (inputYear.Text == string.Empty)
            {
                MessageBox.Show("Year is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (inputPublisher.Text == string.Empty)
            {
                MessageBox.Show("Publisher is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ResetFormControls()
        {
            inputTitle.Clear();
            inputAuthor.Clear();
            inputYear.Clear();
            inputPublisher.Clear();
        }

        private void buttonRenounce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void inputTitle_TextChanged(object sender, EventArgs e)
        {

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

        private void inputAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputAuthor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void inputYear_KeyPress(object sender, KeyPressEventArgs e)
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

        private void inputYear_TextChanged(object sender, EventArgs e)
        {
            inputYear.MaxLength = 4;
        }

        private void inputPublisher_KeyPress(object sender, KeyPressEventArgs e)
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

        private void inputPublisher_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
