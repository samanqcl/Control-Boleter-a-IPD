namespace IPD.Forms
{
    partial class FormUtileria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtileria));
            timer1 = new System.Windows.Forms.Timer(components);
            errorAPago = new ErrorProvider(components);
            panel1 = new Panel();
            label12 = new Label();
            textBoxTarifas = new TextBox();
            label11 = new Label();
            comboBoxCantidad = new ComboBox();
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
            comboBoxItem = new ComboBox();
            textBoxDNI = new TextBox();
            buttonPagar = new Button();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorAPago).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // errorAPago
            // 
            errorAPago.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Controls.Add(textBoxTarifas);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(comboBoxCantidad);
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
            panel1.Controls.Add(comboBoxItem);
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
            panel1.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(401, 375);
            label12.Name = "label12";
            label12.Size = new Size(48, 37);
            label12.TabIndex = 52;
            label12.Text = "S/";
            // 
            // textBoxTarifas
            // 
            textBoxTarifas.BackColor = SystemColors.Control;
            textBoxTarifas.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTarifas.Location = new Point(453, 369);
            textBoxTarifas.Name = "textBoxTarifas";
            textBoxTarifas.Size = new Size(115, 45);
            textBoxTarifas.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(411, 321);
            label11.Name = "label11";
            label11.Size = new Size(126, 37);
            label11.TabIndex = 50;
            label11.Text = "TARIFA:";
            // 
            // comboBoxCantidad
            // 
            comboBoxCantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCantidad.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCantidad.FormattingEnabled = true;
            comboBoxCantidad.Location = new Point(270, 321);
            comboBoxCantidad.Name = "comboBoxCantidad";
            comboBoxCantidad.Size = new Size(109, 45);
            comboBoxCantidad.TabIndex = 49;
            comboBoxCantidad.SelectedIndexChanged += comboBoxCantidad_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(89, 329);
            label10.Name = "label10";
            label10.Size = new Size(170, 37);
            label10.TabIndex = 48;
            label10.Text = "CANTIDAD:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(411, 553);
            label9.Name = "label9";
            label9.Size = new Size(159, 37);
            label9.TabIndex = 47;
            label9.Text = "HORA FIN:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(409, 431);
            label8.Name = "label8";
            label8.Size = new Size(196, 37);
            label8.TabIndex = 46;
            label8.Text = "HORA INICIO:";
            // 
            // monthCalendario
            // 
            monthCalendario.Location = new Point(89, 451);
            monthCalendario.Name = "monthCalendario";
            monthCalendario.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(89, 402);
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
            comboBoxHoraFin.Location = new Point(442, 613);
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
            comboBoxHoraInicio.Location = new Point(440, 486);
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
            // comboBoxItem
            // 
            comboBoxItem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxItem.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxItem.FormattingEnabled = true;
            comboBoxItem.Items.AddRange(new object[] { "Futsal (S/ 30.00 hr)", "Basket (S/ 20.00 hr)", "Voley (S/ 20.00 hr)" });
            comboBoxItem.Location = new Point(270, 255);
            comboBoxItem.Name = "comboBoxItem";
            comboBoxItem.Size = new Size(300, 45);
            comboBoxItem.TabIndex = 35;
            comboBoxItem.SelectedIndexChanged += comboBoxItem_SelectedIndexChanged;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDNI.Location = new Point(270, 191);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(300, 45);
            textBoxDNI.TabIndex = 34;
            // 
            // buttonPagar
            // 
            buttonPagar.Font = new Font("HP Simplified Hans", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPagar.Location = new Point(161, 674);
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
            label5.Location = new Point(89, 263);
            label5.Name = "label5";
            label5.Size = new Size(95, 37);
            label5.TabIndex = 32;
            label5.Text = "ITEM:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("HP Simplified Hans", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(89, 199);
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
            label1.Location = new Point(70, 98);
            label1.Name = "label1";
            label1.Size = new Size(525, 66);
            label1.TabIndex = 30;
            label1.Text = "ALQUILAR UTILERIA";
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
            // FormUtileria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 906);
            Controls.Add(panel1);
            Name = "FormUtileria";
            Text = "FormUtileria";
            Load += FormUtileria_Load;
            ((System.ComponentModel.ISupportInitialize)errorAPago).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorAPago;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private MonthCalendar monthCalendario;
        private Label label4;
        private ComboBox comboBoxHoraFin;
        private ComboBox comboBoxHoraInicio;
        private Button buttonMoneda;
        private Label label7;
        private Label labelSegundos;
        private Label label3;
        private Button buttonCancelar;
        private ComboBox comboBoxItem;
        private TextBox textBoxDNI;
        private Button buttonPagar;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxCantidad;
        private Label label10;
        private TextBox textBoxTarifas;
        private Label label11;
        private Label label12;
    }
}