namespace FastBeats.View
{
    partial class frmConsultarArtistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarArtistas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mcboGenero = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mtxtArtista = new MetroFramework.Controls.MetroTextBox();
            this.mdgvArtistas = new MetroFramework.Controls.MetroGrid();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvArtistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 353);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 24;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // mPanel
            // 
            this.mPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel.Controls.Add(this.mcboGenero);
            this.mPanel.Controls.Add(this.metroLabel16);
            this.mPanel.Controls.Add(this.metroLabel13);
            this.mPanel.Controls.Add(this.mtxtArtista);
            this.mPanel.Controls.Add(this.mdgvArtistas);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(32, 82);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(687, 252);
            this.mPanel.TabIndex = 25;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mcboGenero
            // 
            this.mcboGenero.FormattingEnabled = true;
            this.mcboGenero.ItemHeight = 23;
            this.mcboGenero.Location = new System.Drawing.Point(83, 39);
            this.mcboGenero.Name = "mcboGenero";
            this.mcboGenero.Size = new System.Drawing.Size(121, 29);
            this.mcboGenero.TabIndex = 4;
            this.mcboGenero.UseSelectable = true;
            this.mcboGenero.SelectedIndexChanged += new System.EventHandler(this.mcboGenero_SelectedIndexChanged);
            this.mcboGenero.Enter += new System.EventHandler(this.mcboGenero_Enter);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(3, 49);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(55, 19);
            this.metroLabel16.TabIndex = 12;
            this.metroLabel16.Text = "Gênero:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(7, 13);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(50, 19);
            this.metroLabel13.TabIndex = 3;
            this.metroLabel13.Text = "Artista:";
            // 
            // mtxtArtista
            // 
            this.mtxtArtista.Lines = new string[0];
            this.mtxtArtista.Location = new System.Drawing.Point(82, 12);
            this.mtxtArtista.MaxLength = 32767;
            this.mtxtArtista.Name = "mtxtArtista";
            this.mtxtArtista.PasswordChar = '\0';
            this.mtxtArtista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtArtista.SelectedText = "";
            this.mtxtArtista.Size = new System.Drawing.Size(406, 19);
            this.mtxtArtista.TabIndex = 2;
            this.mtxtArtista.UseSelectable = true;
            this.mtxtArtista.TextChanged += new System.EventHandler(this.mtxtArtista_TextChanged);
            this.mtxtArtista.Enter += new System.EventHandler(this.mtxtArtista_Enter);
            // 
            // mdgvArtistas
            // 
            this.mdgvArtistas.AllowUserToAddRows = false;
            this.mdgvArtistas.AllowUserToDeleteRows = false;
            this.mdgvArtistas.AllowUserToOrderColumns = true;
            this.mdgvArtistas.AllowUserToResizeRows = false;
            this.mdgvArtistas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvArtistas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvArtistas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvArtistas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvArtistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvArtistas.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvArtistas.EnableHeadersVisualStyles = false;
            this.mdgvArtistas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvArtistas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvArtistas.Location = new System.Drawing.Point(3, 84);
            this.mdgvArtistas.Name = "mdgvArtistas";
            this.mdgvArtistas.ReadOnly = true;
            this.mdgvArtistas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvArtistas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvArtistas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvArtistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvArtistas.Size = new System.Drawing.Size(679, 163);
            this.mdgvArtistas.TabIndex = 2;
            this.mdgvArtistas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mdgvArtistas_DoubleClick);
            this.mdgvArtistas.DoubleClick += new System.EventHandler(this.mdgvArtistas_DoubleClick);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // frmConsultarArtistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 416);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mTileVoltar);
            this.Name = "frmConsultarArtistas";
            this.Text = "Consultar Artistas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmConsultarArtistas_Load);
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvArtistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mTileVoltar;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroGrid mdgvArtistas;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox mtxtArtista;
        private MetroFramework.Controls.MetroComboBox mcboGenero;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}