﻿namespace EjemploProgressBarYDatagridview
{
    partial class OpcionGroupBox
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
            this.gbgenero = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbnacionalidad = new System.Windows.Forms.GroupBox();
            this.btngenero = new System.Windows.Forms.Button();
            this.btnnacionalidad = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.gbgenero.SuspendLayout();
            this.gbnacionalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbgenero
            // 
            this.gbgenero.Controls.Add(this.flowLayoutPanel1);
            this.gbgenero.Controls.Add(this.radioButton1);
            this.gbgenero.Controls.Add(this.radioButton2);
            this.gbgenero.Location = new System.Drawing.Point(0, 0);
            this.gbgenero.Name = "gbgenero";
            this.gbgenero.Size = new System.Drawing.Size(174, 143);
            this.gbgenero.TabIndex = 0;
            this.gbgenero.TabStop = false;
            this.gbgenero.Text = "Genero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uso de GroupBox";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(83, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(31, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Femnino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(32, 33);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Colombiano";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(32, 77);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Otro";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // gbnacionalidad
            // 
            this.gbnacionalidad.Controls.Add(this.radioButton3);
            this.gbnacionalidad.Controls.Add(this.radioButton4);
            this.gbnacionalidad.Controls.Add(this.gbgenero);
            this.gbnacionalidad.Location = new System.Drawing.Point(316, 98);
            this.gbnacionalidad.Name = "gbnacionalidad";
            this.gbnacionalidad.Size = new System.Drawing.Size(174, 143);
            this.gbnacionalidad.TabIndex = 6;
            this.gbnacionalidad.TabStop = false;
            this.gbnacionalidad.Text = "Nacionalidad";
            this.gbnacionalidad.Visible = false;
            // 
            // btngenero
            // 
            this.btngenero.Location = new System.Drawing.Point(535, 131);
            this.btngenero.Name = "btngenero";
            this.btngenero.Size = new System.Drawing.Size(75, 23);
            this.btngenero.TabIndex = 7;
            this.btngenero.Text = "Genero";
            this.btngenero.UseVisualStyleBackColor = true;
            this.btngenero.Click += new System.EventHandler(this.btngenero_Click);
            // 
            // btnnacionalidad
            // 
            this.btnnacionalidad.Location = new System.Drawing.Point(535, 175);
            this.btnnacionalidad.Name = "btnnacionalidad";
            this.btnnacionalidad.Size = new System.Drawing.Size(75, 23);
            this.btnnacionalidad.TabIndex = 8;
            this.btnnacionalidad.Text = "Nacionalidad";
            this.btnnacionalidad.UseVisualStyleBackColor = true;
            this.btnnacionalidad.Click += new System.EventHandler(this.btnnacionalidad_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(535, 217);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // OpcionGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnnacionalidad);
            this.Controls.Add(this.btngenero);
            this.Controls.Add(this.gbnacionalidad);
            this.Controls.Add(this.label1);
            this.Name = "OpcionGroupBox";
            this.Text = "OpcionGroupBox";
            this.gbgenero.ResumeLayout(false);
            this.gbgenero.PerformLayout();
            this.gbnacionalidad.ResumeLayout(false);
            this.gbnacionalidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbgenero;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox gbnacionalidad;
        private System.Windows.Forms.Button btngenero;
        private System.Windows.Forms.Button btnnacionalidad;
        private System.Windows.Forms.Button btnsalir;
    }
}