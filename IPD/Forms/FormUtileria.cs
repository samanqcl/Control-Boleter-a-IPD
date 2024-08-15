using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IPD.Forms
{
    public partial class FormUtileria : Form
    {
        private DateTime TiempoActual = DateTime.Now;
        private int ticks = 120;
        private bool moneda = false;

        public FormUtileria()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void FormUtileria_Load(object sender, EventArgs e)
        {
            Tarifas_unidad dep = new Tarifas_unidad();
            comboBoxItem.DataSource = dep.CargarItems();
            comboBoxItem.DisplayMember = "descripcion";
            comboBoxItem.ValueMember = "id_item";
        }

        public void cargar_cantidad(string id_item)
        {
            Conexion con = new Conexion();
            using (SqlConnection cn = con.conexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT cantidad FROM Alquiler WHERE id_item = @id_item", cn);
                cmd.Parameters.AddWithValue("@id_item", id_item);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int cantidad = reader.GetInt32(reader.GetOrdinal("cantidad"));
                    reader.Close();

                    for (int i = 1; i <= cantidad; i++)
                    {
                        comboBoxCantidad.Items.Add(i.ToString());
                    }

                    if (comboBoxCantidad.Items.Count > 0)
                    {
                        comboBoxCantidad.SelectedIndex = 0; 
                    }
                }
                else
                {
                    comboBoxCantidad.Items.Clear(); 
                    comboBoxCantidad.Items.Add("0");
                    comboBoxCantidad.SelectedIndex = 0;
                }
            }
        }

        public void mostrar_tarifa(int cantidad, string id_item)
        {
            Conexion con = new Conexion();
            using (SqlConnection cn = con.conexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT precio FROM Alquiler WHERE id_item = @id_item", cn);
                cmd.Parameters.AddWithValue("@id_item", id_item);

                SqlDataReader reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    float tarifaAlquiler = reader1.GetFloat(reader1.GetOrdinal("tarifa_alquiler"));
                    textBoxTarifas.Text = (tarifaAlquiler * cantidad).ToString();
                }
                else
                {
                    textBoxTarifas.Text = "0.00";
                }
                reader1.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarRecibo(int Nro_Boleta, string Descripcion, string Fecha, string Hora, int DNI, float tarifa, string Fecha_alquiler, int HInicio, int HFin)
        {
            MessageBox.Show("IPD - Instituto Nacional de Items\n" +
                            "\nRUC 20135897044" +
                            "\nAV. HIPOLITO UNANUE S/N PUERTA NRO 3" +
                            "\n" +
                            "OPERACION NRO " + "A-" + Nro_Boleta +
                            "\n" +
                            "\n\t   ENTRADA GENERAL" +
                            "\n" +
                            "\nItem\t\t\t: " + Descripcion +
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

        private void GuardarBaseDatos(int DNI, string Descripcion, int cantidad, string Fecha_alquiler, int HInicio, int HFin, float Importe)
        {
            int Nro_Boleta = 0;
            string id_item = "";
            string Deporte = "";
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
                    SqlDataReader reader = consu_boleta.ExecuteReader();
                    if (reader.Read())
                    {
                        Nro_Boleta = reader.IsDBNull(reader.GetOrdinal("ultimo_nro_boleta")) ? 1 : reader.GetInt32(reader.GetOrdinal("ultimo_nro_boleta")) + 1;
                    }
                    reader.Close();

                    SqlCommand consu_id_deporte = new SqlCommand("SELECT id_deporte FROM Alquiler WHERE nombre_deporte = '"+Deporte+"'", cn);
                    SqlDataReader reader1 = consu_id_deporte.ExecuteReader();
                    if (reader1.Read())
                    {
                        id_deporte = reader1["id_deporte"].ToString();
                    }
                    reader1.Close();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (dni) VALUES (@dni)", cn);
                    cmd.Parameters.AddWithValue("@dni", DNI);
                    cmd.ExecuteNonQuery();

                    SqlCommand consu_id_concepto = new SqlCommand("SELECT id_item FROM Alquiler WHERE id_deporte = '"+id_deporte+"'", cn);
                    SqlDataReader reader2 = consu_id_deporte.ExecuteReader();
                    if (reader1.Read())
                    {
                        id_item = reader2["id_item"].ToString();
                    }
                    reader2.Close();

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
            MostrarRecibo(Nro_Boleta, Descripcion, Fecha, Hora, DNI, Importe, Fecha_alquiler, HInicio, HFin);
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            int DNI, HInicio, HFin;
            string Fecha_alquiler;
            string Descripcion;
            int cantidad;
            float Tarifa;

            if (string.IsNullOrEmpty(textBoxDNI.Text))
            {
                errorAPago.SetError(textBoxDNI, "INGRESE DNI");
                textBoxDNI.Focus();
            }

            else if (string.IsNullOrEmpty(comboBoxItem.Text))
            {
                errorAPago.SetError(comboBoxItem, "SELECCIONE UN ITEM");
                comboBoxItem.Focus();
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
                Descripcion = comboBoxItem.Text;
                Fecha_alquiler = monthCalendario.SelectionStart.Day.ToString() + "/" + monthCalendario.SelectionStart.Month.ToString() + "/" + monthCalendario.SelectionStart.Year.ToString();
                HInicio = int.Parse(comboBoxHoraInicio.Text);
                HFin = int.Parse(comboBoxHoraFin.Text);
                cantidad = int.Parse(comboBoxCantidad.Text);
                Tarifa = float.Parse(textBoxTarifas.Text);

                if (HInicio >= HFin)
                {
                    errorAPago.SetError(comboBoxHoraFin, "La hora de fin debe ser mayor a la hora de inicio");
                    comboBoxHoraFin.Focus();
                }

                else
                {
                    GuardarBaseDatos(DNI, Descripcion, cantidad, Fecha_alquiler, HInicio, HFin, Tarifa);
                    this.Close();
                }
            }
        }

        private void buttonMoneda_Click(object sender, EventArgs e)
        {
            moneda = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
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

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItem.SelectedValue.ToString() != null)
            {
                string id_item = comboBoxItem.SelectedValue.ToString();
                cargar_cantidad(id_item);
            }
        }

        private void comboBoxCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItem.SelectedValue.ToString() != null)
            {
                string id_item = comboBoxItem.SelectedValue.ToString();
                int cantidad = int.Parse(comboBoxCantidad.SelectedItem.ToString());
                mostrar_tarifa(cantidad, id_item);
            }
        }
    }
}
