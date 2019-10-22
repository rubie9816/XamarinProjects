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

    public partial class Agregar : MetroFramework.Forms.MetroForm
    {
        List<Cuatrimestres> cuatrimestres = new List<Cuatrimestres>();
        
        public Agregar()
        {
            InitializeComponent();
            
            #region combobox
            cuatrimestres.Add(new Cuatrimestres() { Id = 1, Nombre = "Primer cuatrimestre" });
            cuatrimestres.Add(new Cuatrimestres() { Id = 2, Nombre = "Segundo cuatrimestre" });
            cuatrimestres.Add(new Cuatrimestres() { Id = 3, Nombre = "Tercer cuatrimestre" });
            cuatrimestres.Add(new Cuatrimestres() { Id = 4, Nombre = "Cuarto cuatrimestre" });
            cuatrimestres.Add(new Cuatrimestres() { Id = 5, Nombre = "Quinto cuatrimestre" });
            cuatrimestres.Add(new Cuatrimestres() { Id = 6, Nombre = "Sexto cuatrimestre" });
            cuatrimestres.Add(new Cuatrimestres() { Id = 7, Nombre = "Septimo cuatrimestre" });
            cuatrimestres.Add(new Cuatrimestres() { Id = 8, Nombre = "Octavo cuatrimestre" });
            cuatrimestres.Add(new Cuatrimestres() { Id = 9, Nombre = "Noveno cuatrimestre" });
            cuatrimestres.Add(new Cuatrimestres() { Id = 10, Nombre = "Decimo cuatrimestre" });

            //Setup data binding
            this.cbCuatrimestre.DataSource = cuatrimestres;
            this.cbCuatrimestre.DisplayMember = "Nombre";
            this.cbCuatrimestre.ValueMember = "Id";
            #endregion
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NuevoAlumno();
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void NuevoAlumno()
        {
            Alumnos alumno = new Alumnos();
            alumno.Matricula = txtMatricula.Text;
            alumno.Nombre = txtMatricula.Text;
            alumno.Cuatrimestre = cbCuatrimestre.Text;
            alumno.Correo = txtCorreo.Text;

            alumno.Agregar(alumno);
        }
    }
}
