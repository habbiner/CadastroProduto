using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_avaliativa_31_05_2021
{
    public partial class cadastro : Form
    {
        Produto produto = new Produto();

        public cadastro()
        {
            InitializeComponent();
        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                produtos produtos = new produtos();
                produtos.nome_produto = Nome_produto.Text;
                produtos.nome_fornecedor = Nome_fornecedor.Text;
                produtos.qtd_produto = Convert.ToInt32(Qtd_produto.Text);
                produtos.valor = Convert.ToInt32(Valor.Text);
                produto.inserirDados(produtos);
                MessageBox.Show("Produto inserido com sucesso!");
                Form1.instancia.atualizar_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir produto.\nDetalhes:" + ex.ToString());
            }
        }
    }
}
