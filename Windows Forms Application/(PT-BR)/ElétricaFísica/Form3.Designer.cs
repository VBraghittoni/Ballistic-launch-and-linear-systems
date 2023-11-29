namespace ElétricaFísica
{
    partial class LancamentoB2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LancamentoB2));
            this.radiano = new System.Windows.Forms.TextBox();
            this.instrucoes2 = new System.Windows.Forms.TextBox();
            this.Canimacao = new System.Windows.Forms.Button();
            this.angulo = new System.Windows.Forms.TextBox();
            this.Sanimacao = new System.Windows.Forms.Button();
            this.instrucao1 = new System.Windows.Forms.TextBox();
            this.instrucao2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radiano
            // 
            this.radiano.Location = new System.Drawing.Point(512, 240);
            this.radiano.Name = "radiano";
            this.radiano.Size = new System.Drawing.Size(153, 20);
            this.radiano.TabIndex = 5;
            this.radiano.TextChanged += new System.EventHandler(this.angulo_TextChanged);
            this.radiano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radiano_KeyPress);
            // 
            // instrucoes2
            // 
            this.instrucoes2.Location = new System.Drawing.Point(328, 58);
            this.instrucoes2.Multiline = true;
            this.instrucoes2.Name = "instrucoes2";
            this.instrucoes2.Size = new System.Drawing.Size(347, 90);
            this.instrucoes2.TabIndex = 7;
            // 
            // Canimacao
            // 
            this.Canimacao.BackColor = System.Drawing.Color.Transparent;
            this.Canimacao.ForeColor = System.Drawing.Color.Black;
            this.Canimacao.Location = new System.Drawing.Point(12, 398);
            this.Canimacao.Name = "Canimacao";
            this.Canimacao.Size = new System.Drawing.Size(92, 40);
            this.Canimacao.TabIndex = 8;
            this.Canimacao.Text = "Com animação";
            this.Canimacao.UseVisualStyleBackColor = false;
            this.Canimacao.Click += new System.EventHandler(this.Canimacao_Click);
            // 
            // angulo
            // 
            this.angulo.Location = new System.Drawing.Point(328, 240);
            this.angulo.Name = "angulo";
            this.angulo.Size = new System.Drawing.Size(153, 20);
            this.angulo.TabIndex = 9;
            this.angulo.TextChanged += new System.EventHandler(this.radiano_TextChanged_1);
            this.angulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.angulo_KeyPress_1);
            // 
            // Sanimacao
            // 
            this.Sanimacao.BackColor = System.Drawing.Color.Transparent;
            this.Sanimacao.ForeColor = System.Drawing.Color.Black;
            this.Sanimacao.Location = new System.Drawing.Point(694, 398);
            this.Sanimacao.Name = "Sanimacao";
            this.Sanimacao.Size = new System.Drawing.Size(94, 40);
            this.Sanimacao.TabIndex = 10;
            this.Sanimacao.Text = "Sem animação";
            this.Sanimacao.UseVisualStyleBackColor = false;
            this.Sanimacao.Click += new System.EventHandler(this.Sanimacao_Click);
            // 
            // instrucao1
            // 
            this.instrucao1.ForeColor = System.Drawing.Color.Black;
            this.instrucao1.Location = new System.Drawing.Point(360, 215);
            this.instrucao1.Multiline = true;
            this.instrucao1.Name = "instrucao1";
            this.instrucao1.Size = new System.Drawing.Size(80, 20);
            this.instrucao1.TabIndex = 11;
            this.instrucao1.Text = "Em graus:";
            // 
            // instrucao2
            // 
            this.instrucao2.ForeColor = System.Drawing.Color.Black;
            this.instrucao2.Location = new System.Drawing.Point(547, 215);
            this.instrucao2.Multiline = true;
            this.instrucao2.Name = "instrucao2";
            this.instrucao2.Size = new System.Drawing.Size(80, 20);
            this.instrucao2.TabIndex = 12;
            this.instrucao2.Text = "Em radianos:";
            // 
            // LancamentoB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElétricaFísica.Properties.Resources.Fis;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instrucao2);
            this.Controls.Add(this.instrucao1);
            this.Controls.Add(this.Sanimacao);
            this.Controls.Add(this.angulo);
            this.Controls.Add(this.Canimacao);
            this.Controls.Add(this.instrucoes2);
            this.Controls.Add(this.radiano);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LancamentoB2";
            this.Text = "LancamentoB2";
            this.Load += new System.EventHandler(this.LancamentoB2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox radiano;
        private System.Windows.Forms.TextBox instrucoes2;
        private System.Windows.Forms.Button Canimacao;
        private System.Windows.Forms.TextBox angulo;
        private System.Windows.Forms.Button Sanimacao;
        private System.Windows.Forms.TextBox instrucao1;
        private System.Windows.Forms.TextBox instrucao2;
    }
}