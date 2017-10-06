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
    public partial class modificar_usuario : Form
    {
        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        string usuarioActualM;
        int numarreglo=0;
       
        
    
        
        public modificar_usuario( Usuario[] u,Grupo[] g, string usuarioActual )
        {
            InitializeComponent();
            users = u;
            grupos = g;

            users = u;
            usuarioActualM = usuarioActual;

            for(int i =0; i < users.Length; i++)
            {
                if (users[i].getId() == usuarioActual)
                {
                    numarreglo = i;
                    break;
                }
            }
            txtID.Text = users[numarreglo].getId();
            txtCargo.Text = users[numarreglo].getCargo();
            txtGrupo.Text = users[numarreglo].getGrupo();
            txtContra.Text = users[numarreglo].getContra();


        }

        private void modificar_usuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labID_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          

           
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                users[numarreglo].setId(txtID.Text);
                users[numarreglo].setCargo(txtCargo.Text);
                users[numarreglo].setGrupo(txtGrupo.Text);
                users[numarreglo].setContra(txtContra.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtCargo.Text = "";
            txtGrupo.Text = "";
            txtContra.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
