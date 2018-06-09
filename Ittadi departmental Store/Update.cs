using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ittadi_departmental_Store
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Close();
        }
    }
}
