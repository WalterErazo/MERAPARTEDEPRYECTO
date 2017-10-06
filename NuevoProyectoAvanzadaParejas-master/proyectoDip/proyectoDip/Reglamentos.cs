using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDip
{
    
    public class Reglamentos
    {
        private string inforeglamento = "";

        public void setInfoReglamento(string inforeglamento)
        {
            this.inforeglamento = inforeglamento;
        }
        public string getInfoReglamento()
        {
            return inforeglamento;
        }
    }

  
}