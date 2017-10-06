using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDip
{
   public class Grupo
    {
        string nombre;
        Usuario parlamentario;
        Usuario[] asesores = new Usuario[8];
        int agregado = 0;
        int contador;

        public int getAgregado()
        {
            return agregado;
        }
        public void setNombre(string n)
        {
            this.nombre = n;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setParlamentario(Usuario p)
        {
            this.parlamentario = p;
        }
        public Usuario getParlamentario()
        {
            return parlamentario;
        }
        public void asignarAsesor(Usuario a)
        {

            for (int i = 0; i < 8; i++)
            {
                if (asesores[i] == a)
                {
                    agregado = 0;
                }
                if (asesores[i] != null)
                {
                    asesores[i] = a;
                    agregado = 1;
                }
                else
                {
                    agregado = -1;
                }

            }
        }
            public bool VerificarAsesor(Usuario a)
        {
            for (int i = 0; i < 8; i++)
            {
                if (asesores[i]!= null&& asesores[i] == a)
                {
                    return true;
                    break;
                }
               
            }
            return false;
            }
        public int AsesoresEnGrupo()
        {
            for (int i = 0; i < 8; i++)
            {
                if (asesores[i] != null)
                {
                    contador+=1;
                }
            }
            return contador;

        }
        }
    }

