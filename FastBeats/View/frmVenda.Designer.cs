namespace FastBeats.View
{
    partial class frmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.mdgvItensVenda = new MetroFramework.Controls.MetroGrid();
            this.txtCodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodCardapio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtxtComanda = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtCod = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtQuantidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mbtnFinalizar = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtxtTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mlblAviso = new MetroFramework.Controls.MetroLabel();
            this.cboNome = new System.Windows.Forms.ComboBox();
            this.mrdbCardapio = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbProd = new MetroFramework.Controls.MetroRadioButton();
            this.mbtnAdd = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.mPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdgvItensVenda
            // 
            this.mdgvItensVenda.AllowUserToAddRows = false;
            this.mdgvItensVenda.AllowUserToResizeRows = false;
            this.mdgvItensVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvItensVenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvItensVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvItensVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvItensVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvItensVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCodProd,
            this.txtCodCardapio,
            this.txtProd,
            this.txtPreco});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvItensVenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvItensVenda.EnableHeadersVisualStyles = false;
            this.mdgvItensVenda.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvItensVenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvItensVenda.Location = new System.Drawing.Point(12, 14);
            this.mdgvItensVenda.Name = "mdgvItensVenda";
            this.mdgvItensVenda.ReadOnly = true;
            this.mdgvItensVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvItensVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvItensVenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvItensVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvItensVenda.Size = new System.Drawing.Size(382, 276);
            this.mdgvItensVenda.TabIndex = 0;
            // 
            // txtCodProd
            // 
            this.txtCodProd.HeaderText = "Código Produto";
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.ReadOnly = true;
            this.txtCodProd.Visible = false;
            // 
            // txtCodCardapio
            // 
            this.txtCodCardapio.HeaderText = "Código Cardápio";
            this.txtCodCardapio.Name = "txtCodCardapio";
            this.txtCodCardapio.ReadOnly = true;
            this.txtCodCardapio.Visible = false;
            // 
            // txtProd
            // 
            this.txtProd.FillWeight = 149.2386F;
            this.txtProd.HeaderText = "Produto";
            this.txtProd.Name = "txtProd";
            this.txtProd.ReadOnly = true;
            // 
            // txtPreco
            // 
            this.txtPreco.FillWeight = 50.76142F;
            this.txtPreco.HeaderText = "Preço (R$)";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            // 
            // mtxtComanda
            // 
            this.mtxtComanda.Lines = new string[0];
            this.mtxtComanda.Location = new System.Drawing.Point(487, 8);
            this.mtxtComanda.MaxLength = 32767;
            this.mtxtComanda.Name = "mtxtComanda";
            this.mtxtComanda.PasswordChar = '\0';
            this.mtxtComanda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtComanda.SelectedText = "";
            this.mtxtComanda.Size = new System.Drawing.Size(155, 23);
            this.mtxtComanda.TabIndex = 2;
            this.mtxtComanda.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(411, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Comanda:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(425, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Codigo:";
            // 
            // mtxtCod
            // 
            this.mtxtCod.Lines = new string[0];
            this.mtxtCod.Location = new System.Drawing.Point(487, 78);
            this.mtxtCod.MaxLength = 32767;
            this.mtxtCod.Name = "mtxtCod";
            this.mtxtCod.PasswordChar = '\0';
            this.mtxtCod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCod.SelectedText = "";
            this.mtxtCod.Size = new System.Drawing.Size(155, 23);
            this.mtxtCod.TabIndex = 8;
            this.mtxtCod.UseSelectable = true;
            this.mtxtCod.TextChanged += new System.EventHandler(this.mtxtCod_TextChanged);
            this.mtxtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCod_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(400, 178);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Quantidade:";
            // 
            // mtxtQuantidade
            // 
            this.mtxtQuantidade.Lines = new string[] {
        "1"};
            this.mtxtQuantidade.Location = new System.Drawing.Point(487, 174);
            this.mtxtQuantidade.MaxLength = 32767;
            this.mtxtQuantidade.Name = "mtxtQuantidade";
            this.mtxtQuantidade.PasswordChar = '\0';
            this.mtxtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtQuantidade.SelectedText = "";
            this.mtxtQuantidade.Size = new System.Drawing.Size(155, 23);
            this.mtxtQuantidade.TabIndex = 12;
            this.mtxtQuantidade.Text = "1";
            this.mtxtQuantidade.UseSelectable = true;
            this.mtxtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtQuantidade_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(432, 133);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Nome:";
            // 
            // mbtnFinalizar
            // 
            this.mbtnFinalizar.Location = new System.Drawing.Point(567, 292);
            this.mbtnFinalizar.Name = "mbtnFinalizar";
            this.mbtnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.mbtnFinalizar.TabIndex = 18;
            this.mbtnFinalizar.Text = "Finalizar";
            this.mbtnFinalizar.UseSelectable = true;
            this.mbtnFinalizar.Click += new System.EventHandler(this.mbtnFinalizar_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(442, 258);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(39, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Total:";
            // 
            // mtxtTotal
            // 
            this.mtxtTotal.Lines = new string[0];
            this.mtxtTotal.Location = new System.Drawing.Point(487, 254);
            this.mtxtTotal.MaxLength = 32767;
            this.mtxtTotal.Name = "mtxtTotal";
            this.mtxtTotal.PasswordChar = '\0';
            this.mtxtTotal.ReadOnly = true;
            this.mtxtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTotal.SelectedText = "";
            this.mtxtTotal.Size = new System.Drawing.Size(155, 23);
            this.mtxtTotal.TabIndex = 16;
            this.mtxtTotal.UseSelectable = true;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 426);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 25;
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
            this.mPanel.Controls.Add(this.mlblAviso);
            this.mPanel.Controls.Add(this.cboNome);
            this.mPanel.Controls.Add(this.mrdbCardapio);
            this.mPanel.Controls.Add(this.mrdbProd);
            this.mPanel.Controls.Add(this.mbtnAdd);
            this.mPanel.Controls.Add(this.metroLabel6);
            this.mPanel.Controls.Add(this.mdgvItensVenda);
            this.mPanel.Controls.Add(this.mtxtTotal);
            this.mPanel.Controls.Add(this.mtxtComanda);
            this.mPanel.Controls.Add(this.mbtnFinalizar);
            this.mPanel.Controls.Add(this.metroLabel1);
            this.mPanel.Controls.Add(this.mtxtCod);
            this.mPanel.Controls.Add(this.metroLabel2);
            this.mPanel.Controls.Add(this.mtxtQuantidade);
            this.mPanel.Controls.Add(this.metroLabel4);
            this.mPanel.Controls.Add(this.metroLabel3);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(68, 63);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(661, 330);
            this.mPanel.TabIndex = 27;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mlblAviso
            // 
            this.mlblAviso.AutoSize = true;
            this.mlblAviso.Location = new System.Drawing.Point(12, 296);
            this.mlblAviso.Name = "mlblAviso";
            this.mlblAviso.Size = new System.Drawing.Size(0, 0);
            this.mlblAviso.TabIndex = 38;
            // 
            // cboNome
            // 
            this.cboNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cboNome.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboNome.FormattingEnabled = true;
            this.cboNome.Location = new System.Drawing.Point(487, 133);
            this.cboNome.Name = "cboNome";
            this.cboNome.Size = new System.Drawing.Size(155, 21);
            this.cboNome.TabIndex = 10;
            this.cboNome.SelectedIndexChanged += new System.EventHandler(this.cboNome_SelectedIndexChanged);
            this.cboNome.TextChanged += new System.EventHandler(this.cboNome_TextChanged);
            // 
            // mrdbCardapio
            // 
            this.mrdbCardapio.AutoSize = true;
            this.mrdbCardapio.Location = new System.Drawing.Point(571, 44);
            this.mrdbCardapio.Name = "mrdbCardapio";
            this.mrdbCardapio.Size = new System.Drawing.Size(71, 15);
            this.mrdbCardapio.TabIndex = 6;
            this.mrdbCardapio.Text = "Cardápio";
            this.mrdbCardapio.UseSelectable = true;
            this.mrdbCardapio.CheckedChanged += new System.EventHandler(this.mrdbCardapio_CheckedChanged);
            // 
            // mrdbProd
            // 
            this.mrdbProd.AutoSize = true;
            this.mrdbProd.Location = new System.Drawing.Point(487, 44);
            this.mrdbProd.Name = "mrdbProd";
            this.mrdbProd.Size = new System.Drawing.Size(66, 15);
            this.mrdbProd.TabIndex = 4;
            this.mrdbProd.Text = "Produto";
            this.mrdbProd.UseSelectable = true;
            this.mrdbProd.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // mbtnAdd
            // 
            this.mbtnAdd.Location = new System.Drawing.Point(567, 205);
            this.mbtnAdd.Name = "mbtnAdd";
            this.mbtnAdd.Size = new System.Drawing.Size(75, 23);
            this.mbtnAdd.TabIndex = 14;
            this.mbtnAdd.Text = "Adicionar";
            this.mbtnAdd.UseSelectable = true;
            this.mbtnAdd.Click += new System.EventHandler(this.mbtnAdd_Click);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 489);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mTileVoltar);
            this.Name = "frmVenda";
            this.Text = "Vendas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mdgvItensVenda;
        private MetroFramework.Controls.MetroTextBox mtxtComanda;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtCod;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtxtQuantidade;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton mbtnFinalizar;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mtxtTotal;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTile mTileVoltar;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroButton mbtnAdd;
        private MetroFramework.Controls.MetroRadioButton mrdbCardapio;
        private MetroFramework.Controls.MetroRadioButton mrdbProd;
        private System.Windows.Forms.ComboBox cboNome;
        private MetroFramework.Controls.MetroLabel mlblAviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodCardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPreco;
    }
}