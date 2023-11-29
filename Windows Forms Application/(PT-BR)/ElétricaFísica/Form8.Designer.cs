namespace ElétricaFísica
{
    partial class SistemaL3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaL3));
            this.Enter = new System.Windows.Forms.Button();
            this.variavel3 = new System.Windows.Forms.TextBox();
            this.variavel4 = new System.Windows.Forms.TextBox();
            this.resultado2 = new System.Windows.Forms.TextBox();
            this.resultado1 = new System.Windows.Forms.TextBox();
            this.variavel2 = new System.Windows.Forms.TextBox();
            this.variavel1 = new System.Windows.Forms.TextBox();
            this.instrucoes = new System.Windows.Forms.TextBox();
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
            this.Enter.Location = new System.Drawing.Point(12, 12);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 1;
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // variavel3
            // 
            this.variavel3.Location = new System.Drawing.Point(105, 169);
            this.variavel3.Name = "variavel3";
            this.variavel3.Size = new System.Drawing.Size(74, 20);
            this.variavel3.TabIndex = 8;
            this.variavel3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variavel3_KeyPress);
            // 
            // variavel4
            // 
            this.variavel4.Location = new System.Drawing.Point(203, 169);
            this.variavel4.Name = "variavel4";
            this.variavel4.Size = new System.Drawing.Size(74, 20);
            this.variavel4.TabIndex = 9;
            this.variavel4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variavel4_KeyPress);
            // 
            // resultado2
            // 
            this.resultado2.Location = new System.Drawing.Point(303, 169);
            this.resultado2.Name = "resultado2";
            this.resultado2.Size = new System.Drawing.Size(74, 20);
            this.resultado2.TabIndex = 10;
            this.resultado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resultado2_KeyPress);
            // 
            // resultado1
            // 
            this.resultado1.Location = new System.Drawing.Point(303, 143);
            this.resultado1.Name = "resultado1";
            this.resultado1.Size = new System.Drawing.Size(74, 20);
            this.resultado1.TabIndex = 11;
            this.resultado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resultado1_KeyPress);
            // 
            // variavel2
            // 
            this.variavel2.Location = new System.Drawing.Point(203, 143);
            this.variavel2.Name = "variavel2";
            this.variavel2.Size = new System.Drawing.Size(74, 20);
            this.variavel2.TabIndex = 12;
            this.variavel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variavel2_KeyPress);
            // 
            // variavel1
            // 
            this.variavel1.Location = new System.Drawing.Point(105, 143);
            this.variavel1.Name = "variavel1";
            this.variavel1.Size = new System.Drawing.Size(74, 20);
            this.variavel1.TabIndex = 13;
            this.variavel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variavel1_KeyPress);
            // 
            // instrucoes
            // 
            this.instrucoes.Location = new System.Drawing.Point(94, 79);
            this.instrucoes.Multiline = true;
            this.instrucoes.Name = "instrucoes";
            this.instrucoes.Size = new System.Drawing.Size(294, 121);
            this.instrucoes.TabIndex = 14;
            // 
            // SistemaL3
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElétricaFísica.Properties.Resources.Elec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.variavel1);
            this.Controls.Add(this.variavel2);
            this.Controls.Add(this.resultado1);
            this.Controls.Add(this.resultado2);
            this.Controls.Add(this.variavel4);
            this.Controls.Add(this.variavel3);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.instrucoes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SistemaL3";
            this.Text = "SistemaL3";
            this.Load += new System.EventHandler(this.SistemaL3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox variavel3;
        private System.Windows.Forms.TextBox variavel4;
        private System.Windows.Forms.TextBox resultado2;
        private System.Windows.Forms.TextBox resultado1;
        private System.Windows.Forms.TextBox variavel2;
        private System.Windows.Forms.TextBox variavel1;
        private System.Windows.Forms.TextBox instrucoes;
    }
}