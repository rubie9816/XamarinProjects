using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _170444_RubiVargas_EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectAll();
            rtbEditor.SelectionFont = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
        }

        private void btnSubrayado_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectAll();
            rtbEditor.SelectionFont = new Font("Tahoma", 10, FontStyle.Underline);
        }

        private void btnAlineaIzq_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectAll();
            rtbEditor.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void btnAlinearCentro_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectAll();
            rtbEditor.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnAlinearDere_Click(object sender, EventArgs e)
        {
            rtbEditor.SelectAll();
            rtbEditor.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
