using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasolinera.class1
{
    public class Cliente
    {

       

        private long ncedula;

        public long Ncedula
        {
            get { return ncedula; }
            set { ncedula = value; }
        }


        private String nombres;

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private String apellidos;

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private String direccion;

       
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

    }
}
