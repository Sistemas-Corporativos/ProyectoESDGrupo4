namespace ProyectoESDGrupo4.Forms
{
    partial class frmEstacionPrimeraVez
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
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estación Primera Vez";
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(11, 48);
            this.dgvSolicitudes.MultiSelect = false;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(1099, 393);
            this.dgvSolicitudes.TabIndex = 5;
            // 
            // frmEstacionPrimeraVez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSolicitudes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstacionPrimeraVez";
            this.Text = "Estacion Primera Vez";
            this.Load += new System.EventHandler(this.frmEstacionPrimeraVez_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
    }
}