/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 27 jun. 2021
 * Hora: 03:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace CatalogadorArchivos
{
	/// <summary>
	/// Description of CatalogadorArchivos.
	/// </summary>
	public class CatalogadorArchivos
	{
		static OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Grupo6.accdb");
		
		public CatalogadorArchivos()
		{
		}
		
		public static void eliminar(int indiceEscaneo)
		{
			//OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Grupo6.accdb");
			String sqlQuery = "DELETE FROM ESCANEOS WHERE ID_ESCANEO = " + Convert.ToString(indiceEscaneo) + ";";
			OleDbCommand cmd = new OleDbCommand(sqlQuery, conexion);
			conexion.Open();
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		
		public static DirectoryInfo registraEscaneo(String rutaCarpeta)
		{
			int files = Directory.GetFiles(rutaCarpeta, "*.*", SearchOption.AllDirectories).Length;
			String[] rutas = Directory.GetFiles(rutaCarpeta, "*", SearchOption.AllDirectories);
			String[] directorios = Directory.GetDirectories(rutaCarpeta, "*", SearchOption.AllDirectories);
			int dirs = Directory.GetDirectories(rutaCarpeta, "*", SearchOption.AllDirectories).Length;
				
			DirectoryInfo informacionDirectorio = new DirectoryInfo(rutaCarpeta);
			DriveInfo informacionDispositivo = new DriveInfo(rutaCarpeta);
			var ofrmEscaneoCarpeta = new frmEscaneandoCarpeta();
									
			ofrmEscaneoCarpeta.txtUbicacion.Text = informacionDirectorio.Name;
			ofrmEscaneoCarpeta.lblTamanoValor.Text = FormatSizeExtended(GetDirectorySize(rutaCarpeta));
			ofrmEscaneoCarpeta.lblEtiquetaUnidad.Text = informacionDispositivo.VolumeLabel;
			ofrmEscaneoCarpeta.lblSistemaArchivosValor.Text = informacionDispositivo.DriveFormat;
			ofrmEscaneoCarpeta.lblTipoValor.Text = informacionDispositivo.DriveType.ToString();
			ofrmEscaneoCarpeta.lblNumeroSerieUnidad.Text = GetHDDSerial().ToUpper();
			ofrmEscaneoCarpeta.lblCapacidadDispositivoValor.Text = FormatSizeExtended(informacionDispositivo.TotalSize);
			ofrmEscaneoCarpeta.lblEspacioLibreDispositivoValor.Text = FormatSizeExtended(informacionDispositivo.AvailableFreeSpace);
			ofrmEscaneoCarpeta.lblContenidoDispositivoValor.Text = String.Concat(files, " Archivos, ", dirs, " Carpetas");
			ofrmEscaneoCarpeta.progressBar1.Value = 100;
			ofrmEscaneoCarpeta.ShowDialog();
			
				
			string sqlQuery = "INSERT INTO ESCANEOS ([NOMBRE]," +
			                  "[ARCHIVOS]," +
			                  "CARPETAS," +
			                  "TAMANO," +
			                  "CAPACIDAD," +
			                  "ESPACIOLIBRE," +
			                  "SISTEMAARCHIVOS," +
			                  "NUMEROSERIE, TIPO, ETIQUETA, ID_CATEGORIA, ID_LOCACION, PRESTAMO, FECHA_ESCANEO, LETRA_DISPOSITIVO, COMENTARIO, NOMBRE_PC) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
			
			OleDbCommand cmd = new OleDbCommand(sqlQuery, conexion);
			conexion.Open();
			cmd.Parameters.AddWithValue("@NOMBRE", informacionDirectorio.Name);
			cmd.Parameters.AddWithValue("@ARCHIVOS", files);
			cmd.Parameters.AddWithValue("@CARPETAS", dirs);
			cmd.Parameters.AddWithValue("@TAMANO", GetDirectorySize(rutaCarpeta));
			cmd.Parameters.AddWithValue("@CAPACIDAD", informacionDispositivo.TotalSize);
			cmd.Parameters.AddWithValue("@ESPACIOLIBRE", informacionDispositivo.AvailableFreeSpace);
			cmd.Parameters.AddWithValue("@SISTEMAARCHIVOS", informacionDispositivo.DriveFormat);
			cmd.Parameters.AddWithValue("@NUMEROSERIE", GetHDDSerial().ToUpper());
			cmd.Parameters.AddWithValue("@TIPO", informacionDispositivo.DriveType.ToString());
			cmd.Parameters.AddWithValue("@ETIQUETA", rutaCarpeta);
			cmd.Parameters.AddWithValue("@ID_CATEGORIA", 0);
			cmd.Parameters.AddWithValue("@ID_LOCACION", 0);
			cmd.Parameters.AddWithValue("@PRESTAMO", "");
			cmd.Parameters.AddWithValue("@FECHA_ESCANEO", OleDbType.Date).Value = DateTime.Now.ToString();
			cmd.Parameters.AddWithValue("@LETRA_DISPOSITIVO", informacionDirectorio.Root.Name);
			cmd.Parameters.AddWithValue("@COMENTARIO", ofrmEscaneoCarpeta.txtComentario.Text);
			cmd.Parameters.AddWithValue("@NOMBRE_PC", Environment.MachineName);
					
			cmd.ExecuteNonQuery();
			conexion.Close();
				
			sqlQuery = "SELECT MAX(ID_ESCANEO) FROM ESCANEOS;";
				
			cmd = new OleDbCommand(sqlQuery, conexion);
			conexion.Open();
			int idEscaneo = (int)cmd.ExecuteScalar();
			conexion.Close();
				
			sqlQuery = "INSERT INTO ESTRUCTURA_ESCANEOS ([ID_ESCANEO]," +
														"[RUTA]," +
														"[NOMBRE]," +
														"[TAMANO]," +
														"[TIPO]," +
														"[SOLO_LECTURA]," +
														"[OCULTO]," +
														"[SISTEMA]," +
														"FECHA_MODIFICACION," +
														"FECHA_CREACION," +
														"FECHA_ACCESO," +
														"ENCRIPTADO," +
														"COMPRIMIDO," +
														"ARCHIVADO) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?)";

			cmd = new OleDbCommand(sqlQuery, conexion);
			conexion.Open();
			foreach (var ruta in rutas) {
				DirectoryInfo infoRuta = new DirectoryInfo(ruta);
				FileInfo infoArchivo = new FileInfo(ruta);
				FileAttributes atributosArchivo = new FileAttributes();
				atributosArchivo = infoArchivo.Attributes;
				
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@ID_ESCANEO", idEscaneo);
				cmd.Parameters.AddWithValue("@RUTA", ruta);
				cmd.Parameters.AddWithValue("@NOMBRE", infoArchivo.Name);
				cmd.Parameters.AddWithValue("@TAMANO", infoArchivo.Length);
				cmd.Parameters.AddWithValue("@TIPO", infoArchivo.Extension);
				cmd.Parameters.AddWithValue("@SOLO_LECTURA", OleDbType.Boolean).Value = ((File.GetAttributes(ruta) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly);
				cmd.Parameters.AddWithValue("@OCULTO", OleDbType.Boolean).Value = ((File.GetAttributes(ruta) & FileAttributes.Hidden) == FileAttributes.Hidden);
				cmd.Parameters.AddWithValue("@SISTEMA", OleDbType.Boolean).Value = ((File.GetAttributes(ruta) & FileAttributes.System) == FileAttributes.System);
				cmd.Parameters.AddWithValue("@FECHA_MODIFICACION", OleDbType.Date).Value = infoArchivo.LastWriteTime.ToString();
				cmd.Parameters.AddWithValue("@FECHA_CREACION", OleDbType.Date).Value = infoArchivo.CreationTime.ToString();
				cmd.Parameters.AddWithValue("@FECHA_ACCESO", OleDbType.Date).Value = infoArchivo.LastAccessTime.ToString();
				cmd.Parameters.AddWithValue("@ENCRIPTADO", OleDbType.Boolean).Value = ((File.GetAttributes(ruta) & FileAttributes.Encrypted) == FileAttributes.Encrypted);
				cmd.Parameters.AddWithValue("@COMPRIMIDO", OleDbType.Boolean).Value = ((File.GetAttributes(ruta) & FileAttributes.Compressed) == FileAttributes.Compressed);
				cmd.Parameters.AddWithValue("@ARCHIVADO", OleDbType.Boolean).Value = ((File.GetAttributes(ruta) & FileAttributes.Archive) == FileAttributes.Archive);

				cmd.ExecuteNonQuery();
			
			
				
			}
				conexion.Close();		
			return informacionDirectorio;
			
		}
		
		static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
		private static long GetDirectorySize(string p)
		{
			// 1.
			// Get array of all file names.
			string[] a = Directory.GetFiles(p, "*.*");
	
			// 2.
			// Calculate total bytes of all files in a loop.
			long b = 0;
			foreach (string name in a) {
				// 3.
				// Use FileInfo to get length of each file.
				FileInfo info = new FileInfo(name);
				b += info.Length;
			}
			// 4.
			// Return total size
			return b;
		}
		
		private static long GetFileSize(string p)
		{
			// 1.
			// Get array of all file names.
			String[] a = Directory.GetFiles(p, "*.*");
	
			// 2.
			// Calculate total bytes of all files in a loop.
			long b = 0;
			foreach (string name in a) {
				// 3.
				// Use FileInfo to get length of each file.
				FileInfo info = new FileInfo(name);
				b += info.Length;
			}
			// 4.
			// Return total size
			return b;
		}
			
		public static string GetHDDSerial()
		{
			ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

			foreach (ManagementObject wmi_HD in searcher.Get()) {
				// get the hardware serial no.
				if (wmi_HD["SerialNumber"] != null)
					Debug.WriteLine(wmi_HD["SerialNumber"].ToString());
				return wmi_HD["SerialNumber"].ToString();
			}

			return string.Empty;
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
		
		public static String[] retornaEntradasEstructuraEscaneos(int escaneoSeleccionado, String ruta)
		{
			String[] listaEstructuraEscaneos;
			
			OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ESTRUCTURA_ESCANEOS.RUTA as RUTA " +
			                           "FROM ESTRUCTURA_ESCANEOS WHERE ESTRUCTURA_ESCANEOS.ID_ESCANEO = " + escaneoSeleccionado + " AND ESTRUCTURA_ESCANEOS.RUTA LIKE '%" + ruta + "%';", conexion);

			DataSet d = new DataSet();

			adapter.Fill(d);
			
			listaEstructuraEscaneos = new string[d.Tables[0].Rows.Count];
			int indice = 0;
			foreach (DataRow row in d.Tables[0].Rows) {
				listaEstructuraEscaneos[indice] = row["RUTA"].ToString();
				indice++;
			}
			
			return listaEstructuraEscaneos;
		}
		
		public static DataRow obtieneAtributosArchivo(String idEstructuraEscaneos){
			DataRow archivo = null;
			String sqlQuery = "SELECT * FROM ESTRUCTURA_ESCANEOS WHERE ID_ESTRUCTURA_ESCANEO = @ID;";
			OleDbCommand cmd = new OleDbCommand(sqlQuery, conexion);
			cmd.Parameters.AddWithValue("@ID", idEstructuraEscaneos);
			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

			DataSet d = new DataSet();

			adapter.Fill(d);
			
			foreach (DataRow row in d.Tables[0].Rows) {
				archivo = row;
			}
			
			return archivo;
		}
		
		public static DataRow obtieneAtributosEscaneo(int idEscaneo){
			DataRow escaneo = null;
			String sqlQuery = "SELECT * FROM ESCANEOS WHERE ID_ESCANEO = @ID;";
			OleDbCommand cmd = new OleDbCommand(sqlQuery, conexion);
			cmd.Parameters.AddWithValue("@ID", idEscaneo);
			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

			DataSet d = new DataSet();

			adapter.Fill(d);
			
			foreach (DataRow row in d.Tables[0].Rows) {
				escaneo = row;
			}
			
			return escaneo;
		}
		
		public static void actualizaAtributosArchivo(int idEstructuraEscaneos, String nombre, String comentario){
			
//			String sqlQuery = "UPDATE ESTRUCTURA_ESCANEOS SET NOMBRE = @NOMBRE, COMENTARIO = @COMENTARIO, ID_CATEGORIA = @ID_CATEGORIA, ID_LOCACION = @ID_LOCACION WHERE ID_ESTRUCTURA_ESCANEO = @ID_ESTRUCTURA_ESCANEO;";
			String sqlQuery = "UPDATE ESTRUCTURA_ESCANEOS SET NOMBRE = @NOMBRE, COMENTARIO = @COMENTARIO WHERE ID_ESTRUCTURA_ESCANEO = @ID_ESTRUCTURA_ESCANEO;";
			
			OleDbCommand cmd = new OleDbCommand(sqlQuery, conexion);
			cmd.Parameters.AddWithValue("@NOMBRE", nombre);
			cmd.Parameters.AddWithValue("@COMENTARIO", comentario);
			cmd.Parameters.AddWithValue("@ID_ESTRUCTURA_ESCANEO", idEstructuraEscaneos);
//			cmd.Parameters.Add("@ID_CATEGORIA", idCategoria);
//			cmd.Parameters.Add("@ID_LOCACION", idLocacion);
			
			conexion.Open();
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		
		public static void actualizaAtributosEscaneo(int idEscaneo, String nombre, String comentario, int idCategoria, int idLocacion){
			
//			String sqlQuery = "UPDATE ESTRUCTURA_ESCANEOS SET NOMBRE = @NOMBRE, COMENTARIO = @COMENTARIO, ID_CATEGORIA = @ID_CATEGORIA, ID_LOCACION = @ID_LOCACION WHERE ID_ESTRUCTURA_ESCANEO = @ID_ESTRUCTURA_ESCANEO;";
			String sqlQuery = "UPDATE ESCANEOS SET NOMBRE = @NOMBRE, COMENTARIO = @COMENTARIO, ID_CATEGORIA = @ID_CATEGORIA, ID_LOCACION = @ID_LOCACION WHERE ID_ESCANEO = @ID_ESCANEO;";
			
			OleDbCommand cmd = new OleDbCommand(sqlQuery, conexion);
			cmd.Parameters.AddWithValue("@NOMBRE", nombre);
			cmd.Parameters.AddWithValue("@COMENTARIO", comentario);
			
			cmd.Parameters.AddWithValue("@ID_CATEGORIA", idCategoria);
			cmd.Parameters.AddWithValue("@ID_LOCACION", idLocacion);
			cmd.Parameters.AddWithValue("@ID_ESCANEO", idEscaneo);
			
			conexion.Open();
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		
		public static void insertaCategoria(String nombre, String comentario)
		{
			String sqlQuery = "INSERT INTO CATEGORIAS ([DESCRIPCION]," +
														"[COMENTARIO]) values (?,?)";

			OleDbCommand cmd = new OleDbCommand(sqlQuery, conexion);
			conexion.Open();
			
			cmd.Parameters.Clear();
			cmd.Parameters.AddWithValue("@DESCRIPCION", nombre);
			cmd.Parameters.AddWithValue("@COMENTARIO", comentario);

			cmd.ExecuteNonQuery();
			conexion.Close();
		
		}
	}
}