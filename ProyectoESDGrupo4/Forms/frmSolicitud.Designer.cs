namespace ProyectoESDGrupo4.Forms
{
    partial class frmSolicitud
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
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipoSolicitante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoTramite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPersonaTramite = new System.Windows.Forms.ComboBox();
            this.gbxSolicitante = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccionSolicitante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdadSolicitante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomSolicitante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumDocSolicitante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoDocSolicitante = new System.Windows.Forms.ComboBox();
            this.gbxApoderado = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccionApoderado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEdadApoderado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreApoderado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumDocApoderado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxTipoDocApoderado = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxInfo.SuspendLayout();
            this.gbxSolicitante.SuspendLayout();
            this.gbxApoderado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.label3);
            this.gbxInfo.Controls.Add(this.cbxTipoSolicitante);
            this.gbxInfo.Controls.Add(this.label2);
            this.gbxInfo.Controls.Add(this.cbxTipoTramite);
            this.gbxInfo.Controls.Add(this.label1);
            this.gbxInfo.Controls.Add(this.cbxPersonaTramite);
            this.gbxInfo.Location = new System.Drawing.Point(18, 54);
            this.gbxInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxInfo.Size = new System.Drawing.Size(422, 298);
            this.gbxInfo.TabIndex = 0;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Información de Tramite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Nacionalidad del Solicitante :";
            // 
            // cbxTipoSolicitante
            // 
            this.cbxTipoSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoSolicitante.FormattingEnabled = true;
            this.cbxTipoSolicitante.Items.AddRange(new object[] {
            "Salvadoreño",
            "Extranjero"});
            this.cbxTipoSolicitante.Location = new System.Drawing.Point(14, 234);
            this.cbxTipoSolicitante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTipoSolicitante.Name = "cbxTipoSolicitante";
            this.cbxTipoSolicitante.Size = new System.Drawing.Size(268, 28);
            this.cbxTipoSolicitante.TabIndex = 4;
            this.cbxTipoSolicitante.SelectedIndexChanged += new System.EventHandler(this.cbxTipoSolicitante_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Tramite :";
            // 
            // cbxTipoTramite
            // 
            this.cbxTipoTramite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoTramite.FormattingEnabled = true;
            this.cbxTipoTramite.Items.AddRange(new object[] {
            "Primera_Vez",
            "Reposicion"});
            this.cbxTipoTramite.Location = new System.Drawing.Point(14, 154);
            this.cbxTipoTramite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTipoTramite.Name = "cbxTipoTramite";
            this.cbxTipoTramite.Size = new System.Drawing.Size(268, 28);
            this.cbxTipoTramite.TabIndex = 2;
            this.cbxTipoTramite.SelectedIndexChanged += new System.EventHandler(this.cbxTipoTramite_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Persona que Realiza el Tramite :";
            // 
            // cbxPersonaTramite
            // 
            this.cbxPersonaTramite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonaTramite.FormattingEnabled = true;
            this.cbxPersonaTramite.Items.AddRange(new object[] {
            "Personal",
            "Persona_Autorizada",
            "Apoderado"});
            this.cbxPersonaTramite.Location = new System.Drawing.Point(14, 66);
            this.cbxPersonaTramite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPersonaTramite.Name = "cbxPersonaTramite";
            this.cbxPersonaTramite.Size = new System.Drawing.Size(337, 28);
            this.cbxPersonaTramite.TabIndex = 0;
            this.cbxPersonaTramite.SelectedIndexChanged += new System.EventHandler(this.cbxPersonaTramite_SelectedIndexChanged);
            // 
            // gbxSolicitante
            // 
            this.gbxSolicitante.Controls.Add(this.label8);
            this.gbxSolicitante.Controls.Add(this.txtDireccionSolicitante);
            this.gbxSolicitante.Controls.Add(this.label7);
            this.gbxSolicitante.Controls.Add(this.txtEdadSolicitante);
            this.gbxSolicitante.Controls.Add(this.label6);
            this.gbxSolicitante.Controls.Add(this.txtNomSolicitante);
            this.gbxSolicitante.Controls.Add(this.label5);
            this.gbxSolicitante.Controls.Add(this.txtNumDocSolicitante);
            this.gbxSolicitante.Controls.Add(this.label4);
            this.gbxSolicitante.Controls.Add(this.cbxTipoDocSolicitante);
            this.gbxSolicitante.Location = new System.Drawing.Point(18, 362);
            this.gbxSolicitante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxSolicitante.Name = "gbxSolicitante";
            this.gbxSolicitante.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxSolicitante.Size = new System.Drawing.Size(450, 477);
            this.gbxSolicitante.TabIndex = 1;
            this.gbxSolicitante.TabStop = false;
            this.gbxSolicitante.Text = "Datos del Solicitante";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dirección :";
            // 
            // txtDireccionSolicitante
            // 
            this.txtDireccionSolicitante.Location = new System.Drawing.Point(14, 371);
            this.txtDireccionSolicitante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccionSolicitante.Multiline = true;
            this.txtDireccionSolicitante.Name = "txtDireccionSolicitante";
            this.txtDireccionSolicitante.Size = new System.Drawing.Size(406, 95);
            this.txtDireccionSolicitante.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edad :";
            // 
            // txtEdadSolicitante
            // 
            this.txtEdadSolicitante.Location = new System.Drawing.Point(14, 295);
            this.txtEdadSolicitante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdadSolicitante.Name = "txtEdadSolicitante";
            this.txtEdadSolicitante.Size = new System.Drawing.Size(124, 26);
            this.txtEdadSolicitante.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre :";
            // 
            // txtNomSolicitante
            // 
            this.txtNomSolicitante.Location = new System.Drawing.Point(14, 218);
            this.txtNomSolicitante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomSolicitante.Name = "txtNomSolicitante";
            this.txtNomSolicitante.Size = new System.Drawing.Size(406, 26);
            this.txtNomSolicitante.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "No de Documento :";
            // 
            // txtNumDocSolicitante
            // 
            this.txtNumDocSolicitante.Location = new System.Drawing.Point(14, 142);
            this.txtNumDocSolicitante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumDocSolicitante.Name = "txtNumDocSolicitante";
            this.txtNumDocSolicitante.Size = new System.Drawing.Size(268, 26);
            this.txtNumDocSolicitante.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Documento :";
            // 
            // cbxTipoDocSolicitante
            // 
            this.cbxTipoDocSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDocSolicitante.FormattingEnabled = true;
            this.cbxTipoDocSolicitante.Items.AddRange(new object[] {
            "Dui",
            "Pasaporte",
            "Carnet_Residente"});
            this.cbxTipoDocSolicitante.Location = new System.Drawing.Point(14, 62);
            this.cbxTipoDocSolicitante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTipoDocSolicitante.Name = "cbxTipoDocSolicitante";
            this.cbxTipoDocSolicitante.Size = new System.Drawing.Size(268, 28);
            this.cbxTipoDocSolicitante.TabIndex = 6;
            this.cbxTipoDocSolicitante.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDocSolicitante_SelectedIndexChanged);
            // 
            // gbxApoderado
            // 
            this.gbxApoderado.Controls.Add(this.label9);
            this.gbxApoderado.Controls.Add(this.txtDireccionApoderado);
            this.gbxApoderado.Controls.Add(this.label10);
            this.gbxApoderado.Controls.Add(this.txtEdadApoderado);
            this.gbxApoderado.Controls.Add(this.label11);
            this.gbxApoderado.Controls.Add(this.txtNombreApoderado);
            this.gbxApoderado.Controls.Add(this.label12);
            this.gbxApoderado.Controls.Add(this.txtNumDocApoderado);
            this.gbxApoderado.Controls.Add(this.label13);
            this.gbxApoderado.Controls.Add(this.cbxTipoDocApoderado);
            this.gbxApoderado.Location = new System.Drawing.Point(512, 362);
            this.gbxApoderado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxApoderado.Name = "gbxApoderado";
            this.gbxApoderado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxApoderado.Size = new System.Drawing.Size(446, 477);
            this.gbxApoderado.TabIndex = 2;
            this.gbxApoderado.TabStop = false;
            this.gbxApoderado.Text = "Datos del Apoderado / Persona Autorizada";
            this.gbxApoderado.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Dirección :";
            // 
            // txtDireccionApoderado
            // 
            this.txtDireccionApoderado.Location = new System.Drawing.Point(9, 371);
            this.txtDireccionApoderado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccionApoderado.Multiline = true;
            this.txtDireccionApoderado.Name = "txtDireccionApoderado";
            this.txtDireccionApoderado.Size = new System.Drawing.Size(406, 95);
            this.txtDireccionApoderado.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 271);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Edad :";
            // 
            // txtEdadApoderado
            // 
            this.txtEdadApoderado.Location = new System.Drawing.Point(9, 295);
            this.txtEdadApoderado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdadApoderado.Name = "txtEdadApoderado";
            this.txtEdadApoderado.Size = new System.Drawing.Size(108, 26);
            this.txtEdadApoderado.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 194);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nombre :";
            // 
            // txtNombreApoderado
            // 
            this.txtNombreApoderado.Location = new System.Drawing.Point(9, 218);
            this.txtNombreApoderado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreApoderado.Name = "txtNombreApoderado";
            this.txtNombreApoderado.Size = new System.Drawing.Size(406, 26);
            this.txtNombreApoderado.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "No de Documento :";
            // 
            // txtNumDocApoderado
            // 
            this.txtNumDocApoderado.Location = new System.Drawing.Point(9, 142);
            this.txtNumDocApoderado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumDocApoderado.Name = "txtNumDocApoderado";
            this.txtNumDocApoderado.Size = new System.Drawing.Size(268, 26);
            this.txtNumDocApoderado.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Tipo de Documento :";
            // 
            // cbxTipoDocApoderado
            // 
            this.cbxTipoDocApoderado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDocApoderado.FormattingEnabled = true;
            this.cbxTipoDocApoderado.Items.AddRange(new object[] {
            "Dui",
            "Pasaporte",
            "Carnet_Residente"});
            this.cbxTipoDocApoderado.Location = new System.Drawing.Point(9, 62);
            this.cbxTipoDocApoderado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTipoDocApoderado.Name = "cbxTipoDocApoderado";
            this.cbxTipoDocApoderado.Size = new System.Drawing.Size(268, 28);
            this.cbxTipoDocApoderado.TabIndex = 16;
            this.cbxTipoDocApoderado.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDocApoderado_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoESDGrupo4.Properties.Resources.Error_icon;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(154, 866);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(402, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(237, 33);
            this.label14.TabIndex = 6;
            this.label14.Text = "Solicitud de NIT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoESDGrupo4.Properties.Resources.Nit;
            this.pictureBox1.Location = new System.Drawing.Point(453, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ProyectoESDGrupo4.Properties.Resources.Save_icon;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(18, 866);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1016, 925);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbxApoderado);
            this.Controls.Add(this.gbxSolicitante);
            this.Controls.Add(this.gbxInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmSolicitud";
            this.Text = "Solicitud";
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.gbxSolicitante.ResumeLayout(false);
            this.gbxSolicitante.PerformLayout();
            this.gbxApoderado.ResumeLayout(false);
            this.gbxApoderado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoTramite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPersonaTramite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipoSolicitante;
        private System.Windows.Forms.GroupBox gbxSolicitante;
        private System.Windows.Forms.GroupBox gbxApoderado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoDocSolicitante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccionSolicitante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdadSolicitante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomSolicitante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumDocSolicitante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccionApoderado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEdadApoderado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreApoderado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumDocApoderado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxTipoDocApoderado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
    }
}