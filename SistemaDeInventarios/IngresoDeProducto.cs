using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventarios
{
    public partial class IngresoDeProducto : Form
    {
        public IngresoDeProducto()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string text = txtnuevoproducto.Text;
            MessageBox.Show("El producto: " + "'"+text+"'" + " a sido agregado al sistema.");
            txtnuevoproducto.Clear();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
