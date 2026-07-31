namespace Ejercicio1
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
            txtCantidad = new TextBox();
            cboUnidad = new ComboBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(73, 71);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(194, 23);
            txtCantidad.TabIndex = 0;
            // 
            // cboUnidad
            // 
            cboUnidad.FormattingEnabled = true;
            cboUnidad.Location = new Point(415, 71);
            cboUnidad.Name = "cboUnidad";
            cboUnidad.Size = new Size(213, 23);
            cboUnidad.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(304, 138);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(314, 220);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(cboUnidad);
            Controls.Add(txtCantidad);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidad;
        private ComboBox cboUnidad;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
