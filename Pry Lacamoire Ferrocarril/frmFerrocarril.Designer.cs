namespace Pry_Lacamoire_Ferrocarril
{
    partial class frmFerrocarril
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFerrocarril));
            this.lblFerrocarrilFerro = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.numericudDias = new System.Windows.Forms.NumericUpDown();
            this.cmdCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericudDias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFerrocarrilFerro
            // 
            this.lblFerrocarrilFerro.AutoSize = true;
            this.lblFerrocarrilFerro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFerrocarrilFerro.Location = new System.Drawing.Point(96, 44);
            this.lblFerrocarrilFerro.Name = "lblFerrocarrilFerro";
            this.lblFerrocarrilFerro.Size = new System.Drawing.Size(206, 25);
            this.lblFerrocarrilFerro.TabIndex = 0;
            this.lblFerrocarrilFerro.Text = "Ferrocarril FERRO";
            this.lblFerrocarrilFerro.Click += new System.EventHandler(this.lblFerrocarrilFerro_Click);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(45, 104);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(99, 13);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distancia a recorrer";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(45, 166);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(83, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Dias de Estadía";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(247, 96);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 3;
            this.txtDistancia.Text = "2";
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // numericudDias
            // 
            this.numericudDias.Location = new System.Drawing.Point(247, 166);
            this.numericudDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericudDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericudDias.Name = "numericudDias";
            this.numericudDias.Size = new System.Drawing.Size(55, 20);
            this.numericudDias.TabIndex = 4;
            this.numericudDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Enabled = false;
            this.cmdCalcular.Location = new System.Drawing.Point(154, 225);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcular.TabIndex = 5;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // frmFerrocarril
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 329);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.numericudDias);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblFerrocarrilFerro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFerrocarril";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferrocarril";
            this.Load += new System.EventHandler(this.frmFerrocarril_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericudDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFerrocarrilFerro;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.NumericUpDown numericudDias;
        private System.Windows.Forms.Button cmdCalcular;
    }
}

