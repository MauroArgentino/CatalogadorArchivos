/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 22 jun. 2021
 * Hora: 21:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CatalogadorArchivos
{
	partial class frmPropiedadesEscaneos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		public System.Windows.Forms.Label lblTipoValor;
		public System.Windows.Forms.ComboBox cbxCategoria;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label lblEtiquetaUnidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label18;
		public System.Windows.Forms.Label lblContenidoDispositivoValor;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.ComboBox cbxLocacion;
		private System.Windows.Forms.Label label19;
		public System.Windows.Forms.Label lblSistemaArchivosValor;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label lblNumeroSerieUnidad;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label lblCapacidadDispositivoValor;
		public System.Windows.Forms.Label lblEspacioLibreDispositivoValor;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.Label lblLetraUnidad;
		public System.Windows.Forms.Label lblNombreEquipo;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.Label lblIDEscaneo;
		private System.Windows.Forms.GroupBox groupBox4;
		public System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Label lblComentario;
		public System.Windows.Forms.Label lblAccedidoValor;
		private System.Windows.Forms.Label lblAccedido;
		public System.Windows.Forms.TextBox txtUbicacion;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label lblTamanoValor;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		void InitializeComponent(){
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropiedadesEscaneos));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.lblComentario = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblCapacidadDispositivoValor = new System.Windows.Forms.Label();
			this.lblTamanoValor = new System.Windows.Forms.Label();
			this.lblEspacioLibreDispositivoValor = new System.Windows.Forms.Label();
			this.lblContenidoDispositivoValor = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblAccedidoValor = new System.Windows.Forms.Label();
			this.lblAccedido = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblLetraUnidad = new System.Windows.Forms.Label();
			this.lblNombreEquipo = new System.Windows.Forms.Label();
			this.lblSistemaArchivosValor = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblEtiquetaUnidad = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblNumeroSerieUnidad = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblIDEscaneo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTipoValor = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtUbicacion = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cbxLocacion = new System.Windows.Forms.ComboBox();
			this.cbxCategoria = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtComentario);
			this.groupBox1.Controls.Add(this.lblComentario);
			this.groupBox1.Location = new System.Drawing.Point(16, 464);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(440, 112);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtComentario
			// 
			this.txtComentario.AccessibleName = "txtComentario";
			this.txtComentario.Location = new System.Drawing.Point(88, 16);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(344, 88);
			this.txtComentario.TabIndex = 8;
			// 
			// lblComentario
			// 
			this.lblComentario.Location = new System.Drawing.Point(8, 16);
			this.lblComentario.Name = "lblComentario";
			this.lblComentario.Size = new System.Drawing.Size(76, 23);
			this.lblComentario.TabIndex = 9;
			this.lblComentario.Text = "Comentario:";
			this.lblComentario.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblCapacidadDispositivoValor);
			this.groupBox2.Controls.Add(this.lblTamanoValor);
			this.groupBox2.Controls.Add(this.lblEspacioLibreDispositivoValor);
			this.groupBox2.Controls.Add(this.lblContenidoDispositivoValor);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.lblAccedidoValor);
			this.groupBox2.Controls.Add(this.lblAccedido);
			this.groupBox2.Location = new System.Drawing.Point(16, 208);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(440, 176);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			// 
			// lblCapacidadDispositivoValor
			// 
			this.lblCapacidadDispositivoValor.Location = new System.Drawing.Point(120, 48);
			this.lblCapacidadDispositivoValor.Name = "lblCapacidadDispositivoValor";
			this.lblCapacidadDispositivoValor.Size = new System.Drawing.Size(312, 23);
			this.lblCapacidadDispositivoValor.TabIndex = 6;
			this.lblCapacidadDispositivoValor.Text = "label1";
			// 
			// lblTamanoValor
			// 
			this.lblTamanoValor.AccessibleName = "lblTamanoValor";
			this.lblTamanoValor.Location = new System.Drawing.Point(120, 16);
			this.lblTamanoValor.Name = "lblTamanoValor";
			this.lblTamanoValor.Size = new System.Drawing.Size(312, 23);
			this.lblTamanoValor.TabIndex = 7;
			this.lblTamanoValor.Text = "label1";
			// 
			// lblEspacioLibreDispositivoValor
			// 
			this.lblEspacioLibreDispositivoValor.Location = new System.Drawing.Point(120, 80);
			this.lblEspacioLibreDispositivoValor.Name = "lblEspacioLibreDispositivoValor";
			this.lblEspacioLibreDispositivoValor.Size = new System.Drawing.Size(312, 23);
			this.lblEspacioLibreDispositivoValor.TabIndex = 8;
			this.lblEspacioLibreDispositivoValor.Text = "label1";
			// 
			// lblContenidoDispositivoValor
			// 
			this.lblContenidoDispositivoValor.Location = new System.Drawing.Point(120, 112);
			this.lblContenidoDispositivoValor.Name = "lblContenidoDispositivoValor";
			this.lblContenidoDispositivoValor.Size = new System.Drawing.Size(312, 23);
			this.lblContenidoDispositivoValor.TabIndex = 9;
			this.lblContenidoDispositivoValor.Text = "label1";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 48);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 10;
			this.label12.Text = "Capacidad:";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 11;
			this.label11.Text = "Tamaño:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "Espacio libre:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "Contenidos:";
			// 
			// lblAccedidoValor
			// 
			this.lblAccedidoValor.Location = new System.Drawing.Point(120, 144);
			this.lblAccedidoValor.Name = "lblAccedidoValor";
			this.lblAccedidoValor.Size = new System.Drawing.Size(312, 23);
			this.lblAccedidoValor.TabIndex = 5;
			this.lblAccedidoValor.Text = "label8";
			// 
			// lblAccedido
			// 
			this.lblAccedido.Location = new System.Drawing.Point(8, 144);
			this.lblAccedido.Name = "lblAccedido";
			this.lblAccedido.Size = new System.Drawing.Size(112, 23);
			this.lblAccedido.TabIndex = 2;
			this.lblAccedido.Text = "Fecha de escaneo:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblLetraUnidad);
			this.groupBox3.Controls.Add(this.lblNombreEquipo);
			this.groupBox3.Controls.Add(this.lblSistemaArchivosValor);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.lblEtiquetaUnidad);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.lblNumeroSerieUnidad);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.lblIDEscaneo);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.lblTipoValor);
			this.groupBox3.Location = new System.Drawing.Point(16, 56);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(440, 152);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			// 
			// lblLetraUnidad
			// 
			this.lblLetraUnidad.Location = new System.Drawing.Point(336, 120);
			this.lblLetraUnidad.Name = "lblLetraUnidad";
			this.lblLetraUnidad.Size = new System.Drawing.Size(88, 23);
			this.lblLetraUnidad.TabIndex = 6;
			this.lblLetraUnidad.Text = "label1";
			// 
			// lblNombreEquipo
			// 
			this.lblNombreEquipo.Location = new System.Drawing.Point(336, 56);
			this.lblNombreEquipo.Name = "lblNombreEquipo";
			this.lblNombreEquipo.Size = new System.Drawing.Size(96, 23);
			this.lblNombreEquipo.TabIndex = 1;
			this.lblNombreEquipo.Text = "label1";
			// 
			// lblSistemaArchivosValor
			// 
			this.lblSistemaArchivosValor.Location = new System.Drawing.Point(136, 56);
			this.lblSistemaArchivosValor.Name = "lblSistemaArchivosValor";
			this.lblSistemaArchivosValor.Size = new System.Drawing.Size(100, 23);
			this.lblSistemaArchivosValor.TabIndex = 1;
			this.lblSistemaArchivosValor.Text = "label1";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(240, 56);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(88, 23);
			this.label13.TabIndex = 2;
			this.label13.Text = "Computadora:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Sistema de archivos:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Etiqueta:";
			// 
			// lblEtiquetaUnidad
			// 
			this.lblEtiquetaUnidad.Location = new System.Drawing.Point(136, 24);
			this.lblEtiquetaUnidad.Name = "lblEtiquetaUnidad";
			this.lblEtiquetaUnidad.Size = new System.Drawing.Size(296, 23);
			this.lblEtiquetaUnidad.TabIndex = 4;
			this.lblEtiquetaUnidad.Text = "label1";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(240, 120);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 23);
			this.label8.TabIndex = 5;
			this.label8.Text = "Letra de Unidad:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Numero de serie:";
			// 
			// lblNumeroSerieUnidad
			// 
			this.lblNumeroSerieUnidad.Location = new System.Drawing.Point(136, 120);
			this.lblNumeroSerieUnidad.Name = "lblNumeroSerieUnidad";
			this.lblNumeroSerieUnidad.Size = new System.Drawing.Size(88, 23);
			this.lblNumeroSerieUnidad.TabIndex = 6;
			this.lblNumeroSerieUnidad.Text = "label1";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(240, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "ID de Disco:";
			// 
			// lblIDEscaneo
			// 
			this.lblIDEscaneo.Location = new System.Drawing.Point(336, 88);
			this.lblIDEscaneo.Name = "lblIDEscaneo";
			this.lblIDEscaneo.Size = new System.Drawing.Size(88, 23);
			this.lblIDEscaneo.TabIndex = 8;
			this.lblIDEscaneo.Text = "label1";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Tipo:";
			// 
			// lblTipoValor
			// 
			this.lblTipoValor.Location = new System.Drawing.Point(136, 88);
			this.lblTipoValor.Name = "lblTipoValor";
			this.lblTipoValor.Size = new System.Drawing.Size(88, 23);
			this.lblTipoValor.TabIndex = 8;
			this.lblTipoValor.Text = "label1";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(296, 584);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 1;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Location = new System.Drawing.Point(384, 584);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// txtUbicacion
			// 
			this.txtUbicacion.AccessibleName = "txtUbicacion";
			this.txtUbicacion.Location = new System.Drawing.Point(72, 24);
			this.txtUbicacion.Name = "txtUbicacion";
			this.txtUbicacion.Size = new System.Drawing.Size(384, 20);
			this.txtUbicacion.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// cbxLocacion
			// 
			this.cbxLocacion.FormattingEnabled = true;
			this.cbxLocacion.Items.AddRange(new object[] {
			"Desconocida"});
			this.cbxLocacion.Location = new System.Drawing.Point(88, 48);
			this.cbxLocacion.Name = "cbxLocacion";
			this.cbxLocacion.Size = new System.Drawing.Size(344, 21);
			this.cbxLocacion.TabIndex = 11;
			// 
			// cbxCategoria
			// 
			this.cbxCategoria.FormattingEnabled = true;
			this.cbxCategoria.Items.AddRange(new object[] {
			"Descategorizado"});
			this.cbxCategoria.Location = new System.Drawing.Point(88, 16);
			this.cbxCategoria.Name = "cbxCategoria";
			this.cbxCategoria.Size = new System.Drawing.Size(344, 21);
			this.cbxCategoria.TabIndex = 10;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(16, 48);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 23);
			this.label19.TabIndex = 12;
			this.label19.Text = "Locación:";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(16, 16);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(64, 23);
			this.label18.TabIndex = 13;
			this.label18.Text = "Categoría:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cbxLocacion);
			this.groupBox4.Controls.Add(this.cbxCategoria);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Location = new System.Drawing.Point(16, 384);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(440, 80);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			// 
			// frmPropiedadesEscaneos
			// 
			this.AcceptButton = this.btnAceptar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(475, 615);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtUbicacion);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPropiedadesEscaneos";
			this.Text = "Propiedades";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}
	}

