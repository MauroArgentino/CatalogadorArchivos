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
	partial class frmPropiedadesArchivos
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
		public System.Windows.Forms.CheckBox chkSoloLectura;
		public System.Windows.Forms.CheckBox chkComprimido;
		public System.Windows.Forms.CheckBox chkSistema;
		public System.Windows.Forms.CheckBox chkArchivado;
		public System.Windows.Forms.CheckBox chkOculto;
		public System.Windows.Forms.CheckBox chkEncriptado;
		public System.Windows.Forms.TextBox txtComentario;
		private System.Windows.Forms.Label lblAtributos;
		private System.Windows.Forms.Label lblComentario;
		public System.Windows.Forms.Label lblNombreValor;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblTipo;
		public System.Windows.Forms.TextBox txtUbicacion;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label lblAccedidoValor;
		public System.Windows.Forms.Label lblModificadoValor;
		public System.Windows.Forms.Label lblCreadoValor;
		private System.Windows.Forms.Label lblAccedido;
		private System.Windows.Forms.Label lblModificado;
		private System.Windows.Forms.Label lblCreado;
		private System.Windows.Forms.Label lblRuta;
		public System.Windows.Forms.Label lblTamanoValor;
		public System.Windows.Forms.Label lblRutaValor;
		public System.Windows.Forms.Label lblTipoValor;
		private System.Windows.Forms.Label lblTamano;
		public System.Windows.Forms.ImageList LargeImageList;
		
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
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropiedadesArchivos));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkSoloLectura = new System.Windows.Forms.CheckBox();
			this.chkComprimido = new System.Windows.Forms.CheckBox();
			this.chkSistema = new System.Windows.Forms.CheckBox();
			this.chkArchivado = new System.Windows.Forms.CheckBox();
			this.chkOculto = new System.Windows.Forms.CheckBox();
			this.chkEncriptado = new System.Windows.Forms.CheckBox();
			this.txtComentario = new System.Windows.Forms.TextBox();
			this.lblAtributos = new System.Windows.Forms.Label();
			this.lblComentario = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblAccedidoValor = new System.Windows.Forms.Label();
			this.lblModificadoValor = new System.Windows.Forms.Label();
			this.lblCreadoValor = new System.Windows.Forms.Label();
			this.lblAccedido = new System.Windows.Forms.Label();
			this.lblModificado = new System.Windows.Forms.Label();
			this.lblCreado = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblRuta = new System.Windows.Forms.Label();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblTamanoValor = new System.Windows.Forms.Label();
			this.lblRutaValor = new System.Windows.Forms.Label();
			this.lblTipoValor = new System.Windows.Forms.Label();
			this.lblNombreValor = new System.Windows.Forms.Label();
			this.lblTamano = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtUbicacion = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LargeImageList = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkSoloLectura);
			this.groupBox1.Controls.Add(this.chkComprimido);
			this.groupBox1.Controls.Add(this.chkSistema);
			this.groupBox1.Controls.Add(this.chkArchivado);
			this.groupBox1.Controls.Add(this.chkOculto);
			this.groupBox1.Controls.Add(this.chkEncriptado);
			this.groupBox1.Controls.Add(this.txtComentario);
			this.groupBox1.Controls.Add(this.lblAtributos);
			this.groupBox1.Controls.Add(this.lblComentario);
			this.groupBox1.Location = new System.Drawing.Point(16, 320);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 168);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// chkSoloLectura
			// 
			this.chkSoloLectura.Enabled = false;
			this.chkSoloLectura.Location = new System.Drawing.Point(256, 40);
			this.chkSoloLectura.Name = "chkSoloLectura";
			this.chkSoloLectura.Size = new System.Drawing.Size(96, 24);
			this.chkSoloLectura.TabIndex = 10;
			this.chkSoloLectura.Text = "Solo lectura";
			this.chkSoloLectura.UseVisualStyleBackColor = true;
			// 
			// chkComprimido
			// 
			this.chkComprimido.Enabled = false;
			this.chkComprimido.Location = new System.Drawing.Point(256, 16);
			this.chkComprimido.Name = "chkComprimido";
			this.chkComprimido.Size = new System.Drawing.Size(96, 24);
			this.chkComprimido.TabIndex = 10;
			this.chkComprimido.Text = "Comprimido";
			this.chkComprimido.UseVisualStyleBackColor = true;
			// 
			// chkSistema
			// 
			this.chkSistema.Enabled = false;
			this.chkSistema.Location = new System.Drawing.Point(176, 40);
			this.chkSistema.Name = "chkSistema";
			this.chkSistema.Size = new System.Drawing.Size(80, 24);
			this.chkSistema.TabIndex = 10;
			this.chkSistema.Text = "Sistema";
			this.chkSistema.UseVisualStyleBackColor = true;
			// 
			// chkArchivado
			// 
			this.chkArchivado.Enabled = false;
			this.chkArchivado.Location = new System.Drawing.Point(88, 40);
			this.chkArchivado.Name = "chkArchivado";
			this.chkArchivado.Size = new System.Drawing.Size(88, 24);
			this.chkArchivado.TabIndex = 10;
			this.chkArchivado.Text = "Archivado";
			this.chkArchivado.UseVisualStyleBackColor = true;
			// 
			// chkOculto
			// 
			this.chkOculto.Enabled = false;
			this.chkOculto.Location = new System.Drawing.Point(176, 16);
			this.chkOculto.Name = "chkOculto";
			this.chkOculto.Size = new System.Drawing.Size(80, 24);
			this.chkOculto.TabIndex = 10;
			this.chkOculto.Text = "Oculto";
			this.chkOculto.UseVisualStyleBackColor = true;
			// 
			// chkEncriptado
			// 
			this.chkEncriptado.Enabled = false;
			this.chkEncriptado.Location = new System.Drawing.Point(88, 16);
			this.chkEncriptado.Name = "chkEncriptado";
			this.chkEncriptado.Size = new System.Drawing.Size(88, 24);
			this.chkEncriptado.TabIndex = 10;
			this.chkEncriptado.Text = "Encriptado";
			this.chkEncriptado.UseVisualStyleBackColor = true;
			// 
			// txtComentario
			// 
			this.txtComentario.AccessibleName = "txtComentario";
			this.txtComentario.Location = new System.Drawing.Point(88, 72);
			this.txtComentario.Multiline = true;
			this.txtComentario.Name = "txtComentario";
			this.txtComentario.Size = new System.Drawing.Size(264, 88);
			this.txtComentario.TabIndex = 8;
			// 
			// lblAtributos
			// 
			this.lblAtributos.Location = new System.Drawing.Point(8, 24);
			this.lblAtributos.Name = "lblAtributos";
			this.lblAtributos.Size = new System.Drawing.Size(76, 23);
			this.lblAtributos.TabIndex = 9;
			this.lblAtributos.Text = "Atributos:";
			this.lblAtributos.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblComentario
			// 
			this.lblComentario.Location = new System.Drawing.Point(8, 72);
			this.lblComentario.Name = "lblComentario";
			this.lblComentario.Size = new System.Drawing.Size(76, 23);
			this.lblComentario.TabIndex = 9;
			this.lblComentario.Text = "Comentario:";
			this.lblComentario.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblAccedidoValor);
			this.groupBox2.Controls.Add(this.lblModificadoValor);
			this.groupBox2.Controls.Add(this.lblCreadoValor);
			this.groupBox2.Controls.Add(this.lblAccedido);
			this.groupBox2.Controls.Add(this.lblModificado);
			this.groupBox2.Controls.Add(this.lblCreado);
			this.groupBox2.Location = new System.Drawing.Point(16, 200);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(360, 120);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			// 
			// lblAccedidoValor
			// 
			this.lblAccedidoValor.Location = new System.Drawing.Point(120, 80);
			this.lblAccedidoValor.Name = "lblAccedidoValor";
			this.lblAccedidoValor.Size = new System.Drawing.Size(224, 23);
			this.lblAccedidoValor.TabIndex = 5;
			this.lblAccedidoValor.Text = "label8";
			// 
			// lblModificadoValor
			// 
			this.lblModificadoValor.Location = new System.Drawing.Point(120, 48);
			this.lblModificadoValor.Name = "lblModificadoValor";
			this.lblModificadoValor.Size = new System.Drawing.Size(224, 23);
			this.lblModificadoValor.TabIndex = 4;
			this.lblModificadoValor.Text = "label7";
			// 
			// lblCreadoValor
			// 
			this.lblCreadoValor.Location = new System.Drawing.Point(120, 16);
			this.lblCreadoValor.Name = "lblCreadoValor";
			this.lblCreadoValor.Size = new System.Drawing.Size(224, 23);
			this.lblCreadoValor.TabIndex = 3;
			this.lblCreadoValor.Text = "label6";
			// 
			// lblAccedido
			// 
			this.lblAccedido.Location = new System.Drawing.Point(16, 80);
			this.lblAccedido.Name = "lblAccedido";
			this.lblAccedido.Size = new System.Drawing.Size(100, 23);
			this.lblAccedido.TabIndex = 2;
			this.lblAccedido.Text = "Accedido:";
			// 
			// lblModificado
			// 
			this.lblModificado.Location = new System.Drawing.Point(16, 48);
			this.lblModificado.Name = "lblModificado";
			this.lblModificado.Size = new System.Drawing.Size(100, 23);
			this.lblModificado.TabIndex = 1;
			this.lblModificado.Text = "Modificado:";
			// 
			// lblCreado
			// 
			this.lblCreado.Location = new System.Drawing.Point(16, 16);
			this.lblCreado.Name = "lblCreado";
			this.lblCreado.Size = new System.Drawing.Size(100, 23);
			this.lblCreado.TabIndex = 0;
			this.lblCreado.Text = "Creado:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblRuta);
			this.groupBox3.Controls.Add(this.lblTipo);
			this.groupBox3.Controls.Add(this.lblTamanoValor);
			this.groupBox3.Controls.Add(this.lblRutaValor);
			this.groupBox3.Controls.Add(this.lblTipoValor);
			this.groupBox3.Controls.Add(this.lblNombreValor);
			this.groupBox3.Controls.Add(this.lblTamano);
			this.groupBox3.Controls.Add(this.lblNombre);
			this.groupBox3.Location = new System.Drawing.Point(16, 56);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(360, 144);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			// 
			// lblRuta
			// 
			this.lblRuta.Location = new System.Drawing.Point(12, 80);
			this.lblRuta.Name = "lblRuta";
			this.lblRuta.Size = new System.Drawing.Size(100, 23);
			this.lblRuta.TabIndex = 1;
			this.lblRuta.Text = "Ruta:";
			// 
			// lblTipo
			// 
			this.lblTipo.Location = new System.Drawing.Point(12, 48);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(100, 23);
			this.lblTipo.TabIndex = 1;
			this.lblTipo.Text = "Tipo:";
			// 
			// lblTamanoValor
			// 
			this.lblTamanoValor.Location = new System.Drawing.Point(120, 112);
			this.lblTamanoValor.Name = "lblTamanoValor";
			this.lblTamanoValor.Size = new System.Drawing.Size(216, 23);
			this.lblTamanoValor.TabIndex = 2;
			this.lblTamanoValor.Text = "label1";
			// 
			// lblRutaValor
			// 
			this.lblRutaValor.AccessibleName = "lblTamanoValor";
			this.lblRutaValor.AutoEllipsis = true;
			this.lblRutaValor.Location = new System.Drawing.Point(120, 80);
			this.lblRutaValor.Name = "lblRutaValor";
			this.lblRutaValor.Size = new System.Drawing.Size(216, 23);
			this.lblRutaValor.TabIndex = 1;
			this.lblRutaValor.Text = "label1";
			// 
			// lblTipoValor
			// 
			this.lblTipoValor.Location = new System.Drawing.Point(120, 48);
			this.lblTipoValor.Name = "lblTipoValor";
			this.lblTipoValor.Size = new System.Drawing.Size(216, 23);
			this.lblTipoValor.TabIndex = 2;
			this.lblTipoValor.Text = "label1";
			// 
			// lblNombreValor
			// 
			this.lblNombreValor.AccessibleName = "lblTamanoValor";
			this.lblNombreValor.Location = new System.Drawing.Point(120, 16);
			this.lblNombreValor.Name = "lblNombreValor";
			this.lblNombreValor.Size = new System.Drawing.Size(216, 23);
			this.lblNombreValor.TabIndex = 1;
			this.lblNombreValor.Text = "label1";
			// 
			// lblTamano
			// 
			this.lblTamano.Location = new System.Drawing.Point(12, 112);
			this.lblTamano.Name = "lblTamano";
			this.lblTamano.Size = new System.Drawing.Size(100, 23);
			this.lblTamano.TabIndex = 2;
			this.lblTamano.Text = "Tamaño:";
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(12, 16);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(100, 23);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Text = "Nombre:";
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(200, 496);
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
			this.btnCancelar.Location = new System.Drawing.Point(288, 496);
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
			this.txtUbicacion.Size = new System.Drawing.Size(304, 20);
			this.txtUbicacion.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(16, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// LargeImageList
			// 
			this.LargeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeImageList.ImageStream")));
			this.LargeImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.LargeImageList.Images.SetKeyName(0, ".exe");
			this.LargeImageList.Images.SetKeyName(1, ".pdf");
			this.LargeImageList.Images.SetKeyName(2, ".txt");
			this.LargeImageList.Images.SetKeyName(3, ".jpg");
			this.LargeImageList.Images.SetKeyName(4, ".jpeg");
			this.LargeImageList.Images.SetKeyName(5, ".jpg");
			// 
			// frmPropiedadesArchivos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(389, 535);
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
			this.Name = "frmPropiedadesArchivos";
			this.Text = "Propiedades";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
