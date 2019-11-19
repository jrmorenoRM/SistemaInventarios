namespace SistemaDeInventarios.Ventanas
{
    partial class wf_insertar_nuevo_proveedor
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
            this.btn_guardar_grupo = new System.Windows.Forms.Button();
            this.txt_nuevo_proveeor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_guardar_grupo
            // 
            this.btn_guardar_grupo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_grupo.Location = new System.Drawing.Point(46, 120);
            this.btn_guardar_grupo.Name = "btn_guardar_grupo";
            this.btn_guardar_grupo.Size = new System.Drawing.Size(260, 31);
            this.btn_guardar_grupo.TabIndex = 6;
            this.btn_guardar_grupo.Text = "GUARDAR";
            this.btn_guardar_grupo.UseVisualStyleBackColor = true;
            this.btn_guardar_grupo.Click += new System.EventHandler(this.btn_guardar_grupo_Click);
            // 
            // txt_nuevo_proveeor
            // 
            this.txt_nuevo_proveeor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_nuevo_proveeor.Location = new System.Drawing.Point(46, 80);
            this.txt_nuevo_proveeor.Name = "txt_nuevo_proveeor";
            this.txt_nuevo_proveeor.Size = new System.Drawing.Size(260, 20);
            this.txt_nuevo_proveeor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESO NOMBRE DE NUEVO PROVEEDOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wf_insertar_nuevo_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guardar_grupo);
            this.Controls.Add(this.txt_nuevo_proveeor);
            this.Controls.Add(this.label2);
            this.Name = "wf_insertar_nuevo_proveedor";
            this.Text = "wf_insertar_nuevo_proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar_grupo;
        private System.Windows.Forms.TextBox txt_nuevo_proveeor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}