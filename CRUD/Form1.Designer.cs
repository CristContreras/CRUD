namespace CRUD
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nroLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNIEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajoEmpleado = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnConectarBD = new System.Windows.Forms.Button();
            this.btnDesconectarBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(248, 242);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(371, 242);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroLegajo,
            this.DNIEmpleado,
            this.nombreEmpleado,
            this.apellidoEmpleado,
            this.SectorTrabajo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(816, 213);
            this.dataGridView1.TabIndex = 6;
            // 
            // nroLegajo
            // 
            this.nroLegajo.HeaderText = "Legajo";
            this.nroLegajo.MinimumWidth = 8;
            this.nroLegajo.Name = "nroLegajo";
            // 
            // DNIEmpleado
            // 
            this.DNIEmpleado.HeaderText = "DNI";
            this.DNIEmpleado.MinimumWidth = 8;
            this.DNIEmpleado.Name = "DNIEmpleado";
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.HeaderText = "Nombre";
            this.nombreEmpleado.MinimumWidth = 8;
            this.nombreEmpleado.Name = "nombreEmpleado";
            // 
            // apellidoEmpleado
            // 
            this.apellidoEmpleado.HeaderText = "Apellido";
            this.apellidoEmpleado.MinimumWidth = 8;
            this.apellidoEmpleado.Name = "apellidoEmpleado";
            // 
            // SectorTrabajo
            // 
            this.SectorTrabajo.HeaderText = "Sector de Trabajo";
            this.SectorTrabajo.MinimumWidth = 8;
            this.SectorTrabajo.Name = "SectorTrabajo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSector);
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.txtDNIEmpleado);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.txtApellidoEmpleado);
            this.groupBox1.Controls.Add(this.lblNombreEmpleado);
            this.groupBox1.Controls.Add(this.txtNombreEmpleado);
            this.groupBox1.Controls.Add(this.txtLegajo);
            this.groupBox1.Controls.Add(this.lblLegajoEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 209);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sector trabajo:";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(597, 56);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(129, 26);
            this.txtSector.TabIndex = 5;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(22, 112);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(41, 20);
            this.lblDNI.TabIndex = 10;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNIEmpleado
            // 
            this.txtDNIEmpleado.Location = new System.Drawing.Point(161, 109);
            this.txtDNIEmpleado.Name = "txtDNIEmpleado";
            this.txtDNIEmpleado.Size = new System.Drawing.Size(129, 26);
            this.txtDNIEmpleado.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(482, 112);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(597, 112);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(129, 26);
            this.txtApellidoEmpleado.TabIndex = 4;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(22, 160);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(69, 20);
            this.lblNombreEmpleado.TabIndex = 6;
            this.lblNombreEmpleado.Text = "Nombre:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(161, 157);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(129, 26);
            this.txtNombreEmpleado.TabIndex = 3;
            // 
            // txtLegajo
            // 
            this.txtLegajo.AccessibleDescription = "";
            this.txtLegajo.AccessibleName = "";
            this.txtLegajo.Location = new System.Drawing.Point(161, 59);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(129, 26);
            this.txtLegajo.TabIndex = 1;
            this.txtLegajo.Tag = "";
            // 
            // lblLegajoEmpleado
            // 
            this.lblLegajoEmpleado.AutoSize = true;
            this.lblLegajoEmpleado.Location = new System.Drawing.Point(22, 59);
            this.lblLegajoEmpleado.Name = "lblLegajoEmpleado";
            this.lblLegajoEmpleado.Size = new System.Drawing.Size(137, 20);
            this.lblLegajoEmpleado.TabIndex = 4;
            this.lblLegajoEmpleado.Text = "Legajo Empleado:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 242);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 35);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(129, 242);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 35);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnConectarBD
            // 
            this.btnConectarBD.Location = new System.Drawing.Point(526, 234);
            this.btnConectarBD.Name = "btnConectarBD";
            this.btnConectarBD.Size = new System.Drawing.Size(138, 50);
            this.btnConectarBD.TabIndex = 10;
            this.btnConectarBD.Text = "Conectar a BD";
            this.btnConectarBD.UseVisualStyleBackColor = true;
            this.btnConectarBD.Click += new System.EventHandler(this.btnConectarBD_Click);
            // 
            // btnDesconectarBD
            // 
            this.btnDesconectarBD.Location = new System.Drawing.Point(670, 234);
            this.btnDesconectarBD.Name = "btnDesconectarBD";
            this.btnDesconectarBD.Size = new System.Drawing.Size(158, 50);
            this.btnDesconectarBD.TabIndex = 11;
            this.btnDesconectarBD.Text = "Desconectar a BD";
            this.btnDesconectarBD.UseVisualStyleBackColor = true;
            this.btnDesconectarBD.Click += new System.EventHandler(this.btnDesconectarBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 529);
            this.Controls.Add(this.btnDesconectarBD);
            this.Controls.Add(this.btnConectarBD);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CRUD Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorTrabajo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDNIEmpleado;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblLegajoEmpleado;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnConectarBD;
        private System.Windows.Forms.Button btnDesconectarBD;
    }
}

