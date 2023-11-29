namespace ElétricaFísica
{
    partial class SistemaL1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaL1));
            this.QtdEquacoes = new System.Windows.Forms.TextBox();
            this.qtd = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // QtdEquacoes
            // 
            this.QtdEquacoes.Location = new System.Drawing.Point(105, 82);
            this.QtdEquacoes.Multiline = true;
            this.QtdEquacoes.Name = "QtdEquacoes";
            this.QtdEquacoes.Size = new System.Drawing.Size(231, 68);
            this.QtdEquacoes.TabIndex = 4;
            this.QtdEquacoes.Text = "Olá, meu caro, agradeço por escolher o lado certo da força, bom agora quero que v" +
    "oce me diga quantas equações voce quer que eu utilize para efetuar o seu cálculo" +
    ":";
            // 
            // qtd
            // 
            this.qtd.FormattingEnabled = true;
            this.qtd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.qtd.Location = new System.Drawing.Point(269, 129);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(67, 21);
            this.qtd.TabIndex = 5;
            this.qtd.SelectedIndexChanged += new System.EventHandler(this.caminho_SelectedIndexChanged);
            // 
            // SistemaL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElétricaFísica.Properties.Resources.Elec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.QtdEquacoes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SistemaL1";
            this.Text = "SistemaL1";
            this.Load += new System.EventHandler(this.SistemaL1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QtdEquacoes;
        private System.Windows.Forms.ComboBox qtd;
    }
}