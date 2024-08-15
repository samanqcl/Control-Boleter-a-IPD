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
    public partial class FormEntrada : Form
    {
        private DateTime TiempoActual = DateTime.Now;
        private int ticks = 99;
        private bool moneda = false;

        public FormEntrada()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void FormEntrada_Load(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("SELECT tarifa_entrada FROM Deporte WHERE id_deporte = @id_deporte", cn);
                cmd.Parameters.AddWithValue("@id_deporte", id_deporte);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBoxTarifas.Text = reader["tarifa_entrada"].ToString();
                }
                else
                {
                    textBoxTarifas.Text = "0.00";
                }
                reader.Close();
            }
        }

        private void MostrarRecibo(int Nro_Boleta, string Deporte, string Fecha, string Hora, int DNI, float Importe, float Total)
        {
            MessageBox.Show("IPD - Instituto Nacional de Deportes\n" +
                            "\nRUC 20135897044" +
                            "\nAV. HIPOLITO UNANUE S/N PUERTA NRO 3" +
                            "\n" +
                            "OPERACION NRO " + "EG-" + Nro_Boleta +
                            "\n" +
                            "\n\t   ENTRADA GENERAL" +
                            "\n" +
                            "\nDEPORTE\t\t\t: " + Deporte.ToUpper() +
                            "\nUSUARIO\t\t\t: " + DNI +
                            "\n" +
                            "\nIMPORTE\t\t\t: S/ " + Importe + ".00" +
                            "\nI.T.F\t\t\t: S/ 0.00" +
                            "\n" +
                            "\nTOTAL\t\t\t: S/ " + Total + ".00" +
                            "\n" +
                            "\nFECHA: " + Fecha +
                            "\nHORA: " + Hora +
                            "\n" +
                            "\npara cualquier consulta puede llamar a atencion" +
                            "\n\tpor telefono al (01) 204 - 8420");
        }


        private void GuardarBaseDatos(int DNI, string Deporte, float Importe)
        {
            int Nro_Boleta = 0;
            string id_deporte = "";
            string Fecha = TiempoActual.ToString("dd/MM/yy");
            string Hora = TiempoActual.ToString("HH:mm:ss");
            string Concepto = "Entrada General";
            string id_concepto = "ENTGEN";
            float Total = Importe;

            Conexion con = new Conexion();
            using (SqlConnection cn = con.conexion())
            {
                try
                {
                    SqlCommand consu_boleta = new SqlCommand("SELECT MAX(nro_boleta) ultimo_nro_boleta FROM Ticket;", cn);
                    SqlDataReader reader = consu_boleta.ExecuteReader();
                    if (reader.Read())
                    {
                        Nro_Boleta = reader.IsDBNull(reader.GetOrdinal("ultimo_nro_boleta")) ? 1: reader.GetInt32(reader.GetOrdinal("ultimo_nro_boleta")) + 1;
                    }
                    reader.Close();

                    SqlCommand consu_id_deporte = new SqlCommand("SELECT id_deporte FROM Deporte WHERE nombre_deporte = '"+Deporte+"'", cn);
                    SqlDataReader reader1 = consu_id_deporte.ExecuteReader();
                    if (reader1.Read())
                    {
                        id_deporte = reader1["id_deporte"].ToString();
                    }
                    reader1.Close();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (dni) VALUES (@dni)", cn);
                    cmd.Parameters.AddWithValue("@dni", DNI);
                    cmd.ExecuteNonQuery();

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

            MostrarRecibo(Nro_Boleta, Deporte, Fecha, Hora, DNI, Importe, Total);
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            int DNI;
            string Deporte;
            float Tarifa;

            if (string.IsNullOrEmpty(textBoxDNI.Text))
            {
                errorEPago.SetError(textBoxDNI, "INGRESE DNI");
                textBoxDNI.Focus();
            }

            else if (string.IsNullOrEmpty(comboBoxDeporte.Text))
            {
                errorEPago.SetError(comboBoxDeporte, "SELECCIONE UN DEPORTE");
                comboBoxDeporte.Focus();
            }

            else if (moneda == false)
            {
                errorEPago.SetError(buttonMoneda, "INGRESE MONTO A PAGAR");
                buttonMoneda.Focus();
            }

            else
            {
                DNI = int.Parse(textBoxDNI.Text);
                Deporte = comboBoxDeporte.Text;
                Tarifa = float.Parse(textBoxTarifas.Text);

                GuardarBaseDatos(DNI, Deporte, Tarifa);

                this.Close();
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
