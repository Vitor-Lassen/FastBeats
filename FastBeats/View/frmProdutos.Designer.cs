namespace FastBeats.View
{
    partial class frmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mbtnConsultar = new MetroFramework.Controls.MetroButton();
            this.mbtnNovo = new MetroFramework.Controls.MetroButton();
            this.mbtnAlterar = new MetroFramework.Controls.MetroButton();
            this.mbtnCadastrar = new MetroFramework.Controls.MetroButton();
            this.mtxtPrecoVenda = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtxtPrecoCusto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtxtQuantidadeMin = new MetroFramework.Controls.MetroTextBox();
            this.mtxtQuantidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtNome = new MetroFramework.Controls.MetroTextBox();
            this.mtxtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mlblAvisos = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.mPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 328);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 24;
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
            // mPanel
            // 
            this.mPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel.Controls.Add(this.mbtnConsultar);
            this.mPanel.Controls.Add(this.mbtnNovo);
            this.mPanel.Controls.Add(this.mbtnAlterar);
            this.mPanel.Controls.Add(this.mbtnCadastrar);
            this.mPanel.Controls.Add(this.mtxtPrecoVenda);
            this.mPanel.Controls.Add(this.metroLabel6);
            this.mPanel.Controls.Add(this.mtxtPrecoCusto);
            this.mPanel.Controls.Add(this.metroLabel5);
            this.mPanel.Controls.Add(this.mtxtQuantidadeMin);
            this.mPanel.Controls.Add(this.mtxtQuantidade);
            this.mPanel.Controls.Add(this.metroLabel4);
            this.mPanel.Controls.Add(this.metroLabel3);
            this.mPanel.Controls.Add(this.mtxtNome);
            this.mPanel.Controls.Add(this.mtxtCodigo);
            this.mPanel.Controls.Add(this.metroLabel2);
            this.mPanel.Controls.Add(this.metroLabel1);
            this.mPanel.Controls.Add(this.mlblAvisos);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(46, 69);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(715, 252);
            this.mPanel.TabIndex = 26;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mbtnConsultar
            // 
            this.mbtnConsultar.Location = new System.Drawing.Point(466, 199);
            this.mbtnConsultar.Name = "mbtnConsultar";
            this.mbtnConsultar.Size = new System.Drawing.Size(103, 33);
            this.mbtnConsultar.TabIndex = 16;
            this.mbtnConsultar.Text = "Consultar";
            this.mbtnConsultar.UseSelectable = true;
            this.mbtnConsultar.Click += new System.EventHandler(this.mbtnConsultar_Click);
            // 
            // mbtnNovo
            // 
            this.mbtnNovo.Location = new System.Drawing.Point(574, 199);
            this.mbtnNovo.Name = "mbtnNovo";
            this.mbtnNovo.Size = new System.Drawing.Size(103, 33);
            this.mbtnNovo.TabIndex = 18;
            this.mbtnNovo.Text = "Novo";
            this.mbtnNovo.UseSelectable = true;
            this.mbtnNovo.Click += new System.EventHandler(this.mbtnNovo_Click);
            // 
            // mbtnAlterar
            // 
            this.mbtnAlterar.Location = new System.Drawing.Point(356, 199);
            this.mbtnAlterar.Name = "mbtnAlterar";
            this.mbtnAlterar.Size = new System.Drawing.Size(103, 33);
            this.mbtnAlterar.TabIndex = 14;
            this.mbtnAlterar.Text = "Alterar";
            this.mbtnAlterar.UseSelectable = true;
            this.mbtnAlterar.Visible = false;
            this.mbtnAlterar.Click += new System.EventHandler(this.mbtnAlterar_Click);
            // 
            // mbtnCadastrar
            // 
            this.mbtnCadastrar.Location = new System.Drawing.Point(356, 199);
            this.mbtnCadastrar.Name = "mbtnCadastrar";
            this.mbtnCadastrar.Size = new System.Drawing.Size(103, 33);
            this.mbtnCadastrar.TabIndex = 13;
            this.mbtnCadastrar.Text = "Cadastrar";
            this.mbtnCadastrar.UseSelectable = true;
            this.mbtnCadastrar.Click += new System.EventHandler(this.mbtnCadastrar_Click);
            // 
            // mtxtPrecoVenda
            // 
            this.mtxtPrecoVenda.Lines = new string[0];
            this.mtxtPrecoVenda.Location = new System.Drawing.Point(137, 79);
            this.mtxtPrecoVenda.MaxLength = 32767;
            this.mtxtPrecoVenda.Name = "mtxtPrecoVenda";
            this.mtxtPrecoVenda.PasswordChar = '\0';
            this.mtxtPrecoVenda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPrecoVenda.SelectedText = "";
            this.mtxtPrecoVenda.Size = new System.Drawing.Size(91, 23);
            this.mtxtPrecoVenda.TabIndex = 6;
            this.mtxtPrecoVenda.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(20, 79);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(111, 19);
            this.metroLabel6.TabIndex = 39;
            this.metroLabel6.Text = "*Preço de Venda:";
            // 
            // mtxtPrecoCusto
            // 
            this.mtxtPrecoCusto.Lines = new string[0];
            this.mtxtPrecoCusto.Location = new System.Drawing.Point(137, 119);
            this.mtxtPrecoCusto.MaxLength = 32767;
            this.mtxtPrecoCusto.Name = "mtxtPrecoCusto";
            this.mtxtPrecoCusto.PasswordChar = '\0';
            this.mtxtPrecoCusto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPrecoCusto.SelectedText = "";
            this.mtxtPrecoCusto.Size = new System.Drawing.Size(91, 23);
            this.mtxtPrecoCusto.TabIndex = 12;
            this.mtxtPrecoCusto.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 119);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(102, 19);
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "Preço de Custo:";
            // 
            // mtxtQuantidadeMin
            // 
            this.mtxtQuantidadeMin.Lines = new string[0];
            this.mtxtQuantidadeMin.Location = new System.Drawing.Point(522, 79);
            this.mtxtQuantidadeMin.MaxLength = 32767;
            this.mtxtQuantidadeMin.Name = "mtxtQuantidadeMin";
            this.mtxtQuantidadeMin.PasswordChar = '\0';
            this.mtxtQuantidadeMin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtQuantidadeMin.SelectedText = "";
            this.mtxtQuantidadeMin.Size = new System.Drawing.Size(91, 23);
            this.mtxtQuantidadeMin.TabIndex = 10;
            this.mtxtQuantidadeMin.UseSelectable = true;
            this.mtxtQuantidadeMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtQuantidadeMin_KeyPress);
            // 
            // mtxtQuantidade
            // 
            this.mtxtQuantidade.Lines = new string[0];
            this.mtxtQuantidade.Location = new System.Drawing.Point(314, 79);
            this.mtxtQuantidade.MaxLength = 32767;
            this.mtxtQuantidade.Name = "mtxtQuantidade";
            this.mtxtQuantidade.PasswordChar = '\0';
            this.mtxtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtQuantidade.SelectedText = "";
            this.mtxtQuantidade.Size = new System.Drawing.Size(91, 23);
            this.mtxtQuantidade.TabIndex = 8;
            this.mtxtQuantidade.UseSelectable = true;
            this.mtxtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtQuantidade_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(235, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Quantidade:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(434, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 38);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Quantidade \r\nMiníma:";
            // 
            // mtxtNome
            // 
            this.mtxtNome.Lines = new string[0];
            this.mtxtNome.Location = new System.Drawing.Point(314, 34);
            this.mtxtNome.MaxLength = 32767;
            this.mtxtNome.Name = "mtxtNome";
            this.mtxtNome.PasswordChar = '\0';
            this.mtxtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNome.SelectedText = "";
            this.mtxtNome.Size = new System.Drawing.Size(348, 23);
            this.mtxtNome.TabIndex = 4;
            this.mtxtNome.UseSelectable = true;
            // 
            // mtxtCodigo
            // 
            this.mtxtCodigo.Lines = new string[0];
            this.mtxtCodigo.Location = new System.Drawing.Point(137, 34);
            this.mtxtCodigo.MaxLength = 32767;
            this.mtxtCodigo.Name = "mtxtCodigo";
            this.mtxtCodigo.PasswordChar = '\0';
            this.mtxtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCodigo.SelectedText = "";
            this.mtxtCodigo.Size = new System.Drawing.Size(91, 23);
            this.mtxtCodigo.TabIndex = 2;
            this.mtxtCodigo.UseSelectable = true;
            this.mtxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCodigo_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(235, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Nome:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "*Código:";
            // 
            // mlblAvisos
            // 
            this.mlblAvisos.AutoSize = true;
            this.mlblAvisos.Location = new System.Drawing.Point(66, 231);
            this.mlblAvisos.Name = "mlblAvisos";
            this.mlblAvisos.Size = new System.Drawing.Size(0, 0);
            this.mlblAvisos.TabIndex = 28;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 391);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mTileVoltar);
            this.Name = "frmProdutos";
            this.Text = "Produtos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mTileVoltar;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mlblAvisos;
        public MetroFramework.Controls.MetroTextBox mtxtPrecoVenda;
        public MetroFramework.Controls.MetroTextBox mtxtPrecoCusto;
        public MetroFramework.Controls.MetroTextBox mtxtQuantidadeMin;
        public MetroFramework.Controls.MetroTextBox mtxtQuantidade;
        public MetroFramework.Controls.MetroTextBox mtxtNome;
        public MetroFramework.Controls.MetroTextBox mtxtCodigo;
        public MetroFramework.Controls.MetroButton mbtnCadastrar;
        public MetroFramework.Controls.MetroButton mbtnNovo;
        public MetroFramework.Controls.MetroButton mbtnAlterar;
        public MetroFramework.Controls.MetroButton mbtnConsultar;
    }
}