/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 19 jun. 2021
 * Hora: 16:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CatalogadorArchivos
{
	partial class frmEscaneandoCarpeta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		public System.Windows.Forms.TextBox txtUbicacion;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label lblCapacidadDispositivoValor;
		private System.Windows.Forms.Label label12;
		public System.Windows.Forms.Label lblEspacioLibreDispositivoValor;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.Label lblContenidoDispositivoValor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.Label lblTipoValor;
		public System.Windows.Forms.Label lblNumeroSerieUnidad;
		public System.Windows.Forms.Label lblEtiquetaUnidad;
		public System.Windows.Forms.Label lblSistemaArchivosValor;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		public System.Windows.Forms.Label lblTamanoValor;
		public System.Windows.Forms.TextBox txtComentario;
		public System.Windows.Forms.PictureBox pictureBox1;
		
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
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		void InitializeComponent(){
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblSistemaArchivosValor = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblEtiquetaUnidad = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblNumeroSerieUnidad = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTipoValor = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblCapacidadDispositivoValor = new System.Windows.Forms.Label();
			this.lblTamanoValor = new System.Windows.Forms.Label();
			this.lblEspacioLibreDispositivoValor = new System.Windows.Forms.Label();
			this.lblContenidoDispositivoValor = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.txtUbicacion = new System.Windows.Forms.TextBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(24, 64);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(616, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblSistemaArchivosValor);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lblEtiquetaUnidad);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lblNumeroSerieUnidad);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblTipoValor);
			this.groupBox1.Location = new System.Drawing.Point(24, 104);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 128);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Disco";
			// 
			// lblSistemaArchivosValor
			// 
			this.lblSistemaArchivosValor.Location = new System.Drawing.Point(152, 48);
			this.lblSistemaArchivosValor.Name = "lblSistemaArchivosValor";
			this.lblSistemaArchivosValor.Size = new System.Drawing.Size(100, 23);
			this.lblSistemaArchivosValor.TabIndex = 0;
			this.lblSistemaArchivosValor.Text = "label1";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Sistema de archivos:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Etiqueta:";
			// 
			// lblEtiquetaUnidad
			// 
			this.lblEtiquetaUnidad.Location = new System.Drawing.Point(152, 24);
			this.lblEtiquetaUnidad.Name = "lblEtiquetaUnidad";
			this.lblEtiquetaUnidad.Size = new System.Drawing.Size(100, 23);
			this.lblEtiquetaUnidad.TabIndex = 0;
			this.lblEtiquetaUnidad.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Numero de serie:";
			// 
			// lblNumeroSerieUnidad
			// 
			this.lblNumeroSerieUnidad.Location = new System.Drawing.Point(152, 96);
			this.lblNumeroSerieUnidad.Name = "lblNumeroSerieUnidad";
			this.lblNumeroSerieUnidad.Size = new System.Drawing.Size(100, 23);
			this.lblNumeroSerieUnidad.TabIndex = 0;
			this.lblNumeroSerieUnidad.Text = "label1";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tipo:";
			// 
			// lblTipoValor
			// 
			this.lblTipoValor.Location = new System.Drawing.Point(152, 72);
			this.lblTipoValor.Name = "lblTipoValor";
			this.lblTipoValor.Size = new System.Drawing.Size(100, 23);
			this.lblTipoValor.TabIndex = 0;
			this.lblTipoValor.Text = "label1";
			// 
			// groupBox2
			// 
			this.groupBox2.AccessibleName = "groupBox2";
			this.groupBox2.Controls.Add(this.lblCapacidadDispositivoValor);
			this.groupBox2.Controls.Add(this.lblTamanoValor);
			this.groupBox2.Controls.Add(this.lblEspacioLibreDispositivoValor);
			this.groupBox2.Controls.Add(this.lblContenidoDispositivoValor);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(336, 104);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(304, 128);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Resultados del Escaneo";
			// 
			// lblCapacidadDispositivoValor
			// 
			this.lblCapacidadDispositivoValor.Location = new System.Drawing.Point(104, 48);
			this.lblCapacidadDispositivoValor.Name = "lblCapacidadDispositivoValor";
			this.lblCapacidadDispositivoValor.Size = new System.Drawing.Size(192, 23);
			this.lblCapacidadDispositivoValor.TabIndex = 0;
			this.lblCapacidadDispositivoValor.Text = "label1";
			// 
			// lblTamanoValor
			// 
			this.lblTamanoValor.AccessibleName = "lblTamanoValor";
			this.lblTamanoValor.Location = new System.Drawing.Point(104, 24);
			this.lblTamanoValor.Name = "lblTamanoValor";
			this.lblTamanoValor.Size = new System.Drawing.Size(192, 23);
			this.lblTamanoValor.TabIndex = 0;
			this.lblTamanoValor.Text = "label1";
			// 
			// lblEspacioLibreDispositivoValor
			// 
			this.lblEspacioLibreDispositivoValor.Location = new System.Drawing.Point(104, 72);
			this.lblEspacioLibreDispositivoValor.Name = "lblEspacioLibreDispositivoValor";
			this.lblEspacioLibreDispositivoValor.Size = new System.Drawing.Size(192, 23);
			this.lblEspacioLibreDispositivoValor.TabIndex = 0;
			this.lblEspacioLibreDispositivoValor.Text = "label1";
			// 
			// lblContenidoDispositivoValor
			// 
			this.lblContenidoDispositivoValor.Location = new System.Drawing.Point(104, 96);
			this.lblContenidoDispositivoValor.Name = "lblContenidoDispositivoValor";
			this.lblContenidoDispositivoValor.Size = new System.Drawing.Size(192, 23);
			this.lblContenidoDispositivoValor.TabIndex = 0;
			this.lblContenidoDispositivoValor.Text = "label1";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(16, 48);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 0;
			this.label12.Text = "Capacidad:";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(16, 24);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 0;
			this.label11.Text = "Tamaño:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 0;
			this.label9.Text = "Espacio libre:";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 0;
			this.label10.Text = "Contenidos:";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
			this.statusStrip1.Location = new System.Drawing.Point(0, 349);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(659, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// txtUbicacion
			// 
			this.txtUbicacion.AccessibleName = "txtUbicacion";
			this.txtUbicacion.Location = new System.Drawing.Point(88, 24);
			this.txtUbicacion.Name = "txtUbicacion";
			this.txtUbicacion.Size = new System.Drawing.Size(552, 20);
			this.txtUbicacion.TabIndex = 4;
			// 
			// txtComentario
			// 
			this.txtComentario.AccessibleName = "txtComentario";
			this.txtComentario.Location = new System.Drawing.Point(96, 248);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(232, 88);
			this.txtComentario.TabIndex = 4;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Descategorizado"});
			this.comboBox1.Location = new System.Drawing.Point(416, 248);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(224, 21);
			this.comboBox1.TabIndex = 5;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"Desconocida"});
			this.comboBox2.Location = new System.Drawing.Point(416, 280);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(224, 21);
			this.comboBox2.TabIndex = 6;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(24, 248);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 7;
			this.label17.Text = "Comentario:";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(336, 248);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 23);
			this.label18.TabIndex = 7;
			this.label18.Text = "Categoría:";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(336, 280);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(104, 23);
			this.label19.TabIndex = 7;
			this.label19.Text = "Locación:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(24, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// frmEscaneandoCarpeta
			// 
			this.AccessibleName = "lblTamanoValor";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 371);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.txtComentario);
			this.Controls.Add(this.txtUbicacion);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEscaneandoCarpeta";
			this.Text = "Escaneando carpeta...";
			this.Load += new System.EventHandler(this.frmEscaneandoCarpeta_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		
		}
	}

