using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWindowsDialog
{
    public partial class Form2 : Form
    {
        public Cliente ClienteSelecionado { get; internal set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var lstClientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nome = "João" },
                new Cliente { Id = 2, Nome = "Carlos" },
                new Cliente { Id = 3, Nome = "Pedro" },
                new Cliente { Id = 4, Nome = "Marcos" },
                new Cliente { Id = 5, Nome = "Roger" },
            };

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lstClientes;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cliente = (Cliente)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                this.ClienteSelecionado = cliente;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
