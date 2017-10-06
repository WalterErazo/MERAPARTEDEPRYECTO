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
    public partial class Form1 : Form
    {
        Usuario[] users = new Usuario[999];
        Grupo[] grupos = new Grupo[200];
        string usuarioActual;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Usuario[] u, Grupo[]g = null)
        {
            InitializeComponent();
            users = u;
            grupos = g;



        }
        string user;
        string pasw;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CrearU fcu = new CrearU();
            fcu.Show();
            this.Hide();

            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (txtContra.Text == "")
            {
                MessageBox.Show("Ingresar la contraseña.");       
            }
            else
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Ingresar el usuario.");
                }
                else
                {
                    if (txtContra.Text == "" && txtUsuario.Text == "")
                    {
                        MessageBox.Show("Favor llenar los espacios vacios.");
                    }
                }
            }
            user = txtUsuario.Text;
            pasw = txtContra.Text;


            for(int a=0; a < users.Length; a++)
            {
                if (users[a]!=null&&users[a].getId() == user && users[a].getContra() == pasw)
                {
                    usuarioActual = user;
                    menu mod = new menu(users, grupos,usuarioActual);
                    mod.Show();
                    break;
                }
                else
                   {
                    MessageBox.Show("NO se pudo iniciar sesion verifique el usuario y la contraseña");


                }
              
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
