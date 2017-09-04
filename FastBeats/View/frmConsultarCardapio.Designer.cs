namespace FastBeats.View
{
    partial class frmConsultarCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCardapio));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mtxtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.mtxtProduto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mdgvCardapio = new MetroFramework.Controls.MetroGrid();
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.mPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvCardapio)).BeginInit();
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
            this.mPanel.Controls.Add(this.mtxtCodigo);
            this.mPanel.Controls.Add(this.mtxtProduto);
            this.mPanel.Controls.Add(this.metroLabel2);
            this.mPanel.Controls.Add(this.metroLabel1);
            this.mPanel.Controls.Add(this.mdgvCardapio);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(35, 89);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(682, 236);
            this.mPanel.TabIndex = 25;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mtxtCodigo
            // 
            this.mtxtCodigo.Lines = new string[0];
            this.mtxtCodigo.Location = new System.Drawing.Point(75, 6);
            this.mtxtCodigo.MaxLength = 32767;
            this.mtxtCodigo.Name = "mtxtCodigo";
            this.mtxtCodigo.PasswordChar = '\0';
            this.mtxtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCodigo.SelectedText = "";
            this.mtxtCodigo.Size = new System.Drawing.Size(158, 23);
            this.mtxtCodigo.TabIndex = 35;
            this.mtxtCodigo.UseSelectable = true;
            this.mtxtCodigo.TextChanged += new System.EventHandler(this.mtxtCodigo_TextChanged);
            this.mtxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCodigo_KeyPress);
            // 
            // mtxtProduto
            // 
            this.mtxtProduto.Lines = new string[0];
            this.mtxtProduto.Location = new System.Drawing.Point(75, 38);
            this.mtxtProduto.MaxLength = 32767;
            this.mtxtProduto.Name = "mtxtProduto";
            this.mtxtProduto.PasswordChar = '\0';
            this.mtxtProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtProduto.SelectedText = "";
            this.mtxtProduto.Size = new System.Drawing.Size(372, 23);
            this.mtxtProduto.TabIndex = 36;
            this.mtxtProduto.UseSelectable = true;
            this.mtxtProduto.TextChanged += new System.EventHandler(this.mtxtProduto_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Produto:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Código:";
            // 
            // mdgvCardapio
            // 
            this.mdgvCardapio.AllowUserToAddRows = false;
            this.mdgvCardapio.AllowUserToDeleteRows = false;
            this.mdgvCardapio.AllowUserToResizeRows = false;
            this.mdgvCardapio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvCardapio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvCardapio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvCardapio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvCardapio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvCardapio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvCardapio.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvCardapio.EnableHeadersVisualStyles = false;
            this.mdgvCardapio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvCardapio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvCardapio.Location = new System.Drawing.Point(3, 76);
            this.mdgvCardapio.Name = "mdgvCardapio";
            this.mdgvCardapio.ReadOnly = true;
            this.mdgvCardapio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvCardapio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvCardapio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvCardapio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvCardapio.Size = new System.Drawing.Size(674, 155);
            this.mdgvCardapio.TabIndex = 2;
            this.mdgvCardapio.DoubleClick += new System.EventHandler(this.mdgvCardapio_DoubleClick);
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 336);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 41);
            this.mTileVoltar.TabIndex = 26;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // frmConsultarCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 400);
            this.Controls.Add(this.mTileVoltar);
            this.Controls.Add(this.mPanel);
            this.Name = "frmConsultarCardapio";
            this.Text = "Consultar Cardápio";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmConsultarCardapio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvCardapio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroTile mTileVoltar;
        public MetroFramework.Controls.MetroTextBox mtxtCodigo;
        public MetroFramework.Controls.MetroTextBox mtxtProduto;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroGrid mdgvCardapio;
    }
}