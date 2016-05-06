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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lsB_Resultados = new System.Windows.Forms.ListBox();
            this.picB_Pocima = new System.Windows.Forms.PictureBox();
            this.btn_GenXML = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Pocima)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerarPocima);
            // 
            // lsB_Resultados
            // 
            this.lsB_Resultados.FormattingEnabled = true;
            this.lsB_Resultados.Location = new System.Drawing.Point(119, 12);
            this.lsB_Resultados.Name = "lsB_Resultados";
            this.lsB_Resultados.Size = new System.Drawing.Size(421, 225);
            this.lsB_Resultados.TabIndex = 1;
            // 
            // picB_Pocima
            // 
            this.picB_Pocima.Image = global::GeneradorPociones.recursos.pocima;
            this.picB_Pocima.InitialImage = null;
            this.picB_Pocima.Location = new System.Drawing.Point(12, 12);
            this.picB_Pocima.Name = "picB_Pocima";
            this.picB_Pocima.Size = new System.Drawing.Size(101, 106);
            this.picB_Pocima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB_Pocima.TabIndex = 2;
            this.picB_Pocima.TabStop = false;
            // 
            // btn_GenXML
            // 
            this.btn_GenXML.Location = new System.Drawing.Point(12, 165);
            this.btn_GenXML.Name = "btn_GenXML";
            this.btn_GenXML.Size = new System.Drawing.Size(101, 35);
            this.btn_GenXML.TabIndex = 3;
            this.btn_GenXML.Text = "Generar XML";
            this.btn_GenXML.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 43);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pociones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // formPociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_GenXML);
            this.Controls.Add(this.picB_Pocima);
            this.Controls.Add(this.lsB_Resultados);
            this.Controls.Add(this.button1);
            this.Name = "formPociones";
            this.Text = "Generador de pociones";
            ((System.ComponentModel.ISupportInitialize)(this.picB_Pocima)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsB_Resultados;
        private System.Windows.Forms.PictureBox picB_Pocima;
        private System.Windows.Forms.Button btn_GenXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

