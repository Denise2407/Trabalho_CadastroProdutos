namespace Aula12
{
    partial class FormCadastro
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
            lblNome = new Label();
            btnSalvar = new Button();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            lblPreco = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15F);
            lblNome.Location = new Point(37, 44);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(89, 35);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(37, 237);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(318, 51);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(146, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(209, 27);
            txtNome.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(146, 125);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(209, 27);
            txtPreco.TabIndex = 4;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 15F);
            lblPreco.Location = new Point(37, 117);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(83, 35);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço:";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 354);
            Controls.Add(lblPreco);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(btnSalvar);
            Controls.Add(lblNome);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Button btnSalvar;
        private TextBox txtNome;
        private TextBox txtPreco;
        private Label lblPreco;
    }
}