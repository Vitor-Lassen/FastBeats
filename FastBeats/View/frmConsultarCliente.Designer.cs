namespace FastBeats.View
{
    partial class frmConsultarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCliente));
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mtxtNome = new MetroFramework.Controls.MetroTextBox();
            this.mdgvClientes = new MetroFramework.Controls.MetroGrid();
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mPanel
            // 
            this.mPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel.Controls.Add(this.mskCPF);
            this.mPanel.Controls.Add(this.metroLabel16);
            this.mPanel.Controls.Add(this.metroLabel13);
            this.mPanel.Controls.Add(this.mtxtNome);
            this.mPanel.Controls.Add(this.mdgvClientes);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(23, 63);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(687, 252);
            this.mPanel.TabIndex = 27;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mskCPF
            // 
            this.mskCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.mskCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCPF.ForeColor = System.Drawing.Color.Gainsboro;
            this.mskCPF.Location = new System.Drawing.Point(82, 47);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.SkipLiterals = false;
            this.mskCPF.TabIndex = 3;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPF.TextChanged += new System.EventHandler(this.mskCPF_TextChanged);
            this.mskCPF.Enter += new System.EventHandler(this.mskCPF_Enter);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(40, 48);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(36, 19);
            this.metroLabel16.TabIndex = 12;
            this.metroLabel16.Text = "CPF:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(27, 12);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(49, 19);
            this.metroLabel13.TabIndex = 3;
            this.metroLabel13.Text = "Nome:";
            // 
            // mtxtNome
            // 
            this.mtxtNome.Lines = new string[0];
            this.mtxtNome.Location = new System.Drawing.Point(82, 12);
            this.mtxtNome.MaxLength = 32767;
            this.mtxtNome.Name = "mtxtNome";
            this.mtxtNome.PasswordChar = '\0';
            this.mtxtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNome.SelectedText = "";
            this.mtxtNome.Size = new System.Drawing.Size(600, 19);
            this.mtxtNome.TabIndex = 2;
            this.mtxtNome.UseSelectable = true;
            this.mtxtNome.TextChanged += new System.EventHandler(this.mtxtNome_TextChanged);
            this.mtxtNome.Enter += new System.EventHandler(this.mtxtNome_Enter);
            // 
            // mdgvClientes
            // 
            this.mdgvClientes.AllowUserToAddRows = false;
            this.mdgvClientes.AllowUserToDeleteRows = false;
            this.mdgvClientes.AllowUserToOrderColumns = true;
            this.mdgvClientes.AllowUserToResizeRows = false;
            this.mdgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mdgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvClientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.mdgvClientes.EnableHeadersVisualStyles = false;
            this.mdgvClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvClientes.Location = new System.Drawing.Point(3, 84);
            this.mdgvClientes.Name = "mdgvClientes";
            this.mdgvClientes.ReadOnly = true;
            this.mdgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mdgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvClientes.Size = new System.Drawing.Size(679, 163);
            this.mdgvClientes.TabIndex = 2;
            this.mdgvClientes.DoubleClick += new System.EventHandler(this.mdgvClientes_DoubleClick);
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 328);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 6;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // frmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 391);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mTileVoltar);
            this.Name = "frmConsultarCliente";
            this.Text = "Consultar Clientes";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmConsultarCliente_Load);
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox mtxtNome;
        private MetroFramework.Controls.MetroGrid mdgvClientes;
        private MetroFramework.Controls.MetroTile mTileVoltar;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.MaskedTextBox mskCPF;
    }
}