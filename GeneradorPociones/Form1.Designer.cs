﻿namespace GeneradorPociones
{
    partial class formPociones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPociones));
            this.btn_GenPocion = new System.Windows.Forms.Button();
            this.lsB_Resultados = new System.Windows.Forms.ListBox();
            this.picB_Pocima = new System.Windows.Forms.PictureBox();
            this.grB_Contador = new System.Windows.Forms.GroupBox();
            this.lbl_NPociones = new System.Windows.Forms.Label();
            this.menuUsuario = new System.Windows.Forms.MenuStrip();
            this.archiv_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevo_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardar_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genHTML_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genXML_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sFD_GuardarXML = new System.Windows.Forms.SaveFileDialog();
            this.sFD_GuardarHTML = new System.Windows.Forms.SaveFileDialog();
            this.sFD_GuardarRTF = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkB_CE = new System.Windows.Forms.CheckBox();
            this.chkB_TOS = new System.Windows.Forms.CheckBox();
            this.chkB_Detalles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Pocima)).BeginInit();
            this.grB_Contador.SuspendLayout();
            this.menuUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GenPocion
            // 
            this.btn_GenPocion.Location = new System.Drawing.Point(42, 249);
            this.btn_GenPocion.Name = "btn_GenPocion";
            this.btn_GenPocion.Size = new System.Drawing.Size(101, 35);
            this.btn_GenPocion.TabIndex = 0;
            this.btn_GenPocion.Text = "Generar";
            this.btn_GenPocion.UseVisualStyleBackColor = true;
            this.btn_GenPocion.Click += new System.EventHandler(this.GenerarPocima);
            // 
            // lsB_Resultados
            // 
            this.lsB_Resultados.FormattingEnabled = true;
            this.lsB_Resultados.Location = new System.Drawing.Point(162, 36);
            this.lsB_Resultados.Name = "lsB_Resultados";
            this.lsB_Resultados.Size = new System.Drawing.Size(478, 290);
            this.lsB_Resultados.TabIndex = 1;
            // 
            // picB_Pocima
            // 
            this.picB_Pocima.Image = global::GeneradorPociones.recursos.pxA_pocion;
            this.picB_Pocima.InitialImage = null;
            this.picB_Pocima.Location = new System.Drawing.Point(42, 44);
            this.picB_Pocima.Name = "picB_Pocima";
            this.picB_Pocima.Size = new System.Drawing.Size(101, 106);
            this.picB_Pocima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB_Pocima.TabIndex = 2;
            this.picB_Pocima.TabStop = false;
            // 
            // grB_Contador
            // 
            this.grB_Contador.Controls.Add(this.lbl_NPociones);
            this.grB_Contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grB_Contador.Location = new System.Drawing.Point(42, 289);
            this.grB_Contador.Name = "grB_Contador";
            this.grB_Contador.Size = new System.Drawing.Size(101, 48);
            this.grB_Contador.TabIndex = 4;
            this.grB_Contador.TabStop = false;
            this.grB_Contador.Text = "Pociones";
            // 
            // lbl_NPociones
            // 
            this.lbl_NPociones.AutoSize = true;
            this.lbl_NPociones.Location = new System.Drawing.Point(34, 20);
            this.lbl_NPociones.Name = "lbl_NPociones";
            this.lbl_NPociones.Size = new System.Drawing.Size(16, 18);
            this.lbl_NPociones.TabIndex = 0;
            this.lbl_NPociones.Text = "0";
            // 
            // menuUsuario
            // 
            this.menuUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiv_MenuItem,
            this.guardar_MenuItem,
            this.info_MenuItem});
            this.menuUsuario.Location = new System.Drawing.Point(0, 0);
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(652, 28);
            this.menuUsuario.TabIndex = 5;
            this.menuUsuario.Text = "menuStrip1";
            // 
            // archiv_MenuItem
            // 
            this.archiv_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevo_MenuItem});
            this.archiv_MenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.archiv_MenuItem.Image = global::GeneradorPociones.recursos.file;
            this.archiv_MenuItem.Name = "archiv_MenuItem";
            this.archiv_MenuItem.Size = new System.Drawing.Size(87, 24);
            this.archiv_MenuItem.Text = "Archivo";
            // 
            // nuevo_MenuItem
            // 
            this.nuevo_MenuItem.Name = "nuevo_MenuItem";
            this.nuevo_MenuItem.Size = new System.Drawing.Size(121, 24);
            this.nuevo_MenuItem.Text = "Nuevo";
            this.nuevo_MenuItem.Click += new System.EventHandler(this.nuevo_MenuItem_Click);
            // 
            // guardar_MenuItem
            // 
            this.guardar_MenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genHTML_MenuItem,
            this.genXML_MenuItem,
            this.rTFToolStripMenuItem});
            this.guardar_MenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guardar_MenuItem.Image = global::GeneradorPociones.recursos.content_save;
            this.guardar_MenuItem.Name = "guardar_MenuItem";
            this.guardar_MenuItem.Size = new System.Drawing.Size(90, 24);
            this.guardar_MenuItem.Text = "Guardar";
            // 
            // genHTML_MenuItem
            // 
            this.genHTML_MenuItem.Name = "genHTML_MenuItem";
            this.genHTML_MenuItem.Size = new System.Drawing.Size(117, 24);
            this.genHTML_MenuItem.Text = "HTML";
            this.genHTML_MenuItem.Click += new System.EventHandler(this.genHTML_MenuItem_Click);
            // 
            // genXML_MenuItem
            // 
            this.genXML_MenuItem.Name = "genXML_MenuItem";
            this.genXML_MenuItem.Size = new System.Drawing.Size(117, 24);
            this.genXML_MenuItem.Text = "XML";
            this.genXML_MenuItem.Click += new System.EventHandler(this.genXML_MenuItem_Click);
            // 
            // rTFToolStripMenuItem
            // 
            this.rTFToolStripMenuItem.Name = "rTFToolStripMenuItem";
            this.rTFToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.rTFToolStripMenuItem.Text = "RTF";
            this.rTFToolStripMenuItem.Click += new System.EventHandler(this.genRTF_MenuItem_Click);
            // 
            // info_MenuItem
            // 
            this.info_MenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.info_MenuItem.Image = global::GeneradorPociones.recursos.web;
            this.info_MenuItem.Name = "info_MenuItem";
            this.info_MenuItem.Size = new System.Drawing.Size(128, 24);
            this.info_MenuItem.Text = "Desarrollador";
            this.info_MenuItem.Click += new System.EventHandler(this.info_MenuItem_Click);
            // 
            // sFD_GuardarXML
            // 
            this.sFD_GuardarXML.DefaultExt = "xml";
            this.sFD_GuardarXML.FileName = "XML";
            this.sFD_GuardarXML.Filter = "XML | *.xml";
            // 
            // sFD_GuardarHTML
            // 
            this.sFD_GuardarHTML.DefaultExt = "html";
            this.sFD_GuardarHTML.FileName = "HTML";
            this.sFD_GuardarHTML.Filter = "HTML | *.html | HTM | *.htm";
            // 
            // sFD_GuardarRTF
            // 
            this.sFD_GuardarRTF.DefaultExt = "rtf";
            this.sFD_GuardarRTF.FileName = "Fichero RTF";
            this.sFD_GuardarRTF.Filter = "RTF | *.RTF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkB_Detalles);
            this.groupBox1.Controls.Add(this.chkB_TOS);
            this.groupBox1.Controls.Add(this.chkB_CE);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 87);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pociones";
            // 
            // chkB_CE
            // 
            this.chkB_CE.AutoSize = true;
            this.chkB_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB_CE.Location = new System.Drawing.Point(11, 23);
            this.chkB_CE.Name = "chkB_CE";
            this.chkB_CE.Size = new System.Drawing.Size(130, 17);
            this.chkB_CE.TabIndex = 1;
            this.chkB_CE.Text = "Contenedor y etiqueta";
            this.chkB_CE.UseVisualStyleBackColor = true;
            this.chkB_CE.CheckedChanged += new System.EventHandler(this.chkB_CE_CheckedChanged);
            // 
            // chkB_TOS
            // 
            this.chkB_TOS.AutoSize = true;
            this.chkB_TOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB_TOS.Location = new System.Drawing.Point(11, 46);
            this.chkB_TOS.Name = "chkB_TOS";
            this.chkB_TOS.Size = new System.Drawing.Size(120, 17);
            this.chkB_TOS.TabIndex = 2;
            this.chkB_TOS.Text = "Olor, sabor y textura";
            this.chkB_TOS.UseVisualStyleBackColor = true;
            this.chkB_TOS.CheckedChanged += new System.EventHandler(this.chkB_TOS_CheckedChanged);
            // 
            // chkB_Detalles
            // 
            this.chkB_Detalles.AutoSize = true;
            this.chkB_Detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB_Detalles.Location = new System.Drawing.Point(11, 69);
            this.chkB_Detalles.Name = "chkB_Detalles";
            this.chkB_Detalles.Size = new System.Drawing.Size(64, 17);
            this.chkB_Detalles.TabIndex = 3;
            this.chkB_Detalles.Text = "Detalles";
            this.chkB_Detalles.UseVisualStyleBackColor = true;
            this.chkB_Detalles.CheckedChanged += new System.EventHandler(this.chkB_Detalles_CheckedChanged);
            // 
            // formPociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grB_Contador);
            this.Controls.Add(this.picB_Pocima);
            this.Controls.Add(this.lsB_Resultados);
            this.Controls.Add(this.btn_GenPocion);
            this.Controls.Add(this.menuUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuUsuario;
            this.MaximizeBox = false;
            this.Name = "formPociones";
            this.Text = "Generador de pociones";
            ((System.ComponentModel.ISupportInitialize)(this.picB_Pocima)).EndInit();
            this.grB_Contador.ResumeLayout(false);
            this.grB_Contador.PerformLayout();
            this.menuUsuario.ResumeLayout(false);
            this.menuUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_GenPocion;
        private System.Windows.Forms.ListBox lsB_Resultados;
        private System.Windows.Forms.PictureBox picB_Pocima;
        private System.Windows.Forms.GroupBox grB_Contador;
        private System.Windows.Forms.Label lbl_NPociones;
        private System.Windows.Forms.MenuStrip menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem archiv_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevo_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardar_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem genHTML_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem genXML_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem info_MenuItem;
        private System.Windows.Forms.SaveFileDialog sFD_GuardarXML;
        private System.Windows.Forms.SaveFileDialog sFD_GuardarHTML;
        private System.Windows.Forms.ToolStripMenuItem rTFToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sFD_GuardarRTF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkB_Detalles;
        private System.Windows.Forms.CheckBox chkB_TOS;
        private System.Windows.Forms.CheckBox chkB_CE;
    }
}

