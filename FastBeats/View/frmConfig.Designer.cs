namespace FastBeats.View
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabPageGerais = new MetroFramework.Controls.MetroTabPage();
            this.mcboTema = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mcboCor = new MetroFramework.Controls.MetroComboBox();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroTabPageGerais.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.mPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // metroTabPageGerais
            // 
            this.metroTabPageGerais.Controls.Add(this.mcboTema);
            this.metroTabPageGerais.Controls.Add(this.metroLabel1);
            this.metroTabPageGerais.Controls.Add(this.metroLabel2);
            this.metroTabPageGerais.Controls.Add(this.mcboCor);
            this.metroTabPageGerais.HorizontalScrollbarBarColor = true;
            this.metroTabPageGerais.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageGerais.HorizontalScrollbarSize = 10;
            this.metroTabPageGerais.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageGerais.Name = "metroTabPageGerais";
            this.metroTabPageGerais.Padding = new System.Windows.Forms.Padding(25);
            this.metroTabPageGerais.Size = new System.Drawing.Size(660, 210);
            this.metroTabPageGerais.TabIndex = 2;
            this.metroTabPageGerais.Text = "Gerais";
            this.metroTabPageGerais.VerticalScrollbarBarColor = true;
            this.metroTabPageGerais.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageGerais.VerticalScrollbarSize = 10;
            this.metroTabPageGerais.Visible = false;
            // 
            // mcboTema
            // 
            this.mcboTema.FormattingEnabled = true;
            this.mcboTema.ItemHeight = 23;
            this.mcboTema.Items.AddRange(new object[] {
            "Branco",
            "Preto"});
            this.mcboTema.Location = new System.Drawing.Point(134, 55);
            this.mcboTema.Name = "mcboTema";
            this.mcboTema.Size = new System.Drawing.Size(121, 29);
            this.mcboTema.TabIndex = 6;
            this.mcboTema.UseSelectable = true;
            this.mcboTema.SelectedIndexChanged += new System.EventHandler(this.mcboTema_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(85, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tema:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(93, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Cor:";
            // 
            // mcboCor
            // 
            this.mcboCor.FormattingEnabled = true;
            this.mcboCor.ItemHeight = 23;
            this.mcboCor.Items.AddRange(new object[] {
            "Cinza",
            "Azul",
            "Verde",
            "Verde-Limão",
            "Verde-Azulado",
            "Laranja",
            "Marrom",
            "Rosa",
            "Magenta",
            "Roxo",
            "Vermelho",
            "Amarelo"});
            this.mcboCor.Location = new System.Drawing.Point(134, 112);
            this.mcboCor.Name = "mcboCor";
            this.mcboCor.Size = new System.Drawing.Size(121, 29);
            this.mcboCor.TabIndex = 5;
            this.mcboCor.UseSelectable = true;
            this.mcboCor.SelectedIndexChanged += new System.EventHandler(this.mcboCor_SelectedIndexChanged);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPageGerais);
            this.metroTabControl.Location = new System.Drawing.Point(-1, -1);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(668, 252);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            // 
            // mPanel
            // 
            this.mPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel.Controls.Add(this.metroTabControl);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(43, 96);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(668, 252);
            this.mPanel.TabIndex = 25;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 381);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 26;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 444);
            this.Controls.Add(this.mTileVoltar);
            this.Controls.Add(this.mPanel);
            this.Name = "frmConfig";
            this.Text = "Ajustes";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroTabPageGerais.ResumeLayout(false);
            this.metroTabPageGerais.PerformLayout();
            this.metroTabControl.ResumeLayout(false);
            this.mPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPageGerais;
        private MetroFramework.Controls.MetroComboBox mcboTema;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox mcboCor;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroTile mTileVoltar;

    }
}