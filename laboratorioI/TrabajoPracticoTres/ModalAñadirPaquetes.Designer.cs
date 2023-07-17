namespace TrabajoPracticoTres
{
    partial class ModalGenerarCobro
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
            this.gbPaquetes = new System.Windows.Forms.GroupBox();
            this.tbPaquetesC = new System.Windows.Forms.TextBox();
            this.tbPaquetesB = new System.Windows.Forms.TextBox();
            this.tbPaquetesA = new System.Windows.Forms.TextBox();
            this.lPaquetesTipoC = new System.Windows.Forms.Label();
            this.lPaquetesTipoB = new System.Windows.Forms.Label();
            this.lPaquetesTipoA = new System.Windows.Forms.Label();
            this.lHoraPartida = new System.Windows.Forms.Label();
            this.nudHoraPartida = new System.Windows.Forms.NumericUpDown();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.lDomingoFeriado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.lMes = new System.Windows.Forms.Label();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.lDia = new System.Windows.Forms.Label();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gbPaquetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraPartida)).BeginInit();
            this.gbFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPaquetes
            // 
            this.gbPaquetes.Controls.Add(this.tbPaquetesC);
            this.gbPaquetes.Controls.Add(this.tbPaquetesB);
            this.gbPaquetes.Controls.Add(this.tbPaquetesA);
            this.gbPaquetes.Controls.Add(this.lPaquetesTipoC);
            this.gbPaquetes.Controls.Add(this.lPaquetesTipoB);
            this.gbPaquetes.Controls.Add(this.lPaquetesTipoA);
            this.gbPaquetes.Location = new System.Drawing.Point(12, 12);
            this.gbPaquetes.Name = "gbPaquetes";
            this.gbPaquetes.Size = new System.Drawing.Size(125, 133);
            this.gbPaquetes.TabIndex = 0;
            this.gbPaquetes.TabStop = false;
            this.gbPaquetes.Text = "Paquetes";
            // 
            // tbPaquetesC
            // 
            this.tbPaquetesC.Location = new System.Drawing.Point(60, 95);
            this.tbPaquetesC.Name = "tbPaquetesC";
            this.tbPaquetesC.Size = new System.Drawing.Size(44, 20);
            this.tbPaquetesC.TabIndex = 5;
            // 
            // tbPaquetesB
            // 
            this.tbPaquetesB.Location = new System.Drawing.Point(60, 59);
            this.tbPaquetesB.Name = "tbPaquetesB";
            this.tbPaquetesB.Size = new System.Drawing.Size(44, 20);
            this.tbPaquetesB.TabIndex = 4;
            // 
            // tbPaquetesA
            // 
            this.tbPaquetesA.Location = new System.Drawing.Point(60, 23);
            this.tbPaquetesA.Name = "tbPaquetesA";
            this.tbPaquetesA.Size = new System.Drawing.Size(44, 20);
            this.tbPaquetesA.TabIndex = 3;
            // 
            // lPaquetesTipoC
            // 
            this.lPaquetesTipoC.AutoSize = true;
            this.lPaquetesTipoC.Location = new System.Drawing.Point(16, 95);
            this.lPaquetesTipoC.Name = "lPaquetesTipoC";
            this.lPaquetesTipoC.Size = new System.Drawing.Size(38, 13);
            this.lPaquetesTipoC.TabIndex = 2;
            this.lPaquetesTipoC.Text = "Tipo C";
            // 
            // lPaquetesTipoB
            // 
            this.lPaquetesTipoB.AutoSize = true;
            this.lPaquetesTipoB.Location = new System.Drawing.Point(16, 62);
            this.lPaquetesTipoB.Name = "lPaquetesTipoB";
            this.lPaquetesTipoB.Size = new System.Drawing.Size(38, 13);
            this.lPaquetesTipoB.TabIndex = 1;
            this.lPaquetesTipoB.Text = "Tipo B";
            // 
            // lPaquetesTipoA
            // 
            this.lPaquetesTipoA.AutoSize = true;
            this.lPaquetesTipoA.Location = new System.Drawing.Point(16, 26);
            this.lPaquetesTipoA.Name = "lPaquetesTipoA";
            this.lPaquetesTipoA.Size = new System.Drawing.Size(38, 13);
            this.lPaquetesTipoA.TabIndex = 0;
            this.lPaquetesTipoA.Text = "Tipo A";
            // 
            // lHoraPartida
            // 
            this.lHoraPartida.AutoSize = true;
            this.lHoraPartida.Location = new System.Drawing.Point(15, 23);
            this.lHoraPartida.Name = "lHoraPartida";
            this.lHoraPartida.Size = new System.Drawing.Size(80, 13);
            this.lHoraPartida.TabIndex = 1;
            this.lHoraPartida.Text = "Hora de partida";
            // 
            // nudHoraPartida
            // 
            this.nudHoraPartida.Location = new System.Drawing.Point(18, 42);
            this.nudHoraPartida.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHoraPartida.Name = "nudHoraPartida";
            this.nudHoraPartida.Size = new System.Drawing.Size(52, 20);
            this.nudHoraPartida.TabIndex = 2;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.rbSi);
            this.gbFecha.Controls.Add(this.rbNo);
            this.gbFecha.Controls.Add(this.lDomingoFeriado);
            this.gbFecha.Controls.Add(this.label2);
            this.gbFecha.Controls.Add(this.nudAño);
            this.gbFecha.Controls.Add(this.lMes);
            this.gbFecha.Controls.Add(this.nudMes);
            this.gbFecha.Controls.Add(this.lDia);
            this.gbFecha.Controls.Add(this.nudDia);
            this.gbFecha.Controls.Add(this.lHoraPartida);
            this.gbFecha.Controls.Add(this.nudHoraPartida);
            this.gbFecha.Location = new System.Drawing.Point(143, 12);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(252, 133);
            this.gbFecha.TabIndex = 3;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(158, 45);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(34, 17);
            this.rbSi.TabIndex = 10;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(113, 45);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 4;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // lDomingoFeriado
            // 
            this.lDomingoFeriado.AutoSize = true;
            this.lDomingoFeriado.Location = new System.Drawing.Point(110, 23);
            this.lDomingoFeriado.Name = "lDomingoFeriado";
            this.lDomingoFeriado.Size = new System.Drawing.Size(118, 13);
            this.lDomingoFeriado.TabIndex = 9;
            this.lDomingoFeriado.Text = "¿Es domingo o feriado?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Año";
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(134, 96);
            this.nudAño.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nudAño.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(45, 20);
            this.nudAño.TabIndex = 8;
            this.nudAño.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // lMes
            // 
            this.lMes.AutoSize = true;
            this.lMes.Location = new System.Drawing.Point(72, 77);
            this.lMes.Name = "lMes";
            this.lMes.Size = new System.Drawing.Size(27, 13);
            this.lMes.TabIndex = 5;
            this.lMes.Text = "Mes";
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(75, 96);
            this.nudMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(42, 20);
            this.nudMes.TabIndex = 6;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lDia
            // 
            this.lDia.AutoSize = true;
            this.lDia.Location = new System.Drawing.Point(15, 77);
            this.lDia.Name = "lDia";
            this.lDia.Size = new System.Drawing.Size(23, 13);
            this.lDia.TabIndex = 3;
            this.lDia.Text = "Dia";
            // 
            // nudDia
            // 
            this.nudDia.Location = new System.Drawing.Point(18, 96);
            this.nudDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(42, 20);
            this.nudDia.TabIndex = 4;
            this.nudDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(12, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(186, 49);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGenerar.Location = new System.Drawing.Point(204, 151);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(191, 49);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // ModalGenerarCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 210);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.gbPaquetes);
            this.Name = "ModalGenerarCobro";
            this.Text = "Generar cobro";
            this.gbPaquetes.ResumeLayout(false);
            this.gbPaquetes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoraPartida)).EndInit();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox tbPaquetesC;
        public System.Windows.Forms.TextBox tbPaquetesB;
        public System.Windows.Forms.TextBox tbPaquetesA;
        public System.Windows.Forms.NumericUpDown nudHoraPartida;
        public System.Windows.Forms.NumericUpDown nudAño;
        public System.Windows.Forms.NumericUpDown nudMes;
        public System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.GroupBox gbPaquetes;
        private System.Windows.Forms.Label lPaquetesTipoC;
        private System.Windows.Forms.Label lPaquetesTipoB;
        private System.Windows.Forms.Label lPaquetesTipoA;
        private System.Windows.Forms.Label lHoraPartida;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lMes;
        private System.Windows.Forms.Label lDia;
        private System.Windows.Forms.Label lDomingoFeriado;
        public System.Windows.Forms.RadioButton rbNo;
        public System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerar;
    }
}