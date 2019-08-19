using Devart.Data.PostgreSql;
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
    public partial class IngresoDeProductos : Form
    {

      

       
        public IngresoDeProductos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            IngresoDeProducto v_ingresoDeProducto = new IngresoDeProducto();
            v_ingresoDeProducto.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
      
    }

}
