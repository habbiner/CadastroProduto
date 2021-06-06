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
    public partial class Form1 : Form
    {
        Produto produto = new Produto();

        public static Form1 instancia;

        public Form1()
        {
            InitializeComponent();
            instancia = this;
            atualizar_grid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new cadastro().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            produto.testar_conexao();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            atualizar_grid();
        }

        public void atualizar_grid()
        {
            List<produtos> produtos = produto.selecionarTodos();
            dgv_produtos.DataSource = produtos;
            dgv_produtos.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id_produto = Convert.ToInt32(deletar_txt.Text);
            int linhas_afetadas = produto.delete(id_produto);
            if (linhas_afetadas == 0)
            {
                MessageBox.Show("Nenhum registro removido. Verifique o ID digitado!");
            }
            else
            {
                MessageBox.Show(linhas_afetadas + " registro removido do banco de dados");
                atualizar_grid();
            }
        }

        private void deletar_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            atualizar_grid();
        }
    }
}
