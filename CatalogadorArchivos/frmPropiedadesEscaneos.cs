/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 22 jun. 2021
 * Hora: 21:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace CatalogadorArchivos
{
	/// <summary>
	/// Description of frmPropiedadesArchivos.
	/// </summary>
	public partial class frmPropiedadesEscaneos : Form
	{
		public int idEscaneoSeleccionado;

		public int IdEscaneoSeleccionado {
			get {
				return idEscaneoSeleccionado;
			}
			set {
				idEscaneoSeleccionado = value;
			}
		}

		static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
		public frmPropiedadesEscaneos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public static string FormatSizeExtended(Int64 bytes)
		{
			int counter = 0;
			decimal number = (decimal)bytes;

			while (Math.Round(number / 1024) >= 1) {
				number = number / 1024;  
				counter++;  
			}  
			return string.Format("{0:n1} {1} ({2:n1} bytes)", number, suffixes[counter], bytes);  
		
		}
		
		void btnAceptar_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
		
	}
}
