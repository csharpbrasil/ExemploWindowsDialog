using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWindowsDialog
{
    public partial class UserControl1 : UserControl    
    {   
        public Cliente ClienteSelecionado { get; set; }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            DialogResult result = form2.ShowDialog();

            if (result == DialogResult.OK)
            {
                var cliente = form2.ClienteSelecionado;
                textBox1.Text = cliente.Nome;
            }
            else
            {
                MessageBox.Show("Nada foi selecionado");
            }
        }
    }
}
