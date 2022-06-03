namespace Proyecto_TAP
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
            this.label_consultorio = new System.Windows.Forms.Label();
            this.label_edad = new System.Windows.Forms.Label();
            this.label_paciente = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_hora = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.text_fecha = new System.Windows.Forms.TextBox();
            this.text_edad = new System.Windows.Forms.TextBox();
            this.text_telefono = new System.Windows.Forms.TextBox();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_hora = new System.Windows.Forms.TextBox();
            this.button_agregar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.dataGridViewtabla = new System.Windows.Forms.DataGridView();
            this.clmTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_turno = new System.Windows.Forms.Label();
            this.text_turno = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_limpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_consultorio
            // 
            this.label_consultorio.AutoSize = true;
            this.label_consultorio.Location = new System.Drawing.Point(303, 9);
            this.label_consultorio.Name = "label_consultorio";
            this.label_consultorio.Size = new System.Drawing.Size(59, 13);
            this.label_consultorio.TabIndex = 0;
            this.label_consultorio.Text = "Consultorio";
            // 
            // label_edad
            // 
            this.label_edad.AutoSize = true;
            this.label_edad.Location = new System.Drawing.Point(62, 196);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(35, 13);
            this.label_edad.TabIndex = 1;
            this.label_edad.Text = "Edad:";
            // 
            // label_paciente
            // 
            this.label_paciente.AutoSize = true;
            this.label_paciente.Location = new System.Drawing.Point(62, 164);
            this.label_paciente.Name = "label_paciente";
            this.label_paciente.Size = new System.Drawing.Size(109, 13);
            this.label_paciente.TabIndex = 2;
            this.label_paciente.Text = "Nombre del Paciente:";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(62, 95);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(40, 13);
            this.label_fecha.TabIndex = 3;
            this.label_fecha.Text = "Fecha:";
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Location = new System.Drawing.Point(64, 130);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(33, 13);
            this.label_hora.TabIndex = 4;
            this.label_hora.Text = "Hora:";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(62, 240);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(52, 13);
            this.label_telefono.TabIndex = 5;
            this.label_telefono.Text = "Telefono:";
            // 
            // text_fecha
            // 
            this.text_fecha.Location = new System.Drawing.Point(202, 95);
            this.text_fecha.Name = "text_fecha";
            this.text_fecha.Size = new System.Drawing.Size(279, 20);
            this.text_fecha.TabIndex = 6;
            // 
            // text_edad
            // 
            this.text_edad.Location = new System.Drawing.Point(202, 196);
            this.text_edad.Name = "text_edad";
            this.text_edad.Size = new System.Drawing.Size(279, 20);
            this.text_edad.TabIndex = 7;
            // 
            // text_telefono
            // 
            this.text_telefono.Location = new System.Drawing.Point(202, 237);
            this.text_telefono.Name = "text_telefono";
            this.text_telefono.Size = new System.Drawing.Size(279, 20);
            this.text_telefono.TabIndex = 8;
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(202, 164);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(279, 20);
            this.text_nombre.TabIndex = 9;
            // 
            // text_hora
            // 
            this.text_hora.Location = new System.Drawing.Point(202, 130);
            this.text_hora.Name = "text_hora";
            this.text_hora.Size = new System.Drawing.Size(279, 20);
            this.text_hora.TabIndex = 10;
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(660, 143);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 23);
            this.button_agregar.TabIndex = 11;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(660, 172);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(75, 23);
            this.button_actualizar.TabIndex = 13;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(660, 201);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_eliminar.TabIndex = 14;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // dataGridViewtabla
            // 
            this.dataGridViewtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTurno,
            this.clmNombre,
            this.clmEdad,
            this.clmTelefono,
            this.clmHora,
            this.clmFecha});
            this.dataGridViewtabla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewtabla.Location = new System.Drawing.Point(12, 302);
            this.dataGridViewtabla.MultiSelect = false;
            this.dataGridViewtabla.Name = "dataGridViewtabla";
            this.dataGridViewtabla.RowHeadersVisible = false;
            this.dataGridViewtabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewtabla.Size = new System.Drawing.Size(776, 145);
            this.dataGridViewtabla.TabIndex = 15;
            this.dataGridViewtabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewtabla_CellClick);
            // 
            // clmTurno
            // 
            this.clmTurno.HeaderText = "Turno";
            this.clmTurno.Name = "clmTurno";
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.Width = 225;
            // 
            // clmEdad
            // 
            this.clmEdad.HeaderText = "Edad";
            this.clmEdad.Name = "clmEdad";
            // 
            // clmTelefono
            // 
            this.clmTelefono.HeaderText = "Telefono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.Width = 120;
            // 
            // clmHora
            // 
            this.clmHora.HeaderText = "Hora";
            this.clmHora.Name = "clmHora";
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.Width = 125;
            // 
            // label_turno
            // 
            this.label_turno.AutoSize = true;
            this.label_turno.Location = new System.Drawing.Point(64, 67);
            this.label_turno.Name = "label_turno";
            this.label_turno.Size = new System.Drawing.Size(35, 13);
            this.label_turno.TabIndex = 16;
            this.label_turno.Text = "Turno";
            this.label_turno.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // text_turno
            // 
            this.text_turno.Location = new System.Drawing.Point(202, 64);
            this.text_turno.Name = "text_turno";
            this.text_turno.Size = new System.Drawing.Size(279, 20);
            this.text_turno.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_TAP.Properties.Resources.logomedico;
            this.pictureBox1.Location = new System.Drawing.Point(660, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(660, 230);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 19;
            this.button_limpar.Text = "Limpiar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(149)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_turno);
            this.Controls.Add(this.label_turno);
            this.Controls.Add(this.dataGridViewtabla);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.text_hora);
            this.Controls.Add(this.text_nombre);
            this.Controls.Add(this.text_telefono);
            this.Controls.Add(this.text_edad);
            this.Controls.Add(this.text_fecha);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_paciente);
            this.Controls.Add(this.label_edad);
            this.Controls.Add(this.label_consultorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_consultorio;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.Label label_paciente;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.TextBox text_fecha;
        private System.Windows.Forms.TextBox text_edad;
        private System.Windows.Forms.TextBox text_telefono;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.TextBox text_hora;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView dataGridViewtabla;
        private System.Windows.Forms.Label label_turno;
        private System.Windows.Forms.TextBox text_turno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.Button button_limpar;
    }
}

