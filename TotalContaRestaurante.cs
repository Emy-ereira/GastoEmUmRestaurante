using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastoEmUmRestaurante
{
    public partial class TotalContaRestaurante : Form
    {
        public TotalContaRestaurante()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (double.Parse(txtDespesa.Text) * 1.10).ToString("N");
        }
    }
}
