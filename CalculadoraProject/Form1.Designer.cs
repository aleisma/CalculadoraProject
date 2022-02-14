namespace CalculadoraProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cajaResultado = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajaResultado
            // 
            this.cajaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaResultado.Location = new System.Drawing.Point(12, 12);
            this.cajaResultado.Multiline = true;
            this.cajaResultado.Name = "cajaResultado";
            this.cajaResultado.ReadOnly = true;
            this.cajaResultado.Size = new System.Drawing.Size(237, 56);
            this.cajaResultado.TabIndex = 0;
            this.cajaResultado.Text = "0";
            this.cajaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cajaResultado.TextChanged += new System.EventHandler(this.cajaResultado_TextChanged);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHistorial.ForeColor = System.Drawing.Color.Black;
            this.lblHistorial.Location = new System.Drawing.Point(20, 42);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(84, 13);
            this.lblHistorial.TabIndex = 1;
            this.lblHistorial.Text = "Ingrese un Valor";
            this.lblHistorial.Click += new System.EventHandler(this.lblHistorial_Click);
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUno.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUno.Location = new System.Drawing.Point(11, 218);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(75, 42);
            this.btnUno.TabIndex = 2;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDos.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDos.Location = new System.Drawing.Point(92, 218);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(75, 42);
            this.btnDos.TabIndex = 3;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTres.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTres.Location = new System.Drawing.Point(173, 218);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 42);
            this.btnTres.TabIndex = 4;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSeis.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeis.Location = new System.Drawing.Point(173, 170);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(75, 42);
            this.btnSeis.TabIndex = 7;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCinco.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCinco.Location = new System.Drawing.Point(92, 170);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 42);
            this.btnCinco.TabIndex = 6;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCuatro.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCuatro.Location = new System.Drawing.Point(11, 170);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(75, 42);
            this.btnCuatro.TabIndex = 5;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNueve.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNueve.Location = new System.Drawing.Point(173, 122);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(75, 42);
            this.btnNueve.TabIndex = 10;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOcho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOcho.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOcho.Location = new System.Drawing.Point(92, 122);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(75, 42);
            this.btnOcho.TabIndex = 9;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSiete.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiete.Location = new System.Drawing.Point(11, 122);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(75, 42);
            this.btnSiete.TabIndex = 8;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCero.FlatAppearance.BorderSize = 2;
            this.btnCero.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCero.Location = new System.Drawing.Point(11, 266);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(156, 45);
            this.btnCero.TabIndex = 11;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPunto.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPunto.Location = new System.Drawing.Point(173, 267);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(75, 42);
            this.btnPunto.TabIndex = 12;
            this.btnPunto.Text = ",";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMultiplicacion.Location = new System.Drawing.Point(11, 317);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(75, 42);
            this.btnMultiplicacion.TabIndex = 13;
            this.btnMultiplicacion.Text = "X";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnResta.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResta.Location = new System.Drawing.Point(92, 365);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 42);
            this.btnResta.TabIndex = 14;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSuma.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuma.Location = new System.Drawing.Point(92, 317);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 42);
            this.btnSuma.TabIndex = 15;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.LimeGreen;
            this.btnIgual.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIgual.Location = new System.Drawing.Point(173, 317);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 90);
            this.btnIgual.TabIndex = 16;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrar.Location = new System.Drawing.Point(173, 74);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 42);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "<";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(92, 74);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 42);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDivision.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDivision.Location = new System.Drawing.Point(11, 365);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 42);
            this.btnDivision.TabIndex = 18;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModulo.Location = new System.Drawing.Point(11, 74);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(75, 42);
            this.btnModulo.TabIndex = 17;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(262, 406);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.cajaResultado);
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "Form1";
            this.Opacity = 0.88D;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Calculadora V 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajaResultado;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnModulo;
    }
}

