namespace DashBoard_UI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pBEmpleados = new System.Windows.Forms.PictureBox();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.pBProductos = new System.Windows.Forms.PictureBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.pBClientes = new System.Windows.Forms.PictureBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.pBEnvios = new System.Windows.Forms.PictureBox();
            this.lblEnvios = new System.Windows.Forms.Label();
            this.pBInformes = new System.Windows.Forms.PictureBox();
            this.lblInformes = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.chartNorthWind = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBInformes)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNorthWind)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pbLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartNorthWind, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 581);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.Image = global::DashBoard_UI.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(6, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(195, 101);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.pBEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.lblEmpleados);
            this.flowLayoutPanel1.Controls.Add(this.pBProductos);
            this.flowLayoutPanel1.Controls.Add(this.lblProductos);
            this.flowLayoutPanel1.Controls.Add(this.pBClientes);
            this.flowLayoutPanel1.Controls.Add(this.lblClientes);
            this.flowLayoutPanel1.Controls.Add(this.pBEnvios);
            this.flowLayoutPanel1.Controls.Add(this.lblEnvios);
            this.flowLayoutPanel1.Controls.Add(this.pBInformes);
            this.flowLayoutPanel1.Controls.Add(this.lblInformes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(206, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(766, 103);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pBEmpleados
            // 
            this.pBEmpleados.BackgroundImage = global::DashBoard_UI.Properties.Resources._293_2933613_employee_icon_png;
            this.pBEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBEmpleados.InitialImage = global::DashBoard_UI.Properties.Resources._293_2933613_employee_icon_png;
            this.pBEmpleados.Location = new System.Drawing.Point(3, 3);
            this.pBEmpleados.Name = "pBEmpleados";
            this.pBEmpleados.Size = new System.Drawing.Size(83, 77);
            this.pBEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBEmpleados.TabIndex = 1;
            this.pBEmpleados.TabStop = false;
            this.pBEmpleados.Click += new System.EventHandler(this.pbEmpleados_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.BackColor = System.Drawing.Color.DarkGray;
            this.lblEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.Color.Black;
            this.lblEmpleados.Location = new System.Drawing.Point(3, 83);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(83, 16);
            this.lblEmpleados.TabIndex = 6;
            this.lblEmpleados.Text = "Empleados";
            this.lblEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpleados.Click += new System.EventHandler(this.lblEmpleados_Click);
            // 
            // pBProductos
            // 
            this.pBProductos.BackgroundImage = global::DashBoard_UI.Properties.Resources._49602_freight_packing_products_shipment_trucking_icon;
            this.pBProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBProductos.InitialImage = global::DashBoard_UI.Properties.Resources._293_2933613_employee_icon_png;
            this.pBProductos.Location = new System.Drawing.Point(92, 3);
            this.pBProductos.Name = "pBProductos";
            this.pBProductos.Size = new System.Drawing.Size(84, 77);
            this.pBProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBProductos.TabIndex = 2;
            this.pBProductos.TabStop = false;
            this.pBProductos.Click += new System.EventHandler(this.pBProductos_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.Color.White;
            this.lblProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(92, 83);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(84, 16);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "Productos";
            this.lblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductos.Click += new System.EventHandler(this.lblProductos_Click);
            // 
            // pBClientes
            // 
            this.pBClientes.BackgroundImage = global::DashBoard_UI.Properties.Resources._1218712_customers_group_team_user_user_group_icon;
            this.pBClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBClientes.InitialImage = global::DashBoard_UI.Properties.Resources._293_2933613_employee_icon_png;
            this.pBClientes.Location = new System.Drawing.Point(182, 3);
            this.pBClientes.Name = "pBClientes";
            this.pBClientes.Size = new System.Drawing.Size(100, 77);
            this.pBClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBClientes.TabIndex = 4;
            this.pBClientes.TabStop = false;
            this.pBClientes.Click += new System.EventHandler(this.pBClientes_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.White;
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(182, 83);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(100, 16);
            this.lblClientes.TabIndex = 7;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // pBEnvios
            // 
            this.pBEnvios.BackgroundImage = global::DashBoard_UI.Properties.Resources._2332026;
            this.pBEnvios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBEnvios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBEnvios.InitialImage = global::DashBoard_UI.Properties.Resources._293_2933613_employee_icon_png;
            this.pBEnvios.Location = new System.Drawing.Point(288, 3);
            this.pBEnvios.Name = "pBEnvios";
            this.pBEnvios.Size = new System.Drawing.Size(100, 77);
            this.pBEnvios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBEnvios.TabIndex = 8;
            this.pBEnvios.TabStop = false;
            this.pBEnvios.Click += new System.EventHandler(this.pbEnvios_Click);
            // 
            // lblEnvios
            // 
            this.lblEnvios.AutoSize = true;
            this.lblEnvios.BackColor = System.Drawing.Color.White;
            this.lblEnvios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnvios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEnvios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnvios.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvios.Location = new System.Drawing.Point(288, 83);
            this.lblEnvios.Name = "lblEnvios";
            this.lblEnvios.Size = new System.Drawing.Size(100, 16);
            this.lblEnvios.TabIndex = 9;
            this.lblEnvios.Text = "Envios";
            this.lblEnvios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnvios.Click += new System.EventHandler(this.lblEnvios_Click);
            // 
            // pBInformes
            // 
            this.pBInformes.BackgroundImage = global::DashBoard_UI.Properties.Resources._49615_reports_report_documents_icon;
            this.pBInformes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBInformes.InitialImage = global::DashBoard_UI.Properties.Resources._293_2933613_employee_icon_png;
            this.pBInformes.Location = new System.Drawing.Point(394, 3);
            this.pBInformes.Name = "pBInformes";
            this.pBInformes.Size = new System.Drawing.Size(100, 77);
            this.pBInformes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBInformes.TabIndex = 10;
            this.pBInformes.TabStop = false;
            this.pBInformes.Click += new System.EventHandler(this.pbInformes_Click);
            // 
            // lblInformes
            // 
            this.lblInformes.AutoSize = true;
            this.lblInformes.BackColor = System.Drawing.Color.White;
            this.lblInformes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInformes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInformes.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformes.Location = new System.Drawing.Point(394, 83);
            this.lblInformes.Name = "lblInformes";
            this.lblInformes.Size = new System.Drawing.Size(100, 16);
            this.lblInformes.TabIndex = 11;
            this.lblInformes.Text = "Informes";
            this.lblInformes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInformes.Click += new System.EventHandler(this.lblInformes_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btn1);
            this.flowLayoutPanel2.Controls.Add(this.btn2);
            this.flowLayoutPanel2.Controls.Add(this.btn3);
            this.flowLayoutPanel2.Controls.Add(this.btn4);
            this.flowLayoutPanel2.Controls.Add(this.btn5);
            this.flowLayoutPanel2.Controls.Add(this.btn6);
            this.flowLayoutPanel2.Controls.Add(this.btn7);
            this.flowLayoutPanel2.Controls.Add(this.btn8);
            this.flowLayoutPanel2.Controls.Add(this.btn9);
            this.flowLayoutPanel2.Controls.Add(this.btn10);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 113);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(195, 462);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(184, 38);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Total de ventas por empleado";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Location = new System.Drawing.Point(3, 47);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(184, 38);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "1";
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Location = new System.Drawing.Point(3, 91);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(184, 38);
            this.btn3.TabIndex = 2;
            this.btn3.Tag = "2";
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Location = new System.Drawing.Point(3, 135);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(184, 38);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "3";
            this.btn4.Text = "button4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Location = new System.Drawing.Point(3, 179);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(184, 38);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "button5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Location = new System.Drawing.Point(3, 223);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(184, 38);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "button6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Location = new System.Drawing.Point(3, 267);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(184, 38);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "button7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Location = new System.Drawing.Point(3, 311);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(184, 38);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "btn8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Location = new System.Drawing.Point(3, 355);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(184, 38);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "btn9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn10
            // 
            this.btn10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10.Location = new System.Drawing.Point(3, 399);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(184, 38);
            this.btn10.TabIndex = 9;
            this.btn10.Text = "btn10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // chartNorthWind
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNorthWind.ChartAreas.Add(chartArea1);
            this.chartNorthWind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartNorthWind.Location = new System.Drawing.Point(207, 113);
            this.chartNorthWind.Name = "chartNorthWind";
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series1.ShadowOffset = 1;
            series1.YValuesPerPoint = 4;
            this.chartNorthWind.Series.Add(series1);
            this.chartNorthWind.Size = new System.Drawing.Size(764, 462);
            this.chartNorthWind.TabIndex = 5;
            this.chartNorthWind.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Titulo1";
            this.chartNorthWind.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DashBoard_lortega";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBInformes)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartNorthWind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pBEmpleados;
        private System.Windows.Forms.PictureBox pBProductos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.PictureBox pBClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNorthWind;
        private System.Windows.Forms.PictureBox pBEnvios;
        private System.Windows.Forms.Label lblEnvios;
        private System.Windows.Forms.PictureBox pBInformes;
        private System.Windows.Forms.Label lblInformes;
    }
}

