using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDip
{
   public class Usuario
    {
        private string id;
        private string cargo;
        private string grupo;
        private string contra;

        Ley[] bajoPrestamo = new Ley[8];
        public string getContra()
        {
            return this.contra;
        }
        public void setContra(string contra)
        {
            this.contra = contra;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return this.id;
        }
        public string getCargo()
        {
            return this.cargo;
        }
        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }
        public void setGrupo(string grupo)
        {
            this.grupo = grupo;
        }
        public string getGrupo()
        {
            return grupo;
        }
    }
}
