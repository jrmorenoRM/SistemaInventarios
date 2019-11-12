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
    public partial class ControlDeUsuarios : Form
    {
        public ControlDeUsuarios()
        {
            InitializeComponent();
        }

        private void ControlDeUsuarios_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

         
        }

        private void CmdListadoUsuario_Click(object sender, EventArgs e)
        {
           
        
            //
            //ABRIR FORMULARIO DENTRO DEL PANEL//
            //
            ListadoDeUsuarios ListadoDeUsuarios = new ListadoDeUsuarios();
            ListadoDeUsuarios.TopLevel = false;
            ListadoDeUsuarios.Parent = panel_CONTENEDOR;
            ListadoDeUsuarios.Show();
            //
            //ABRIR FORMULARIO DENTRO DEL PANEL//
            //
        }

        private void Panel_CONTENEDOR_Paint(object sender, PaintEventArgs e)
        {

        }

    
    }
}
