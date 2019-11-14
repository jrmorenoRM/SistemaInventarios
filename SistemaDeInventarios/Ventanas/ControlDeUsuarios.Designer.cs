namespace SistemaDeInventarios
{
    partial class ControlDeUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdListadoUsuario = new System.Windows.Forms.Button();
            this.cmdAgregarUsuario = new System.Windows.Forms.Button();
            this.panel_CONTENEDOR = new System.Windows.Forms.Panel();
            this.panel_CONTENEDOR.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdListadoUsuario
            // 
            this.cmdListadoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdListadoUsuario.Location = new System.Drawing.Point(238, 12);
            this.cmdListadoUsuario.Name = "cmdListadoUsuario";
            this.cmdListadoUsuario.Size = new System.Drawing.Size(172, 51);
            this.cmdListadoUsuario.TabIndex = 0;
            this.cmdListadoUsuario.Text = "LISTADO DE USUARIOS";
            this.cmdListadoUsuario.UseVisualStyleBackColor = true;
            this.cmdListadoUsuario.Click += new System.EventHandler(this.CmdListadoUsuario_Click);
            // 
            // cmdAgregarUsuario
            // 
            this.cmdAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAgregarUsuario.Location = new System.Drawing.Point(572, 13);
            this.cmdAgregarUsuario.Name = "cmdAgregarUsuario";
            this.cmdAgregarUsuario.Size = new System.Drawing.Size(186, 50);
            this.cmdAgregarUsuario.TabIndex = 1;
            this.cmdAgregarUsuario.Text = "AGREGAR UN USUARIO";
            this.cmdAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // panel_CONTENEDOR
            // 
            this.panel_CONTENEDOR.Controls.Add(this.cmdListadoUsuario);
            this.panel_CONTENEDOR.Controls.Add(this.cmdAgregarUsuario);
            this.panel_CONTENEDOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_CONTENEDOR.Location = new System.Drawing.Point(0, 0);
            this.panel_CONTENEDOR.Name = "panel_CONTENEDOR";
            this.panel_CONTENEDOR.Size = new System.Drawing.Size(1039, 622);
            this.panel_CONTENEDOR.TabIndex = 2;
            this.panel_CONTENEDOR.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_CONTENEDOR_Paint);
            // 
            // ControlDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 622);
            this.Controls.Add(this.panel_CONTENEDOR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ControlDeUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODULO DE USUARIOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ControlDeUsuarios_Load);
            this.panel_CONTENEDOR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_CONTENEDOR;
        public System.Windows.Forms.Button cmdListadoUsuario;
        public System.Windows.Forms.Button cmdAgregarUsuario;
    }
}