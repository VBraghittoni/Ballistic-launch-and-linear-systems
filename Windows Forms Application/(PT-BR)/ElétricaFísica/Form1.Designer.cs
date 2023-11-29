namespace ElétricaFísica
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.SistemaL = new System.Windows.Forms.Button();
            this.LancamentoB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SistemaL
            // 
            this.SistemaL.BackColor = System.Drawing.Color.Transparent;
            this.SistemaL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SistemaL.FlatAppearance.BorderSize = 0;
            this.SistemaL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SistemaL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SistemaL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SistemaL.ForeColor = System.Drawing.Color.Transparent;
            this.SistemaL.Location = new System.Drawing.Point(446, 158);
            this.SistemaL.Name = "SistemaL";
            this.SistemaL.Size = new System.Drawing.Size(117, 119);
            this.SistemaL.TabIndex = 1;
            this.SistemaL.UseVisualStyleBackColor = false;
            this.SistemaL.Click += new System.EventHandler(this.SistemaL_Click_1);
            // 
            // LancamentoB
            // 
            this.LancamentoB.BackColor = System.Drawing.Color.Transparent;
            this.LancamentoB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LancamentoB.FlatAppearance.BorderSize = 0;
            this.LancamentoB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LancamentoB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LancamentoB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LancamentoB.ForeColor = System.Drawing.Color.Transparent;
            this.LancamentoB.Location = new System.Drawing.Point(260, 158);
            this.LancamentoB.Name = "LancamentoB";
            this.LancamentoB.Size = new System.Drawing.Size(121, 119);
            this.LancamentoB.TabIndex = 2;
            this.LancamentoB.UseVisualStyleBackColor = false;
            this.LancamentoB.Click += new System.EventHandler(this.LancamentoB_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElétricaFísica.Properties.Resources.Menu3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LancamentoB);
            this.Controls.Add(this.SistemaL);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SistemaL;
        private System.Windows.Forms.Button LancamentoB;
    }
}

