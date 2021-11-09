using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PooTema3Circurnferencia.Entidades;
using Color = PooTema3Circurnferencia.Entidades.Color;

namespace PooTema3Circunferencia.Windows
{
    public partial class FrmCircunferenciaAE : Form
    {
        public FrmCircunferenciaAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboBordes(ref BordeComboBox);
            CargarDatosComboRellenos(ref RellenoComboBox);
            if (circunferencia!=null)
            {
                RadioNumericUpDown.Value = circunferencia.Radio;
                BordeComboBox.SelectedItem = circunferencia.Borde;
                RellenoComboBox.SelectedItem = circunferencia.Relleno;
            }
        }

        private void CargarDatosComboRellenos(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Color));
        }

        private void CargarDatosComboBordes(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(Color));
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Circunferencia circunferencia;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (circunferencia==null)
                {
                    circunferencia = new Circunferencia();
                }

                circunferencia.Radio =(int) RadioNumericUpDown.Value;
                circunferencia.Borde =(Color) BordeComboBox.SelectedItem;
                circunferencia.Relleno = (Color) RellenoComboBox.SelectedItem;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            return true;
        }

        public Circunferencia GetCircunferencia()
        {
            return circunferencia;
        }

        public void SetCircunferencia(Circunferencia circCopia)
        {
            circunferencia = circCopia;
        }
    }
}
