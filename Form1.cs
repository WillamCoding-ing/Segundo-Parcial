namespace Examen2doParcial
{
    public partial class Form1 : Form
    {
        const decimal SEGURO_COMPLETO = 300m;
        const decimal GPS = 100m;
        const decimal DESCUENTO_CORP = 0.15m;
        const decimal DOMICILIO = 500m;
        const decimal ITBIS = 0.18m;
        decimal subtotal = 0m;
        public Form1()
        {
            InitializeComponent();

        }

        private void dtpSalida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkCorporativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEncabezado.Text = "Días".PadRight(6) +
                     "Vehículo".PadRight(24) +
                     "Tarifa".PadLeft(10) +
                     "Total".PadLeft(12);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dias = (int)nudDias.Value;
            decimal tarifaDiaria = Convert.ToDecimal(txtTarifa.Text);
            string vehiculo = txtVehiculo.Text;

            if (rbnCompleto.Checked)
            {
                tarifaDiaria += SEGURO_COMPLETO;
                vehiculo += " (Completo)";
            }

            if (chkGps.Checked)
            {
                tarifaDiaria += GPS;
                vehiculo += " (GPS)";
            }

            decimal totalLinea = tarifaDiaria * dias;
            subtotal += totalLinea;

            string linea = dias.ToString().PadRight(6) +
                           vehiculo.PadRight(24) +
                           tarifaDiaria.ToString("N2").PadLeft(10) +
                           totalLinea.ToString("N2").PadLeft(12);

            lstAlquileres.Items.Add(linea);
            lblSubtotal.Text = $"RD$ {subtotal:N2}";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstAlquileres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDescuento_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtSucursal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            chkCorporativo.Checked = false;
            dtpSalida.Value = DateTime.Now;
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            rbnBasico.Checked = true;
            rbtSucursal.Checked = true;
            chkGps.Checked = false;
            lstAlquileres.Items.Clear();

            subtotal = 0m;
            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";

            txtCliente.Focus();
        }

        private void lblEncabezado_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal descuento = 0m;
            if (chkCorporativo.Checked)
            {
                descuento = subtotal * DESCUENTO_CORP;
            }

            decimal domicilio = 0m;
            if (rbtDomicilio.Checked)
            {
                domicilio = DOMICILIO;
            }

            decimal baseImponible = subtotal - descuento + domicilio;
            decimal itbis = baseImponible * ITBIS;
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = $"RD$ {subtotal:N2}";
            lblDescuento.Text = $"RD$ {descuento:N2}";
            lblDomicilio.Text = $"RD$ {domicilio:N2}";
            lblItbis.Text = $"RD$ {itbis:N2}";
            lblTotal.Text = $"RD$ {total:N2}";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
