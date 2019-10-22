using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _170444_RubiVargas_Inscripciones
{
    public class Alumnos
    {
        public static List<Alumnos> alumnos_inscritos = new List<Alumnos>();

        private string nombre;
        private string matricula;
        private string cuatrimestre;
        private string correo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Cuatrimestre { get => cuatrimestre; set => cuatrimestre = value; }
        public string Correo { get => correo; set => correo = value; }


        public void Agregar(Alumnos alumno_nuevo)
        {
            alumnos_inscritos.Add(alumno_nuevo);
        }

        public void Eliminar(Alumnos alumno_baja)
        {
            alumnos_inscritos.Remove(alumno_baja);
        }

    }

}
