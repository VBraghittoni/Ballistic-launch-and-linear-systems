namespace ElétricaFísica
{
    partial class SistemaL2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaL2));
            this.Enter = new System.Windows.Forms.Button();
            this.resultado1 = new System.Windows.Forms.TextBox();
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
            // resultado1
            // 
            this.resultado1.Location = new System.Drawing.Point(236, 118);
            this.resultado1.Name = "resultado1";
            this.resultado1.Size = new System.Drawing.Size(74, 20);
            this.resultado1.TabIndex = 8;
            this.resultado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resultado1_KeyPress);
            // 
            // variavel1
            // 
            this.variavel1.Location = new System.Drawing.Point(129, 118);
            this.variavel1.Name = "variavel1";
            this.variavel1.Size = new System.Drawing.Size(74, 20);
            this.variavel1.TabIndex = 9;
            this.variavel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.variavel1_KeyPress);
            // 
            // instrucoes
            // 
            this.instrucoes.Location = new System.Drawing.Point(102, 79);
            this.instrucoes.Multiline = true;
            this.instrucoes.Name = "instrucoes";
            this.instrucoes.Size = new System.Drawing.Size(231, 68);
            this.instrucoes.TabIndex = 10;
            // 
            // SistemaL2
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ElétricaFísica.Properties.Resources.Elec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.variavel1);
            this.Controls.Add(this.resultado1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.instrucoes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SistemaL2";
            this.Text = "SistemaL2";
            this.Load += new System.EventHandler(this.SistemaL2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox resultado1;
        private System.Windows.Forms.TextBox variavel1;
        private System.Windows.Forms.TextBox instrucoes;
    }
}