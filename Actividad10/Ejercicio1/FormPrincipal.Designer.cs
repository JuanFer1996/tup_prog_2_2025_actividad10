namespace Ejercicio1
{
    partial class FormPrincipal
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
            lsbVerSolicitudesImportadas = new ListBox();
            btnIMportarSolicitudes = new Button();
            SuspendLayout();
            // 
            // lsbVerSolicitudesImportadas
            // 
            lsbVerSolicitudesImportadas.FormattingEnabled = true;
            lsbVerSolicitudesImportadas.ItemHeight = 15;
            lsbVerSolicitudesImportadas.Location = new Point(12, 81);
            lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            lsbVerSolicitudesImportadas.Size = new Size(273, 244);
            lsbVerSolicitudesImportadas.TabIndex = 0;
            // 
            // btnIMportarSolicitudes
            // 
            btnIMportarSolicitudes.Location = new Point(12, 12);
            btnIMportarSolicitudes.Name = "btnIMportarSolicitudes";
            btnIMportarSolicitudes.Size = new Size(90, 53);
            btnIMportarSolicitudes.TabIndex = 1;
            btnIMportarSolicitudes.Text = "Importar Solicitudes";
            btnIMportarSolicitudes.UseVisualStyleBackColor = true;
            btnIMportarSolicitudes.Click += btnIMportarSolicitudes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIMportarSolicitudes);
            Controls.Add(lsbVerSolicitudesImportadas);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbVerSolicitudesImportadas;
        private Button btnIMportarSolicitudes;
    }
}
