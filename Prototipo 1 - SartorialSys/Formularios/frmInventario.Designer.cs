namespace Prototipo_1___SartorialSys
{
    partial class frmInventario
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
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStockConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColorConsulta = new System.Windows.Forms.TextBox();
            this.txtTallaConsulta = new System.Windows.Forms.TextBox();
            this.txtCategoriaConsulta = new System.Windows.Forms.TextBox();
            this.txtDescripcionConsulta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tabActualizar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntBuscarActualizar = new System.Windows.Forms.Button();
            this.txtParametroActualizar = new System.Windows.Forms.TextBox();
            this.tabClientes.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabActualizar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabConsulta);
            this.tabClientes.Controls.Add(this.tabActualizar);
            this.tabClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabClientes.Location = new System.Drawing.Point(0, 0);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(827, 603);
            this.tabClientes.TabIndex = 17;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.panel1);
            this.tabConsulta.Controls.Add(this.groupBox1);
            this.tabConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabConsulta.Size = new System.Drawing.Size(819, 574);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consultar Stock";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtStockConsulta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtColorConsulta);
            this.panel1.Controls.Add(this.txtTallaConsulta);
            this.panel1.Controls.Add(this.txtCategoriaConsulta);
            this.panel1.Controls.Add(this.txtDescripcionConsulta);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 459);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "Datos Producto";
            // 
            // txtStockConsulta
            // 
            this.txtStockConsulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockConsulta.Location = new System.Drawing.Point(283, 293);
            this.txtStockConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStockConsulta.Name = "txtStockConsulta";
            this.txtStockConsulta.ReadOnly = true;
            this.txtStockConsulta.Size = new System.Drawing.Size(320, 24);
            this.txtStockConsulta.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Stock:";
            // 
            // txtColorConsulta
            // 
            this.txtColorConsulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorConsulta.Location = new System.Drawing.Point(283, 207);
            this.txtColorConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColorConsulta.Name = "txtColorConsulta";
            this.txtColorConsulta.ReadOnly = true;
            this.txtColorConsulta.Size = new System.Drawing.Size(320, 24);
            this.txtColorConsulta.TabIndex = 42;
            // 
            // txtTallaConsulta
            // 
            this.txtTallaConsulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTallaConsulta.Location = new System.Drawing.Point(283, 250);
            this.txtTallaConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTallaConsulta.Name = "txtTallaConsulta";
            this.txtTallaConsulta.ReadOnly = true;
            this.txtTallaConsulta.Size = new System.Drawing.Size(320, 24);
            this.txtTallaConsulta.TabIndex = 32;
            // 
            // txtCategoriaConsulta
            // 
            this.txtCategoriaConsulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaConsulta.Location = new System.Drawing.Point(284, 164);
            this.txtCategoriaConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoriaConsulta.Name = "txtCategoriaConsulta";
            this.txtCategoriaConsulta.ReadOnly = true;
            this.txtCategoriaConsulta.Size = new System.Drawing.Size(318, 24);
            this.txtCategoriaConsulta.TabIndex = 31;
            // 
            // txtDescripcionConsulta
            // 
            this.txtDescripcionConsulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionConsulta.Location = new System.Drawing.Point(283, 121);
            this.txtDescripcionConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionConsulta.Name = "txtDescripcionConsulta";
            this.txtDescripcionConsulta.ReadOnly = true;
            this.txtDescripcionConsulta.Size = new System.Drawing.Size(320, 24);
            this.txtDescripcionConsulta.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Talla:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Color:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Descripción:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(79, 168);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 19);
            this.label29.TabIndex = 26;
            this.label29.Text = "Categoría:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(813, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Código del Producto:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(671, 46);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(95, 36);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Buscar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Consultar Producto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(394, 51);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(230, 26);
            this.txtID.TabIndex = 0;
            // 
            // tabActualizar
            // 
            this.tabActualizar.Controls.Add(this.panel2);
            this.tabActualizar.Controls.Add(this.groupBox2);
            this.tabActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabActualizar.Location = new System.Drawing.Point(4, 25);
            this.tabActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabActualizar.Name = "tabActualizar";
            this.tabActualizar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabActualizar.Size = new System.Drawing.Size(819, 574);
            this.tabActualizar.TabIndex = 1;
            this.tabActualizar.Text = "Actualizar Stock";
            this.tabActualizar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 459);
            this.panel2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 351);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(169, 354);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(178, 19);
            this.label26.TabIndex = 51;
            this.label26.Text = "Fecha de Actualización:";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(336, 391);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(137, 53);
            this.iconButton1.TabIndex = 50;
            this.iconButton1.Text = "Actualizar";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(394, 310);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(320, 24);
            this.textBox7.TabIndex = 49;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(167, 313);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(147, 19);
            this.label25.TabIndex = 48;
            this.label25.Text = "Egreso de Producto:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(394, 269);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(320, 24);
            this.textBox1.TabIndex = 47;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(169, 272);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(147, 19);
            this.label24.TabIndex = 46;
            this.label24.Text = "Ingreso de Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(315, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 28);
            this.label9.TabIndex = 45;
            this.label9.Text = "Datos Producto";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(394, 228);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(320, 24);
            this.textBox2.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(168, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 19);
            this.label11.TabIndex = 43;
            this.label11.Text = "Stock:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(394, 146);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(320, 24);
            this.textBox3.TabIndex = 42;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(394, 187);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(320, 24);
            this.textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(395, 105);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(318, 24);
            this.textBox5.TabIndex = 31;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(394, 64);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(320, 24);
            this.textBox6.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(168, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "Talla:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(168, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 19);
            this.label16.TabIndex = 28;
            this.label16.Text = "Color:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(168, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 19);
            this.label17.TabIndex = 27;
            this.label17.Text = "Descripción:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(168, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 19);
            this.label23.TabIndex = 26;
            this.label23.Text = "Categoría:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bntBuscarActualizar);
            this.groupBox2.Controls.Add(this.txtParametroActualizar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(813, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Consultar Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Código del Producto:";
            // 
            // bntBuscarActualizar
            // 
            this.bntBuscarActualizar.Location = new System.Drawing.Point(671, 46);
            this.bntBuscarActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntBuscarActualizar.Name = "bntBuscarActualizar";
            this.bntBuscarActualizar.Size = new System.Drawing.Size(95, 36);
            this.bntBuscarActualizar.TabIndex = 11;
            this.bntBuscarActualizar.Text = "Buscar";
            this.bntBuscarActualizar.UseVisualStyleBackColor = true;
            // 
            // txtParametroActualizar
            // 
            this.txtParametroActualizar.Location = new System.Drawing.Point(394, 51);
            this.txtParametroActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParametroActualizar.Name = "txtParametroActualizar";
            this.txtParametroActualizar.Size = new System.Drawing.Size(230, 26);
            this.txtParametroActualizar.TabIndex = 0;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 603);
            this.Controls.Add(this.tabClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInventario";
            this.Text = "SartorialSys";
            this.tabClientes.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabActualizar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TabPage tabActualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStockConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColorConsulta;
        private System.Windows.Forms.TextBox txtTallaConsulta;
        private System.Windows.Forms.TextBox txtCategoriaConsulta;
        private System.Windows.Forms.TextBox txtDescripcionConsulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label26;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntBuscarActualizar;
        private System.Windows.Forms.TextBox txtParametroActualizar;
    }
}