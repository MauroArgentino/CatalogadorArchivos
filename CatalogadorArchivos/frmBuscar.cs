/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 23 jun. 2021
 * Hora: 01:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace CatalogadorArchivos
{
	/// <summary>
	/// Description of frmBuscar.
	/// </summary>
	public partial class frmBuscar : Form
	{
		OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Grupo6.accdb");
		string sqlQuery;
		static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
		
		public frmBuscar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void btnBuscar_Click(object sender, EventArgs e)
		{
			//OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Grupo6.accdb");
			RefrescaEscaneos();
		}
		
		private void RefrescaEscaneos(){
			lvEncontrados.Items.Clear();
			OleDbDataReader reader;
			sqlQuery = "SELECT ESCANEOS.ID_ESCANEO," +
				"ESCANEOS.NOMBRE as Nombre," +
				"ESTRUCTURA_ESCANEOS.NOMBRE," +
				"ESTRUCTURA_ESCANEOS.TIPO," +
				"ESTRUCTURA_ESCANEOS.TAMANO," +
				"ESTRUCTURA_ESCANEOS.FECHA_MODIFICACION," +
				"ESTRUCTURA_ESCANEOS.RUTA," +
				"(SELECT TOP 1 CATEGORIAS.DESCRIPCION FROM CATEGORIAS, ESCANEOS WHERE ESCANEOS.ID_CATEGORIA = CATEGORIAS.ID_CATEGORIA) AS CATEGORIA," +
				"(SELECT TOP 1 LOCACIONES.DESCRIPCION FROM LOCACIONES, ESCANEOS WHERE ESCANEOS.ID_LOCACION = LOCACIONES.ID_LOCACION) AS LOCACION," +
				"ESCANEOS.PRESTAMO," +
				"ESTRUCTURA_ESCANEOS.COMENTARIO as Comentario," +
				"ESCANEOS.COMENTARIO as Comentario_disco " +
				"FROM ESCANEOS " +
				"INNER JOIN " +
				"ESTRUCTURA_ESCANEOS " +
				"ON ESCANEOS.ID_ESCANEO = ESTRUCTURA_ESCANEOS.ID_ESCANEO " +
				"WHERE ESTRUCTURA_ESCANEOS.COMENTARIO LIKE '%" + txtBuscarPor.Text + "%' OR ESCANEOS.COMENTARIO LIKE '%" + txtBuscarPor.Text + "%' OR ESCANEOS.NOMBRE LIKE '%" + txtBuscarPor.Text + "%' OR ESTRUCTURA_ESCANEOS.NOMBRE LIKE '%" + txtBuscarPor.Text + "%';";
			
			if (cbxNombre.Checked){
				
			}
			String porComentarioEscaneo;
			String porComentarioEstructuraEscaneos;
			String enNombres;
			String enDiscos;
			String enCarpetas;
			String enArchivos;
			String incluirSubcarpetas;
			
			OleDbCommand cmd = new OleDbCommand(sqlQuery, conexion);
			cmd.Parameters.AddWithValue("@TEXTO", OleDbType.VarChar).Value = txtBuscarPor.Text;
			
			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
 
			DataSet d = new DataSet();
			adapter.Fill(d);
 
			foreach (DataRow row in d.Tables[0].Rows) {
				String[] fila = new String[17];
				ListViewItem itm;
				fila[0] = row[0].ToString();
				fila[1] = row[1].ToString();
				fila[2] = row[2].ToString();
				fila[3] = row[3].ToString();
				fila[4] = FormatSize(Convert.ToInt64(row[4]));
				fila[5] = row[5].ToString();
				fila[6] = row[6].ToString();
				fila[7] = row[7].ToString();
				fila[8] = row[8].ToString();
				fila[9] = row[9].ToString();
				fila[10] = row[10].ToString();
				fila[11] = row[11].ToString();
			
				itm = new ListViewItem(fila);
				lvEncontrados.Items.Add(itm);
				
			}
			
		}
		
		public static string FormatSize(Int64 bytes)
		{
			int counter = 0;
			decimal number = (decimal)bytes;

			while (Math.Round(number / 1024) >= 1) {
				number = number / 1024;  
				counter++;  
			}  
			return string.Format("{0:n1} {1}", number, suffixes[counter]);  
		
		}
		void txtBuscarPor_KeyPress(object sender, KeyPressEventArgs e)
		{
			
			if (e.KeyChar == (char) Keys.Enter) {
				e.Handled = true;
				btnBuscar_Click(null, null);
			}
		}
		
	}
}
