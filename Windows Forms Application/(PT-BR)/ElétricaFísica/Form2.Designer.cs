namespace ElétricaFísica
{
    partial class LancamentoB1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LancamentoB1));
            this.Enter = new System.Windows.Forms.Button();
            this.distancia = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.instrucoes1 = new System.Windows.Forms.TextBox();
            this.instrucao1 = new System.Windows.Forms.TextBox();
            this.instrucao2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.Transparent;
            this.Enter.FlatAppearance.BorderSize = 0;
            this.Enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter.ForeColor = System.Drawing.Color.Transparent;
            this.Enter.Location = new System.Drawing.Point(12, -13);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(57, 11);
            this.Enter.TabIndex = 2;
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // distancia
            // 
            this.distancia.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.distancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distancia.ForeColor = System.Drawing.SystemColors.Menu;
            this.distancia.Location = new System.Drawing.Point(418, 192);
            this.distancia.Name = "distancia";
            this.distancia.Size = new System.Drawing.Size(261, 20);
            this.distancia.TabIndex = 3;
            this.distancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distancia_KeyPress_1);
            // 
            // altura
            // 
            this.altura.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.altura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.altura.ForeColor = System.Drawing.SystemColors.Menu;
            this.altura.Location = new System.Drawing.Point(418, 238);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(261, 20);
            this.altura.TabIndex = 4;
            this.altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.altura_KeyPress);
            // 
            // instrucoes1
            // 
            this.instrucoes1.ForeColor = System.Drawing.Color.Black;
            this.instrucoes1.Location = new System.Drawing.Point(332, 63);
            this.instrucoes1.Multiline = true;
            this.instrucoes1.Name = "instrucoes1";
            this.instrucoes1.Size = new System.Drawing.Size(347, 90);
            this.instrucoes1.TabIndex = 8;
            // 
            // instrucao1
            // 
            this.instrucao1.ForeColor = System.Drawing.Color.Black;
            this.instrucao1.Location = new System.Drawing.Point(332, 192);
            this.instrucao1.Multiline = true;
            this.instrucao1.Name = "instrucao1";
            this.instrucao1.Size = new System.Drawing.Size(80, 20);
            this.instrucao1.TabIndex = 9;
            this.instrucao1.Text = "Horizontal:";
            // 
            // instrucao2
            // 
            this.instrucao2.ForeColor = System.Drawing.Color.Black;
            this.instrucao2.Location = new System.Drawing.Point(332, 238);
            this.instrucao2.Multiline = true;
            this.instrucao2.Name = "instrucao2";
            this.instrucao2.Size = new System.Drawing.Size(80, 20);
            this.instrucao2.TabIndex = 10;
            this.instrucao2.Text = "Vertical:";
            // 
            // LancamentoB1
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElétricaFísica.Properties.Resources.Fis;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instrucao2);
            this.Controls.Add(this.instrucao1);
            this.Controls.Add(this.instrucoes1);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.distancia);
            this.Controls.Add(this.Enter);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LancamentoB1";
            this.Text = "LancamentoB1";
            this.Load += new System.EventHandler(this.LancamentoB1_Load);
            this.Click += new System.EventHandler(this.Enter_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox distancia;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.TextBox instrucoes1;
        private System.Windows.Forms.TextBox instrucao1;
        private System.Windows.Forms.TextBox instrucao2;
    }
}