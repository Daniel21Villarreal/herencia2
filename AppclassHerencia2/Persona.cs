using System;
using System.Collections.Generic;
using System.Text;

namespace AppclassHerencia2
{
    class Persona
    {
        protected double nombre;

        public double Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public Persona()
        {
            nombre = 0;
        }
        public Persona(int persona)
        {
            this.nombre = persona;
        }
        public double fechadenacimiento(Persona p)
        {
            double d = 0;
            d = nombre - p.nombre;
            d = Math.Abs(d);// Valor Absoluto
            return d;
        }
        public override string ToString()
        {
            return "Persona=" + nombre;
        }
    }
}
