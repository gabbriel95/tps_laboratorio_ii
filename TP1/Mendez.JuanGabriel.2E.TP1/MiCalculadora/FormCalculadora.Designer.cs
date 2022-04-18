namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.components = new System.ComponentModel.Container();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnABin = new System.Windows.Forms.Button();
            this.btnADec = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lvlError = new System.Windows.Forms.Label();
            this.lvlError2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lstOperaciones = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(185, 91);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(101, 23);
            this.cmbOperador.TabIndex = 1;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(59, 91);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(60, 23);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber1_KeyPress);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(322, 91);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(60, 23);
            this.txtNumber2.TabIndex = 2;
            this.txtNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber2_KeyPress);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(49, 184);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(120, 56);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(175, 184);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 56);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpi ar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(301, 184);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 56);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnABin
            // 
            this.btnABin.Location = new System.Drawing.Point(237, 258);
            this.btnABin.Name = "btnABin";
            this.btnABin.Size = new System.Drawing.Size(145, 51);
            this.btnABin.TabIndex = 6;
            this.btnABin.Text = "Convertir a Binario";
            this.btnABin.UseVisualStyleBackColor = true;
            this.btnABin.Click += new System.EventHandler(this.btnABin_Click);
            // 
            // btnADec
            // 
            this.btnADec.Location = new System.Drawing.Point(86, 258);
            this.btnADec.Name = "btnADec";
            this.btnADec.Size = new System.Drawing.Size(145, 51);
            this.btnADec.TabIndex = 7;
            this.btnADec.Text = "Convertir a Decimal";
            this.btnADec.UseVisualStyleBackColor = true;
            this.btnADec.Click += new System.EventHandler(this.btnADec_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(266, 37);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(197, 33);
            this.lblResultado.TabIndex = 8;
            // 
            // lvlError
            // 
            this.lvlError.AutoSize = true;
            this.lvlError.ForeColor = System.Drawing.Color.Red;
            this.lvlError.Location = new System.Drawing.Point(59, 117);
            this.lvlError.Name = "lvlError";
            this.lvlError.Size = new System.Drawing.Size(115, 15);
            this.lvlError.TabIndex = 9;
            this.lvlError.Text = "*Error, solo numeros";
            this.lvlError.Visible = false;
            // 
            // lvlError2
            // 
            this.lvlError2.AutoSize = true;
            this.lvlError2.ForeColor = System.Drawing.Color.Red;
            this.lvlError2.Location = new System.Drawing.Point(322, 117);
            this.lvlError2.Name = "lvlError2";
            this.lvlError2.Size = new System.Drawing.Size(115, 15);
            this.lvlError2.TabIndex = 10;
            this.lvlError2.Text = "*Error, solo numeros";
            this.lvlError2.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOperaciones.Location = new System.Drawing.Point(479, 55);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(235, 243);
            this.lstOperaciones.TabIndex = 12;
            this.lstOperaciones.Text = "";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.lvlError2);
            this.Controls.Add(this.lvlError);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnADec);
            this.Controls.Add(this.btnABin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.cmbOperador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Mendez Juan del curo 2E";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnABin;
        private System.Windows.Forms.Button btnADec;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lvlError;
        private System.Windows.Forms.Label lvlError2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox lstOperaciones;
    }
}
