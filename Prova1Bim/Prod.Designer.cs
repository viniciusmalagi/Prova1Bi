namespace Prova1Bim
{
    partial class Prod
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.btn_pesquisa = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(142, 112);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(42, 20);
            this.txt_id.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Produto";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(76, 177);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(169, 20);
            this.txt_produto.TabIndex = 4;
            this.txt_produto.TextChanged += new System.EventHandler(this.txt_produto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor R$";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(317, 177);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(59, 20);
            this.txt_valor.TabIndex = 6;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(305, 242);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 10;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(224, 242);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 9;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(142, 242);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_Alterar.TabIndex = 8;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(59, 242);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 7;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // btn_pesquisa
            // 
            this.btn_pesquisa.Location = new System.Drawing.Point(204, 109);
            this.btn_pesquisa.Name = "btn_pesquisa";
            this.btn_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_pesquisa.TabIndex = 13;
            this.btn_pesquisa.Text = "Buscar";
            this.btn_pesquisa.UseVisualStyleBackColor = true;
            this.btn_pesquisa.Click += new System.EventHandler(this.btn_pesquisa_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(301, 109);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 14;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 340);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_pesquisa);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Prod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Button btn_pesquisa;
        private System.Windows.Forms.Button btn_limpar;
    }
}