using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAgeAndBirthDay
{
    public partial class frmAge : Form
    {
        public frmAge()
        {
            InitializeComponent();
        }

        private void btnCalu_Click(object sender, EventArgs e)
        {
            Form frm = new frmBirthDay();
            frm.ShowDialog();
        }
    }
}