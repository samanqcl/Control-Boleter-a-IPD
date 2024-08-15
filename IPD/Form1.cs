using System.IO;
using System.Security.Cryptography;

namespace IPD
{
    public partial class Form1 : Form
    {
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildProcess(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(childForm);
            this.MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            OpenChildProcess(new Forms.FormEntrada(), sender);
        }

        private void buttonAlquiler_Click(object sender, EventArgs e)
        {
            OpenChildProcess(new Forms.FormAlquiler(), sender);
        }

        private void button_utileria_Click(object sender, EventArgs e)
        {
            OpenChildProcess(new Forms.FormUtileria(), sender);
        }
    }
}