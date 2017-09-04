namespace FastBeats.View
{
    partial class frmConsultarAgenda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarAgenda));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.mdtpData = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mtxtEvento = new MetroFramework.Controls.MetroTextBox();
            this.mdgvEventos = new MetroFramework.Controls.MetroGrid();
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.mPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // mPanel
            // 
            this.mPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel.Controls.Add(this.metroLabel11);
            this.mPanel.Controls.Add(this.mdtpData);
            this.mPanel.Controls.Add(this.metroLabel13);
            this.mPanel.Controls.Add(this.mtxtEvento);
            this.mPanel.Controls.Add(this.mdgvEventos);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(122, 84);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(687, 252);
            this.mPanel.TabIndex = 26;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(7, 53);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(39, 19);
            this.metroLabel11.TabIndex = 65;
            this.metroLabel11.Text = "Data:";
            // 
            // mdtpData
            // 
            this.mdtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtpData.Location = new System.Drawing.Point(82, 47);
            this.mdtpData.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtpData.Name = "mdtpData";
            this.mdtpData.Size = new System.Drawing.Size(127, 29);
            this.mdtpData.TabIndex = 64;
            this.mdtpData.ValueChanged += new System.EventHandler(this.mdtpData_ValueChanged);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(7, 13);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(51, 19);
            this.metroLabel13.TabIndex = 3;
            this.metroLabel13.Text = "Evento:";
            // 
            // mtxtEvento
            // 
            this.mtxtEvento.Lines = new string[0];
            this.mtxtEvento.Location = new System.Drawing.Point(82, 12);
            this.mtxtEvento.MaxLength = 32767;
            this.mtxtEvento.Name = "mtxtEvento";
            this.mtxtEvento.PasswordChar = '\0';
            this.mtxtEvento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtEvento.SelectedText = "";
            this.mtxtEvento.Size = new System.Drawing.Size(406, 19);
            this.mtxtEvento.TabIndex = 2;
            this.mtxtEvento.UseSelectable = true;
            this.mtxtEvento.TextChanged += new System.EventHandler(this.mtxtEvento_TextChanged);
            // 
            // mdgvEventos
            // 
            this.mdgvEventos.AllowUserToAddRows = false;
            this.mdgvEventos.AllowUserToDeleteRows = false;
            this.mdgvEventos.AllowUserToOrderColumns = true;
            this.mdgvEventos.AllowUserToResizeRows = false;
            this.mdgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvEventos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvEventos.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvEventos.EnableHeadersVisualStyles = false;
            this.mdgvEventos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvEventos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvEventos.Location = new System.Drawing.Point(3, 84);
            this.mdgvEventos.Name = "mdgvEventos";
            this.mdgvEventos.ReadOnly = true;
            this.mdgvEventos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvEventos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvEventos.Size = new System.Drawing.Size(679, 163);
            this.mdgvEventos.TabIndex = 2;
            this.mdgvEventos.DoubleClick += new System.EventHandler(this.mdgvEventos_DoubleClick);
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 358);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 27;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // frmConsultarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 421);
            this.Controls.Add(this.mTileVoltar);
            this.Controls.Add(this.mPanel);
            this.Name = "frmConsultarAgenda";
            this.Text = "Consultar Agenda";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmConsultarAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox mtxtEvento;
        private MetroFramework.Controls.MetroTile mTileVoltar;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        public MetroFramework.Controls.MetroDateTime mdtpData;
        public MetroFramework.Controls.MetroGrid mdgvEventos;
    }
}