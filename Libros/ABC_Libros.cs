using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libros
{
    public partial class ABC_Libros : Form
    {
        Conexion conexion = new Conexion();
        int boton_cambio = 0;
        //1 = Nuevo libro
        //2 = Editar libro
        public ABC_Libros()
        {
            InitializeComponent();
        }

        private void ABC_Libros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aBC_LIBROSDataSet7.cat_Editorial' Puede moverla o quitarla según sea necesario.
            this.cat_EditorialTableAdapter.Fill(this.aBC_LIBROSDataSet7.cat_Editorial);
            // TODO: esta línea de código carga datos en la tabla 'aBC_LIBROSDataSet6.cat_Autores' Puede moverla o quitarla según sea necesario.
            this.cat_AutoresTableAdapter.Fill(this.aBC_LIBROSDataSet6.cat_Autores);
            // TODO: esta línea de código carga datos en la tabla 'aBC_LIBROSDataSet5.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter1.Fill(this.aBC_LIBROSDataSet5.Libros);
            // TODO: esta línea de código carga datos en la tabla 'aBC_LIBROSDataSet4.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.aBC_LIBROSDataSet4.Libros);
            // TODO: esta línea de código carga datos en la tabla 'aBC_LIBROSDataSet31.cat_Edicion' Puede moverla o quitarla según sea necesario.
            this.cat_EdicionTableAdapter.Fill(this.aBC_LIBROSDataSet31.cat_Edicion);
            #region datasources
            // TODO: esta línea de código carga datos en la tabla 'aBC_LIBROSDataSet2.cat_Estatus' Puede moverla o quitarla según sea necesario.
            this.cat_EstatusTableAdapter.Fill(this.aBC_LIBROSDataSet2.cat_Estatus);
            // TODO: esta línea de código carga datos en la tabla 'aBC_LIBROSDataSet1.cat_Idioma' Puede moverla o quitarla según sea necesario.
            this.cat_IdiomaTableAdapter.Fill(this.aBC_LIBROSDataSet1.cat_Idioma);
            // TODO: esta línea de código carga datos en la tabla 'aBC_LIBROSDataSet.cat_Genero' Puede moverla o quitarla según sea necesario.
            this.cat_GeneroTableAdapter.Fill(this.aBC_LIBROSDataSet.cat_Genero);
            #endregion

            //ocultar columna de id
            //Llenar el grid
            InhabilitarEscritura();
            dgvStock.DataSource = conexion.ConsultaDatosStock();

            int id_stock = (int)dgvStock.CurrentRow.Cells[1].Value;
            int id_libro = (int)dgvStock.CurrentRow.Cells[3].Value;
            this.dgvStock.Columns[3].Visible = false;
            MostrarDatosLibro(id_stock);
            MostrarEstatusLibro(id_libro);

        }

        protected void CargarGridview()
        {
            dgvStock.DataSource = conexion.ConsultaDatosStock();
            this.dgvStock.Columns[3].Visible = false;
        }

        protected void MostrarDatosLibro(int id_stock)
        {
            List<string> info_libro = conexion.ConsultarDatosLibro(id_stock);
            txtISBN.Text = info_libro[0];
            txtTitulo.Text = info_libro[1];
            txtAutor.Text = info_libro[2];
            txtEdicion.Text = info_libro[3];
            txtEditorial.Text = info_libro[4];
            cbIdioma.Text = info_libro[5];
            cbGenero.Text = info_libro[6];
            cbEstatus.Text = info_libro[7];
        }

        protected void MostrarEstatusLibro(int id_libro)
        {
            List<string> info_estatus = conexion.ConsultarEstatusLibro(id_libro);
            txtCantidad.Text = info_estatus[0];
            txtDisponible.Text = info_estatus[1];
            txtPrestamo.Text = info_estatus[2];
            txtDanado.Text = info_estatus[3];
            txtBaja.Text = info_estatus[4];
        }

        private void EditarLibro()
        {
            int id_libro = (int)dgvStock.CurrentRow.Cells[3].Value;
            InhabilitarEscritura();
            List<string> info_libro = new List<string>();
            info_libro.Add(txtISBN.Text);
            info_libro.Add(txtTitulo.Text);
            info_libro.Add(txtAutor.Text);
            info_libro.Add(txtEditorial.Text);
            info_libro.Add(txtEdicion.SelectedValue.ToString());
            info_libro.Add(cbIdioma.SelectedValue.ToString());
            info_libro.Add(cbGenero.SelectedValue.ToString());
            conexion.ModificarLibro(info_libro, id_libro);
        }

        private void NuevoLibro()
        {
            InhabilitarEscritura();
            List<string> info_libro = new List<string>();
            info_libro.Add(txtISBN.Text);
            info_libro.Add(txtTitulo.Text);
            info_libro.Add(txtAutor.Text);
            info_libro.Add(txtEditorial.Text);
            info_libro.Add(txtEdicion.SelectedValue.ToString());
            info_libro.Add(cbIdioma.SelectedValue.ToString());
            info_libro.Add(cbGenero.SelectedValue.ToString());
            conexion.AgregarLibro(info_libro);
        }

        private void MostrarInfoLibro()
        {
            int id_stock = (int)dgvStock.CurrentRow.Cells[1].Value;
            int id_libro = (int)dgvStock.CurrentRow.Cells[3].Value;
            MostrarDatosLibro(id_stock);
            MostrarEstatusLibro(id_libro);
        }

        private void ModificarEstatus()
        {
            int id_stock = (int)dgvStock.CurrentRow.Cells[1].Value;
            int estatus = Convert.ToInt32(cbEstatus.SelectedValue);
            conexion.CambiarEstatus(id_stock, estatus);
            CargarGridview();
        }

        private void HabilitarEscritura()
        {
            txtISBN.Enabled = true;
            txtTitulo.Enabled = true;
            txtAutor.Enabled = true;
            txtEdicion.Enabled = true;
            txtEditorial.Enabled = true;
            cbIdioma.Enabled = true;
            cbGenero.Enabled = true;
            cbEstatus.Enabled = true;
        }

        private void InhabilitarEscritura()
        {
            txtISBN.Enabled = false;
            txtTitulo.Enabled = false;
            txtAutor.Enabled = false;
            txtEdicion.Enabled = false;
            txtEditorial.Enabled = false;
            cbIdioma.Enabled = false;
            cbGenero.Enabled = false;
            cbEstatus.Enabled = false;
            txtCantidad.Enabled = false;
            txtDisponible.Enabled = false;
            txtPrestamo.Enabled = false;
            txtDanado.Enabled = false;
            txtBaja.Enabled = false;
        }


        //BOTONES

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (boton_cambio != 2)
            {
                InhabilitarEscritura();
                boton_cambio = 0;
            }
            if (e.RowIndex >= 0)
            {
                MostrarInfoLibro();
            }
        }

        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            boton_cambio = 1;
            HabilitarEscritura();

            txtISBN.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEdicion.Text = "";
            txtEditorial.Text = "";
            cbIdioma.Text = "";
            cbGenero.Text = "";
            cbEstatus.Text = "";
            txtCantidad.Text = "";
            txtDisponible.Text = "";
            txtPrestamo.Text = "";
            txtDanado.Text = "";
            txtBaja.Text = "";
        }

        private void btnGuadarLibro_Click(object sender, EventArgs e)
        {
            switch (boton_cambio)
            {
                case 1:
                    NuevoLibro();
                    break;
                case 2:
                    EditarLibro();
                    break;
                default:
                    break;
            }
            MessageBox.Show("Cambio realizado");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.librosTableAdapter1.FillBy(this.aBC_LIBROSDataSet5.Libros);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.librosTableAdapter1.FillBy1(this.aBC_LIBROSDataSet5.Libros);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            boton_cambio = 2;
            HabilitarEscritura();
            CargarGridview();
        }

        private void btnBorrarLibro_Click(object sender, EventArgs e)
        {
            int id_stock = (int)dgvStock.CurrentRow.Cells[1].Value;
            conexion.EliminarLibro(id_stock);
            MessageBox.Show("Libro eliminado");
            CargarGridview();
        }

        private void btnCancelarLibro_Click(object sender, EventArgs e)
        {
            InhabilitarEscritura();
            boton_cambio = 0;
            MostrarInfoLibro();
        }

        private void btnAgregaStock_Click(object sender, EventArgs e)
        {
            int id_stock = (int)dgvStock.CurrentRow.Cells[1].Value;
            conexion.CambiarEstatus(id_stock, 1);
            CargarGridview();
        }

        private void btnModificaEstatus_Click(object sender, EventArgs e)
        {
            cbEstatus.Enabled = true;

        }

        private void btnBorraStock_Click(object sender, EventArgs e)
        {
            int id_stock = (int)dgvStock.CurrentRow.Cells[1].Value;
            conexion.CambiarEstatus(id_stock, 4);
            CargarGridview();
        }

        private void btnGuardarStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambio realizado");
            int id_stock = (int)dgvStock.CurrentRow.Cells[1].Value;
            int estatus = (int)cbEstatus.SelectedValue;
            conexion.CambiarEstatus(id_stock, estatus);
            CargarGridview();
            cbEstatus.Enabled = false;
        }

        private void btnCancelarStock_Click(object sender, EventArgs e)
        {
            InhabilitarEscritura();
            boton_cambio = 0;
            MostrarInfoLibro();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int rows = dgvStock.RowCount;
            int index = dgvStock.SelectedCells[0].OwningRow.Index;
            if (index < rows - 1)
            {
                dgvStock.Rows[index].Selected = false;
                if (index != rows - 1)
                {
                    dgvStock.Rows[++index].Selected = true;
                }
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            int rows = dgvStock.RowCount;
            int index = dgvStock.SelectedCells[0].OwningRow.Index;
            dgvStock.Rows[index].Selected = false;
            dgvStock.Rows[rows - 1].Selected = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            int rows = dgvStock.RowCount;
            int index = dgvStock.SelectedCells[0].OwningRow.Index;
            if (index >= rows - 1)
            {
                dgvStock.Rows[index].Selected = false;
                if (index > 0)
                {
                    dgvStock.Rows[--index].Selected = true;
                }
            }

        }

        private void btnPrincipio_Click(object sender, EventArgs e)
        {
            int index = dgvStock.SelectedCells[0].OwningRow.Index;
            dgvStock.Rows[index].Selected = false;
            dgvStock.Rows[0].Selected = true;
        }
    }
}
