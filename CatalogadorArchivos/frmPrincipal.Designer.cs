/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 5 jun. 2021
 * Hora: 22:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CatalogadorArchivos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		public System.Windows.Forms.ListView lvEscaneos;
		private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem abrirRecienteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem limpiarBaseDeDatosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem compactarBaseDeDatosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informaciónDeBaseDeDatosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ToolStripButton tssbPropiedades;
		private System.Windows.Forms.ToolStripButton tssbEliminar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.TreeView treeView2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ListView lvEstructura_Escaneos;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ColumnHeader columnHeader15;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ColumnHeader columnHeader17;
		private System.Windows.Forms.ColumnHeader columnHeader18;
		private System.Windows.Forms.ColumnHeader columnHeader19;
		private System.Windows.Forms.ColumnHeader columnHeader20;
		private System.Windows.Forms.ColumnHeader columnHeader21;
		private System.Windows.Forms.ColumnHeader columnHeader22;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ContextMenuStrip cmsVistas;
		private System.Windows.Forms.ToolStripMenuItem tsmiIconosGrandes;
		private System.Windows.Forms.ToolStripMenuItem tsmiDetalles;
		private System.Windows.Forms.ToolStripMenuItem tsmiIconosPequenos;
		private System.Windows.Forms.ToolStripMenuItem tsmiLista;
		private System.Windows.Forms.ToolStripMenuItem tsmiIconos;
		private System.Windows.Forms.ToolStripSplitButton tssbEscanearDisco;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ToolStripButton tssbBuscar;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripComboBox tscbxUnidadesOpticas;
		private System.Windows.Forms.ImageList SmallImageList;
		private System.Windows.Forms.ImageList LargeImageList;
		private System.Windows.Forms.TreeView treeView3;
		private System.Windows.Forms.TreeView treeView4;
		private System.Windows.Forms.ContextMenuStrip cmsCategorias;
		private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;

		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo1");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo2");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nodo3");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nodo4");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nodo0", new System.Windows.Forms.TreeNode[] {
			treeNode1,
			treeNode2,
			treeNode3,
			treeNode4});
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirRecienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.limpiarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compactarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónDeBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
			this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tssbEscanearDisco = new System.Windows.Forms.ToolStripSplitButton();
			this.tssbPropiedades = new System.Windows.Forms.ToolStripButton();
			this.tssbEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.tssbBuscar = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.tscbxUnidadesOpticas = new System.Windows.Forms.ToolStripComboBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.treeView2 = new System.Windows.Forms.TreeView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.treeView3 = new System.Windows.Forms.TreeView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.treeView4 = new System.Windows.Forms.TreeView();
			this.lvEscaneos = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader21 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader22 = new System.Windows.Forms.ColumnHeader();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lvEstructura_Escaneos = new System.Windows.Forms.ListView();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.cmsVistas = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiIconosGrandes = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDetalles = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiIconosPequenos = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLista = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiIconos = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.SmallImageList = new System.Windows.Forms.ImageList(this.components);
			this.LargeImageList = new System.Windows.Forms.ImageList(this.components);
			this.cmsCategorias = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.cmsVistas.SuspendLayout();
			this.cmsCategorias.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.archivosToolStripMenuItem,
			this.verToolStripMenuItem,
			this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1228, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivosToolStripMenuItem
			// 
			this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nuevoToolStripMenuItem,
			this.abrirToolStripMenuItem,
			this.abrirRecienteToolStripMenuItem,
			this.limpiarBaseDeDatosToolStripMenuItem,
			this.compactarBaseDeDatosToolStripMenuItem,
			this.informaciónDeBaseDeDatosToolStripMenuItem,
			this.tsmiSalir});
			this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
			this.archivosToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
			this.archivosToolStripMenuItem.Text = "Archivos";
			// 
			// nuevoToolStripMenuItem
			// 
			this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
			this.nuevoToolStripMenuItem.Text = "Nuevo";
			// 
			// abrirToolStripMenuItem
			// 
			this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
			this.abrirToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
			this.abrirToolStripMenuItem.Text = "Abrir";
			// 
			// abrirRecienteToolStripMenuItem
			// 
			this.abrirRecienteToolStripMenuItem.Name = "abrirRecienteToolStripMenuItem";
			this.abrirRecienteToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
			this.abrirRecienteToolStripMenuItem.Text = "Abrir reciente";
			// 
			// limpiarBaseDeDatosToolStripMenuItem
			// 
			this.limpiarBaseDeDatosToolStripMenuItem.Name = "limpiarBaseDeDatosToolStripMenuItem";
			this.limpiarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
			this.limpiarBaseDeDatosToolStripMenuItem.Text = "Limpiar Base de Datos";
			// 
			// compactarBaseDeDatosToolStripMenuItem
			// 
			this.compactarBaseDeDatosToolStripMenuItem.Name = "compactarBaseDeDatosToolStripMenuItem";
			this.compactarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
			this.compactarBaseDeDatosToolStripMenuItem.Text = "Compactar Base de Datos";
			// 
			// informaciónDeBaseDeDatosToolStripMenuItem
			// 
			this.informaciónDeBaseDeDatosToolStripMenuItem.Name = "informaciónDeBaseDeDatosToolStripMenuItem";
			this.informaciónDeBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
			this.informaciónDeBaseDeDatosToolStripMenuItem.Text = "Información de Base de Datos";
			// 
			// tsmiSalir
			// 
			this.tsmiSalir.Name = "tsmiSalir";
			this.tsmiSalir.Size = new System.Drawing.Size(263, 24);
			this.tsmiSalir.Text = "Salir";
			this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
			// 
			// verToolStripMenuItem
			// 
			this.verToolStripMenuItem.Name = "verToolStripMenuItem";
			this.verToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
			this.verToolStripMenuItem.Text = "Ver";
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tssbEscanearDisco,
			this.tssbPropiedades,
			this.tssbEliminar,
			this.toolStripSeparator1,
			this.toolStripButton3,
			this.tssbBuscar,
			this.toolStripButton4,
			this.toolStripSeparator2,
			this.toolStripButton5,
			this.toolStripButton6,
			this.tscbxUnidadesOpticas});
			this.toolStrip1.Location = new System.Drawing.Point(0, 27);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1228, 44);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tssbEscanearDisco
			// 
			this.tssbEscanearDisco.AutoSize = false;
			this.tssbEscanearDisco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.tssbEscanearDisco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tssbEscanearDisco.Image = ((System.Drawing.Image)(resources.GetObject("tssbEscanearDisco.Image")));
			this.tssbEscanearDisco.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tssbEscanearDisco.Name = "tssbEscanearDisco";
			this.tssbEscanearDisco.Size = new System.Drawing.Size(48, 44);
			this.tssbEscanearDisco.Text = "Escanear disco";
			this.tssbEscanearDisco.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
			// 
			// tssbPropiedades
			// 
			this.tssbPropiedades.AutoSize = false;
			this.tssbPropiedades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tssbPropiedades.Enabled = false;
			this.tssbPropiedades.Image = ((System.Drawing.Image)(resources.GetObject("tssbPropiedades.Image")));
			this.tssbPropiedades.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tssbPropiedades.Name = "tssbPropiedades";
			this.tssbPropiedades.Size = new System.Drawing.Size(44, 44);
			this.tssbPropiedades.Text = "Propiedades";
			this.tssbPropiedades.Click += new System.EventHandler(this.tssbPropiedades_Click);
			// 
			// tssbEliminar
			// 
			this.tssbEliminar.AutoSize = false;
			this.tssbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tssbEliminar.Enabled = false;
			this.tssbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tssbEliminar.Image")));
			this.tssbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tssbEliminar.Name = "tssbEliminar";
			this.tssbEliminar.Size = new System.Drawing.Size(44, 44);
			this.tssbEliminar.Text = "Eliminar";
			this.tssbEliminar.Click += new System.EventHandler(this.tssbEliminar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.AutoSize = false;
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(41, 41);
			this.toolStripButton3.Text = "Imprimir";
			// 
			// tssbBuscar
			// 
			this.tssbBuscar.AutoSize = false;
			this.tssbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tssbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tssbBuscar.Image")));
			this.tssbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tssbBuscar.Name = "tssbBuscar";
			this.tssbBuscar.Size = new System.Drawing.Size(44, 44);
			this.tssbBuscar.Text = "Buscar";
			this.tssbBuscar.Click += new System.EventHandler(this.tssbBuscar_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.AutoSize = false;
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(41, 41);
			this.toolStripButton4.Text = "Estadísticas";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.AutoSize = false;
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(41, 41);
			this.toolStripButton5.Text = "toolStripButton5";
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.AutoSize = false;
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(41, 41);
			this.toolStripButton6.Text = "toolStripButton6";
			// 
			// tscbxUnidadesOpticas
			// 
			this.tscbxUnidadesOpticas.Name = "tscbxUnidadesOpticas";
			this.tscbxUnidadesOpticas.Size = new System.Drawing.Size(121, 44);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 71);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer1.Size = new System.Drawing.Size(1228, 548);
			this.splitContainer1.SplitterDistance = 301;
			this.splitContainer1.TabIndex = 2;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.lvEscaneos);
			this.splitContainer2.Size = new System.Drawing.Size(1228, 301);
			this.splitContainer2.SplitterDistance = 529;
			this.splitContainer2.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(529, 301);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.treeView2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(521, 275);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Categorías";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// treeView2
			// 
			this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView2.ItemHeight = 32;
			this.treeView2.Location = new System.Drawing.Point(3, 3);
			this.treeView2.Name = "treeView2";
			treeNode1.Name = "Nodo1";
			treeNode1.Text = "Nodo1";
			treeNode2.Name = "Nodo2";
			treeNode2.Text = "Nodo2";
			treeNode3.Name = "Nodo3";
			treeNode3.Text = "Nodo3";
			treeNode4.Name = "Nodo4";
			treeNode4.Text = "Nodo4";
			treeNode5.Name = "Nodo0";
			treeNode5.Text = "Nodo0";
			this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
			treeNode5});
			this.treeView2.Size = new System.Drawing.Size(515, 269);
			this.treeView2.TabIndex = 0;
			this.treeView2.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.treeView3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(521, 275);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Locaciones";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// treeView3
			// 
			this.treeView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView3.Location = new System.Drawing.Point(3, 3);
			this.treeView3.Name = "treeView3";
			this.treeView3.Size = new System.Drawing.Size(515, 269);
			this.treeView3.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.treeView4);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(521, 275);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Contactos";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// treeView4
			// 
			this.treeView4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView4.Location = new System.Drawing.Point(0, 0);
			this.treeView4.Name = "treeView4";
			this.treeView4.Size = new System.Drawing.Size(521, 275);
			this.treeView4.TabIndex = 0;
			// 
			// lvEscaneos
			// 
			this.lvEscaneos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2,
			this.columnHeader3,
			this.columnHeader4,
			this.columnHeader5,
			this.columnHeader6,
			this.columnHeader7,
			this.columnHeader8,
			this.columnHeader9,
			this.columnHeader15,
			this.columnHeader16,
			this.columnHeader17,
			this.columnHeader18,
			this.columnHeader19,
			this.columnHeader20,
			this.columnHeader21,
			this.columnHeader22});
			this.lvEscaneos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvEscaneos.FullRowSelect = true;
			this.lvEscaneos.GridLines = true;
			this.lvEscaneos.Location = new System.Drawing.Point(0, 0);
			this.lvEscaneos.Name = "lvEscaneos";
			this.lvEscaneos.Size = new System.Drawing.Size(695, 301);
			this.lvEscaneos.TabIndex = 0;
			this.lvEscaneos.UseCompatibleStateImageBehavior = false;
			this.lvEscaneos.View = System.Windows.Forms.View.Details;
			this.lvEscaneos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
			this.lvEscaneos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID Disco";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Nombre";
			this.columnHeader2.Width = 180;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Archivos";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Carpetas";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Tamaño";
			this.columnHeader5.Width = 120;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Capacidad";
			this.columnHeader6.Width = 120;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Espacio libre";
			this.columnHeader7.Width = 120;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Sistema de archivos";
			this.columnHeader8.Width = 120;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Numero de serie";
			this.columnHeader9.Width = 120;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Tipo";
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Etiqueta";
			this.columnHeader16.Width = 260;
			// 
			// columnHeader17
			// 
			this.columnHeader17.Text = "Categoría";
			// 
			// columnHeader18
			// 
			this.columnHeader18.Text = "Locación";
			// 
			// columnHeader19
			// 
			this.columnHeader19.Text = "Préstamo";
			// 
			// columnHeader20
			// 
			this.columnHeader20.Text = "Fecha de escaneo";
			this.columnHeader20.Width = 160;
			// 
			// columnHeader21
			// 
			this.columnHeader21.Text = "Letra de Dispositivo";
			this.columnHeader21.Width = 160;
			// 
			// columnHeader22
			// 
			this.columnHeader22.Text = "Comentario";
			this.columnHeader22.Width = 260;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.lvEstructura_Escaneos);
			this.splitContainer3.Size = new System.Drawing.Size(1228, 243);
			this.splitContainer3.SplitterDistance = 409;
			this.splitContainer3.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.ItemHeight = 24;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.Size = new System.Drawing.Size(409, 243);
			this.treeView1.TabIndex = 0;
			this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icons8-folder-48.png");
			this.imageList1.Images.SetKeyName(1, "icons8-open-file-folder-48.png");
			// 
			// lvEstructura_Escaneos
			// 
			this.lvEstructura_Escaneos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader10,
			this.columnHeader11,
			this.columnHeader12,
			this.columnHeader13,
			this.columnHeader14});
			this.lvEstructura_Escaneos.ContextMenuStrip = this.cmsVistas;
			this.lvEstructura_Escaneos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvEstructura_Escaneos.GridLines = true;
			this.lvEstructura_Escaneos.Location = new System.Drawing.Point(0, 0);
			this.lvEstructura_Escaneos.Name = "lvEstructura_Escaneos";
			this.lvEstructura_Escaneos.Size = new System.Drawing.Size(815, 243);
			this.lvEstructura_Escaneos.TabIndex = 1;
			this.lvEstructura_Escaneos.UseCompatibleStateImageBehavior = false;
			this.lvEstructura_Escaneos.View = System.Windows.Forms.View.Details;
			this.lvEstructura_Escaneos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Nombre";
			this.columnHeader10.Width = 280;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Tamaño";
			this.columnHeader11.Width = 80;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Tipo";
			this.columnHeader12.Width = 150;
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "Modificado";
			this.columnHeader13.Width = 150;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Comentario";
			this.columnHeader14.Width = 300;
			// 
			// cmsVistas
			// 
			this.cmsVistas.ImageScalingSize = new System.Drawing.Size(18, 18);
			this.cmsVistas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsmiIconosGrandes,
			this.tsmiDetalles,
			this.tsmiIconosPequenos,
			this.tsmiLista,
			this.tsmiIconos});
			this.cmsVistas.Name = "cmsVistas";
			this.cmsVistas.Size = new System.Drawing.Size(182, 124);
			// 
			// tsmiIconosGrandes
			// 
			this.tsmiIconosGrandes.Name = "tsmiIconosGrandes";
			this.tsmiIconosGrandes.Size = new System.Drawing.Size(181, 24);
			this.tsmiIconosGrandes.Text = "Iconos Grandes";
			this.tsmiIconosGrandes.Click += new System.EventHandler(this.tsmiIconosGrandes_Click);
			// 
			// tsmiDetalles
			// 
			this.tsmiDetalles.Name = "tsmiDetalles";
			this.tsmiDetalles.Size = new System.Drawing.Size(181, 24);
			this.tsmiDetalles.Text = "Detalles";
			this.tsmiDetalles.Click += new System.EventHandler(this.tsmiDetalles_Click);
			// 
			// tsmiIconosPequenos
			// 
			this.tsmiIconosPequenos.Name = "tsmiIconosPequenos";
			this.tsmiIconosPequenos.Size = new System.Drawing.Size(181, 24);
			this.tsmiIconosPequenos.Text = "Iconos Pequeños";
			// 
			// tsmiLista
			// 
			this.tsmiLista.Name = "tsmiLista";
			this.tsmiLista.Size = new System.Drawing.Size(181, 24);
			this.tsmiLista.Text = "Lista";
			// 
			// tsmiIconos
			// 
			this.tsmiIconos.Name = "tsmiIconos";
			this.tsmiIconos.Size = new System.Drawing.Size(181, 24);
			this.tsmiIconos.Text = "Iconos";
			this.tsmiIconos.Click += new System.EventHandler(this.tsmiIconos_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// SmallImageList
			// 
			this.SmallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SmallImageList.ImageStream")));
			this.SmallImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.SmallImageList.Images.SetKeyName(0, ".exe");
			this.SmallImageList.Images.SetKeyName(1, ".jpg");
			this.SmallImageList.Images.SetKeyName(2, ".pdf");
			this.SmallImageList.Images.SetKeyName(3, ".txt");
			// 
			// LargeImageList
			// 
			this.LargeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeImageList.ImageStream")));
			this.LargeImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.LargeImageList.Images.SetKeyName(0, "icons8-ex-48.png");
			this.LargeImageList.Images.SetKeyName(1, "icons8-jpg-80.png");
			this.LargeImageList.Images.SetKeyName(2, "icons8-pdf-2-96.png");
			this.LargeImageList.Images.SetKeyName(3, "icons8-txt-48.png");
			this.LargeImageList.Images.SetKeyName(4, ".jpg");
			this.LargeImageList.Images.SetKeyName(5, ".jpeg");
			// 
			// cmsCategorias
			// 
			this.cmsCategorias.ImageScalingSize = new System.Drawing.Size(18, 18);
			this.cmsCategorias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.agregarToolStripMenuItem,
			this.buscarToolStripMenuItem});
			this.cmsCategorias.Name = "cmsCategorias";
			this.cmsCategorias.Size = new System.Drawing.Size(128, 52);
			// 
			// agregarToolStripMenuItem
			// 
			this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
			this.agregarToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
			this.agregarToolStripMenuItem.Text = "Agregar";
			this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
			// 
			// buscarToolStripMenuItem
			// 
			this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
			this.buscarToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
			this.buscarToolStripMenuItem.Text = "Buscar";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1228, 619);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "CatalogadorArchivos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.cmsVistas.ResumeLayout(false);
			this.cmsCategorias.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}
	}