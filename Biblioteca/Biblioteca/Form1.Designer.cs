namespace Biblioteca
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
            this.librosButton = new System.Windows.Forms.Button();
            this.sistemaButton = new System.Windows.Forms.Button();
            this.tesisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // librosButton
            // 
            this.librosButton.Location = new System.Drawing.Point(61, 41);
            this.librosButton.Name = "librosButton";
            this.librosButton.Size = new System.Drawing.Size(163, 49);
            this.librosButton.TabIndex = 0;
            this.librosButton.Text = "LIBROS";
            this.librosButton.UseVisualStyleBackColor = true;
            this.librosButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sistemaButton
            // 
            this.sistemaButton.Location = new System.Drawing.Point(61, 173);
            this.sistemaButton.Name = "sistemaButton";
            this.sistemaButton.Size = new System.Drawing.Size(163, 49);
            this.sistemaButton.TabIndex = 1;
            this.sistemaButton.Text = "SISTEMA BIBLIOTECARIOS";
            this.sistemaButton.UseVisualStyleBackColor = true;
            this.sistemaButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tesisButton
            // 
            this.tesisButton.Location = new System.Drawing.Point(61, 96);
            this.tesisButton.Name = "tesisButton";
            this.tesisButton.Size = new System.Drawing.Size(163, 49);
            this.tesisButton.TabIndex = 2;
            this.tesisButton.Text = "TESIS";
            this.tesisButton.UseVisualStyleBackColor = true;
            this.tesisButton.Click += new System.EventHandler(this.tesisButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tesisButton);
            this.Controls.Add(this.sistemaButton);
            this.Controls.Add(this.librosButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button librosButton;
        private System.Windows.Forms.Button sistemaButton;
        private System.Windows.Forms.Button tesisButton;
    }
}

