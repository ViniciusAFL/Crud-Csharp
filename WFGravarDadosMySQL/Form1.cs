using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WFGravarDadosMySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=;database=db_agenda;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                string sql = "Insert into contato (nome,email,telefone) Values('"+txtNome.Text+"', '"+txtEmail.Text+"', +'"+txtTelefone.Text+"')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Cadastro inserido com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                Conexao.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                string q = " '%" + txt_busca + "%' ";

                string sql = "select * from contato where nome Like "+q+" or Email Like"+q;

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {

                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                };
                    //Criando uma linha
                    var linhaListView = new ListViewItem(row);

                    lst_contatos.Items.Add(linhaListView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void lst_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
