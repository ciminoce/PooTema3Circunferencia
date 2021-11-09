using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PooTema3Circunferencia.Datos;
using PooTema3Circurnferencia.Entidades;
using Color = PooTema3Circurnferencia.Entidades.Color;

namespace PooTema3Circunferencia.Windows
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private List<Circunferencia> lista;
        private int cantidadRegistros;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosComboBordes();
            MostrarCantidadRegistros();
            if (cantidadRegistros>0)
            {
                lista = RepositorioDeCircunferencias.GetInstancia().GetLista();
                MostrarDatosEnGrilla();
            }
        }

        private void CargarDatosComboBordes()
        {
            var listaBordes = Enum.GetValues(typeof(Color)).Cast<Color>().ToList();
            foreach (var borde in listaBordes)
            {
                BordesToolStripComboBox.Items.Add(borde);
            }
        }

        private void MostrarCantidadRegistros()
        {
            cantidadRegistros = RepositorioDeCircunferencias.GetInstancia().GetCantidad();
            CantidadRegistrosLabel.Text = cantidadRegistros.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var circunferencia in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, circunferencia);
                AgregarFila(r);
            }
        }

        private void SetearFila(DataGridViewRow r, Circunferencia circunferencia)
        {
            r.Cells[colRadio.Index].Value = circunferencia.Radio;
            r.Cells[colBorde.Index].Value = circunferencia.Borde;
            r.Cells[colRelleno.Index].Value = circunferencia.Relleno;

            r.Tag = circunferencia;
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            //capturar los datos
            FrmCircunferenciaAE frm = new FrmCircunferenciaAE() {Text = "Agregar Circunferencia"};
            DialogResult dr = frm.ShowDialog(this);
            //ver si ya no existe
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Circunferencia circ = frm.GetCircunferencia();
            if (RepositorioDeCircunferencias.GetInstancia().Existe(circ))
            {
                MessageBox.Show("Circunferencia existente!!!", "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //si no existe la guardo
            RepositorioDeCircunferencias.GetInstancia().Agregar(circ);
            DataGridViewRow r = ConstruirFila();
            SetearFila(r,circ);
            AgregarFila(r);
            MostrarCantidadRegistros();

        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Circunferencia circ = (Circunferencia) r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea borrar la circunferencia de radio {circ.Radio}?",
                "Pregunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            RepositorioDeCircunferencias.GetInstancia().Borrar(circ);
            DatosDataGridView.Rows.Remove(r);
            MessageBox.Show("Registro Borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarCantidadRegistros();
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Circunferencia circ = (Circunferencia) r.Tag;
            Circunferencia circCopia = (Circunferencia) circ.Clone();
            FrmCircunferenciaAE frm = new FrmCircunferenciaAE() {Text = "Editar Circunferencia"};
            frm.SetCircunferencia(circCopia);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            circCopia = frm.GetCircunferencia();
            if (RepositorioDeCircunferencias.GetInstancia().Existe(circCopia))
            {
                MessageBox.Show("Circunferencia existente!!!", "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            RepositorioDeCircunferencias.GetInstancia().Editar(circ, circCopia);
            SetearFila(r, circCopia);
            MessageBox.Show("Registro Modificado!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BordesToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BordesToolStripComboBox.SelectedIndex==-1)
            {
                return;
            }

            Color color = (Color) BordesToolStripComboBox.SelectedItem;
            lista=RepositorioDeCircunferencias.GetInstancia().FiltrarPorBorde(color);
            MostrarDatosEnGrilla();
            cantidadRegistros = RepositorioDeCircunferencias.GetInstancia().GetCantidad(color);
            CantidadRegistrosLabel.Text = cantidadRegistros.ToString();
        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            lista = RepositorioDeCircunferencias.GetInstancia().GetLista();
            MostrarDatosEnGrilla();
            MostrarCantidadRegistros();
        }


        private void AscXRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeCircunferencias.GetInstancia().OrdenarAscPorRadio();
            MostrarDatosEnGrilla();
        }

        private void DescXRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = RepositorioDeCircunferencias.GetInstancia().OrdenarDescPorRadio();
            MostrarDatosEnGrilla();

        }
    }
}
