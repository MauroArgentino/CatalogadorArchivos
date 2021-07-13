/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 13 jul. 2021
 * Hora: 02:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatalogadorArchivos
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class frmAniadirCategoria : Form
	{
		public frmAniadirCategoria()
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
			DialogResult = DialogResult.OK;
		}
	}
}
