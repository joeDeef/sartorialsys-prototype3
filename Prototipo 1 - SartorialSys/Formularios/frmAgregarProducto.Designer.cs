namespace Prototipo_1___SartorialSys.Formularios
{
    partial class frmAgregarProducto
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
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(438, 109);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(222, 28);
            this.txtCodigoProducto.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Buscar por código de producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(368, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 15;
            this.label11.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(438, 158);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(222, 28);
            this.txtCantidad.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.Location = new System.Drawing.Point(244, 226);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 42);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.Location = new System.Drawing.Point(417, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 42);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(688, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 42);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 357);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Name = "frmAgregarProducto";
            this.Text = "Agregar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}