namespace FuegosArtificiales
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            temporizadorAnimación = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // temporizadorAnimación
            // 
            temporizadorAnimación.Enabled = true;
            temporizadorAnimación.Interval = 20;
            temporizadorAnimación.Tick += EventoAnimaciones;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Fuegos Artificiales";
            Paint += FormularioDiseño;
            KeyUp += SoltarTecla;
            MouseDown += PresionarBotonMouse;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer temporizadorAnimación;
    }
}