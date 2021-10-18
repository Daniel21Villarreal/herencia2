using System;
using System.Collections.Generic;
using System.Text;

namespace AppclassHerencia2
{
    class Alumno : Persona
    {
 
    private string alumno;

        public string persona
        {
            get
            {
                return alumno;
            }
            set
            {
               alumno = value;
            }
        }

        public Alumno() : base()
        {
            //x = 0;
            alumno = persona ;
        }
        public Alumno(string persona, string alumno) : base(Alumno)
        {
            this.persona = alumno;
        }
        public double matricula (Alumno P)
        {
          
            string Alumno = matricula - Alumno.Persona;
            string Persona = alumno -   Alumno.persona;

            return Alumno;
        }
        public override string ToString()
        {
            return base.ToString() + " Alumno=" + alumno;
        }
    }
}
    

