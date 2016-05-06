namespace GeneradorPociones
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
            this.info_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sFD_GuardarXML = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Pocima)).BeginInit();
            this.grB_Contador.SuspendLayout();
            this.menuUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_GenPocion
            // 
            this.btn_GenPocion.Location = new System.Drawing.Point(12, 147);
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
            this.lsB_Resultados.Location = new System.Drawing.Point(119, 35);
            this.lsB_Resultados.Name = "lsB_Resultados";
            this.lsB_Resultados.Size = new System.Drawing.Size(421, 199);
            this.lsB_Resultados.TabIndex = 1;
            // 
            // picB_Pocima
            // 
            this.picB_Pocima.Image = global::GeneradorPociones.recursos.pxA_pocion;
            this.picB_Pocima.InitialImage = null;
            this.picB_Pocima.Location = new System.Drawing.Point(12, 35);
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
            this.grB_Contador.Location = new System.Drawing.Point(12, 188);
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
            this.menuUsuario.Size = new System.Drawing.Size(552, 28);
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
            this.genXML_MenuItem});
            this.guardar_MenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guardar_MenuItem.Image = global::GeneradorPociones.recursos.content_save;
            this.guardar_MenuItem.Name = "guardar_MenuItem";
            this.guardar_MenuItem.Size = new System.Drawing.Size(90, 24);
            this.guardar_MenuItem.Text = "Guardar";
            // 
            // genHTML_MenuItem
            // 
            this.genHTML_MenuItem.Name = "genHTML_MenuItem";
            this.genHTML_MenuItem.Size = new System.Drawing.Size(152, 24);
            this.genHTML_MenuItem.Text = "HTML";
            this.genHTML_MenuItem.Click += new System.EventHandler(this.genHTML_MenuItem_Click);
            // 
            // genXML_MenuItem
            // 
            this.genXML_MenuItem.Name = "genXML_MenuItem";
            this.genXML_MenuItem.Size = new System.Drawing.Size(152, 24);
            this.genXML_MenuItem.Text = "XML";
            this.genXML_MenuItem.Click += new System.EventHandler(this.genXML_MenuItem_Click);
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
            // formPociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 250);
            this.Controls.Add(this.grB_Contador);
            this.Controls.Add(this.picB_Pocima);
            this.Controls.Add(this.lsB_Resultados);
            this.Controls.Add(this.btn_GenPocion);
            this.Controls.Add(this.menuUsuario);
            this.MainMenuStrip = this.menuUsuario;
            this.MaximizeBox = false;
            this.Name = "formPociones";
            this.Text = "Generador de pociones";
            ((System.ComponentModel.ISupportInitialize)(this.picB_Pocima)).EndInit();
            this.grB_Contador.ResumeLayout(false);
            this.grB_Contador.PerformLayout();
            this.menuUsuario.ResumeLayout(false);
            this.menuUsuario.PerformLayout();
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
    }
}

