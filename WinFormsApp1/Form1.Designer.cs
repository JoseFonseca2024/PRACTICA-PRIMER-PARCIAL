namespace WinFormsApp1
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
            lblTitle = new Label();
            lblTipodeVehiculo = new Label();
            cboTipodeVehiculo = new ComboBox();
            lblMarca = new Label();
            lblModelo = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            lblPasajeros = new Label();
            txtPasajeros = new TextBox();
            lblCapacidad = new Label();
            txtCarga = new TextBox();
            lblBateria = new Label();
            txtBateria = new TextBox();
            btnAgregar = new Button();
            btnDetener = new Button();
            btnIniciar = new Button();
            btnMover = new Button();
            btnCargar = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(144, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(301, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistema de Gestión de Vehiculos ";
            // 
            // lblTipodeVehiculo
            // 
            lblTipodeVehiculo.AutoSize = true;
            lblTipodeVehiculo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipodeVehiculo.Location = new Point(40, 52);
            lblTipodeVehiculo.Name = "lblTipodeVehiculo";
            lblTipodeVehiculo.Size = new Size(135, 21);
            lblTipodeVehiculo.TabIndex = 1;
            lblTipodeVehiculo.Text = "Tipo de vehiculo:";
            // 
            // cboTipodeVehiculo
            // 
            cboTipodeVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipodeVehiculo.FormattingEnabled = true;
            cboTipodeVehiculo.Items.AddRange(new object[] { "Auto", "Camión", "Motocicleta", "Vehiculo Electrico" });
            cboTipodeVehiculo.Location = new Point(192, 52);
            cboTipodeVehiculo.Name = "cboTipodeVehiculo";
            cboTipodeVehiculo.Size = new Size(161, 23);
            cboTipodeVehiculo.TabIndex = 2;
            cboTipodeVehiculo.SelectedIndexChanged += cboTipodeVehiculo_SelectedIndexChanged;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(116, 90);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(59, 21);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(103, 121);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(72, 21);
            lblModelo.TabIndex = 4;
            lblModelo.Text = "Modelo:";
            lblModelo.Click += lblModelo_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(192, 88);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(154, 23);
            txtMarca.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(192, 121);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(154, 23);
            txtModelo.TabIndex = 6;
            // 
            // lblPasajeros
            // 
            lblPasajeros.AutoSize = true;
            lblPasajeros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasajeros.Location = new Point(24, 155);
            lblPasajeros.Name = "lblPasajeros";
            lblPasajeros.Size = new Size(151, 21);
            lblPasajeros.TabIndex = 7;
            lblPasajeros.Text = "Cantidad Pasajeros:";
            lblPasajeros.Visible = false;
            // 
            // txtPasajeros
            // 
            txtPasajeros.Location = new Point(192, 153);
            txtPasajeros.Name = "txtPasajeros";
            txtPasajeros.Size = new Size(26, 23);
            txtPasajeros.TabIndex = 8;
            txtPasajeros.Visible = false;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapacidad.Location = new Point(27, 155);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(191, 21);
            lblCapacidad.TabIndex = 9;
            lblCapacidad.Text = "Capacidad de carga (Kg):";
            lblCapacidad.Visible = false;
            // 
            // txtCarga
            // 
            txtCarga.Location = new Point(224, 157);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(48, 23);
            txtCarga.TabIndex = 10;
            txtCarga.Visible = false;
            // 
            // lblBateria
            // 
            lblBateria.AutoSize = true;
            lblBateria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBateria.Location = new Point(27, 157);
            lblBateria.Name = "lblBateria";
            lblBateria.Size = new Size(172, 21);
            lblBateria.TabIndex = 11;
            lblBateria.Text = "Capacidad de Bateria: ";
            lblBateria.Visible = false;
            // 
            // txtBateria
            // 
            txtBateria.Location = new Point(205, 157);
            txtBateria.Name = "txtBateria";
            txtBateria.Size = new Size(48, 23);
            txtBateria.TabIndex = 12;
            txtBateria.Visible = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(463, 43);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 37);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetener.Location = new Point(463, 174);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(97, 37);
            btnDetener.TabIndex = 14;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(463, 83);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(97, 37);
            btnIniciar.TabIndex = 15;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnMover
            // 
            btnMover.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMover.Location = new Point(463, 126);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(97, 37);
            btnMover.TabIndex = 16;
            btnMover.Text = "Mover";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(360, 174);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(97, 37);
            btnCargar.TabIndex = 17;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Visible = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 228);
            Controls.Add(btnCargar);
            Controls.Add(btnMover);
            Controls.Add(btnIniciar);
            Controls.Add(btnDetener);
            Controls.Add(btnAgregar);
            Controls.Add(txtBateria);
            Controls.Add(lblBateria);
            Controls.Add(txtCarga);
            Controls.Add(lblCapacidad);
            Controls.Add(txtPasajeros);
            Controls.Add(lblPasajeros);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(cboTipodeVehiculo);
            Controls.Add(lblTipodeVehiculo);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTipodeVehiculo;
        private ComboBox cboTipodeVehiculo;
        private Label lblMarca;
        private Label lblModelo;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private Label lblPasajeros;
        private TextBox txtPasajeros;
        private Label lblCapacidad;
        private TextBox txtCarga;
        private Label lblBateria;
        private TextBox txtBateria;
        private Button btnAgregar;
        private Button btnDetener;
        private Button btnIniciar;
        private Button btnMover;
        private Button btnCargar;
    }
}
