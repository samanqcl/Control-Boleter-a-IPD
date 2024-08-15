using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;

namespace IPD.Forms
{
    public partial class FormAlquiler : Form
    {
        private DateTime TiempoActual = DateTime.Now;
        private int ticks = 120;
        private bool moneda = false;

        public FormAlquiler()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            Tarifas_unidad dep = new Tarifas_unidad();
            comboBoxDeporte.DataSource = dep.CargarTarifas();
            comboBoxDeporte.DisplayMember = "nombre_deporte";
            comboBoxDeporte.ValueMember = "id_deporte";
        }

        public void cargar_tarifa(string id_deporte)
        {
            Conexion con = new Conexion();
            using (SqlConnection cn = con.conexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT precio FROM Alquiler WHERE id_deporte = @id_deporte", cn);
                cmd.Parameters.AddWithValue("@id_deporte", id_deporte);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBoxTarifas.Text = reader["precio"].ToString();
                }
                else
                {
                    textBoxTarifas.Text = "0.00";
                }
                reader.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarRecibo(int Nro_Boleta, string id_concepto, string Deporte, string Fecha, string Hora, int DNI, float tarifa, string Fecha_alquiler, int HInicio, int HFin)
        {
            MessageBox.Show("IPD - Instituto Nacional de Deportes\n" +
                            "\nRUC 20135897044" +
                            "\nAV. HIPOLITO UNANUE S/N PUERTA NRO 3" +
                            "\n" +
                            "OPERACION NRO " + "A-" + Nro_Boleta +
                            "\n" +
                            "\n\t   ENTRADA GENERAL" +
                            "\n" +
                            "\nOPERACION CODIGO\t: " + id_concepto.ToUpper() +
                            "\nDEPORTE\t\t\t: " + Deporte.ToUpper() +
                            "\nUSUARIO\t\t\t: " + DNI +
                            "\nFECHA ALQUILER\t\t: " + Fecha_alquiler +
                            "\nHORA INICIO\t\t: " + HInicio + ":00" +
                            "\nHORA FIN\t\t\t: " + HFin + ":00" +
                            "\n" +
                            "\nIMPORTE\t\t\t: S/ " + tarifa + ".00" +
                            "\nI.T.F\t\t\t: S/ 0.00" +
                            "\n" +
                            "\nTOTAL\t\t\t: S/ " + tarifa + ".00" +
                            "\n" +
                            "\nFECHA: " + Fecha +
                            "\nHORA: " + Hora +
                            "\n" +
                            "\npara cualquier consulta puede llamar a atencion" +
                            "\n\tpor telefono al (01) 204 - 8420");
        }

        private void GuardarBaseDatos(int DNI, string Deporte, string Fecha_alquiler, int HInicio, int HFin, float Importe)
        {
            int Nro_Boleta = 0;
            string id_deporte = "";
            string Fecha = TiempoActual.ToString("dd/MM/yy");
            string Hora = TiempoActual.ToString("HH:mm:ss");
            string Concepto = "Alquiler Espacio";
            string id_concepto = "";
            float Total = Importe;

            Conexion con = new Conexion();
            using (SqlConnection cn = con.conexion())
            {
                try
                {
                    SqlCommand consu_boleta = new SqlCommand("SELECT MAX(nro_boleta) ultimo_nro_boleta FROM Ticket;", cn);
                    SqlDataReader reader2 = consu_boleta.ExecuteReader();
                    if (reader2.Read())
                    {
                        Nro_Boleta = reader2.IsDBNull(reader2.GetOrdinal("ultimo_nro_boleta")) ? 1 : reader2.GetInt32(reader2.GetOrdinal("ultimo_nro_boleta")) + 1;
                    }
                    reader2.Close();

                    SqlCommand consu_id_deporte = new SqlCommand("SELECT id_deporte FROM Deporte WHERE nombre_deporte = '"+Deporte+"'", cn);
                    SqlDataReader reader3 = consu_id_deporte.ExecuteReader();
                    if (reader3.Read())
                    {
                        id_deporte = reader3["id_deporte"].ToString();
                    }
                    reader3.Close();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (dni) VALUES (@dni)", cn);
                    cmd.Parameters.AddWithValue("@dni", DNI);
                    cmd.ExecuteNonQuery();

                    SqlCommand consu_id_concepto = new SqlCommand("SELECT id_item FROM Alquiler WHERE id_deporte = '"+id_deporte+"'", cn);
                    SqlDataReader reader4 = consu_id_deporte.ExecuteReader();
                    if (reader4.Read())
                    {
                        id_concepto = reader4["id_concepto"].ToString();
                    }
                    reader4.Close();

                    string query = "INSERT INTO Ticket (nro_boleta, id_deporte, fecha, hora, dni_usuario, concepto, id_concepto, total) VALUES (@nro_boleta, @id_deporte, @fecha, @hora, @dni_usuario, @concepto, @id_concepto, @total)";
                    using (SqlCommand command = new SqlCommand(query, cn))
                    {
                        command.Parameters.AddWithValue("@nro_boleta", Nro_Boleta);
                        command.Parameters.AddWithValue("@id_deporte", id_deporte);
                        command.Parameters.AddWithValue("@fecha", Fecha);
                        command.Parameters.AddWithValue("@hora", Hora);
                        command.Parameters.AddWithValue("@dni_usuario", DNI);
                        command.Parameters.AddWithValue("@concepto", Concepto);
                        command.Parameters.AddWithValue("@id_concepto", id_concepto);
                        command.Parameters.AddWithValue("@total", Total);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            MostrarRecibo(Nro_Boleta, id_concepto, Deporte, Fecha, Hora, DNI, Importe, Fecha_alquiler, HInicio, HFin);
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            int DNI, HInicio, HFin;
            string Fecha_alquiler;
            string Deporte;
            float Tarifa;

            if (string.IsNullOrEmpty(textBoxDNI.Text))
            {
                errorAPago.SetError(textBoxDNI, "INGRESE DNI");
                textBoxDNI.Focus();
            }

            else if (string.IsNullOrEmpty(comboBoxDeporte.Text))
            {
                errorAPago.SetError(comboBoxDeporte, "SELECCIONE UN DEPORTE");
                comboBoxDeporte.Focus();
            }

            else if (monthCalendario.SelectionStart.Day < int.Parse(DateTime.Now.ToString("dd")))
            {
                errorAPago.SetError(monthCalendario, "SELECCIONE UNA FECHA");
                monthCalendario.Focus();
            }

            else if (string.IsNullOrEmpty(comboBoxHoraInicio.Text))
            {
                errorAPago.SetError(comboBoxHoraInicio, "SELECCIONE HORA DE INICIO");
                comboBoxHoraInicio.Focus();
            }

            else if (string.IsNullOrEmpty(comboBoxHoraFin.Text))
            {
                errorAPago.SetError(comboBoxHoraFin, "SELECCIONE HORA DE FIN");
                comboBoxHoraFin.Focus();
            }

            else if (moneda == false)
            {
                errorAPago.SetError(buttonMoneda, "INGRESE MONTO A PAGAR");
                buttonMoneda.Focus();
            }

            else
            {
                DNI = int.Parse(textBoxDNI.Text);
                Deporte = comboBoxDeporte.Text;
                Fecha_alquiler = monthCalendario.SelectionStart.Day.ToString() + "/" + monthCalendario.SelectionStart.Month.ToString() + "/" + monthCalendario.SelectionStart.Year.ToString();
                HInicio = int.Parse(comboBoxHoraInicio.Text);
                HFin = int.Parse(comboBoxHoraFin.Text);
                Tarifa = float.Parse(textBoxTarifas.Text);

                if (HInicio >= HFin)
                {
                    errorAPago.SetError(comboBoxHoraFin, "La hora de fin debe ser mayor a la hora de inicio");
                    comboBoxHoraFin.Focus();
                }

                else
                {
                    GuardarBaseDatos(DNI, Deporte, Fecha_alquiler, HInicio, HFin, Tarifa);
                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks--;
            labelSegundos.Text = ticks.ToString();

            if (ticks == 0)
            {
                timer1.Stop();
                MessageBox.Show("TIEMPO TERMINADO");
                this.Close();
            }
        }

        private void buttonMoneda_Click(object sender, EventArgs e)
        {
            moneda = true;
        }

        private void comboBoxDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDeporte.SelectedValue.ToString() != null)
            {
                string id_deporte = comboBoxDeporte.SelectedValue.ToString();
                cargar_tarifa(id_deporte);
            }
        }
    }
}
