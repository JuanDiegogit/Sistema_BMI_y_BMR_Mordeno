using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vista
{
  public class Usuario
    {
        public int ID { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }

        public int Edad { set; get; }
        public string Genero { set; get; }
        public double Peso { set; get; }
        public double Estatura { set; get; }

        public double BMI { set; get; }
        public double BMR { set; get; }
        public string Nivel_Actividad { set; get; }
    }
}
