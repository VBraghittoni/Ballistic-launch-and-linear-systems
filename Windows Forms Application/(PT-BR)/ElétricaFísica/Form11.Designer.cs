namespace ElétricaFísica
{
    partial class SistemaL6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaL6));
            this.Menu = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(12, 404);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(89, 34);
            this.Menu.TabIndex = 10;
            this.Menu.Text = "Voltar ao Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // sair
            // 
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(699, 404);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(89, 34);
            this.sair.TabIndex = 11;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(95, 83);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(428, 117);
            this.resultado.TabIndex = 12;
            // 
            // SistemaL6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElétricaFísica.Properties.Resources.Elec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.Menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SistemaL6";
            this.Text = "SistemaL6";
            this.Load += new System.EventHandler(this.SistemaL6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.TextBox resultado;
    }
}