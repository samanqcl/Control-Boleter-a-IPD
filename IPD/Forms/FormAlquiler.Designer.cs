namespace IPD.Forms
{
    partial class FormAlquiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlquiler));
            panel1 = new Panel();
            textBoxTarifas = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            monthCalendario = new MonthCalendar();
            label4 = new Label();
            comboBoxHoraFin = new ComboBox();
            comboBoxHoraInicio = new ComboBox();
            buttonMoneda = new Button();
            label7 = new Label();
            labelSegundos = new Label();
            label3 = new Label();
            buttonCancelar = new Button();
            comboBoxDeporte = new ComboBox();
            textBoxDNI = new TextBox();
            buttonPagar = new Button();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            errorAPago = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorAPago).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxTarifas);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(monthCalendario);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxHoraFin);
            panel1.Controls.Add(comboBoxHoraInicio);
            panel1.Controls.Add(buttonMoneda);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(labelSegundos);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(comboBoxDeporte);
            panel1.Controls.Add(textBoxDNI);
            panel1.Controls.Add(buttonPagar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 906);
            panel1.TabIndex = 0;
            // 
            // textBoxTarifas
            // 
            textBoxTarifas.BackColor = SystemColors.Control;
            textBoxTarifas.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTarifas.Location = new Point(301, 325);
            textBoxTarifas.Name = "textBoxTarifas";
            textBoxTarifas.Size = new Size(179, 45);
            textBoxTarifas.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(89, 331);
            label10.Name = "label10";
            label10.Size = new Size(206, 37);
            label10.TabIndex = 48;
            label10.Text = "TARIFA:       S/";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(409, 517);
            label9.Name = "label9";
            label9.Size = new Size(159, 37);
            label9.TabIndex = 47;
            label9.Text = "HORA FIN:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(407, 394);
            label8.Name = "label8";
            label8.Size = new Size(196, 37);
            label8.TabIndex = 46;
            label8.Text = "HORA INICIO:";
            // 
            // monthCalendario
            // 
            monthCalendario.Location = new Point(89, 438);
            monthCalendario.Name = "monthCalendario";
            monthCalendario.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(89, 394);
            label4.Name = "label4";
            label4.Size = new Size(118, 37);
            label4.TabIndex = 44;
            label4.Text = "FECHA:";
            // 
            // comboBoxHoraFin
            // 
            comboBoxHoraFin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHoraFin.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxHoraFin.FormattingEnabled = true;
            comboBoxHoraFin.Items.AddRange(new object[] { "10", "11", "12", "13", "14", "15", "16", "17", "18" });
            comboBoxHoraFin.Location = new Point(440, 577);
            comboBoxHoraFin.Name = "comboBoxHoraFin";
            comboBoxHoraFin.Size = new Size(100, 45);
            comboBoxHoraFin.TabIndex = 42;
            // 
            // comboBoxHoraInicio
            // 
            comboBoxHoraInicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHoraInicio.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxHoraInicio.FormattingEnabled = true;
            comboBoxHoraInicio.Items.AddRange(new object[] { "9", "10", "11", "12", "13", "14", "15", "16", "17" });
            comboBoxHoraInicio.Location = new Point(438, 444);
            comboBoxHoraInicio.Name = "comboBoxHoraInicio";
            comboBoxHoraInicio.Size = new Size(102, 45);
            comboBoxHoraInicio.TabIndex = 41;
            comboBoxHoraInicio.Tag = "";
            // 
            // buttonMoneda
            // 
            buttonMoneda.Font = new Font("HP Simplified Hans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMoneda.Location = new Point(70, 812);
            buttonMoneda.Name = "buttonMoneda";
            buttonMoneda.Size = new Size(225, 40);
            buttonMoneda.TabIndex = 40;
            buttonMoneda.Text = "PAGO SIMULADO";
            buttonMoneda.UseVisualStyleBackColor = true;
            buttonMoneda.Click += buttonMoneda_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("HP Simplified Hans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(225, 52);
            label7.Name = "label7";
            label7.Size = new Size(90, 19);
            label7.TabIndex = 39;
            label7.Text = "SEGUNDOS";
            // 
            // labelSegundos
            // 
            labelSegundos.AutoSize = true;
            labelSegundos.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSegundos.Location = new Point(185, 49);
            labelSegundos.Name = "labelSegundos";
            labelSegundos.Size = new Size(43, 23);
            labelSegundos.TabIndex = 38;
            labelSegundos.Text = "120";
            labelSegundos.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("HP Simplified Hans", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 52);
            label3.Name = "label3";
            label3.Size = new Size(145, 19);
            label3.TabIndex = 37;
            label3.Text = "TIEMPO RESTANTE";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(409, 804);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(200, 50);
            buttonCancelar.TabIndex = 36;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // comboBoxDeporte
            // 
            comboBoxDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeporte.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDeporte.FormattingEnabled = true;
            comboBoxDeporte.Location = new Point(270, 251);
            comboBoxDeporte.Name = "comboBoxDeporte";
            comboBoxDeporte.Size = new Size(300, 45);
            comboBoxDeporte.TabIndex = 35;
            comboBoxDeporte.SelectedIndexChanged += comboBoxDeporte_SelectedIndexChanged;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDNI.Location = new Point(270, 184);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(300, 45);
            textBoxDNI.TabIndex = 34;
            // 
            // buttonPagar
            // 
            buttonPagar.Font = new Font("HP Simplified Hans", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPagar.Location = new Point(161, 670);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(300, 100);
            buttonPagar.TabIndex = 33;
            buttonPagar.Text = "PAGAR";
            buttonPagar.UseVisualStyleBackColor = true;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(89, 259);
            label5.Name = "label5";
            label5.Size = new Size(160, 37);
            label5.TabIndex = 32;
            label5.Text = "DEPORTE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(89, 192);
            label6.Name = "label6";
            label6.Size = new Size(83, 37);
            label6.TabIndex = 31;
            label6.Text = "DNI: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified Hans", 34.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 100);
            label1.Name = "label1";
            label1.Size = new Size(510, 66);
            label1.TabIndex = 30;
            label1.Text = "ALQUILAR ESPACIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HP Simplified Hans", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(368, 52);
            label2.Name = "label2";
            label2.Size = new Size(241, 32);
            label2.TabIndex = 29;
            label2.Text = "      (01) 204 - 8420";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // errorAPago
            // 
            errorAPago.ContainerControl = this;
            // 
            // FormAlquiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 906);
            Controls.Add(panel1);
            Name = "FormAlquiler";
            Text = "FormAlquiler";
            Load += FormAlquiler_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorAPago).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancelar;
        private ComboBox comboBoxDeporte;
        private TextBox textBoxDNI;
        private Button buttonPagar;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorAPago;
        private Label label7;
        private Label labelSegundos;
        private Label label3;
        private Button buttonMoneda;
        private Label label9;
        private Label label8;
        private MonthCalendar monthCalendario;
        private Label label4;
        private ComboBox comboBoxHoraFin;
        private ComboBox comboBoxHoraInicio;
        private TextBox textBoxTarifas;
        private Label label10;
    }
}