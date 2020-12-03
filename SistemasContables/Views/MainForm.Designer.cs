﻿namespace SistemasContables
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.AnimacionPanelNavegacion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelNavegacion = new System.Windows.Forms.Panel();
            this.btnBalanceGeneral = new FontAwesome.Sharp.IconButton();
            this.btnEstadoDeResultados = new FontAwesome.Sharp.IconButton();
            this.btnBalanceDeComprobacion = new FontAwesome.Sharp.IconButton();
            this.btnLibroMayor = new FontAwesome.Sharp.IconButton();
            this.btnLibroDiario = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnRestoreWindow = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddLibroDiario = new FontAwesome.Sharp.IconButton();
            this.btnDeleteLibroDiario = new FontAwesome.Sharp.IconButton();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPrevious = new FontAwesome.Sharp.IconButton();
            this.AnimacionPanelNavegacionBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.MoverVentanaLogo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MoverVentanaPanelTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimacionPanelNavegacion
            // 
            this.AnimacionPanelNavegacion.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionPanelNavegacion.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionPanelNavegacion.DefaultAnimation = animation1;
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelNavegacion.Controls.Add(this.panel2);
            this.panelNavegacion.Controls.Add(this.btnBalanceGeneral);
            this.panelNavegacion.Controls.Add(this.btnEstadoDeResultados);
            this.panelNavegacion.Controls.Add(this.btnBalanceDeComprobacion);
            this.panelNavegacion.Controls.Add(this.btnLibroMayor);
            this.panelNavegacion.Controls.Add(this.btnLibroDiario);
            this.panelNavegacion.Controls.Add(this.btnInicio);
            this.panelNavegacion.Controls.Add(this.btnMenu);
            this.panelNavegacion.Controls.Add(this.pbLogo);
            this.AnimacionPanelNavegacionBack.SetDecoration(this.panelNavegacion, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.panelNavegacion, BunifuAnimatorNS.DecorationType.None);
            this.panelNavegacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavegacion.Location = new System.Drawing.Point(0, 0);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(252, 760);
            this.panelNavegacion.TabIndex = 2;
            // 
            // btnBalanceGeneral
            // 
            this.btnBalanceGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnBalanceGeneral, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnBalanceGeneral, BunifuAnimatorNS.DecorationType.None);
            this.btnBalanceGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBalanceGeneral.FlatAppearance.BorderSize = 0;
            this.btnBalanceGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalanceGeneral.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBalanceGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceGeneral.ForeColor = System.Drawing.Color.White;
            this.btnBalanceGeneral.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            this.btnBalanceGeneral.IconColor = System.Drawing.Color.White;
            this.btnBalanceGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBalanceGeneral.IconSize = 48;
            this.btnBalanceGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceGeneral.Location = new System.Drawing.Point(0, 439);
            this.btnBalanceGeneral.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnBalanceGeneral.Name = "btnBalanceGeneral";
            this.btnBalanceGeneral.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBalanceGeneral.Rotation = 0D;
            this.btnBalanceGeneral.Size = new System.Drawing.Size(252, 60);
            this.btnBalanceGeneral.TabIndex = 21;
            this.btnBalanceGeneral.Text = "Balance general";
            this.btnBalanceGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBalanceGeneral.UseVisualStyleBackColor = true;
            this.btnBalanceGeneral.Click += new System.EventHandler(this.btnBalanceGeneral_Click);
            // 
            // btnEstadoDeResultados
            // 
            this.btnEstadoDeResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnEstadoDeResultados, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnEstadoDeResultados, BunifuAnimatorNS.DecorationType.None);
            this.btnEstadoDeResultados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadoDeResultados.FlatAppearance.BorderSize = 0;
            this.btnEstadoDeResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoDeResultados.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEstadoDeResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoDeResultados.ForeColor = System.Drawing.Color.White;
            this.btnEstadoDeResultados.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.btnEstadoDeResultados.IconColor = System.Drawing.Color.White;
            this.btnEstadoDeResultados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstadoDeResultados.IconSize = 48;
            this.btnEstadoDeResultados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadoDeResultados.Location = new System.Drawing.Point(0, 379);
            this.btnEstadoDeResultados.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnEstadoDeResultados.Name = "btnEstadoDeResultados";
            this.btnEstadoDeResultados.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEstadoDeResultados.Rotation = 0D;
            this.btnEstadoDeResultados.Size = new System.Drawing.Size(252, 60);
            this.btnEstadoDeResultados.TabIndex = 20;
            this.btnEstadoDeResultados.Text = "Estado de resultados";
            this.btnEstadoDeResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadoDeResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstadoDeResultados.UseVisualStyleBackColor = true;
            this.btnEstadoDeResultados.Click += new System.EventHandler(this.btnEstadoDeResultados_Click);
            // 
            // btnBalanceDeComprobacion
            // 
            this.btnBalanceDeComprobacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnBalanceDeComprobacion, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnBalanceDeComprobacion, BunifuAnimatorNS.DecorationType.None);
            this.btnBalanceDeComprobacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBalanceDeComprobacion.FlatAppearance.BorderSize = 0;
            this.btnBalanceDeComprobacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalanceDeComprobacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBalanceDeComprobacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceDeComprobacion.ForeColor = System.Drawing.Color.White;
            this.btnBalanceDeComprobacion.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            this.btnBalanceDeComprobacion.IconColor = System.Drawing.Color.White;
            this.btnBalanceDeComprobacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBalanceDeComprobacion.IconSize = 48;
            this.btnBalanceDeComprobacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceDeComprobacion.Location = new System.Drawing.Point(0, 319);
            this.btnBalanceDeComprobacion.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnBalanceDeComprobacion.Name = "btnBalanceDeComprobacion";
            this.btnBalanceDeComprobacion.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBalanceDeComprobacion.Rotation = 0D;
            this.btnBalanceDeComprobacion.Size = new System.Drawing.Size(252, 60);
            this.btnBalanceDeComprobacion.TabIndex = 19;
            this.btnBalanceDeComprobacion.Text = "Balance de comprobacion";
            this.btnBalanceDeComprobacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceDeComprobacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBalanceDeComprobacion.UseVisualStyleBackColor = true;
            this.btnBalanceDeComprobacion.Click += new System.EventHandler(this.btnBalanceDeComprobacion_Click);
            // 
            // btnLibroMayor
            // 
            this.btnLibroMayor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnLibroMayor, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnLibroMayor, BunifuAnimatorNS.DecorationType.None);
            this.btnLibroMayor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibroMayor.FlatAppearance.BorderSize = 0;
            this.btnLibroMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibroMayor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLibroMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibroMayor.ForeColor = System.Drawing.Color.White;
            this.btnLibroMayor.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnLibroMayor.IconColor = System.Drawing.Color.White;
            this.btnLibroMayor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibroMayor.IconSize = 48;
            this.btnLibroMayor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibroMayor.Location = new System.Drawing.Point(0, 259);
            this.btnLibroMayor.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnLibroMayor.Name = "btnLibroMayor";
            this.btnLibroMayor.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLibroMayor.Rotation = 0D;
            this.btnLibroMayor.Size = new System.Drawing.Size(252, 60);
            this.btnLibroMayor.TabIndex = 18;
            this.btnLibroMayor.Text = "Libro Mayor";
            this.btnLibroMayor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibroMayor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibroMayor.UseVisualStyleBackColor = true;
            this.btnLibroMayor.Click += new System.EventHandler(this.btnLibroMayor_Click);
            // 
            // btnLibroDiario
            // 
            this.btnLibroDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnLibroDiario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnLibroDiario, BunifuAnimatorNS.DecorationType.None);
            this.btnLibroDiario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibroDiario.FlatAppearance.BorderSize = 0;
            this.btnLibroDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibroDiario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLibroDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibroDiario.ForeColor = System.Drawing.Color.White;
            this.btnLibroDiario.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnLibroDiario.IconColor = System.Drawing.Color.White;
            this.btnLibroDiario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibroDiario.IconSize = 48;
            this.btnLibroDiario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibroDiario.Location = new System.Drawing.Point(0, 199);
            this.btnLibroDiario.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnLibroDiario.Name = "btnLibroDiario";
            this.btnLibroDiario.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLibroDiario.Rotation = 0D;
            this.btnLibroDiario.Size = new System.Drawing.Size(252, 60);
            this.btnLibroDiario.TabIndex = 17;
            this.btnLibroDiario.Text = "Libro Diario";
            this.btnLibroDiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibroDiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibroDiario.UseVisualStyleBackColor = true;
            this.btnLibroDiario.Click += new System.EventHandler(this.btnLibroDiario_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnInicio.IconColor = System.Drawing.Color.White;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 48;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 139);
            this.btnInicio.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnInicio.Rotation = 0D;
            this.btnInicio.Size = new System.Drawing.Size(252, 60);
            this.btnInicio.TabIndex = 16;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 48;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 79);
            this.btnMenu.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenu.Rotation = 0D;
            this.btnMenu.Size = new System.Drawing.Size(252, 60);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.AnimacionPanelNavegacion.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacionBack.SetDecoration(this.pbLogo, BunifuAnimatorNS.DecorationType.None);
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(252, 79);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnRestoreWindow);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnExit);
            this.AnimacionPanelNavegacionBack.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(252, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(948, 40);
            this.panelTop.TabIndex = 5;
            // 
            // btnMinimizar
            // 
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 35;
            this.btnMinimizar.Location = new System.Drawing.Point(744, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0D;
            this.btnMinimizar.Size = new System.Drawing.Size(51, 40);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestoreWindow
            // 
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnRestoreWindow, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnRestoreWindow, BunifuAnimatorNS.DecorationType.None);
            this.btnRestoreWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestoreWindow.FlatAppearance.BorderSize = 0;
            this.btnRestoreWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreWindow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRestoreWindow.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestoreWindow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnRestoreWindow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestoreWindow.IconSize = 35;
            this.btnRestoreWindow.Location = new System.Drawing.Point(795, 0);
            this.btnRestoreWindow.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreWindow.Name = "btnRestoreWindow";
            this.btnRestoreWindow.Rotation = 0D;
            this.btnRestoreWindow.Size = new System.Drawing.Size(51, 40);
            this.btnRestoreWindow.TabIndex = 3;
            this.btnRestoreWindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestoreWindow.UseVisualStyleBackColor = true;
            this.btnRestoreWindow.Visible = false;
            this.btnRestoreWindow.Click += new System.EventHandler(this.btnRestoreWindow_Click);
            // 
            // btnMaximizar
            // 
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 35;
            this.btnMaximizar.Location = new System.Drawing.Point(846, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Rotation = 0D;
            this.btnMaximizar.Size = new System.Drawing.Size(51, 40);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnExit
            // 
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(47)))), ((int)(((byte)(6)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 35;
            this.btnExit.Location = new System.Drawing.Point(897, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(51, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.panelContenido);
            this.panelContenedor.Controls.Add(this.panelBottom);
            this.panelContenedor.Controls.Add(this.panelTop);
            this.panelContenedor.Controls.Add(this.panelNavegacion);
            this.AnimacionPanelNavegacionBack.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.panelContenedor, BunifuAnimatorNS.DecorationType.None);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1200, 760);
            this.panelContenedor.TabIndex = 3;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Controls.Add(this.panel3);
            this.AnimacionPanelNavegacionBack.SetDecoration(this.panelContenido, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.panelContenido, BunifuAnimatorNS.DecorationType.None);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(252, 40);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(948, 674);
            this.panelContenido.TabIndex = 8;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panel1);
            this.AnimacionPanelNavegacionBack.SetDecoration(this.panelBottom, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.panelBottom, BunifuAnimatorNS.DecorationType.None);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(252, 714);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(948, 46);
            this.panelBottom.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnAddLibroDiario);
            this.panel1.Controls.Add(this.btnDeleteLibroDiario);
            this.panel1.Controls.Add(this.lblPagina);
            this.panel1.Controls.Add(this.btnPrevious);
            this.AnimacionPanelNavegacionBack.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(354, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(314, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnAddLibroDiario
            // 
            this.btnAddLibroDiario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLibroDiario.BackColor = System.Drawing.Color.Transparent;
            this.btnAddLibroDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnAddLibroDiario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnAddLibroDiario, BunifuAnimatorNS.DecorationType.None);
            this.btnAddLibroDiario.FlatAppearance.BorderSize = 0;
            this.btnAddLibroDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLibroDiario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddLibroDiario.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddLibroDiario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(50)))));
            this.btnAddLibroDiario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddLibroDiario.IconSize = 28;
            this.btnAddLibroDiario.Location = new System.Drawing.Point(207, 0);
            this.btnAddLibroDiario.MaximumSize = new System.Drawing.Size(43, 43);
            this.btnAddLibroDiario.Name = "btnAddLibroDiario";
            this.btnAddLibroDiario.Rotation = 0D;
            this.btnAddLibroDiario.Size = new System.Drawing.Size(43, 43);
            this.btnAddLibroDiario.TabIndex = 2;
            this.btnAddLibroDiario.UseVisualStyleBackColor = false;
            this.btnAddLibroDiario.Click += new System.EventHandler(this.btnAddLibroDiario_Click);
            // 
            // btnDeleteLibroDiario
            // 
            this.btnDeleteLibroDiario.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteLibroDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnDeleteLibroDiario, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnDeleteLibroDiario, BunifuAnimatorNS.DecorationType.None);
            this.btnDeleteLibroDiario.FlatAppearance.BorderSize = 0;
            this.btnDeleteLibroDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLibroDiario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDeleteLibroDiario.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteLibroDiario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnDeleteLibroDiario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDeleteLibroDiario.IconSize = 28;
            this.btnDeleteLibroDiario.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteLibroDiario.MaximumSize = new System.Drawing.Size(43, 43);
            this.btnDeleteLibroDiario.Name = "btnDeleteLibroDiario";
            this.btnDeleteLibroDiario.Rotation = 0D;
            this.btnDeleteLibroDiario.Size = new System.Drawing.Size(43, 43);
            this.btnDeleteLibroDiario.TabIndex = 3;
            this.btnDeleteLibroDiario.UseVisualStyleBackColor = false;
            this.btnDeleteLibroDiario.Click += new System.EventHandler(this.btnDeleteLibroDiario_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AnimacionPanelNavegacion.SetDecoration(this.lblPagina, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacionBack.SetDecoration(this.lblPagina, BunifuAnimatorNS.DecorationType.None);
            this.lblPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(110, -1);
            this.lblPagina.MaximumSize = new System.Drawing.Size(45, 43);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(40, 43);
            this.lblPagina.TabIndex = 1;
            this.lblPagina.Text = "Pag";
            this.lblPagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnNext, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnNext, BunifuAnimatorNS.DecorationType.None);
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.btnNext.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 28;
            this.btnNext.Location = new System.Drawing.Point(152, 0);
            this.btnNext.MaximumSize = new System.Drawing.Size(43, 43);
            this.btnNext.MinimumSize = new System.Drawing.Size(43, 43);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0D;
            this.btnNext.Size = new System.Drawing.Size(43, 43);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionPanelNavegacionBack.SetDecoration(this.btnPrevious, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.btnPrevious, BunifuAnimatorNS.DecorationType.None);
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.btnPrevious.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.IconSize = 28;
            this.btnPrevious.Location = new System.Drawing.Point(61, 0);
            this.btnPrevious.MaximumSize = new System.Drawing.Size(43, 43);
            this.btnPrevious.MinimumSize = new System.Drawing.Size(43, 43);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Rotation = 0D;
            this.btnPrevious.Size = new System.Drawing.Size(43, 43);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // AnimacionPanelNavegacionBack
            // 
            this.AnimacionPanelNavegacionBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimacionPanelNavegacionBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionPanelNavegacionBack.DefaultAnimation = animation2;
            // 
            // MoverVentanaLogo
            // 
            this.MoverVentanaLogo.Fixed = true;
            this.MoverVentanaLogo.Horizontal = true;
            this.MoverVentanaLogo.TargetControl = this.pbLogo;
            this.MoverVentanaLogo.Vertical = true;
            // 
            // MoverVentanaPanelTop
            // 
            this.MoverVentanaPanelTop.Fixed = true;
            this.MoverVentanaPanelTop.Horizontal = true;
            this.MoverVentanaPanelTop.TargetControl = this.panelTop;
            this.MoverVentanaPanelTop.Vertical = true;
            // 
            // panel2
            // 
            this.AnimacionPanelNavegacionBack.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(252, 714);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 46);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionPanelNavegacionBack.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(720, 674);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 46);
            this.panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.panelContenedor);
            this.AnimacionPanelNavegacionBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionPanelNavegacion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(720, 640);
            this.Name = "MainForm";
            this.Text = "Sistemas Contables";
            this.panelNavegacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition AnimacionPanelNavegacionBack;
        private BunifuAnimatorNS.BunifuTransition AnimacionPanelNavegacion;
        private System.Windows.Forms.Panel panelNavegacion;
        private FontAwesome.Sharp.IconButton btnBalanceGeneral;
        private FontAwesome.Sharp.IconButton btnEstadoDeResultados;
        private FontAwesome.Sharp.IconButton btnBalanceDeComprobacion;
        private FontAwesome.Sharp.IconButton btnLibroMayor;
        private FontAwesome.Sharp.IconButton btnLibroDiario;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnRestoreWindow;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuDragControl MoverVentanaLogo;
        private Bunifu.Framework.UI.BunifuDragControl MoverVentanaPanelTop;
        private System.Windows.Forms.Panel panelBottom;
        private FontAwesome.Sharp.IconButton btnPrevious;
        private System.Windows.Forms.Panel panelContenido;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnDeleteLibroDiario;
        private FontAwesome.Sharp.IconButton btnAddLibroDiario;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

