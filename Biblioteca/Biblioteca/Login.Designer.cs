﻿namespace Biblioteca
{
    partial class Login
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
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.ingresarButton = new System.Windows.Forms.Button();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.codigoTextBox.Location = new System.Drawing.Point(46, 76);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(187, 20);
            this.codigoTextBox.TabIndex = 0;
            this.codigoTextBox.Text = "Usuario";
            // 
            // ingresarButton
            // 
            this.ingresarButton.Location = new System.Drawing.Point(99, 157);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(75, 23);
            this.ingresarButton.TabIndex = 2;
            this.ingresarButton.Text = "Ingresar";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.ingresarButton_Click);
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.contraseñaTextBox.Location = new System.Drawing.Point(46, 115);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(187, 20);
            this.contraseñaTextBox.TabIndex = 3;
            this.contraseñaTextBox.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(this.ingresarButton);
            this.Controls.Add(this.codigoTextBox);
            this.Name = "Login";
            this.Text = "LoginBibliotecarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Button ingresarButton;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.Label label1;
    }
}