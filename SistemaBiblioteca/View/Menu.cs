using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{

    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Crud insert = new Crud();

            insert.Insert(txtNome.Text, txtAutor.Text, cbGenero.Text, richResumo.Text);
            MessageBox.Show(insert.msg);
        }



        private void btnRemover_Click(object sender, EventArgs e)
        {
            Crud remove = new Crud();
            int number;
            remove.Remove(number = Int32.Parse(maskedID.Text));
            

            MessageBox.Show(remove.msg);
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
