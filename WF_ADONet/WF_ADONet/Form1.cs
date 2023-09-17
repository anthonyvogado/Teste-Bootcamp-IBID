using System.Data;

namespace WF_ADONet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Item item = new Item();

            DataTable dt = new DataTable();

            dt = item.retornaTodosOsItens();

            dataGridView1.DataSource = dt;
        }
        private void button_adicionarItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.nome = textBox_nomeAdicionar.Text;

            if (item.adicionar())
            {
                MessageBox.Show("Adicionado com sucesso!");

                DataTable dt = new DataTable();

                dt = item.retornaTodosOsItens();

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Erro ao adicionar!");
            }
        }

        private void button_editarItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.nome = textBox_nomeEditar.Text;
            item.id = int.Parse(textBox_idEditar.Text);

            if (item.editar())
            {
                MessageBox.Show("Editado com sucesso!");

                DataTable dt = new DataTable();

                dt = item.retornaTodosOsItens();

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Erro ao editar!");
            }
        }

        private void button_removerItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.id = int.Parse(textBox_idRemover.Text);

            if (item.remover())
            {
                MessageBox.Show("Removido com sucesso!");

                DataTable dt = new DataTable();

                dt = item.retornaTodosOsItens();

                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Erro ao remover!");
            }
        }
    }
}