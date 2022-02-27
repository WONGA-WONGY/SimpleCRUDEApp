using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace _216270014__WB_Godlimpi
{
   public partial class  Add_216270014 : Form
{
       SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sample;Integrated Security=true;"); 
        SqlCommand cmd;  
        SqlDataAdapter adapt;  
        //ID variable used in Updating and Deleting Record  
        int ID = 0;  
        public Add_216270014 ()  
        {  
            InitializeComponent();  
            //DisplayData();  
        }  

        //Insert Data  
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNmae.Text != "" && txtSurname.Text != "")
            {
                cmd = new SqlCommand("insert into WBGodlimpi216270014 ([Name],[Surname],[Cell_Number]) VALUES (?,?,?,?)", con);
                con.Open();
                
                cmd.Parameters.AddWithValue("@Name", txtNmae.Text );
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Cell_Number", txtSurname.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
               
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
           DataTable dt = new DataTable();
           adapt = new SqlDataAdapter("select * from  WBGodlimpi216270014 ", con);
           adapt.Fill(dt);
           dataGridView1.DataSource = dt;
           con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            txtID.Clear();
            txtNmae.Clear();
            txtSurname.Clear();
            txtCellNo.Clear();

        }
        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNmae.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCellNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void Add_216270014_Load(object sender, EventArgs e)
        {
            
        }
    }
}
