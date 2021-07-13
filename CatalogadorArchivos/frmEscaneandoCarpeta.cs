/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 19 jun. 2021
 * Hora: 16:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CatalogadorArchivos
{
	/// <summary>
	/// Description of frmEscaneandoCarpeta.
	/// </summary>
	public partial class frmEscaneandoCarpeta : Form
	{
		
		public frmEscaneandoCarpeta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void frmEscaneandoCarpeta_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
			comboBox2.SelectedIndex = 0;
		}
		
		
		
	}
}
