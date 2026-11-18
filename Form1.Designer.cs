namespace GeneradorPrompts
{
    partial class GeneradordePrompts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtTema = new TextBox();
            label5 = new Label();
            cmbVerbo = new ComboBox();
            label4 = new Label();
            tabPage2 = new TabPage();
            cmbNivelTecnico = new ComboBox();
            label9 = new Label();
            cmbSector = new ComboBox();
            label8 = new Label();
            cmbAudiencia = new ComboBox();
            label7 = new Label();
            cmbRol = new ComboBox();
            label6 = new Label();
            tabPage3 = new TabPage();
            cmbFormato = new ComboBox();
            label10 = new Label();
            tabPage4 = new TabPage();
            cmbIdioma = new ComboBox();
            txtExclusiones = new TextBox();
            label16 = new Label();
            groupBox1 = new GroupBox();
            chkAplicacion = new CheckBox();
            chkVentajas = new CheckBox();
            chkDatos = new CheckBox();
            checkBox1 = new CheckBox();
            chkReferencias = new CheckBox();
            chkEjemplos = new CheckBox();
            label15 = new Label();
            cmbNivelRestriccion = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            cmbTono = new ComboBox();
            label12 = new Label();
            cmbExtension = new ComboBox();
            label11 = new Label();
            groupBox2 = new GroupBox();
            rtbResultado = new RichTextBox();
            btnCopiar = new Button();
            btnLimpiar = new Button();
            btnChatGPT = new Button();
            btnGemini = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(211, 21);
            label2.TabIndex = 1;
            label2.Text = "GENERADOR DE PROMPTS";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 30);
            label3.Name = "label3";
            label3.Size = new Size(316, 15);
            label3.TabIndex = 3;
            label3.Text = "Configura las instrucciones y obten un promt estructurado";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(340, 378);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtTema);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(cmbVerbo);
            tabPage1.Controls.Add(label4);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(332, 350);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Instrucción";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(42, 131);
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(270, 23);
            txtTema.TabIndex = 3;
            txtTema.TextChanged += txtTema_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 113);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 2;
            label5.Text = "TEMA / TAREA";
            // 
            // cmbVerbo
            // 
            cmbVerbo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVerbo.FormattingEnabled = true;
            cmbVerbo.Items.AddRange(new object[] { "Explica", "Analiza", "Compara", "Diseña", "Resume", "Genera", "Evalúa", "Actúa como" });
            cmbVerbo.Location = new Point(131, 49);
            cmbVerbo.Name = "cmbVerbo";
            cmbVerbo.Size = new Size(121, 23);
            cmbVerbo.TabIndex = 1;
            cmbVerbo.SelectedIndexChanged += cmbVerbo_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 52);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 0;
            label4.Text = "VERBO";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbNivelTecnico);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(cmbSector);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(cmbAudiencia);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(cmbRol);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(332, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contexto";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // cmbNivelTecnico
            // 
            cmbNivelTecnico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelTecnico.FormattingEnabled = true;
            cmbNivelTecnico.Items.AddRange(new object[] { "Lenguaje Técnico Moderado", "Lenguaje no Técnico" });
            cmbNivelTecnico.Location = new Point(111, 233);
            cmbNivelTecnico.Name = "cmbNivelTecnico";
            cmbNivelTecnico.Size = new Size(179, 23);
            cmbNivelTecnico.TabIndex = 7;
            cmbNivelTecnico.SelectedIndexChanged += cmbNivelTecnico_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 236);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 6;
            label9.Text = "Nivel Técnico";
            // 
            // cmbSector
            // 
            cmbSector.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSector.FormattingEnabled = true;
            cmbSector.Items.AddRange(new object[] { "Aplicado a sector Tecnologico", "PYMES en Panamá" });
            cmbSector.Location = new Point(111, 177);
            cmbSector.Name = "cmbSector";
            cmbSector.Size = new Size(179, 23);
            cmbSector.TabIndex = 5;
            cmbSector.SelectedIndexChanged += cmbSector_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(61, 180);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 4;
            label8.Text = "Sector";
            // 
            // cmbAudiencia
            // 
            cmbAudiencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAudiencia.FormattingEnabled = true;
            cmbAudiencia.Items.AddRange(new object[] { "Dirigido a esudiantes de Primer Año", "Público General" });
            cmbAudiencia.Location = new Point(111, 116);
            cmbAudiencia.Name = "cmbAudiencia";
            cmbAudiencia.Size = new Size(179, 23);
            cmbAudiencia.TabIndex = 3;
            cmbAudiencia.SelectedIndexChanged += cmbAudiencia_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(44, 119);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 2;
            label7.Text = "Audiencia";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Actua como experto en el tema", "Actua como universitario" });
            cmbRol.Location = new Point(111, 58);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(179, 23);
            cmbRol.TabIndex = 1;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(75, 61);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 0;
            label6.Text = "ROL";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cmbFormato);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(332, 350);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Formato";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbFormato
            // 
            cmbFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormato.FormattingEnabled = true;
            cmbFormato.Items.AddRange(new object[] { "Lista Enumerada", "Tabla Comparativa", "Ensayo de 800 palabras", "En 3 Parrafos", "Mensajes con Emojis", "Rúbirca en Tabla", "Diagrama conceptual" });
            cmbFormato.Location = new Point(85, 119);
            cmbFormato.Name = "cmbFormato";
            cmbFormato.Size = new Size(214, 23);
            cmbFormato.TabIndex = 1;
            cmbFormato.SelectedIndexChanged += cmbFormato_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(15, 122);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 0;
            label10.Text = "FORMATO";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(cmbIdioma);
            tabPage4.Controls.Add(txtExclusiones);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(cmbNivelRestriccion);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(cmbTono);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(cmbExtension);
            tabPage4.Controls.Add(label11);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(332, 350);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Reglas ";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbIdioma
            // 
            cmbIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.Items.AddRange(new object[] { "Ingles ", "Español ", "Bilingue" });
            cmbIdioma.Location = new Point(83, 91);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(212, 23);
            cmbIdioma.TabIndex = 12;
            cmbIdioma.SelectedIndexChanged += cmbIdioma_SelectedIndexChanged;
            // 
            // txtExclusiones
            // 
            txtExclusiones.Location = new Point(83, 317);
            txtExclusiones.Name = "txtExclusiones";
            txtExclusiones.Size = new Size(212, 23);
            txtExclusiones.TabIndex = 11;
            txtExclusiones.TextChanged += txtExclusiones_TextChanged_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(3, 320);
            label16.Name = "label16";
            label16.Size = new Size(70, 15);
            label16.TabIndex = 10;
            label16.Text = "Exclusiones";
            label16.Click += label16_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAplicacion);
            groupBox1.Controls.Add(chkVentajas);
            groupBox1.Controls.Add(chkDatos);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(chkReferencias);
            groupBox1.Controls.Add(chkEjemplos);
            groupBox1.Location = new Point(83, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 142);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // chkAplicacion
            // 
            chkAplicacion.AutoSize = true;
            chkAplicacion.Location = new Point(5, 115);
            chkAplicacion.Name = "chkAplicacion";
            chkAplicacion.Size = new Size(168, 19);
            chkAplicacion.TabIndex = 5;
            chkAplicacion.Text = "Incluye Aplicación Práctica";
            chkAplicacion.UseVisualStyleBackColor = true;
            chkAplicacion.CheckedChanged += chkAplicacion_CheckedChanged;
            // 
            // chkVentajas
            // 
            chkVentajas.AutoSize = true;
            chkVentajas.Location = new Point(5, 90);
            chkVentajas.Name = "chkVentajas";
            chkVentajas.Size = new Size(190, 19);
            chkVentajas.TabIndex = 4;
            chkVentajas.Text = "Presenta ventajas y desventajas";
            chkVentajas.UseVisualStyleBackColor = true;
            chkVentajas.CheckedChanged += chkVentajas_CheckedChanged;
            // 
            // chkDatos
            // 
            chkDatos.AutoSize = true;
            chkDatos.Location = new Point(5, 65);
            chkDatos.Name = "chkDatos";
            chkDatos.Size = new Size(145, 19);
            chkDatos.TabIndex = 3;
            chkDatos.Text = "Usa datos actualizados";
            chkDatos.UseVisualStyleBackColor = true;
            chkDatos.CheckedChanged += chkDatos_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(189, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Agrega referencias academicas";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chkReferencias
            // 
            chkReferencias.AutoSize = true;
            chkReferencias.Location = new Point(6, 40);
            chkReferencias.Name = "chkReferencias";
            chkReferencias.Size = new Size(189, 19);
            chkReferencias.TabIndex = 1;
            chkReferencias.Text = "Agrega referencias academicas";
            chkReferencias.UseVisualStyleBackColor = true;
            // 
            // chkEjemplos
            // 
            chkEjemplos.AutoSize = true;
            chkEjemplos.Location = new Point(6, 15);
            chkEjemplos.Name = "chkEjemplos";
            chkEjemplos.Size = new Size(148, 19);
            chkEjemplos.TabIndex = 0;
            chkEjemplos.Text = "Incluye ejemplos reales";
            chkEjemplos.UseVisualStyleBackColor = true;
            chkEjemplos.CheckedChanged += chkEjemplos_CheckedChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(16, 170);
            label15.Name = "label15";
            label15.Size = new Size(54, 15);
            label15.TabIndex = 8;
            label15.Text = "Criterios";
            label15.Click += label15_Click;
            // 
            // cmbNivelRestriccion
            // 
            cmbNivelRestriccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelRestriccion.FormattingEnabled = true;
            cmbNivelRestriccion.Items.AddRange(new object[] { "Sencillo (Nivel Basico)", "Nivel Intermedio", "Nivel Avanzado", "Para Expertos", "Para Principiantes", "" });
            cmbNivelRestriccion.Location = new Point(83, 131);
            cmbNivelRestriccion.Name = "cmbNivelRestriccion";
            cmbNivelRestriccion.Size = new Size(212, 23);
            cmbNivelRestriccion.TabIndex = 7;
            cmbNivelRestriccion.SelectedIndexChanged += cmbNivelRestriccion_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(34, 134);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 6;
            label14.Text = "Nivel";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(25, 94);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 4;
            label13.Text = "Idioma";
            // 
            // cmbTono
            // 
            cmbTono.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTono.FormattingEnabled = true;
            cmbTono.Items.AddRange(new object[] { "Formal y Academico", "Profesional y corporativo", "Claro y didactico", "Persiasivo y motivador", "Conversacional y Cercano", "" });
            cmbTono.Location = new Point(83, 50);
            cmbTono.Name = "cmbTono";
            cmbTono.Size = new Size(212, 23);
            cmbTono.TabIndex = 3;
            cmbTono.SelectedIndexChanged += cmbTono_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(34, 53);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 2;
            label12.Text = "Tono";
            // 
            // cmbExtension
            // 
            cmbExtension.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExtension.FormattingEnabled = true;
            cmbExtension.Items.AddRange(new object[] { "Máximo 100 palabras", "Máximo 300 palabras", "Máximo 500 palabras", "1 Página aproximada", "Resumen en 5 Puntos" });
            cmbExtension.Location = new Point(83, 10);
            cmbExtension.Name = "cmbExtension";
            cmbExtension.Size = new Size(212, 23);
            cmbExtension.TabIndex = 1;
            cmbExtension.SelectedIndexChanged += cmbExtension_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(16, 13);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 0;
            label11.Text = "Extensión";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtbResultado);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(361, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(427, 382);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Prompt Generado (Editable)";
            // 
            // rtbResultado
            // 
            rtbResultado.Location = new Point(6, 21);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbResultado.Size = new Size(415, 355);
            rtbResultado.TabIndex = 0;
            rtbResultado.Text = "";
            // 
            // btnCopiar
            // 
            btnCopiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopiar.Location = new Point(365, 397);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(91, 23);
            btnCopiar.TabIndex = 6;
            btnCopiar.Text = "Copiar Prompt";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(462, 397);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar todo";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnChatGPT
            // 
            btnChatGPT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChatGPT.Location = new Point(613, 397);
            btnChatGPT.Name = "btnChatGPT";
            btnChatGPT.Size = new Size(83, 23);
            btnChatGPT.TabIndex = 8;
            btnChatGPT.Text = "CHAT GPT";
            btnChatGPT.UseVisualStyleBackColor = true;
            btnChatGPT.Click += btnChatGPT_Click;
            // 
            // btnGemini
            // 
            btnGemini.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGemini.Location = new Point(702, 397);
            btnGemini.Name = "btnGemini";
            btnGemini.Size = new Size(83, 23);
            btnGemini.TabIndex = 9;
            btnGemini.Text = "GEMINI";
            btnGemini.UseVisualStyleBackColor = true;
            btnGemini.Click += btnGemini_Click;
            // 
            // GeneradordePrompts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGemini);
            Controls.Add(btnChatGPT);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCopiar);
            Controls.Add(groupBox2);
            Controls.Add(tabControl1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GeneradordePrompts";
            Text = "Generador de Prompts";
            Load += GeneradordePrompts_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ComboBox cmbVerbo;
        private Label label4;
        private TextBox txtTema;
        private Label label5;
        private Label label6;
        private ComboBox cmbSector;
        private Label label8;
        private ComboBox cmbAudiencia;
        private Label label7;
        private ComboBox cmbRol;
        private ComboBox cmbNivelTecnico;
        private Label label9;
        private ComboBox cmbFormato;
        private Label label10;
        private ComboBox cmbTono;
        private Label label12;
        private ComboBox cmbExtension;
        private Label label11;
        private Label label13;
        private ComboBox cmbNivelRestriccion;
        private Label label14;
        private Label label15;
        private GroupBox groupBox1;
        private CheckBox chkEjemplos;
        private CheckBox chkVentajas;
        private CheckBox chkDatos;
        private CheckBox checkBox1;
        private CheckBox chkReferencias;
        private CheckBox chkAplicacion;
        private Label label16;
        private TextBox txtExclusiones;
        private GroupBox groupBox2;
        private Button btnCopiar;
        private Button btnLimpiar;
        private Button btnChatGPT;
        private Button btnGemini;
        private ComboBox cmbIdioma;
        private RichTextBox rtbResultado;
    }
}
