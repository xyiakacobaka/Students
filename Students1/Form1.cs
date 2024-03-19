using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        SqlConnection con;

        string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=students1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con = new SqlConnection(ConnectionString);
            con.Open();
            SqlDataAdapter sdf = new SqlDataAdapter("SELECT * FROM Students", con);
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            con.Close();
            dataGridView1.DataSource = sd;
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            using (StudentsContext db = new StudentsContext())
            {
                Student student = new Student();
                Form3 Form3 = new Form3();
                Form2 Form2 = new Form2();
                if (LasrNameText.Text != string.Empty && FirstNameText.Text != string.Empty &&
                    SecondNameText.Text != string.Empty && Group.Text != string.Empty)
                {
                    bool succes = Int32.TryParse(Group.Text, out int x);
                    if (succes && x == 1 || x == 2 || x == 3 || x == 4)
                    {
                        student.FirstName = FirstNameText.Text;
                        student.LastName = LasrNameText.Text;
                        student.SecondName = SecondNameText.Text;
                        student.Group = x;
                        db.Add(student);
                        db.SaveChanges();
                        Form3.ShowDialog();
                        FirstNameText.Text = "";
                        SecondNameText.Text = "";
                        LasrNameText.Text = "";
                        Group.Text = "";
                        con = new SqlConnection(ConnectionString);
                        con.Open();
                        SqlDataAdapter sdf = new SqlDataAdapter("SELECT * FROM Students", con);
                        DataTable sd = new DataTable();
                        sdf.Fill(sd);
                        con.Close();
                        dataGridView1.DataSource = sd;
                    }
                    else
                    {
                        Form2.ShowDialog();
                    }
                }
                else
                {
                    {
                        Form2.ShowDialog();
                    }
                }
            }
        }

        private void LasrNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Group_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Search_Click(object sender, EventArgs e)
        {

        }
    }
}