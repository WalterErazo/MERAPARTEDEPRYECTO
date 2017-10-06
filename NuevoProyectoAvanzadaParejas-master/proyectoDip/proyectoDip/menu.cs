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
    public partial class menu : Form
    {
        Grupo[] grupos = new Grupo[200];
        Usuario[] users = new Usuario[999];
        string usuarioActualM;
        public menu()
        {
            InitializeComponent();
        }
        public menu(Usuario[] u,Grupo[] g ,string UsuarioActual="")
        {
            InitializeComponent();

            users = u;
            usuarioActualM = UsuarioActual;
            grupos = g;
        }


        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            modificar_usuario mod = new modificar_usuario(users,grupos,usuarioActualM);
            mod.Show();
            this.Hide();
        }
    }
}
