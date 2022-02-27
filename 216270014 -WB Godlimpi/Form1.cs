using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _216270014__WB_Godlimpi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aDDNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Add_216270014 Add =  new Add_216270014();
            Add.Show();
            this.Hide();
           




        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_216270014 Update = new Update_216270014();
            Update.Show();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remove_Student_216270014 Remove = new Remove_Student_216270014();
            Remove.Show();
        }

        private void retriveInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Retrvive_216270014 Retrvive = new Retrvive_216270014();
            Retrvive.Show();
        }
    }
}
