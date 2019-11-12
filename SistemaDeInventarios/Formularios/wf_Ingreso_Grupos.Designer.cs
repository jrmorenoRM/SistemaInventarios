namespace SistemaDeInventarios
{
    partial class wf_Ingreso_Grupos
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
            this.txt_nuevo_grupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar_grupo
            // 
            this.btn_guardar_grupo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_grupo.Location = new System.Drawing.Point(65, 139);
            this.btn_guardar_grupo.Name = "btn_guardar_grupo";
            this.btn_guardar_grupo.Size = new System.Drawing.Size(260, 31);
            this.btn_guardar_grupo.TabIndex = 3;
            this.btn_guardar_grupo.Text = "GUARDAR";
            this.btn_guardar_grupo.UseVisualStyleBackColor = true;
            this.btn_guardar_grupo.Click += new System.EventHandler(this.Btn_guardar_grupo_Click);
            // 
            // txt_nuevo_grupo
            // 
            this.txt_nuevo_grupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nuevo_grupo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_nuevo_grupo.Location = new System.Drawing.Point(65, 92);
            this.txt_nuevo_grupo.Name = "txt_nuevo_grupo";
            this.txt_nuevo_grupo.Size = new System.Drawing.Size(260, 20);
            this.txt_nuevo_grupo.TabIndex = 2;
            this.txt_nuevo_grupo.TextChanged += new System.EventHandler(this.Txt_nuevo_grupo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO NOMBRE DE NUEVO GRUPO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_guardar_grupo);
            this.panel1.Controls.Add(this.txt_nuevo_grupo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 201);
            this.panel1.TabIndex = 1;
            // 
            // wf_Ingreso_Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 201);
            this.Controls.Add(this.panel1);
            this.Name = "wf_Ingreso_Grupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar_grupo;
        private System.Windows.Forms.TextBox txt_nuevo_grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}