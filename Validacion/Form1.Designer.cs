namespace Validacion
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
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.lblDominio = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblCuil = new System.Windows.Forms.Label();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.lblDominio2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDominio
            // 
            this.txtDominio.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDominio.Location = new System.Drawing.Point(90, 112);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 25);
            this.txtDominio.TabIndex = 0;
            // 
            // txtCuil
            // 
            this.txtCuil.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuil.Location = new System.Drawing.Point(90, 355);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(100, 25);
            this.txtCuil.TabIndex = 1;
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDominio.ForeColor = System.Drawing.Color.Black;
            this.lblDominio.Location = new System.Drawing.Point(86, 71);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(174, 23);
            this.lblDominio.TabIndex = 2;
            this.lblDominio.Text = "INGRESE EL DOMINIO ";
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(468, 90);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(134, 31);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Validar Dominio";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuil.ForeColor = System.Drawing.Color.Black;
            this.lblCuil.Location = new System.Drawing.Point(86, 317);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(134, 23);
            this.lblCuil.TabIndex = 4;
            this.lblCuil.Text = "INGRESE EL CUIL";
            // 
            // btnExtraer
            // 
            this.btnExtraer.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraer.Location = new System.Drawing.Point(468, 349);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(134, 31);
            this.btnExtraer.TabIndex = 5;
            this.btnExtraer.Text = "Extraer Cuil";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // lblDominio2
            // 
            this.lblDominio2.AutoSize = true;
            this.lblDominio2.Font = new System.Drawing.Font("Open Sans Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDominio2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDominio2.Location = new System.Drawing.Point(257, 74);
            this.lblDominio2.Name = "lblDominio2";
            this.lblDominio2.Size = new System.Drawing.Size(105, 19);
            this.lblDominio2.TabIndex = 6;
            this.lblDominio2.Text = "(AAA123 o AA123AA)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(226, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Incluya los guiones correspondientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Validacion.Properties.Resources.wp2386111;
            this.ClientSize = new System.Drawing.Size(799, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDominio2);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblDominio);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.txtDominio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Label lblDominio2;
        private System.Windows.Forms.Label label1;
    }
}

