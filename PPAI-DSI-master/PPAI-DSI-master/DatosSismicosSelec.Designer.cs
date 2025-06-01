namespace PPAI_DSI.Interfaz
{
    partial class DatosSismicosSelec
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDatosGenerales = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSeriesTemporales = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosGenerales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeriesTemporales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evento Sísmico Seleccionado: ";
            // 
            // dataGridViewDatosGenerales
            // 
            this.dataGridViewDatosGenerales.AllowUserToAddRows = false;
            this.dataGridViewDatosGenerales.AllowUserToDeleteRows = false;
            this.dataGridViewDatosGenerales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDatosGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosGenerales.Location = new System.Drawing.Point(17, 88);
            this.dataGridViewDatosGenerales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDatosGenerales.Name = "dataGridViewDatosGenerales";
            this.dataGridViewDatosGenerales.ReadOnly = true;
            this.dataGridViewDatosGenerales.RowHeadersWidth = 62;
            this.dataGridViewDatosGenerales.RowTemplate.Height = 28;
            this.dataGridViewDatosGenerales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDatosGenerales.Size = new System.Drawing.Size(1098, 70);
            this.dataGridViewDatosGenerales.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Series Temporales del Evento:";
            // 
            // dataGridViewSeriesTemporales
            // 
            this.dataGridViewSeriesTemporales.AllowUserToAddRows = false;
            this.dataGridViewSeriesTemporales.AllowUserToDeleteRows = false;
            this.dataGridViewSeriesTemporales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSeriesTemporales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeriesTemporales.Location = new System.Drawing.Point(61, 222);
            this.dataGridViewSeriesTemporales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSeriesTemporales.Name = "dataGridViewSeriesTemporales";
            this.dataGridViewSeriesTemporales.ReadOnly = true;
            this.dataGridViewSeriesTemporales.RowHeadersWidth = 62;
            this.dataGridViewSeriesTemporales.RowTemplate.Height = 28;
            this.dataGridViewSeriesTemporales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeriesTemporales.Size = new System.Drawing.Size(1054, 225);
            this.dataGridViewSeriesTemporales.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(856, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(17, 486);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 76);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DatosSismicosSelec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 601);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSeriesTemporales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDatosGenerales);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DatosSismicosSelec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizacion Datos";
            this.Load += new System.EventHandler(this.DatosSismicosSelec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosGenerales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeriesTemporales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDatosGenerales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSeriesTemporales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}