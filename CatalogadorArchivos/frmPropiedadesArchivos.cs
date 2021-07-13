/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 22 jun. 2021
 * Hora: 21:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatalogadorArchivos
{
	/// <summary>
	/// Description of frmPropiedadesArchivos.
	/// </summary>
	public partial class frmPropiedadesArchivos : Form
	{
		public int idEstructuraEscaneos;

		public int IdEstructuraEscaneos {
			get {
				return idEstructuraEscaneos;
			}
			set {
				idEstructuraEscaneos = value;
			}
		}
		public frmPropiedadesArchivos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void btnAceptar_Click(object sender, EventArgs e)
		{
			CatalogadorArchivos.actualizaAtributosArchivo(idEstructuraEscaneos, txtUbicacion.Text, txtComentario.Text);
			this.Close();
		}
		
	}
}
