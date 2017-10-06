using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDip
{
    class Sisley
    {
        
        public void crearUsuario(string id, string cargo, string grupo)
        {
            Usuario user = new Usuario();
            user.setId(id);
            user.setCargo(cargo);
            user.setGrupo(grupo);


        }
       
    }
}
