
namespace atividade_avaliativa_31_05_2021
{
    partial class cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nome_produto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome_fornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Qtd_produto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Produto";
            // 
            // Nome_produto
            // 
            this.Nome_produto.Location = new System.Drawing.Point(37, 40);
            this.Nome_produto.Name = "Nome_produto";
            this.Nome_produto.Size = new System.Drawing.Size(198, 20);
            this.Nome_produto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Fornecedor";
            // 
            // Nome_fornecedor
            // 
            this.Nome_fornecedor.Location = new System.Drawing.Point(37, 89);
            this.Nome_fornecedor.Name = "Nome_fornecedor";
            this.Nome_fornecedor.Size = new System.Drawing.Size(198, 20);
            this.Nome_fornecedor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // Qtd_produto
            // 
            this.Qtd_produto.Location = new System.Drawing.Point(37, 141);
            this.Qtd_produto.Name = "Qtd_produto";
            this.Qtd_produto.Size = new System.Drawing.Size(198, 20);
            this.Qtd_produto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor";
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(37, 192);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(198, 20);
            this.Valor.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Qtd_produto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nome_fornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome_produto);
            this.Controls.Add(this.label1);
            this.Name = "cadastro";
            this.Text = "cadastro";
            this.Load += new System.EventHandler(this.cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome_produto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nome_fornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Qtd_produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.Button button1;
    }
}