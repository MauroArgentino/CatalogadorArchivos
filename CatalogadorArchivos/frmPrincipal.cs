/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 Alumnos: Montenegro, Mauro
		  Rojas, Silvio
 * Fecha: 5 jun. 2021
 * Hora: 22:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Data.OleDb;

namespace CatalogadorArchivos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int escaneoSeleccionado;
		public DirectoryInfo rutaPrincipal;
		public String rutaRaiz;
		public String NombreCarpeta;
		static readonly string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
		{
			
			var oSeleccionarCarpeta = new FolderBrowserDialog();
			
			if (oSeleccionarCarpeta.ShowDialog() == DialogResult.OK) {
				this.rutaPrincipal = CatalogadorArchivos.registraEscaneo(oSeleccionarCarpeta.SelectedPath);
			}
			RefrescaEscaneos();
		}

		
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
	

		public string GetHDDSerial()
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
		
		private void RefrescaEscaneos()
		{
			lvEscaneos.Items.Clear();
			OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Grupo6.accdb");
			OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ID_ESCANEO," +
															"NOMBRE, ARCHIVOS," +
															"CARPETAS, TAMANO, CAPACIDAD, ESPACIOLIBRE, SISTEMAARCHIVOS, NUMEROSERIE, TIPO, ETIQUETA, (SELECT CATEGORIAS.DESCRIPCION FROM ESCANEOS, CATEGORIAS WHERE ESCANEOS.ID_CATEGORIA = CATEGORIAS.ID_CATEGORIA) as CATEGORIA, (SELECT LOCACIONES.DESCRIPCION FROM ESCANEOS, LOCACIONES WHERE ESCANEOS.ID_LOCACION = LOCACIONES.ID_LOCACION) as LOCACION, PRESTAMO, FECHA_ESCANEO, LETRA_DISPOSITIVO, COMENTARIO FROM ESCANEOS", conexion);
 
			DataSet d = new DataSet();
			adapter.Fill(d);
 
			foreach (DataRow row in d.Tables[0].Rows) {
				String[] fila = new String[17];
				ListViewItem itm;
				fila[0] = row["ID_ESCANEO"].ToString();
				fila[1] = row["NOMBRE"].ToString();
				fila[2] = row["ARCHIVOS"].ToString();
				fila[3] = row["CARPETAS"].ToString();
				fila[4] = FormatSize(Convert.ToInt64(row["TAMANO"]));
				fila[5] = FormatSize(Convert.ToInt64(row["CAPACIDAD"]));
				fila[6] = FormatSize(Convert.ToInt64(row["ESPACIOLIBRE"]));
				fila[7] = row["SISTEMAARCHIVOS"].ToString();
				fila[8] = row["NUMEROSERIE"].ToString();
				fila[9] = row["TIPO"].ToString();
				fila[10] = row["ETIQUETA"].ToString();
				fila[11] = row["CATEGORIA"].ToString();
				fila[12] = row["LOCACION"].ToString();
				fila[13] = row["PRESTAMO"].ToString();
				fila[14] = row["FECHA_ESCANEO"].ToString();
				fila[15] = row["LETRA_DISPOSITIVO"].ToString();
				fila[16] = row["COMENTARIO"].ToString();
				itm = new ListViewItem(fila);
				
				lvEscaneos.Items.Add(itm);
			}
		}
		
		private TreeNode PopulateTreeNode2(string[] paths, string pathSeparator, String rutaOrigen)
		{
			if (paths == null)
				return null;

			TreeNode thisnode = new TreeNode();
			TreeNode currentnode;
			
			char[] cachedpathseparator = pathSeparator.ToCharArray();
			foreach (string path in paths) {
				currentnode = thisnode;
				String rutaTemporal = path;
				rutaTemporal = rutaTemporal.Substring(rutaRaiz.Length - NombreCarpeta.Length);
				foreach (string subPath in rutaTemporal.Split(cachedpathseparator)) {
					if (null == currentnode.Nodes[subPath])
						currentnode = currentnode.Nodes.Add(subPath, subPath);
					else
						currentnode = currentnode.Nodes[subPath];                   
				}
			}

			return thisnode;
		}
		
		void MainForm_Load(object sender, EventArgs e)
		{
			treeView1.ExpandAll();
			treeView2.ExpandAll();
			DriveInfo[] UnidadesAlmacenamiento = DriveInfo.GetDrives();
			foreach (DriveInfo unidad in UnidadesAlmacenamiento) {
				if (unidad.DriveType == DriveType.CDRom) {
					tscbxUnidadesOpticas.Items.Add(unidad.Name);
				}
			}
			tscbxUnidadesOpticas.SelectedIndex = 0;
			toolStrip1.ImageScalingSize = new Size(30, 30);
			if (File.Exists("Grupo6.accdb")) {
				RefrescaEscaneos();
				Text += " - " + Path.GetFullPath("Grupo6.accdb");
			}
			
		}
		
		void tsmiIconos_Click(object sender, EventArgs e)
		{
			lvEstructura_Escaneos.View = View.Tile;
		}
		
		void tsmiDetalles_Click(object sender, EventArgs e)
		{
			lvEstructura_Escaneos.View = View.Details;
		}
		
		void tssbBuscar_Click(object sender, EventArgs e)
		{
			frmBuscar oFrmBuscar = new frmBuscar();
			
			oFrmBuscar.ShowDialog();
		}
		void tssbPropiedades_Click(object sender, EventArgs e)
		{
			frmPropiedadesEscaneos ofrmPropiedadesEscaneos = new frmPropiedadesEscaneos();
			
 
			DataRow row = CatalogadorArchivos.obtieneAtributosEscaneo(escaneoSeleccionado);
				ofrmPropiedadesEscaneos.lblNumeroSerieUnidad.Text = row["NUMEROSERIE"].ToString();
				ofrmPropiedadesEscaneos.lblIDEscaneo.Text = row["ID_ESCANEO"].ToString();
				ofrmPropiedadesEscaneos.txtUbicacion.Text = row["NOMBRE"].ToString();
				ofrmPropiedadesEscaneos.lblContenidoDispositivoValor.Text = row["ARCHIVOS"].ToString() + " Archivos, " + row["CARPETAS"].ToString() + " Carpetas";
				ofrmPropiedadesEscaneos.lblTamanoValor.Text = FormatSizeExtended(Convert.ToInt64(row["TAMANO"]));
				ofrmPropiedadesEscaneos.lblCapacidadDispositivoValor.Text = FormatSizeExtended(Convert.ToInt64(row["CAPACIDAD"]));
				ofrmPropiedadesEscaneos.lblEspacioLibreDispositivoValor.Text = FormatSizeExtended(Convert.ToInt64(row["ESPACIOLIBRE"]));
				ofrmPropiedadesEscaneos.lblSistemaArchivosValor.Text = row["SISTEMAARCHIVOS"].ToString();
				ofrmPropiedadesEscaneos.lblTipoValor.Text = row["TIPO"].ToString();
				ofrmPropiedadesEscaneos.lblEtiquetaUnidad.Text = row["ETIQUETA"].ToString();
				ofrmPropiedadesEscaneos.lblAccedidoValor.Text = String.Format("{0:dddd, dd MMMM yyyy, HH:mm:ss}", row["FECHA_ESCANEO"]);
				ofrmPropiedadesEscaneos.lblLetraUnidad.Text = row["LETRA_DISPOSITIVO"].ToString();
				ofrmPropiedadesEscaneos.txtComentario.Text = row["COMENTARIO"].ToString();
				ofrmPropiedadesEscaneos.lblNombreEquipo.Text = row["NOMBRE_PC"].ToString();
			if (ofrmPropiedadesEscaneos.ShowDialog() == DialogResult.OK) {
				CatalogadorArchivos.actualizaAtributosEscaneo(escaneoSeleccionado, ofrmPropiedadesEscaneos.txtUbicacion.Text, ofrmPropiedadesEscaneos.txtComentario.Text,ofrmPropiedadesEscaneos.cbxCategoria.SelectedIndex, ofrmPropiedadesEscaneos.cbxLocacion.SelectedIndex);
				RefrescaEscaneos();
			}
		}
		
		void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected) {
				escaneoSeleccionado = Convert.ToInt32(e.Item.SubItems[0].Text);
				tssbPropiedades.Enabled = true;
				tssbEliminar.Enabled = true;
				DirectoryInfo informacionDirectorio = new DirectoryInfo(e.Item.SubItems[10].Text);
//				DriveInfo informacionDispositivo = new DriveInfo(oSeleccionarCarpeta.SelectedPath);
				Debug.WriteLine("ruta global: " + informacionDirectorio);
				this.rutaPrincipal = informacionDirectorio;
			} else {
				tssbPropiedades.Enabled = false;
				tssbEliminar.Enabled = false;
			}
			rutaRaiz = e.Item.SubItems[10].Text;
			NombreCarpeta = e.Item.SubItems[1].Text;
		}
		void tsmiSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		/// <summary>
		/// Elimina la entrada seleccionada y refresca la lista de unidades escaneadas
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void tssbEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Estás seguro que quieres eliminar este disco?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
				CatalogadorArchivos.eliminar(escaneoSeleccionado);
				RefrescaEscaneos();
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string itemSeleccionadoNombre = lvEstructura_Escaneos.SelectedItems[0].SubItems[0].Text;
			DataRow atributosArchivo = CatalogadorArchivos.obtieneAtributosArchivo(lvEstructura_Escaneos.SelectedItems[0].Tag.ToString());
			//DirectoryInfo informacionDirectorio = new DirectoryInfo(itemSeleccinado);

			frmPropiedadesArchivos propiedadesArchivos = new frmPropiedadesArchivos();
			propiedadesArchivos.idEstructuraEscaneos = (int) lvEstructura_Escaneos.SelectedItems[0].Tag;
			propiedadesArchivos.txtUbicacion.Text = itemSeleccionadoNombre;
			propiedadesArchivos.lblNombreValor.Text = atributosArchivo["NOMBRE"].ToString();
			propiedadesArchivos.lblTipoValor.Text = atributosArchivo["TIPO"].ToString();
			propiedadesArchivos.lblRutaValor.Text = atributosArchivo["RUTA"].ToString();
			propiedadesArchivos.lblTamanoValor.Text = FormatSizeExtended(Convert.ToInt64(atributosArchivo["TAMANO"]));
			propiedadesArchivos.txtComentario.Text = atributosArchivo["COMENTARIO"].ToString();
			propiedadesArchivos.lblModificadoValor.Text = String.Format("{0:dddd, dd MMMM yyyy, HH:mm:ss}", atributosArchivo["FECHA_MODIFICACION"]);
			propiedadesArchivos.lblCreadoValor.Text = String.Format("{0:dddd, dd MMMM yyyy, HH:mm:ss}", atributosArchivo["FECHA_CREACION"]);
			propiedadesArchivos.lblAccedidoValor.Text = String.Format("{0:dddd, dd MMMM yyyy, HH:mm:ss}", atributosArchivo["FECHA_ACCESO"]);
			if ((bool) atributosArchivo["ARCHIVADO"]) {
				propiedadesArchivos.chkArchivado.CheckState = CheckState.Checked;
			} else {
				propiedadesArchivos.chkArchivado.CheckState = CheckState.Unchecked;
			}
			if ((bool) atributosArchivo["SISTEMA"]) {
				propiedadesArchivos.chkSistema.CheckState = CheckState.Checked;
			} else {
				propiedadesArchivos.chkSistema.CheckState = CheckState.Unchecked;
			}
			if ((bool) atributosArchivo["ENCRIPTADO"]) {
				propiedadesArchivos.chkEncriptado.CheckState = CheckState.Checked;
			} else {
				propiedadesArchivos.chkEncriptado.CheckState = CheckState.Unchecked;
			}
			if ((bool) atributosArchivo["SOLO_LECTURA"]) {
				propiedadesArchivos.chkSoloLectura.CheckState = CheckState.Checked;
			} else {
				propiedadesArchivos.chkSoloLectura.CheckState = CheckState.Unchecked;
			}
			if ((bool) atributosArchivo["OCULTO"]) {
				propiedadesArchivos.chkOculto.CheckState = CheckState.Checked;
			} else {
				propiedadesArchivos.chkOculto.CheckState = CheckState.Unchecked;
			}
			if ((bool) atributosArchivo["COMPRIMIDO"]) {
				propiedadesArchivos.chkComprimido.CheckState = CheckState.Checked;
			} else {
				propiedadesArchivos.chkComprimido.CheckState = CheckState.Unchecked;
			}
			propiedadesArchivos.pictureBox1.Image = propiedadesArchivos.LargeImageList.Images[atributosArchivo["TIPO"].ToString()];
			propiedadesArchivos.ShowDialog();
			RefrescaEscaneosArbol(rutaRaiz);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void listView1_MouseClick(object sender, MouseEventArgs e)
		{
			lvEstructura_Escaneos.Items.Clear();

			string itemSeleccinado = lvEscaneos.SelectedItems[0].SubItems[10].Text;
			DirectoryInfo informacionDirectorio = new DirectoryInfo(itemSeleccinado);
	
			treeView1.Nodes.Clear();
			Debug.WriteLine("item seleccinado: " + itemSeleccinado);
			Debug.WriteLine("informacion directorio: " + informacionDirectorio);
			treeView1.Nodes.Add(PopulateTreeNode2(CatalogadorArchivos.retornaEntradasEstructuraEscaneos(escaneoSeleccionado, itemSeleccinado), "\\", itemSeleccinado));
			//treeView1.Nodes.Add(crearArbol(informacionDirectorio));
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="rutaGlobal"></param>
		public void RefrescaEscaneosArbol(string rutaGlobal)
		{
			lvEstructura_Escaneos.Items.Clear();
			string ruta = rutaGlobal;
//			Console.WriteLine(""+ruta);
//			Console.WriteLine(escaneoSeleccionado.ToString());
			OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Grupo6.accdb");
			OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ESTRUCTURA_ESCANEOS.ID_ESTRUCTURA_ESCANEO as ID_ESTRUCTURA_ESCANEO, ESTRUCTURA_ESCANEOS.NOMBRE as NOMBRE, " +
			                           "ESTRUCTURA_ESCANEOS.TAMANO as TAMANO, ESTRUCTURA_ESCANEOS.TIPO as TIPO, " +
			                           "ESTRUCTURA_ESCANEOS.FECHA_MODIFICACION as FECHA_MODIFICACION, ESTRUCTURA_ESCANEOS.COMENTARIO as COMENTARIO " +
			                           "FROM ESTRUCTURA_ESCANEOS LEFT JOIN ESCANEOS ON ESTRUCTURA_ESCANEOS.ID_ESCANEO = ESCANEOS.ID_ESCANEO " +
			                           "WHERE ESTRUCTURA_ESCANEOS.RUTA LIKE '%" + ruta + "%' AND ESTRUCTURA_ESCANEOS.ID_ESCANEO = " + escaneoSeleccionado + ";", conexion);

			DataSet d = new DataSet();
			adapter.Fill(d);

	
			lvEstructura_Escaneos.SmallImageList = SmallImageList;
			lvEstructura_Escaneos.LargeImageList = LargeImageList;
			foreach (DataRow row in d.Tables[0].Rows) {
				String[] fila = new String[5];
				ListViewItem itm;
				fila[0] = row["NOMBRE"].ToString();
				fila[1] = FormatSize(Convert.ToInt64(row["TAMANO"].ToString()));
				fila[2] = row["TIPO"].ToString().ToLower();
				fila[3] = row["FECHA_MODIFICACION"].ToString();
				fila[4] = row["COMENTARIO"].ToString();
				itm = new ListViewItem(fila);
				itm.Tag = row["ID_ESTRUCTURA_ESCANEO"];
				Icon icono = SystemIcons.WinLogo;
				switch (fila[2]) {
					case ".exe":
						itm.ImageIndex = 0;
						break;
					case ".jpg":
						itm.ImageIndex = 4;
						break;
					case ".pdf":
						itm.ImageIndex = 2;
						break;
					case ".txt":
						itm.ImageIndex = 3;
						break;
//					case ".jpg":
//						itm.ImageIndex = 4;
//						break;
					case ".jpeg":
						itm.ImageIndex = 5;
						break;
				}
				lvEstructura_Escaneos.Items.Add(itm);

			}

		}
		
		void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			string rutastring = rutaRaiz;
			string quitarNombre = rutastring.Replace((this.rutaPrincipal).Name, "");
			string treviewtext;
			if (e.Node == treeView1.TopNode) {
				string rutaGlobal = quitarNombre + treeView1.TopNode.FullPath;
				//			Debug.WriteLine("ruta final: " + treeView1.SelectedNode.Name);
				//			Debug.WriteLine("ruta final: " + treeView1.SelectedNode.Text);
				treviewtext = treeView1.TopNode.Text;
				//			Debug.WriteLine("ruta final: " + rutaGlobal);
		
			} else {
				string rutaGlobal = quitarNombre + treeView1.SelectedNode.FullPath;
				//			Debug.WriteLine("ruta final: " + treeView1.SelectedNode.Name);
				//			Debug.WriteLine("ruta final: " + treeView1.SelectedNode.Text);
				treviewtext = e.Node.FullPath;
				//			Debug.WriteLine("ruta final: " + rutaGlobal);	
			}
			
			//Process.Start(rutaGlobal);
//			cargaIconos();
			RefrescaEscaneosArbol(treviewtext);
		}
		
		private void cargaIconos()
		{
			// Obtain a handle to the system image list.
			NativeMethods.SHFILEINFO shfi = new NativeMethods.SHFILEINFO();
			IntPtr hSysImgList = NativeMethods.SHGetFileInfo("",
				                     0,
				                     ref shfi,
				                     (uint)Marshal.SizeOf(shfi),
				                     NativeMethods.SHGFI_SYSICONINDEX
				                     | NativeMethods.SHGFI_SMALLICON);
			Debug.Assert(hSysImgList != IntPtr.Zero);  // cross our fingers and hope to succeed!

			// Set the ListView control to use that image list.
			IntPtr hOldImgList = NativeMethods.SendMessage(lvEstructura_Escaneos.Handle,
				                     NativeMethods.LVM_SETIMAGELIST,
				                     NativeMethods.LVSIL_SMALL,
				                     hSysImgList);

			// If the ListView control already had an image list, delete the old one.
			if (hOldImgList != IntPtr.Zero) {
				NativeMethods.ImageList_Destroy(hOldImgList);
			}

			// Set up the ListView control's basic properties.
			// Put it in "Details" mode, create a column so that "Details" mode will work,
			// and set its theme so it will look like the one used by Explorer.
   
			NativeMethods.SetWindowTheme(lvEstructura_Escaneos.Handle, "Explorer", null);

			// Get the items from the file system, and add each of them to the ListView,
			// complete with their corresponding name and icon indices.
			string[] s = Directory.GetFileSystemEntries(@"C:\...");
			foreach (string file in s) {
				IntPtr himl = NativeMethods.SHGetFileInfo(file,
					              0,
					              ref shfi,
					              (uint)Marshal.SizeOf(shfi),
					              NativeMethods.SHGFI_DISPLAYNAME
					              | NativeMethods.SHGFI_SYSICONINDEX
					              | NativeMethods.SHGFI_SMALLICON);
				Debug.Assert(himl == hSysImgList); // should be the same imagelist as the one we set
				lvEstructura_Escaneos.Items.Add(shfi.szDisplayName, shfi.iIcon);
			}
		}
		void tsmiIconosGrandes_Click(object sender, EventArgs e)
		{
			lvEstructura_Escaneos.View = View.LargeIcon;
		}
		void treeView2_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			e.Node.ContextMenuStrip = cmsCategorias;
			if (e.Button == MouseButtons.Right) {
				e.Node.ContextMenuStrip.Show();
			}

		}
		void agregarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAniadirCategoria ofrmAniadirCategoria = new frmAniadirCategoria();
			if (ofrmAniadirCategoria.ShowDialog() == DialogResult.OK){
				CatalogadorArchivos.insertaCategoria(ofrmAniadirCategoria.txtNombre.Text, ofrmAniadirCategoria.txtComentario.Text);
			}
		}
		
	}
}
