using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoDip
{
    public class Ley
    {
        private Reglamentos[] reglamentosDeLey;
        private string nombreDeLey;
        private  string contenidoDeLey;

        Reglamentos[] reg = new Reglamentos[5];


        public void setNombreDeLey(string nombreDeLey)
        {
            this.nombreDeLey = nombreDeLey;

        }
    }
}
