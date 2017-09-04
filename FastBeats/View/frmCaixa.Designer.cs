namespace FastBeats.View
{
    partial class frmCaixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mlblAvisos = new MetroFramework.Controls.MetroLabel();
            this.mPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mbtnFinalizar = new MetroFramework.Controls.MetroButton();
            this.mtxtValorTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mbtnAddComan = new MetroFramework.Controls.MetroButton();
            this.mtxtComanda = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mdgvComandas = new MetroFramework.Controls.MetroGrid();
            this.txtComanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodUtiComan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdgvItensVenda = new MetroFramework.Controls.MetroGrid();
            this.txtProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            this.mPanel.SuspendLayout();
            this.mPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvComandas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mPanel
            // 
            this.mPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel.Controls.Add(this.mlblAvisos);
            this.mPanel.Controls.Add(this.mPanel1);
            this.mPanel.Controls.Add(this.mdgvComandas);
            this.mPanel.Controls.Add(this.mdgvItensVenda);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(109, 63);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(703, 341);
            this.mPanel.TabIndex = 29;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mlblAvisos
            // 
            this.mlblAvisos.AutoSize = true;
            this.mlblAvisos.Location = new System.Drawing.Point(21, 311);
            this.mlblAvisos.Name = "mlblAvisos";
            this.mlblAvisos.Size = new System.Drawing.Size(0, 0);
            this.mlblAvisos.TabIndex = 27;
            // 
            // mPanel1
            // 
            this.mPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel1.Controls.Add(this.mbtnFinalizar);
            this.mPanel1.Controls.Add(this.mtxtValorTotal);
            this.mPanel1.Controls.Add(this.metroLabel2);
            this.mPanel1.Controls.Add(this.mbtnAddComan);
            this.mPanel1.Controls.Add(this.mtxtComanda);
            this.mPanel1.Controls.Add(this.metroLabel1);
            this.mPanel1.HorizontalScrollbarBarColor = true;
            this.mPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel1.HorizontalScrollbarSize = 10;
            this.mPanel1.Location = new System.Drawing.Point(477, 140);
            this.mPanel1.Name = "mPanel1";
            this.mPanel1.Size = new System.Drawing.Size(200, 168);
            this.mPanel1.TabIndex = 5;
            this.mPanel1.VerticalScrollbarBarColor = true;
            this.mPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel1.VerticalScrollbarSize = 10;
            // 
            // mbtnFinalizar
            // 
            this.mbtnFinalizar.Location = new System.Drawing.Point(14, 123);
            this.mbtnFinalizar.Name = "mbtnFinalizar";
            this.mbtnFinalizar.Size = new System.Drawing.Size(168, 35);
            this.mbtnFinalizar.TabIndex = 9;
            this.mbtnFinalizar.Text = "Finalizar";
            this.mbtnFinalizar.UseSelectable = true;
            this.mbtnFinalizar.Click += new System.EventHandler(this.mbtnFinalizar_Click);
            // 
            // mtxtValorTotal
            // 
            this.mtxtValorTotal.Lines = new string[0];
            this.mtxtValorTotal.Location = new System.Drawing.Point(14, 92);
            this.mtxtValorTotal.MaxLength = 32767;
            this.mtxtValorTotal.Name = "mtxtValorTotal";
            this.mtxtValorTotal.PasswordChar = '\0';
            this.mtxtValorTotal.ReadOnly = true;
            this.mtxtValorTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtValorTotal.SelectedText = "";
            this.mtxtValorTotal.Size = new System.Drawing.Size(168, 23);
            this.mtxtValorTotal.TabIndex = 8;
            this.mtxtValorTotal.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Valor Total:";
            // 
            // mbtnAddComan
            // 
            this.mbtnAddComan.Location = new System.Drawing.Point(137, 34);
            this.mbtnAddComan.Name = "mbtnAddComan";
            this.mbtnAddComan.Size = new System.Drawing.Size(45, 23);
            this.mbtnAddComan.TabIndex = 6;
            this.mbtnAddComan.Text = "Add";
            this.mbtnAddComan.UseSelectable = true;
            this.mbtnAddComan.Click += new System.EventHandler(this.mbtnAddComan_Click);
            // 
            // mtxtComanda
            // 
            this.mtxtComanda.Lines = new string[0];
            this.mtxtComanda.Location = new System.Drawing.Point(14, 34);
            this.mtxtComanda.MaxLength = 32767;
            this.mtxtComanda.Name = "mtxtComanda";
            this.mtxtComanda.PasswordChar = '\0';
            this.mtxtComanda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtComanda.SelectedText = "";
            this.mtxtComanda.Size = new System.Drawing.Size(117, 23);
            this.mtxtComanda.TabIndex = 5;
            this.mtxtComanda.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Comanda:";
            // 
            // mdgvComandas
            // 
            this.mdgvComandas.AllowUserToAddRows = false;
            this.mdgvComandas.AllowUserToDeleteRows = false;
            this.mdgvComandas.AllowUserToResizeRows = false;
            this.mdgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvComandas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvComandas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvComandas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvComandas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvComandas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvComandas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtComanda,
            this.txtCodUtiComan,
            this.txtCli});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvComandas.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvComandas.EnableHeadersVisualStyles = false;
            this.mdgvComandas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvComandas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvComandas.Location = new System.Drawing.Point(477, 14);
            this.mdgvComandas.Name = "mdgvComandas";
            this.mdgvComandas.ReadOnly = true;
            this.mdgvComandas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvComandas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvComandas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvComandas.Size = new System.Drawing.Size(200, 114);
            this.mdgvComandas.TabIndex = 2;
            // 
            // txtComanda
            // 
            this.txtComanda.HeaderText = "Comanda";
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.ReadOnly = true;
            // 
            // txtCodUtiComan
            // 
            this.txtCodUtiComan.HeaderText = "CodUtiComan";
            this.txtCodUtiComan.Name = "txtCodUtiComan";
            this.txtCodUtiComan.ReadOnly = true;
            this.txtCodUtiComan.Visible = false;
            // 
            // txtCli
            // 
            this.txtCli.HeaderText = "Cliente";
            this.txtCli.Name = "txtCli";
            this.txtCli.ReadOnly = true;
            // 
            // mdgvItensVenda
            // 
            this.mdgvItensVenda.AllowUserToAddRows = false;
            this.mdgvItensVenda.AllowUserToDeleteRows = false;
            this.mdgvItensVenda.AllowUserToResizeRows = false;
            this.mdgvItensVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvItensVenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvItensVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvItensVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvItensVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvItensVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mdgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtProd,
            this.txtPreco});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvItensVenda.DefaultCellStyle = dataGridViewCellStyle5;
            this.mdgvItensVenda.EnableHeadersVisualStyles = false;
            this.mdgvItensVenda.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvItensVenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvItensVenda.Location = new System.Drawing.Point(12, 14);
            this.mdgvItensVenda.Name = "mdgvItensVenda";
            this.mdgvItensVenda.ReadOnly = true;
            this.mdgvItensVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvItensVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mdgvItensVenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvItensVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvItensVenda.Size = new System.Drawing.Size(459, 294);
            this.mdgvItensVenda.TabIndex = 0;
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
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 430);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 28;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 493);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mTileVoltar);
            this.Name = "frmCaixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.mPanel1.ResumeLayout(false);
            this.mPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvComandas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mTileVoltar;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTextBox mtxtValorTotal;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mbtnAddComan;
        private MetroFramework.Controls.MetroTextBox mtxtComanda;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mbtnFinalizar;
        public MetroFramework.Controls.MetroGrid mdgvComandas;
        public MetroFramework.Controls.MetroPanel mPanel;
        public MetroFramework.Controls.MetroPanel mPanel1;
        private MetroFramework.Controls.MetroLabel mlblAvisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodUtiComan;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPreco;
        public MetroFramework.Controls.MetroGrid mdgvItensVenda;
    }
}