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
    public partial class Retrvive_216270014 : Form
    {
        public Retrvive_216270014()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void Retrvive_216270014_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wGodlimpi216270014DataSet.WGodlimpi216270014' table. You can move, or remove it, as needed.
            this.wGodlimpi216270014TableAdapter.Fill(this.wGodlimpi216270014DataSet.WGodlimpi216270014);

        }
    }
}
