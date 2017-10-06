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
    public partial class ModificarLey : Form
    {
        public ModificarLey()
        {
            InitializeComponent();
        }
        String AntiguaLey;
        String NuevaLey;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevaLey = richTextBox1.Text;
            AntiguaLey = richTextBox2.Text;

            if(NuevaLey == "" && AntiguaLey == "")
            {
                MessageBox.Show("No dejar Cuadros de texto Vacios.");
            }
            else
            {
                if (AntiguaLey == "")
                {
                    MessageBox.Show("Ingresar Ley que dese Modificar.");
                }
                else
                {
                    if (NuevaLey == "")
                    {
                        MessageBox.Show("Ingresear Nueva Ley.");
                    }
                    else
                    {
                        if (NuevaLey != "" && AntiguaLey != "")
                        {
                            MessageBox.Show("Ley fue Modificada Correctamente.");
                        }
                    }
                }
            }


 
        }
    }
}
