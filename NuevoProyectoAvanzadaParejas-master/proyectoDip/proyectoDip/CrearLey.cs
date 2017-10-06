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
    public partial class CrearLey : Form
    {
        public CrearLey()
        {
            InitializeComponent();
        }

        String IngreseLey;
        private void button1_Click(object sender, EventArgs e)
        {
            IngreseLey = richTextBox1.Text;
            if (IngreseLey == "")
            {
                MessageBox.Show("Ingrese Nueva Ley.");
            }
            else
            {
                if (IngreseLey != "")
                {
                    MessageBox.Show("Ley Creada con Exito.");
                }
            }

        }
    }
}
