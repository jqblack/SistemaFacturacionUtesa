﻿namespace GUI_V_2
{
    partial class Clientes
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
            this.TelCli = new GUI_V_2.ErrorTxtBox();
            this.DirCli = new GUI_V_2.ErrorTxtBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TipCli = new System.Windows.Forms.ComboBox();
            this.CorCli = new GUI_V_2.ErrorTxtBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.Text = "CLIENTES";
            // 
            // bnt_eliminar
            // 
            this.bnt_eliminar.FlatAppearance.BorderSize = 0;
            this.bnt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(44, 336);
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(162, 333);
            this.estado.Size = new System.Drawing.Size(137, 28);
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(162, 102);
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(162, 58);
            // 
            // TelCli
            // 
            this.TelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelCli.Location = new System.Drawing.Point(162, 142);
            this.TelCli.Name = "TelCli";
            this.TelCli.Size = new System.Drawing.Size(137, 26);
            this.TelCli.TabIndex = 107;
            this.TelCli.Validar = true;
            // 
            // DirCli
            // 
            this.DirCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirCli.Location = new System.Drawing.Point(162, 188);
            this.DirCli.Name = "DirCli";
            this.DirCli.Size = new System.Drawing.Size(137, 26);
            this.DirCli.TabIndex = 108;
            this.DirCli.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(40, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 110;
            this.label3.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(40, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 111;
            this.label4.Text = "DIRECCION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(40, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 112;
            this.label6.Text = "TIPO CLIENTE";
            // 
            // TipCli
            // 
            this.TipCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TipCli.FormattingEnabled = true;
            this.TipCli.Items.AddRange(new object[] {
            "NORMAL",
            "FAMILIA",
            "MAYOR"});
            this.TipCli.Location = new System.Drawing.Point(162, 235);
            this.TipCli.Name = "TipCli";
            this.TipCli.Size = new System.Drawing.Size(137, 28);
            this.TipCli.TabIndex = 113;
            // 
            // CorCli
            // 
            this.CorCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorCli.Location = new System.Drawing.Point(162, 284);
            this.CorCli.Name = "CorCli";
            this.CorCli.Size = new System.Drawing.Size(137, 26);
            this.CorCli.TabIndex = 114;
            this.CorCli.Validar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(40, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 115;
            this.label7.Text = "CORREO";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 553);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CorCli);
            this.Controls.Add(this.TipCli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirCli);
            this.Controls.Add(this.TelCli);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Controls.SetChildIndex(this.TelCli, 0);
            this.Controls.SetChildIndex(this.DirCli, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TipCli, 0);
            this.Controls.SetChildIndex(this.btn_guardar, 0);
            this.Controls.SetChildIndex(this.bnt_eliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.Codigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Nom, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            this.Controls.SetChildIndex(this.CorCli, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorTxtBox TelCli;
        private ErrorTxtBox DirCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TipCli;
        private ErrorTxtBox CorCli;
        private System.Windows.Forms.Label label7;
    }
}