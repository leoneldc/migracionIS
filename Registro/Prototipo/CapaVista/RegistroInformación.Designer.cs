namespace CapaVista
{
    partial class RegistroInformación
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.cbxMunicipio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.cbxTez = new System.Windows.Forms.ComboBox();
            this.cbxOjos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxOcupación = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxTramite = new System.Windows.Forms.ComboBox();
            this.cbxPasaporte = new System.Windows.Forms.ComboBox();
            this.cbxCaso = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información Personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pais*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departamento Residencia*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Municipio Residencia*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "🌎                     Guatemala";
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Items.AddRange(new object[] {
            "Alta Verapaz",
            "Baja Verapaz",
            "Chimaltenago",
            "Chiquimula",
            "Guatemala",
            "El Progreso",
            "Escuintla",
            "Huehuetenango",
            "Izabal",
            "Jalapa",
            "Jutiapa",
            "Petén",
            "Quetzaltenango",
            "Quiché",
            "Retalhuleu",
            "Sacatepequez",
            "San Marcos",
            "Santa Rosa",
            "Sololá",
            "Suchitepequez",
            "Totonicapán",
            "Zacapa"});
            this.cbxDepartamento.Location = new System.Drawing.Point(269, 115);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(206, 21);
            this.cbxDepartamento.TabIndex = 5;
            this.cbxDepartamento.Text = "🏘️                    Seleccionar...";
            this.cbxDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbxDepartamento_SelectedIndexChanged);
            // 
            // cbxMunicipio
            // 
            this.cbxMunicipio.FormattingEnabled = true;
            this.cbxMunicipio.Location = new System.Drawing.Point(539, 115);
            this.cbxMunicipio.Name = "cbxMunicipio";
            this.cbxMunicipio.Size = new System.Drawing.Size(206, 21);
            this.cbxMunicipio.TabIndex = 6;
            this.cbxMunicipio.Text = "🏘️                    Seleccionar...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dirección Residencia*";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(463, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(539, 178);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Celular*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefono";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 247);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 20);
            this.textBox4.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Correo Electronico*";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(269, 247);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(206, 20);
            this.textBox5.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Confirme Correo Electronico";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(539, 247);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 20);
            this.textBox6.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Altura (Centimetros)*";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 315);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(206, 20);
            this.textBox7.TabIndex = 18;
            // 
            // cbxTez
            // 
            this.cbxTez.FormattingEnabled = true;
            this.cbxTez.Items.AddRange(new object[] {
            "Piel Muy Clara",
            "Piel Clara",
            "Piel Morena Clara",
            "Piel Morena Oscura",
            "Piel Oscura",
            "Piel Muy Oscura"});
            this.cbxTez.Location = new System.Drawing.Point(270, 315);
            this.cbxTez.Name = "cbxTez";
            this.cbxTez.Size = new System.Drawing.Size(206, 21);
            this.cbxTez.TabIndex = 19;
            this.cbxTez.Text = "🧍                     Seleccióne...";
            // 
            // cbxOjos
            // 
            this.cbxOjos.FormattingEnabled = true;
            this.cbxOjos.Items.AddRange(new object[] {
            "Negros",
            "Café",
            "Ámbar",
            "Avellana",
            "Verde",
            "Azul",
            "Gris"});
            this.cbxOjos.Location = new System.Drawing.Point(539, 315);
            this.cbxOjos.Name = "cbxOjos";
            this.cbxOjos.Size = new System.Drawing.Size(206, 21);
            this.cbxOjos.TabIndex = 20;
            this.cbxOjos.Text = "👁️                    Seleccióne...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tez*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(536, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ojos*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Ocupación*";
            // 
            // cbxOcupación
            // 
            this.cbxOcupación.FormattingEnabled = true;
            this.cbxOcupación.Items.AddRange(new object[] {
            "Carpintero\tLechero\tFrutero",
            "Cerrajero\tCocinero\tDeshollinador",
            "Mecánico\tLavandero\tArtesano",
            "Pescador\t",
            "Escultor\t",
            "Tornero",
            "Albañil\t",
            "Editor\t",
            "Barrendero",
            "Fontanero o plomero\t",
            "Obrero\t",
            "Panadero",
            "Carpintero\t",
            "Locutor\t",
            "Barbero",
            "Soldador\t",
            "Escritor\t",
            "Leñador",
            "Pintor de brocha gorda\t",
            "Vendedor\t",
            "Peletero",
            "Sastre\t",
            "Repartidor\tImpresor",
            "Pastor ganadero\t",
            "Cajero\t",
            "Policía",
            "Agricultor\t",
            "Vigilante\t",
            "Exterminador",
            "Carnicero\t",
            "Animador\t",
            "Peluquero",
            "Abogado\t",
            "Médico cirujano\t",
            "Paleontólogo",
            "Ingeniero\t",
            "Historiador\t",
            "Geógrafo",
            "Biólogo\t",
            "Filólogo\t",
            "Psicólogo",
            "Matemático\t",
            "Arquitecto\t",
            "Computista",
            "Profesor\t",
            "Periodista\t",
            "Botánico",
            "Físico\t",
            "Sociólogo\t",
            "Farmacólogo",
            "Químico\t",
            "Politólogo",
            "Enfermero",
            "Electricista\t",
            "Bibliotecólogo\t",
            "Paramédico",
            "Técnico de sonido\t",
            "Archivólogo\t",
            "Músico",
            "Filósofo\t",
            "Secretaria\t",
            "Traductor",
            "Antropólogo\t",
            "Técnico en turismo\t",
            "Economista",
            "Administrador\t",
            "Lingüista\t",
            "Radiólogo",
            "Contador\t",
            "Psicoanalista\t",
            "Ecólogo"});
            this.cbxOcupación.Location = new System.Drawing.Point(19, 377);
            this.cbxOcupación.Name = "cbxOcupación";
            this.cbxOcupación.Size = new System.Drawing.Size(463, 21);
            this.cbxOcupación.TabIndex = 24;
            this.cbxOcupación.Text = "💼                                                               Seleccióne...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "* Campos Obligatorios";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 448);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(315, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Información de Solicitud de Pasaporte";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 483);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Tipo Tramite*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(231, 483);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Tipo de Pasaporte*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(536, 481);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Tipo de Caso*";
            // 
            // cbxTramite
            // 
            this.cbxTramite.FormattingEnabled = true;
            this.cbxTramite.Items.AddRange(new object[] {
            "Nuevo Pasaporte",
            "Renovación de Pasaporte"});
            this.cbxTramite.Location = new System.Drawing.Point(19, 499);
            this.cbxTramite.Name = "cbxTramite";
            this.cbxTramite.Size = new System.Drawing.Size(206, 21);
            this.cbxTramite.TabIndex = 30;
            this.cbxTramite.Text = "💼                    Selecciónar...";
            // 
            // cbxPasaporte
            // 
            this.cbxPasaporte.FormattingEnabled = true;
            this.cbxPasaporte.Items.AddRange(new object[] {
            "Pasaporte Ordinario (5 años)",
            "Pasaporte Ordinario (10 años)",
            "Pasaporte Oficial",
            "Pasaporte Diplomático",
            "Documento Especial de Viaje para Refugiadas",
            "Documento Especial de Viaje para Refugiados",
            "Pasaporte Ordinario Tramitido en Misiones Consulares (5 años)",
            "Pasaporte Ordinario Tramitido en Misiones Consulares (10 años)"});
            this.cbxPasaporte.Location = new System.Drawing.Point(237, 497);
            this.cbxPasaporte.Name = "cbxPasaporte";
            this.cbxPasaporte.Size = new System.Drawing.Size(296, 21);
            this.cbxPasaporte.TabIndex = 31;
            this.cbxPasaporte.Text = "💼                    Selecciónar...";
            // 
            // cbxCaso
            // 
            this.cbxCaso.FormattingEnabled = true;
            this.cbxCaso.Location = new System.Drawing.Point(545, 497);
            this.cbxCaso.Name = "cbxCaso";
            this.cbxCaso.Size = new System.Drawing.Size(206, 21);
            this.cbxCaso.TabIndex = 32;
            this.cbxCaso.Text = "💼                    Selecciónar...";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "No. Boleta";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 60);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(206, 20);
            this.textBox8.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(539, 378);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(539, 360);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "Fecha de Nacimiento*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.img1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 429);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 16);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaVista.Properties.Resources.img1;
            this.pictureBox2.Location = new System.Drawing.Point(2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(796, 16);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(273, 44);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Nombre y Apellido*";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(270, 60);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(205, 20);
            this.textBox9.TabIndex = 40;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(539, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "DPI*";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(539, 59);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(206, 20);
            this.textBox10.TabIndex = 42;
            // 
            // RegistroInformación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbxCaso);
            this.Controls.Add(this.cbxPasaporte);
            this.Controls.Add(this.cbxTramite);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbxOcupación);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxOjos);
            this.Controls.Add(this.cbxTez);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxMunicipio);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroInformación";
            this.Text = "Registro de Información";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.ComboBox cbxMunicipio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox cbxTez;
        private System.Windows.Forms.ComboBox cbxOjos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxOcupación;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxTramite;
        private System.Windows.Forms.ComboBox cbxPasaporte;
        private System.Windows.Forms.ComboBox cbxCaso;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox10;
    }
}