using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnOOP
{
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FManage f = new FManage();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
