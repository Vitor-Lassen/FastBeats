namespace FastBeats.View
{
    partial class frmGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenero));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mtxtGenero = new MetroFramework.Controls.MetroTextBox();
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            this.mbtnCadastrar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.mPanel.SuspendLayout();
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
            this.mPanel.Controls.Add(this.metroLabel13);
            this.mPanel.Controls.Add(this.mtxtGenero);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(23, 82);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(661, 183);
            this.mPanel.TabIndex = 0;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(8, 15);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(55, 19);
            this.metroLabel13.TabIndex = 3;
            this.metroLabel13.Text = "Gênero:";
            // 
            // mtxtGenero
            // 
            this.mtxtGenero.Lines = new string[0];
            this.mtxtGenero.Location = new System.Drawing.Point(83, 14);
            this.mtxtGenero.MaxLength = 32767;
            this.mtxtGenero.Name = "mtxtGenero";
            this.mtxtGenero.PasswordChar = '\0';
            this.mtxtGenero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtGenero.SelectedText = "";
            this.mtxtGenero.Size = new System.Drawing.Size(406, 19);
            this.mtxtGenero.TabIndex = 2;
            this.mtxtGenero.UseSelectable = true;
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 318);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 6;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // mbtnCadastrar
            // 
            this.mbtnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnCadastrar.Location = new System.Drawing.Point(581, 309);
            this.mbtnCadastrar.Name = "mbtnCadastrar";
            this.mbtnCadastrar.Size = new System.Drawing.Size(103, 33);
            this.mbtnCadastrar.TabIndex = 4;
            this.mbtnCadastrar.Text = "Cadastrar";
            this.mbtnCadastrar.UseSelectable = true;
            this.mbtnCadastrar.Click += new System.EventHandler(this.mbtnCadastrar_Click);
            // 
            // frmGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 381);
            this.Controls.Add(this.mbtnCadastrar);
            this.Controls.Add(this.mTileVoltar);
            this.Controls.Add(this.mPanel);
            this.Name = "frmGenero";
            this.Text = "Gêneros";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroTile mTileVoltar;
        private MetroFramework.Controls.MetroButton mbtnCadastrar;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox mtxtGenero;
    }
}