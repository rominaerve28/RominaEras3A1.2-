using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gasolinera.class1
{
    public class Gasolina
    {
        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int cgasolina;

        public int Cgasolina
        {
            get{return cgasolina; }
            set { cgasolina = value; }
        }

        private double precioven;

        public double Precioven
        {
            get {
                if (tipo == "Extra")
                {

                    return precioven = 1.5f;
                }else
                {
                    return precioven= 2; 
                }

               

            }
           
        }

        private double subtotal;

        public double Subtotal
        {
            get { return subtotal= precioven *cgasolina; }

        }

        private double iva;

        public double Iva
        {
            get { return iva= subtotal* 0.12f; }
         
        }

        private double total;

        public double Total
        {
            get { return total= subtotal+iva ; }
      
        }




    }
}
