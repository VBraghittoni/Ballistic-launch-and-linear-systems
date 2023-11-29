namespace ElétricaFísica
{
    partial class LancamentoB3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LancamentoB3));
            this.explicacao = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // explicacao
            // 
            this.explicacao.Location = new System.Drawing.Point(137, 12);
            this.explicacao.Multiline = true;
            this.explicacao.Name = "explicacao";
            this.explicacao.Size = new System.Drawing.Size(516, 64);
            this.explicacao.TabIndex = 8;
            this.explicacao.TextChanged += new System.EventHandler(this.explicacao_TextChanged);
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(12, 404);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(89, 34);
            this.Menu.TabIndex = 9;
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
            this.sair.TabIndex = 10;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // LancamentoB3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.explicacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LancamentoB3";
            this.Text = "LancamentoB3";
            this.Load += new System.EventHandler(this.LancamentoB3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox explicacao;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button sair;
    }
}