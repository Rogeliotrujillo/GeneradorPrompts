using System;
using System.Windows.Forms;

namespace GeneradorPrompts
{
    public partial class GeneradordePrompts : Form
    {
        public GeneradordePrompts()
        {
            InitializeComponent();
        }

        private void GeneradordePrompts_Load(object sender, EventArgs e)
        {
            // Aquí puedes poner el código si necesitas que algo pase al abrir la ventana
        }

        // ====================================================================
        // La función que arma el prompt
        // ====================================================================
        private void GenerarPrompt()
        {
            rtbResultado.Clear();

            if (string.IsNullOrWhiteSpace(txtTema.Text))
            {
                rtbResultado.Clear();
                return;
            }

            Font fuenteTitulo = new Font("Segoe UI", 10, FontStyle.Bold);
            Font fuenteNormal = new Font("Segoe UI", 10, FontStyle.Regular);

            
            Color colorTitulo = Color.FromArgb(30, 30, 30);
            Color colorTexto = Color.FromArgb(60, 60, 60);

            
            EscribirTitulo($"{cmbVerbo.Text} ", fuenteTitulo, colorTitulo);

            
            rtbResultado.SelectionFont = fuenteNormal;
            rtbResultado.SelectionColor = colorTexto;
            rtbResultado.AppendText($"sobre el siguiente tema: {txtTema.Text}.\n\n");


            // --- 2. Contexto ---
            EscribirTitulo("CONTEXTO:\n", fuenteTitulo, colorTitulo);
            if (!string.IsNullOrWhiteSpace(cmbRol.Text)) rtbResultado.AppendText($"• {cmbRol.Text}\n");
            if (!string.IsNullOrWhiteSpace(cmbAudiencia.Text)) rtbResultado.AppendText($"• {cmbAudiencia.Text}\n");
            if (!string.IsNullOrWhiteSpace(cmbSector.Text)) rtbResultado.AppendText($"• {cmbSector.Text}\n");
            if (!string.IsNullOrWhiteSpace(cmbNivelTecnico.Text)) rtbResultado.AppendText($"• {cmbNivelTecnico.Text}\n");
            rtbResultado.AppendText("\n");

            // --- 3. Formato de Salida ---
            EscribirTitulo("FORMATO DE SALIDA:\n", fuenteTitulo, colorTitulo);
            if (!string.IsNullOrWhiteSpace(cmbFormato.Text)) rtbResultado.AppendText($"• {cmbFormato.Text}\n\n");

            // --- 4. Restricciones ---
            EscribirTitulo("RESTRICCIONES:\n", fuenteTitulo, colorTitulo);
            if (!string.IsNullOrWhiteSpace(cmbExtension.Text)) rtbResultado.AppendText($"• Extensión: {cmbExtension.Text}\n");
            if (!string.IsNullOrWhiteSpace(cmbTono.Text)) rtbResultado.AppendText($"• Tono: {cmbTono.Text}\n");
            if (!string.IsNullOrWhiteSpace(cmbIdioma.Text)) rtbResultado.AppendText($"• Idioma: {cmbIdioma.Text}\n");
            if (!string.IsNullOrWhiteSpace(cmbNivelRestriccion.Text)) rtbResultado.AppendText($"• Nivel: {cmbNivelRestriccion.Text}\n");

            // Criterios (CheckBox)
            if (chkEjemplos.Checked) rtbResultado.AppendText("• Incluye ejemplos reales\n");
            if (chkReferencias.Checked) rtbResultado.AppendText("• Agrega referencias académicas\n");
            if (chkDatos.Checked) rtbResultado.AppendText("• Usa datos actualizados\n");
            if (chkVentajas.Checked) rtbResultado.AppendText("• Presenta ventajas y desventajas\n");
            if (chkAplicacion.Checked) rtbResultado.AppendText("• Incluye aplicación práctica\n");

            // Exclusiones
            if (!string.IsNullOrWhiteSpace(txtExclusiones.Text))
            {
                rtbResultado.AppendText($"• {txtExclusiones.Text}\n");
            }
        }

        
        private void EscribirTitulo(string texto, Font fuente, Color color)
        {
            rtbResultado.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            rtbResultado.SelectionColor = Color.FromArgb(60, 60, 60);
            rtbResultado.AppendText(texto);

            rtbResultado.Select(rtbResultado.TextLength - texto.Length, texto.Length);
            rtbResultado.SelectionFont = fuente;
            rtbResultado.SelectionColor = color;

            rtbResultado.SelectionStart = rtbResultado.TextLength;
            rtbResultado.SelectionLength = 0;
        }

        // ====================================================================
        // EVENTOS Para que se actualice en tiempo real
        // ====================================================================

        // Evento para el Tema (cuando el usuario escribe)
        private void txtTema_TextChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        // Evento para las Exclusiones (cuando el usuario escribe)
        private void txtExclusiones_TextChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        // Evento para el ComboBox de Verbo (cuando el usuario cambia la opción)
        private void cmbVerbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        // ¡Ojo! Aquí faltan los eventos de los otros ComboBox y CheckBox.
        // Los agregaremos en el siguiente paso para no hacer esto tan largo de golpe.

        // Eventos vacíos que ya tenías (los dejamos por si acaso)
        private void label2_Click(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }

        private void txtTema_TextChanged_1(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void cmbVerbo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void cmbAudiencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void cmbSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void cmbNivelTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void cmbFormato_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void cmbExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void cmbTono_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void cmbNivelRestriccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void chkEjemplos_CheckedChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void chkDatos_CheckedChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void chkVentajas_CheckedChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void chkAplicacion_CheckedChanged(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void txtExclusiones_TextChanged_1(object sender, EventArgs e)
        {
            GenerarPrompt();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbResultado.Text))
            {
                Clipboard.SetText(rtbResultado.Text);
                MessageBox.Show("¡Prompt copiado al portapapeles!", "Éxito");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // 1. Limpiar los TextBox
            txtTema.Clear();
            txtExclusiones.Clear();
            rtbResultado.Clear();

            // 2. Desmarcar los CheckBox
            chkEjemplos.Checked = false;
            chkReferencias.Checked = false;
            chkDatos.Checked = false;
            chkVentajas.Checked = false;
            chkAplicacion.Checked = false;

            // 3. Reiniciar los ComboBox 
            // -1 para que no haya ninguna opción seleccionada
            cmbVerbo.SelectedIndex = -1;
            cmbRol.SelectedIndex = -1;
            cmbAudiencia.SelectedIndex = -1;
            cmbSector.SelectedIndex = -1;
            cmbNivelTecnico.SelectedIndex = -1;
            cmbFormato.SelectedIndex = -1;
            cmbExtension.SelectedIndex = -1;
            cmbTono.SelectedIndex = -1;
            cmbIdioma.SelectedIndex = -1;
            cmbNivelRestriccion.SelectedIndex = -1;

            // 4. Volver a la primera pestaña para que el usuario empiece de cero
            tabControl1.SelectedIndex = 0;

            // 5. Enfocar el cursor en el primer campo para que el usuario pueda escribir de inmediato
            txtTema.Focus();
        }

        private void btnChatGPT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbResultado.Text))
            {
                Clipboard.SetText(rtbResultado.Text); 
                MessageBox.Show("Prompt copiado al portapapeles. Pégalo en ChatGPT.", "Abriendo ChatGPT...");

                
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://chatgpt.com/")
                {
                    UseShellExecute = true
                });
            }
        }

        private void btnGemini_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbResultado.Text))
            {
                Clipboard.SetText(rtbResultado.Text); 
                MessageBox.Show("Prompt copiado al portapapeles. Pégalo en Gemini.", "Abriendo Gemini...");

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://gemini.google.com/")
                {
                    UseShellExecute = true
                });
            }
        }
    }
}
