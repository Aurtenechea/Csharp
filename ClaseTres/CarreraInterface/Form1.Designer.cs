﻿namespace CarreraInterface
{
    partial class Form1
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
            this.grpCarrera = new System.Windows.Forms.GroupBox();
            this.grpAutos = new System.Windows.Forms.GroupBox();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.grpListaAutos = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrearCarrera = new System.Windows.Forms.Button();
            this.txtNombrePiloto = new System.Windows.Forms.TextBox();
            this.lblNombrePiloto = new System.Windows.Forms.Label();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lsbListaAutos = new System.Windows.Forms.ListBox();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbResultado = new System.Windows.Forms.ComboBox();
            this.grpCarrera.SuspendLayout();
            this.grpAutos.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.grpListaAutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCarrera
            // 
            this.grpCarrera.Controls.Add(this.btnCrearCarrera);
            this.grpCarrera.Controls.Add(this.label3);
            this.grpCarrera.Controls.Add(this.txtLugar);
            this.grpCarrera.Controls.Add(this.label2);
            this.grpCarrera.Controls.Add(this.txtFecha);
            this.grpCarrera.Controls.Add(this.label1);
            this.grpCarrera.Controls.Add(this.txtNombre);
            this.grpCarrera.Location = new System.Drawing.Point(23, 13);
            this.grpCarrera.Name = "grpCarrera";
            this.grpCarrera.Size = new System.Drawing.Size(540, 115);
            this.grpCarrera.TabIndex = 0;
            this.grpCarrera.TabStop = false;
            this.grpCarrera.Text = "Carrera";
            // 
            // grpAutos
            // 
            this.grpAutos.Controls.Add(this.cmbFabricante);
            this.grpAutos.Controls.Add(this.btnAgregarAuto);
            this.grpAutos.Controls.Add(this.lblFabricante);
            this.grpAutos.Controls.Add(this.txtNombrePiloto);
            this.grpAutos.Controls.Add(this.lblNombrePiloto);
            this.grpAutos.Enabled = false;
            this.grpAutos.Location = new System.Drawing.Point(23, 134);
            this.grpAutos.Name = "grpAutos";
            this.grpAutos.Size = new System.Drawing.Size(274, 173);
            this.grpAutos.TabIndex = 0;
            this.grpAutos.TabStop = false;
            this.grpAutos.Text = "Autos";
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.cmbResultado);
            this.grpResultado.Controls.Add(this.txtResultado);
            this.grpResultado.Controls.Add(this.btnCorrer);
            this.grpResultado.Location = new System.Drawing.Point(21, 313);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(276, 175);
            this.grpResultado.TabIndex = 0;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado";
            // 
            // grpListaAutos
            // 
            this.grpListaAutos.Controls.Add(this.lsbListaAutos);
            this.grpListaAutos.Location = new System.Drawing.Point(309, 134);
            this.grpListaAutos.Name = "grpListaAutos";
            this.grpListaAutos.Size = new System.Drawing.Size(274, 347);
            this.grpListaAutos.TabIndex = 0;
            this.grpListaAutos.TabStop = false;
            this.grpListaAutos.Text = "Lista de autos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(391, 35);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(143, 20);
            this.txtFecha.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(223, 35);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(150, 20);
            this.txtLugar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lugar";
            // 
            // btnCrearCarrera
            // 
            this.btnCrearCarrera.Location = new System.Drawing.Point(23, 62);
            this.btnCrearCarrera.Name = "btnCrearCarrera";
            this.btnCrearCarrera.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCarrera.TabIndex = 2;
            this.btnCrearCarrera.Text = "Crear Carrera";
            this.btnCrearCarrera.UseVisualStyleBackColor = true;
            this.btnCrearCarrera.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombrePiloto
            // 
            this.txtNombrePiloto.Location = new System.Drawing.Point(6, 42);
            this.txtNombrePiloto.Name = "txtNombrePiloto";
            this.txtNombrePiloto.Size = new System.Drawing.Size(159, 20);
            this.txtNombrePiloto.TabIndex = 0;
            // 
            // lblNombrePiloto
            // 
            this.lblNombrePiloto.AutoSize = true;
            this.lblNombrePiloto.Location = new System.Drawing.Point(6, 23);
            this.lblNombrePiloto.Name = "lblNombrePiloto";
            this.lblNombrePiloto.Size = new System.Drawing.Size(73, 13);
            this.lblNombrePiloto.TabIndex = 1;
            this.lblNombrePiloto.Text = "Nombre Piloto";
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(9, 144);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(182, 23);
            this.btnAgregarAuto.TabIndex = 2;
            this.btnAgregarAuto.Text = "Agregar auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAgregarAuto_MouseClick);
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(6, 79);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 1;
            this.lblFabricante.Text = "Fabricante";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(9, 106);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(156, 21);
            this.cmbFabricante.TabIndex = 3;
            // 
            // lsbListaAutos
            // 
            this.lsbListaAutos.FormattingEnabled = true;
            this.lsbListaAutos.Location = new System.Drawing.Point(19, 23);
            this.lsbListaAutos.Name = "lsbListaAutos";
            this.lsbListaAutos.Size = new System.Drawing.Size(249, 303);
            this.lsbListaAutos.TabIndex = 0;
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(184, 147);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(75, 23);
            this.btnCorrer.TabIndex = 1;
            this.btnCorrer.Text = "Correr";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCorrer_MouseClick);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(11, 14);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(259, 127);
            this.txtResultado.TabIndex = 2;
            // 
            // cmbResultado
            // 
            this.cmbResultado.FormattingEnabled = true;
            this.cmbResultado.Location = new System.Drawing.Point(11, 148);
            this.cmbResultado.Name = "cmbResultado";
            this.cmbResultado.Size = new System.Drawing.Size(145, 21);
            this.cmbResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 546);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.grpListaAutos);
            this.Controls.Add(this.grpAutos);
            this.Controls.Add(this.grpCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCarrera.ResumeLayout(false);
            this.grpCarrera.PerformLayout();
            this.grpAutos.ResumeLayout(false);
            this.grpAutos.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.grpListaAutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCarrera;
        private System.Windows.Forms.Button btnCrearCarrera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpAutos;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.GroupBox grpListaAutos;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.TextBox txtNombrePiloto;
        private System.Windows.Forms.Label lblNombrePiloto;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ListBox lsbListaAutos;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ComboBox cmbResultado;
    }
}

