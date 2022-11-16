using System.Data.SqlClient;
using System.Xml.Linq;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_ID.Text != "")
                {

                    bool result = crud.Del(text_ID.Text);
                    if (result)
                    {
                        MessageBox.Show("All the data is successfully inserted!");
                    }
                    else
                    {
                        MessageBox.Show("Error while inserting data!");
                    }

                    Display();
                    Clear();

                }
                else
                {
                    MessageBox.Show("Please Fill In The Blanks!");
                }
            }
            catch
            {
                MessageBox.Show("Error", "There is an exception case in the first program !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {

                if (text_Address.Text != "" || text_Birth_Date.Text != "" ||
                    text_Email.Text != "" || text_Group_ID.Text != "" ||
                    text_Father_Name.Text != "" || text_ID.Text != "" ||
                    text_Name.Text != "" || text_Surname.Text != "")
                {

                    bool result = crud.Add(int.Parse(text_ID.Text), text_Address.Text,
                    text_Birth_Date.Text,
                    text_Email.Text,
                    text_Father_Name.Text,
                    text_Name.Text, text_Surname.Text, text_Group_ID.Text.ToString());
                    if (result)
                    {
                        MessageBox.Show("All the data is successfully inserted!");
                    }
                    else
                    {
                        MessageBox.Show("Error while inserting data!");
                    }
                    Display();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Please Fill In The Blanks!");
                }
            }
            catch
            {
                MessageBox.Show("Error", "There is an exception case in the second program !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Clear()
        {
            text_Address.Text = "";
            text_Birth_Date.Text = "";
            text_Email.Text = "";
            text_Father_Name.Text = "";
            text_Group_ID.Text = "";
            text_ID.Text = "";
            text_Name.Text = "";
            text_Surname.Text = "";
        }
        private void Display()
        {
            Student_GRID.DataSource = crud.Show();
        }

        private void Student_GRID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            text_ID.Text = Student_GRID.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_Name.Text = Student_GRID.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_Surname.Text = Student_GRID.Rows[e.RowIndex].Cells[2].Value.ToString();
            text_Father_Name.Text = Student_GRID.Rows[e.RowIndex].Cells[3].Value.ToString();
            text_Birth_Date.Text = Student_GRID.Rows[e.RowIndex].Cells[4].Value.ToString();
            text_Address.Text = Student_GRID.Rows[e.RowIndex].Cells[5].Value.ToString();
            text_Email.Text = Student_GRID.Rows[e.RowIndex].Cells[6].Value.ToString();
            text_Group_ID.Text = Student_GRID.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {

                if (text_Address.Text != "" || text_Birth_Date.Text != "" ||
                    text_Email.Text != "" || text_Group_ID.Text != "" ||
                    text_Father_Name.Text != "" || text_ID.Text != "" ||
                    text_Name.Text != "" || text_Surname.Text != "")
                {

                    bool result = crud.Upd(int.Parse(text_ID.Text), text_Address.Text,
                    text_Birth_Date.Text,
                    text_Email.Text,
                    text_Father_Name.Text,
                    text_Name.Text, text_Surname.Text, text_Group_ID.Text.ToString());
                    if (result)
                    {
                        MessageBox.Show("All the data is successfully inserted!");
                    }
                    else
                    {
                        MessageBox.Show("Error while inserting data!");
                    }
                    Display();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Please Fill In The Blanks!");
                }
            }
            catch
            {
                MessageBox.Show("Error", "There is an exception case in the third program !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (text_ID.Text == "")
            {
                Display();
            }
            else
            {
                string ex = text_ID.Text;

                Student_GRID.DataSource = crud.Read(ex);
                Student_GRID.Visible = true;

            }
        }
    }
}