namespace FastBeats.View
{
    partial class frmMenuPrincipal
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
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.picBoxIcone = new System.Windows.Forms.PictureBox();
            this.metroTileConfig = new MetroFramework.Controls.MetroTile();
            this.metroTileLogoff = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mTileRelatorios = new MetroFramework.Controls.MetroTile();
            this.mTileRecepcao = new MetroFramework.Controls.MetroTile();
            this.mTileAgenda = new MetroFramework.Controls.MetroTile();
            this.mTileCaixa = new MetroFramework.Controls.MetroTile();
            this.mTileCardapio = new MetroFramework.Controls.MetroTile();
            this.mTileVenda = new MetroFramework.Controls.MetroTile();
            this.mTileClientes = new MetroFramework.Controls.MetroTile();
            this.mTileProdutos = new MetroFramework.Controls.MetroTile();
            this.mTileArtistas = new MetroFramework.Controls.MetroTile();
            this.mTileFuncionarios = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcone)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // picBoxIcone
            // 
            this.picBoxIcone.Image = global::FastBeats.Properties.Resources.icone_branco0;
            this.picBoxIcone.Location = new System.Drawing.Point(7, 16);
            this.picBoxIcone.Name = "picBoxIcone";
            this.picBoxIcone.Size = new System.Drawing.Size(192, 143);
            this.picBoxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxIcone.TabIndex = 4;
            this.picBoxIcone.TabStop = false;
            this.metroToolTip1.SetToolTip(this.picBoxIcone, "Sobre");
            this.picBoxIcone.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroTileConfig
            // 
            this.metroTileConfig.ActiveControl = null;
            this.metroTileConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTileConfig.Location = new System.Drawing.Point(1315, 634);
            this.metroTileConfig.Name = "metroTileConfig";
            this.metroTileConfig.Size = new System.Drawing.Size(40, 40);
            this.metroTileConfig.TabIndex = 3;
            this.metroTileConfig.TileImage = global::FastBeats.Properties.Resources.setings32;
            this.metroTileConfig.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.metroTileConfig, "Ajustes");
            this.metroTileConfig.UseSelectable = true;
            this.metroTileConfig.UseTileImage = true;
            this.metroTileConfig.Click += new System.EventHandler(this.metroTileConfig_Click);
            // 
            // metroTileLogoff
            // 
            this.metroTileLogoff.ActiveControl = null;
            this.metroTileLogoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTileLogoff.Location = new System.Drawing.Point(23, 644);
            this.metroTileLogoff.Name = "metroTileLogoff";
            this.metroTileLogoff.Size = new System.Drawing.Size(40, 40);
            this.metroTileLogoff.TabIndex = 0;
            this.metroTileLogoff.TileImage = global::FastBeats.Properties.Resources.power32;
            this.metroTileLogoff.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToolTip1.SetToolTip(this.metroTileLogoff, "Logoff");
            this.metroTileLogoff.UseSelectable = true;
            this.metroTileLogoff.UseTileImage = true;
            this.metroTileLogoff.Click += new System.EventHandler(this.metroTileLogoff_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel1.Controls.Add(this.mTileRelatorios);
            this.metroPanel1.Controls.Add(this.mTileRecepcao);
            this.metroPanel1.Controls.Add(this.mTileAgenda);
            this.metroPanel1.Controls.Add(this.mTileCaixa);
            this.metroPanel1.Controls.Add(this.mTileCardapio);
            this.metroPanel1.Controls.Add(this.mTileVenda);
            this.metroPanel1.Controls.Add(this.mTileClientes);
            this.metroPanel1.Controls.Add(this.mTileProdutos);
            this.metroPanel1.Controls.Add(this.mTileArtistas);
            this.metroPanel1.Controls.Add(this.mTileFuncionarios);
            this.metroPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(307, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(804, 547);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mTileRelatorios
            // 
            this.mTileRelatorios.ActiveControl = null;
            this.mTileRelatorios.AutoSize = true;
            this.mTileRelatorios.Location = new System.Drawing.Point(311, 409);
            this.mTileRelatorios.Name = "mTileRelatorios";
            this.mTileRelatorios.Size = new System.Drawing.Size(161, 128);
            this.mTileRelatorios.TabIndex = 17;
            this.mTileRelatorios.Text = "Relatórios";
            this.mTileRelatorios.TileImage = global::FastBeats.Properties.Resources.money182;
            this.mTileRelatorios.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileRelatorios.UseSelectable = true;
            this.mTileRelatorios.UseTileImage = true;
            this.mTileRelatorios.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mTileRecepcao
            // 
            this.mTileRecepcao.ActiveControl = null;
            this.mTileRecepcao.AutoSize = true;
            this.mTileRecepcao.Location = new System.Drawing.Point(144, 275);
            this.mTileRecepcao.Name = "mTileRecepcao";
            this.mTileRecepcao.Size = new System.Drawing.Size(161, 128);
            this.mTileRecepcao.TabIndex = 16;
            this.mTileRecepcao.Text = "Recepção";
            this.mTileRecepcao.TileImage = global::FastBeats.Properties.Resources.recepção;
            this.mTileRecepcao.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileRecepcao.UseSelectable = true;
            this.mTileRecepcao.UseTileImage = true;
            this.mTileRecepcao.Click += new System.EventHandler(this.mTileRecepcao_Click);
            // 
            // mTileAgenda
            // 
            this.mTileAgenda.ActiveControl = null;
            this.mTileAgenda.AutoSize = true;
            this.mTileAgenda.Location = new System.Drawing.Point(311, 275);
            this.mTileAgenda.Name = "mTileAgenda";
            this.mTileAgenda.Size = new System.Drawing.Size(161, 128);
            this.mTileAgenda.TabIndex = 15;
            this.mTileAgenda.Text = "Agenda";
            this.mTileAgenda.TileImage = global::FastBeats.Properties.Resources.agenda8;
            this.mTileAgenda.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAgenda.UseSelectable = true;
            this.mTileAgenda.UseTileImage = true;
            this.mTileAgenda.Click += new System.EventHandler(this.mTileAgenda_Click);
            // 
            // mTileCaixa
            // 
            this.mTileCaixa.ActiveControl = null;
            this.mTileCaixa.AutoSize = true;
            this.mTileCaixa.Location = new System.Drawing.Point(478, 275);
            this.mTileCaixa.Name = "mTileCaixa";
            this.mTileCaixa.Size = new System.Drawing.Size(161, 128);
            this.mTileCaixa.TabIndex = 13;
            this.mTileCaixa.Text = "Caixa";
            this.mTileCaixa.TileImage = global::FastBeats.Properties.Resources.caixa;
            this.mTileCaixa.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileCaixa.UseSelectable = true;
            this.mTileCaixa.UseTileImage = true;
            this.mTileCaixa.Click += new System.EventHandler(this.mTileCaixa_Click);
            // 
            // mTileCardapio
            // 
            this.mTileCardapio.ActiveControl = null;
            this.mTileCardapio.AutoSize = true;
            this.mTileCardapio.Location = new System.Drawing.Point(311, 139);
            this.mTileCardapio.Name = "mTileCardapio";
            this.mTileCardapio.Size = new System.Drawing.Size(161, 128);
            this.mTileCardapio.TabIndex = 8;
            this.mTileCardapio.Text = "Cardápio";
            this.mTileCardapio.TileImage = global::FastBeats.Properties.Resources.cardapio;
            this.mTileCardapio.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileCardapio.UseSelectable = true;
            this.mTileCardapio.UseTileImage = true;
            this.mTileCardapio.Click += new System.EventHandler(this.mTileCardapio_Click);
            // 
            // mTileVenda
            // 
            this.mTileVenda.ActiveControl = null;
            this.mTileVenda.AutoSize = true;
            this.mTileVenda.Location = new System.Drawing.Point(478, 139);
            this.mTileVenda.Name = "mTileVenda";
            this.mTileVenda.Size = new System.Drawing.Size(161, 128);
            this.mTileVenda.TabIndex = 12;
            this.mTileVenda.Text = "Vendas";
            this.mTileVenda.TileImage = global::FastBeats.Properties.Resources.vendas;
            this.mTileVenda.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVenda.UseSelectable = true;
            this.mTileVenda.UseTileImage = true;
            this.mTileVenda.Click += new System.EventHandler(this.mTileVenda_Click);
            // 
            // mTileClientes
            // 
            this.mTileClientes.ActiveControl = null;
            this.mTileClientes.AutoSize = true;
            this.mTileClientes.Location = new System.Drawing.Point(144, 3);
            this.mTileClientes.Name = "mTileClientes";
            this.mTileClientes.Size = new System.Drawing.Size(161, 128);
            this.mTileClientes.TabIndex = 2;
            this.mTileClientes.Text = "Clientes";
            this.mTileClientes.TileImage = global::FastBeats.Properties.Resources.Clientes;
            this.mTileClientes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileClientes.UseSelectable = true;
            this.mTileClientes.UseTileImage = true;
            this.mTileClientes.Click += new System.EventHandler(this.mTileClientes_Click);
            // 
            // mTileProdutos
            // 
            this.mTileProdutos.ActiveControl = null;
            this.mTileProdutos.AutoSize = true;
            this.mTileProdutos.Location = new System.Drawing.Point(144, 139);
            this.mTileProdutos.Name = "mTileProdutos";
            this.mTileProdutos.Size = new System.Drawing.Size(161, 128);
            this.mTileProdutos.TabIndex = 10;
            this.mTileProdutos.Text = "Produtos";
            this.mTileProdutos.TileImage = global::FastBeats.Properties.Resources.produtos1;
            this.mTileProdutos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileProdutos.UseSelectable = true;
            this.mTileProdutos.UseTileImage = true;
            this.mTileProdutos.Click += new System.EventHandler(this.mTileProdutos_Click_1);
            // 
            // mTileArtistas
            // 
            this.mTileArtistas.ActiveControl = null;
            this.mTileArtistas.AutoSize = true;
            this.mTileArtistas.Location = new System.Drawing.Point(478, 3);
            this.mTileArtistas.Name = "mTileArtistas";
            this.mTileArtistas.Size = new System.Drawing.Size(161, 128);
            this.mTileArtistas.TabIndex = 6;
            this.mTileArtistas.Text = "Artistas";
            this.mTileArtistas.TileImage = global::FastBeats.Properties.Resources.Artista;
            this.mTileArtistas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileArtistas.UseSelectable = true;
            this.mTileArtistas.UseTileImage = true;
            this.mTileArtistas.Click += new System.EventHandler(this.mTileArtistas_Click);
            // 
            // mTileFuncionarios
            // 
            this.mTileFuncionarios.ActiveControl = null;
            this.mTileFuncionarios.Location = new System.Drawing.Point(311, 3);
            this.mTileFuncionarios.Name = "mTileFuncionarios";
            this.mTileFuncionarios.Size = new System.Drawing.Size(161, 128);
            this.mTileFuncionarios.TabIndex = 4;
            this.mTileFuncionarios.Text = "Funcionários";
            this.mTileFuncionarios.TileImage = global::FastBeats.Properties.Resources.Funcionarios;
            this.mTileFuncionarios.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileFuncionarios.UseSelectable = true;
            this.mTileFuncionarios.UseTileImage = true;
            this.mTileFuncionarios.Click += new System.EventHandler(this.mTileFuncionarios_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 707);
            this.Controls.Add(this.picBoxIcone);
            this.Controls.Add(this.metroTileConfig);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTileLogoff);
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcone)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTile metroTileLogoff;
        private MetroFramework.Controls.MetroTile mTileClientes;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile mTileFuncionarios;
        private MetroFramework.Controls.MetroTile metroTileConfig;
        private MetroFramework.Controls.MetroTile mTileArtistas;
        private MetroFramework.Controls.MetroTile mTileProdutos;
        private MetroFramework.Controls.MetroTile mTileVenda;
        private MetroFramework.Controls.MetroTile mTileCardapio;
        private MetroFramework.Controls.MetroTile mTileCaixa;
        private MetroFramework.Controls.MetroTile mTileAgenda;
        private MetroFramework.Controls.MetroTile mTileRecepcao;
        private System.Windows.Forms.PictureBox picBoxIcone;
        private MetroFramework.Controls.MetroTile mTileRelatorios;
    }
}