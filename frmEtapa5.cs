using System;
using System.Windows.Forms;

namespace pryPerezEtapa5
{
    public partial class frmEtapa5 : Form
    {

        clsVehiculo objVehiculo = new clsVehiculo();
        public frmEtapa5()
        {
            InitializeComponent();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {

            objVehiculo.CrearVehiculoAleatorio(picVehiculos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objVehiculo.LimpiarPictureBox(picVehiculos);
        }
    }
}
