using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDip
{
    public partial class ModificarReglamento : Form
    {
        public ModificarReglamento()
        {
            InitializeComponent();
        }
        String AntiguoReglamento;
        String NuevoReglamento; 
        private void button1_Click(object sender, EventArgs e)
        {
            AntiguoReglamento = richTextBox1.Text;
            NuevoReglamento = richTextBox2.Text;

            if (AntiguoReglamento == "" && NuevoReglamento ==  "")
            {
                MessageBox.Show("No dejar cuadros de texto en Blaco.");                
            }
            else
            {
            if(NuevoReglamento == "")
            {
                MessageBox.Show("Ingrese Nuevo Reglamento.");
            }
            else
            {
                if (AntiguoReglamento == "")
                {
                    MessageBox.Show("Ingresar antiguo reglamento a modificar.");
                }
                else
                {
                    if (AntiguoReglamento != "" && NuevoReglamento != "")
                    {
                        MessageBox.Show("Reglamento Modificado.");
                    }
                }
            }
            }

        }
    }
}
