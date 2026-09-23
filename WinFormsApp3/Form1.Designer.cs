namespace WinFormsApp3
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
            label1 = new Label();
            lbledad = new Label();
            txtedad = new TextBox();
            bttregistrar = new Button();
            bttveredades = new Button();
            bttlimpiar = new Button();
            bttsalir = new Button();
            lstsalida = new ListBox();
            lblcantidad = new Label();
            lblcantidadedades = new Label();
            lblregistradas = new Label();
            lbledadesregistradas = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 38);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE EDADES";
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(50, 85);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(114, 15);
            lbledad.TabIndex = 1;
            lbledad.Text = "INGRESAR SU EDAD:";
            // 
            // txtedad
            // 
            txtedad.Location = new Point(170, 82);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(138, 23);
            txtedad.TabIndex = 2;
            // 
            // bttregistrar
            // 
            bttregistrar.Location = new Point(39, 148);
            bttregistrar.Name = "bttregistrar";
            bttregistrar.Size = new Size(83, 41);
            bttregistrar.TabIndex = 3;
            bttregistrar.Text = "RESGISTRAR";
            bttregistrar.UseVisualStyleBackColor = true;
            bttregistrar.Click += bttregistrar_Click;
            // 
            // bttveredades
            // 
            bttveredades.Location = new Point(187, 148);
            bttveredades.Name = "bttveredades";
            bttveredades.Size = new Size(100, 41);
            bttveredades.TabIndex = 4;
            bttveredades.Text = "VER EDADES";
            bttveredades.UseVisualStyleBackColor = true;
            bttveredades.Click += bttveredades_Click;
            // 
            // bttlimpiar
            // 
            bttlimpiar.Location = new Point(385, 148);
            bttlimpiar.Name = "bttlimpiar";
            bttlimpiar.Size = new Size(99, 41);
            bttlimpiar.TabIndex = 5;
            bttlimpiar.Text = "LIMPIAR";
            bttlimpiar.UseVisualStyleBackColor = true;
            bttlimpiar.Click += bttlimpiar_Click;
            // 
            // bttsalir
            // 
            bttsalir.Location = new Point(583, 148);
            bttsalir.Name = "bttsalir";
            bttsalir.Size = new Size(99, 41);
            bttsalir.TabIndex = 6;
            bttsalir.Text = "SALIR";
            bttsalir.UseVisualStyleBackColor = true;
            bttsalir.Click += bttsalir_Click;
            // 
            // lstsalida
            // 
            lstsalida.FormattingEnabled = true;
            lstsalida.Location = new Point(39, 228);
            lstsalida.Name = "lstsalida";
            lstsalida.Size = new Size(289, 184);
            lstsalida.TabIndex = 7;
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(385, 271);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(206, 15);
            lblcantidad.TabIndex = 8;
            lblcantidad.Text = "CANTIDAD DE EDADES REGISTRADAS:";
            lblcantidad.Click += lblcantidad_Click;
            // 
            // lblcantidadedades
            // 
            lblcantidadedades.AutoSize = true;
            lblcantidadedades.Location = new Point(385, 307);
            lblcantidadedades.Name = "lblcantidadedades";
            lblcantidadedades.Size = new Size(38, 15);
            lblcantidadedades.TabIndex = 9;
            lblcantidadedades.Text = "label4";
            // 
            // lblregistradas
            // 
            lblregistradas.AutoSize = true;
            lblregistradas.Location = new Point(385, 349);
            lblregistradas.Name = "lblregistradas";
            lblregistradas.Size = new Size(128, 15);
            lblregistradas.TabIndex = 10;
            lblregistradas.Text = "EDADES REGISTRADAS:";
            // 
            // lbledadesregistradas
            // 
            lbledadesregistradas.AutoSize = true;
            lbledadesregistradas.Location = new Point(385, 382);
            lbledadesregistradas.Name = "lbledadesregistradas";
            lbledadesregistradas.Size = new Size(38, 15);
            lbledadesregistradas.TabIndex = 11;
            lbledadesregistradas.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbledadesregistradas);
            Controls.Add(lblregistradas);
            Controls.Add(lblcantidadedades);
            Controls.Add(lblcantidad);
            Controls.Add(lstsalida);
            Controls.Add(bttsalir);
            Controls.Add(bttlimpiar);
            Controls.Add(bttveredades);
            Controls.Add(bttregistrar);
            Controls.Add(txtedad);
            Controls.Add(lbledad);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbledad;
        private TextBox txtedad;
        private Button bttregistrar;
        private Button bttveredades;
        private Button bttlimpiar;
        private Button bttsalir;
        private ListBox lstsalida;
        private Label lblcantidad;
        private Label lblcantidadedades;
        private Label lblregistradas;
        private Label lbledadesregistradas;
    }
}
