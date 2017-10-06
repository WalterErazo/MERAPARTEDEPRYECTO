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
    public partial class CrearU : Form
    {
         Grupo[] grupos = new Grupo[200];
         Usuario[] users = new Usuario[999];
        string grup;
        public CrearU()
        {
            InitializeComponent();
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" && txtGrupo.Text == "" && txtContra.Text == "" && txtCargo.Text == "")
            {
                MessageBox.Show("Por Favor llenar todos los cuadros de texto.");

            }
            else
            {
                if (txtCargo.Text == "")
                {
                    MessageBox.Show("Ingresar Cargo que desempaña.");

                }
                else
                {
                    if (txtContra.Text == "")
                    {
                        MessageBox.Show("Ingresar Contraseña.");
                    }
                    else
                    {
                        if (txtGrupo.Text == "")
                        {
                            MessageBox.Show("Ingresar el Grupo que pertenece.");
                        }
                        else
                        {
                            if (txtId.Text == "")
                            {
                                MessageBox.Show("Ingresar ID.");
                            }
                        }
                    }
                }
            }

            Usuario user = new Usuario();
            user.setId(txtId.Text);
            user.setCargo(txtCargo.Text);
            user.setGrupo(txtGrupo.Text);
            user.setContra(txtContra.Text);
            grup = txtGrupo.Text;
            if (txtCargo.Text == "parlamentario" || txtCargo.Text == "Parlamentario")
            {
                Grupo grupObj = new Grupo();
                grupObj.setNombre(txtGrupo.Text);
                grupObj.setParlamentario(user);
                for (int i = 0; i < 200; i++)
                {
                    if (grupos[i] == null)
                    {
                        grupos[i] = grupObj;
                        break;

                    }
                    else if (grupos[i] != null)
                    {
                        if (grupos[i].getNombre() == txtGrupo.Text || grupos[i].getParlamentario() == user)
                        {
                            MessageBox.Show("El grupo ya existe y posee un parlamentario");
                            break;
                        }

                    }

                }
            }

            else if (txtCargo.Text == "Asesor" || txtCargo.Text == "asesor")
            {
                for (int i = 0; i < 200; i++)
                {
                    if (grupos[i] != null && grupos[i].getNombre() != user.getGrupo())
                    {
                        MessageBox.Show("el grupo al que intenta incorporarse no existe");
                    }
                    else if (grupos[i] != null && grupos[i].getNombre() == user.getGrupo())
                    {
                        if (grupos[i].VerificarAsesor(user) == false)
                        {
                            grupos[i].asignarAsesor(user);
                            MessageBox.Show("agregado al grupo");
                        }
                        else if (grupos[i].VerificarAsesor(user) == true)
                        {
                            MessageBox.Show("el ususario ya pertenece al grupo");
                        }
                        else if (grupos[i].AsesoresEnGrupo() == 8)
                        {
                            MessageBox.Show("no se puede agregar al grupo, numero maximo de asesores alcanzado");


                        }

                    }
                }



            }


            for (int i = 0; i < 999; i++)
            {
                if (users[i] == null)
                {
                    users[i] = user;
                }
                break;
            }
          
            
            
            Form1 f1 = new Form1(users);
            f1.Show();
            this.Hide();
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearU_Load(object sender, EventArgs e)
        {

        }
    }
}
