namespace Sistema_Empresarial
{
    partial class Form1
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
            this.Sistem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sistem
            // 
            this.Sistem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sistem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sistem.Location = new System.Drawing.Point(207, 9);
            this.Sistem.Name = "Sistem";
            this.Sistem.Size = new System.Drawing.Size(367, 38);
            this.Sistem.TabIndex = 2;
            this.Sistem.Text = "Sistema Empresarial";
            this.Sistem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAcessar);
            this.panel1.Controls.Add(this.txtEmpresa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(198, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 333);
            this.panel1.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(135, 137);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(199, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Text = "\r\n";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Red;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrar.Location = new System.Drawing.Point(135, 269);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 35);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Não Possui Cadastro?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.Blue;
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAcessar.Location = new System.Drawing.Point(135, 175);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(115, 35);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(135, 99);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(199, 20);
            this.txtEmpresa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sistem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Sistem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

