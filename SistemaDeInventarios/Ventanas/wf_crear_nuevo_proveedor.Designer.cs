﻿namespace SistemaDeInventarios.Ventanas
{
    partial class wf_crear_nuevo_proveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_numero_telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numero_celular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_correo_electronico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nombre_contacto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboProveedor = new System.Windows.Forms.ComboBox();
            this.ds_detalle_proveedores = new SistemaDeInventarios.DataSets.ds_detalle_proveedores();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_detalle_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_numero_telefono);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_numero_celular);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_correo_electronico);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_nombre_contacto);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboProveedor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 436);
            this.panel1.TabIndex = 0;
            // 
            // txt_numero_telefono
            // 
            this.txt_numero_telefono.Location = new System.Drawing.Point(277, 255);
            this.txt_numero_telefono.Name = "txt_numero_telefono";
            this.txt_numero_telefono.Size = new System.Drawing.Size(293, 20);
            this.txt_numero_telefono.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "NUMERO TELEFONO:";
            // 
            // txt_numero_celular
            // 
            this.txt_numero_celular.Location = new System.Drawing.Point(277, 206);
            this.txt_numero_celular.Name = "txt_numero_celular";
            this.txt_numero_celular.Size = new System.Drawing.Size(293, 20);
            this.txt_numero_celular.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "NUMERO CELULAR:";
            // 
            // txt_correo_electronico
            // 
            this.txt_correo_electronico.Location = new System.Drawing.Point(277, 154);
            this.txt_correo_electronico.Name = "txt_correo_electronico";
            this.txt_correo_electronico.Size = new System.Drawing.Size(293, 20);
            this.txt_correo_electronico.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "CORREO ELECTRONICO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SistemaDeInventarios.Properties.Resources.SIGNO_MAS;
            this.pictureBox1.Location = new System.Drawing.Point(588, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_nombre_contacto
            // 
            this.txt_nombre_contacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre_contacto.Location = new System.Drawing.Point(277, 61);
            this.txt_nombre_contacto.Name = "txt_nombre_contacto";
            this.txt_nombre_contacto.Size = new System.Drawing.Size(293, 20);
            this.txt_nombre_contacto.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::SistemaDeInventarios.Properties.Resources.CANCELAR;
            this.button2.Location = new System.Drawing.Point(458, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 100);
            this.button2.TabIndex = 35;
            this.button2.Text = "CANCELAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::SistemaDeInventarios.Properties.Resources.GUARDAR;
            this.button1.Location = new System.Drawing.Point(277, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 100);
            this.button1.TabIndex = 34;
            this.button1.Text = "GUARDAR\r\n";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboProveedor
            // 
            this.comboProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboProveedor.DataSource = this.ds_detalle_proveedores;
            this.comboProveedor.DisplayMember = "dt_detalle_producto.nombre_proveedor_detalle";
            this.comboProveedor.DropDownHeight = 100;
            this.comboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProveedor.FormattingEnabled = true;
            this.comboProveedor.Location = new System.Drawing.Point(277, 96);
            this.comboProveedor.Name = "comboProveedor";
            this.comboProveedor.Size = new System.Drawing.Size(293, 30);
            this.comboProveedor.TabIndex = 33;
            this.comboProveedor.ValueMember = "dt_detalle_producto.id_proveedor_detalle";
            // 
            // ds_detalle_proveedores
            // 
            this.ds_detalle_proveedores.DataSetName = "ds_detalle_proveedores";
            this.ds_detalle_proveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "NOMBRE CONTACTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "EMPRESA:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDORES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wf_crear_nuevo_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 436);
            this.Controls.Add(this.panel1);
            this.Name = "wf_crear_nuevo_proveedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_detalle_proveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_contacto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_numero_telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_numero_celular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_correo_electronico;
        private System.Windows.Forms.Label label3;
        private DataSets.ds_detalle_proveedores ds_detalle_proveedores;
    }
}