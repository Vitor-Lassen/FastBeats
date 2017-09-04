namespace FastBeats.View
{
    partial class frmCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardapio));
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mtxtCod = new MetroFramework.Controls.MetroTextBox();
            this.mlblCod = new MetroFramework.Controls.MetroLabel();
            this.mlblAviso = new MetroFramework.Controls.MetroLabel();
            this.mbtnNovo = new MetroFramework.Controls.MetroButton();
            this.mbtnAtualizar = new MetroFramework.Controls.MetroButton();
            this.mbtnConsultar = new MetroFramework.Controls.MetroButton();
            this.mbtnCadastrar = new MetroFramework.Controls.MetroButton();
            this.mtxtPrecoProd = new MetroFramework.Controls.MetroTextBox();
            this.mtxtNomeProd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            this.mPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mPanel
            // 
            this.mPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel.Controls.Add(this.mtxtCod);
            this.mPanel.Controls.Add(this.mlblCod);
            this.mPanel.Controls.Add(this.mlblAviso);
            this.mPanel.Controls.Add(this.mbtnNovo);
            this.mPanel.Controls.Add(this.mbtnAtualizar);
            this.mPanel.Controls.Add(this.mbtnConsultar);
            this.mPanel.Controls.Add(this.mbtnCadastrar);
            this.mPanel.Controls.Add(this.mtxtPrecoProd);
            this.mPanel.Controls.Add(this.mtxtNomeProd);
            this.mPanel.Controls.Add(this.metroLabel4);
            this.mPanel.Controls.Add(this.metroLabel3);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(38, 96);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(687, 252);
            this.mPanel.TabIndex = 25;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mtxtCod
            // 
            this.mtxtCod.Lines = new string[0];
            this.mtxtCod.Location = new System.Drawing.Point(163, 36);
            this.mtxtCod.MaxLength = 32767;
            this.mtxtCod.Name = "mtxtCod";
            this.mtxtCod.PasswordChar = '\0';
            this.mtxtCod.ReadOnly = true;
            this.mtxtCod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCod.SelectedText = "";
            this.mtxtCod.Size = new System.Drawing.Size(176, 23);
            this.mtxtCod.TabIndex = 39;
            this.mtxtCod.UseSelectable = true;
            this.mtxtCod.Visible = false;
            // 
            // mlblCod
            // 
            this.mlblCod.AutoSize = true;
            this.mlblCod.Location = new System.Drawing.Point(33, 36);
            this.mlblCod.Name = "mlblCod";
            this.mlblCod.Size = new System.Drawing.Size(56, 19);
            this.mlblCod.TabIndex = 38;
            this.mlblCod.Text = "Código:";
            this.mlblCod.Visible = false;
            // 
            // mlblAviso
            // 
            this.mlblAviso.AutoSize = true;
            this.mlblAviso.Location = new System.Drawing.Point(18, 214);
            this.mlblAviso.Name = "mlblAviso";
            this.mlblAviso.Size = new System.Drawing.Size(0, 0);
            this.mlblAviso.TabIndex = 37;
            // 
            // mbtnNovo
            // 
            this.mbtnNovo.Location = new System.Drawing.Point(559, 200);
            this.mbtnNovo.Name = "mbtnNovo";
            this.mbtnNovo.Size = new System.Drawing.Size(103, 33);
            this.mbtnNovo.TabIndex = 36;
            this.mbtnNovo.Text = "Novo";
            this.mbtnNovo.UseSelectable = true;
            this.mbtnNovo.Visible = false;
            this.mbtnNovo.Click += new System.EventHandler(this.mbtnNovo_Click);
            // 
            // mbtnAtualizar
            // 
            this.mbtnAtualizar.Location = new System.Drawing.Point(341, 200);
            this.mbtnAtualizar.Name = "mbtnAtualizar";
            this.mbtnAtualizar.Size = new System.Drawing.Size(103, 33);
            this.mbtnAtualizar.TabIndex = 35;
            this.mbtnAtualizar.Text = "Atualizar";
            this.mbtnAtualizar.UseSelectable = true;
            this.mbtnAtualizar.Visible = false;
            this.mbtnAtualizar.Click += new System.EventHandler(this.mbtnAtualizar_Click);
            // 
            // mbtnConsultar
            // 
            this.mbtnConsultar.Location = new System.Drawing.Point(450, 200);
            this.mbtnConsultar.Name = "mbtnConsultar";
            this.mbtnConsultar.Size = new System.Drawing.Size(103, 33);
            this.mbtnConsultar.TabIndex = 34;
            this.mbtnConsultar.Text = "Consultar";
            this.mbtnConsultar.UseSelectable = true;
            this.mbtnConsultar.Click += new System.EventHandler(this.mbtnConsultar_Click);
            // 
            // mbtnCadastrar
            // 
            this.mbtnCadastrar.Location = new System.Drawing.Point(341, 200);
            this.mbtnCadastrar.Name = "mbtnCadastrar";
            this.mbtnCadastrar.Size = new System.Drawing.Size(103, 33);
            this.mbtnCadastrar.TabIndex = 33;
            this.mbtnCadastrar.Text = "Cadastrar";
            this.mbtnCadastrar.UseSelectable = true;
            this.mbtnCadastrar.Click += new System.EventHandler(this.mbtnCadastrar_Click);
            // 
            // mtxtPrecoProd
            // 
            this.mtxtPrecoProd.Lines = new string[0];
            this.mtxtPrecoProd.Location = new System.Drawing.Point(163, 124);
            this.mtxtPrecoProd.MaxLength = 32767;
            this.mtxtPrecoProd.Name = "mtxtPrecoProd";
            this.mtxtPrecoProd.PasswordChar = '\0';
            this.mtxtPrecoProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPrecoProd.SelectedText = "";
            this.mtxtPrecoProd.Size = new System.Drawing.Size(176, 23);
            this.mtxtPrecoProd.TabIndex = 7;
            this.mtxtPrecoProd.UseSelectable = true;
            // 
            // mtxtNomeProd
            // 
            this.mtxtNomeProd.Lines = new string[0];
            this.mtxtNomeProd.Location = new System.Drawing.Point(163, 81);
            this.mtxtNomeProd.MaxLength = 32767;
            this.mtxtNomeProd.Name = "mtxtNomeProd";
            this.mtxtNomeProd.PasswordChar = '\0';
            this.mtxtNomeProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNomeProd.SelectedText = "";
            this.mtxtNomeProd.Size = new System.Drawing.Size(176, 23);
            this.mtxtNomeProd.TabIndex = 6;
            this.mtxtNomeProd.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 124);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(118, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Preço do Produto:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(127, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "*Nome do Produto:";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(18, 384);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 26;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // frmCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 443);
            this.Controls.Add(this.mTileVoltar);
            this.Controls.Add(this.mPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCardapio";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Cardápio";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmCardapio_Load);
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanel;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTile mTileVoltar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroButton mbtnNovo;
        public MetroFramework.Controls.MetroButton mbtnAtualizar;
        private MetroFramework.Controls.MetroButton mbtnConsultar;
        public MetroFramework.Controls.MetroButton mbtnCadastrar;
        private MetroFramework.Controls.MetroLabel mlblAviso;
        public MetroFramework.Controls.MetroTextBox mtxtPrecoProd;
        public MetroFramework.Controls.MetroTextBox mtxtNomeProd;
        public MetroFramework.Controls.MetroTextBox mtxtCod;
        public MetroFramework.Controls.MetroLabel mlblCod;
    }
}