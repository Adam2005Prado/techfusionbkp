using Csharp_and_Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup2
{
    public partial class Form2 : Form
    {
        Classe_produto pct = new Classe_produto();


        public Form2(Classe_produto Produto, float tam)
        {
            InitializeComponent();
            pictureBox1.Image = Produto.imagem;
            label123.Text = Produto.nome;
            label123.Font = new Font(label123.Font.FontFamily, tam);
            preco.Text = Produto.preco.ToString();

            String[] itens = { "Pix", "Crédito", "Débito" };

            for (int i = 0; i < itens.Length; i++)
            {
                comboBox1.Items.Add(itens[i]);
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {
            //Connection cn = new Connection();
            //string preco = cn.obterdados("Select produto.preco_prod from produto where Cod_prod = 1").ToString();
            //label123.Text = preco;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pagar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                Classe_produto CP = new Classe_produto();
                preco3 = CP.preco;
                desconto = preco3 * 0.05;
            }
            else
            {
                desconto = preco3;
            }
            form3 form3 = new Form3(pct);
            form3.showDialog();
    }
    }
}