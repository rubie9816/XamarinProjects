using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170444_RubiVargas_Inscripciones
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Alumnos alumno = new Alumnos();

        public Form1()
        {
            InitializeComponent();
            dgvAlumnos.DataSource = ConvertirTabla(_170444_RubiVargas_Inscripciones.Alumnos.alumnos_inscritos);
            dgvAlumnos.Columns[0].Visible = false;
        }


        public DataTable ConvertirTabla(List<Alumnos> list)
        {
            DataTable table = new DataTable();
            table.Columns.Add("idTabla", typeof(int));
            table.Columns.Add("Matricula", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Cuatrimestre", typeof(string));
            table.Columns.Add("Correo", typeof(string));

            int i = 0;

            foreach (Alumnos alumno in list)
            {
                DataRow row = table.NewRow();
                row["idTabla"] = i;
                row["Matricula"] = alumno.Matricula;
                row["Nombre"] = alumno.Nombre;
                row["Cuatrimestre"] = alumno.Cuatrimestre;
                row["Correo"] = alumno.Correo;
                table.Rows.Add(row);

                i++;
            }

            return table;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            agregar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            alumno.Eliminar(_170444_RubiVargas_Inscripciones.Alumnos.alumnos_inscritos[Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value)]);
            RefrescarGrid();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        public void RefrescarGrid()
        {
            dgvAlumnos.DataSource = ConvertirTabla(_170444_RubiVargas_Inscripciones.Alumnos.alumnos_inscritos);
        }
    }
}
