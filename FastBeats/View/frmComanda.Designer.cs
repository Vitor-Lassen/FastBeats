namespace FastBeats.View
{
    partial class frmComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComanda));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mbtnAddComanda = new MetroFramework.Controls.MetroButton();
            this.mtxtComanda = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mlblAvisos = new MetroFramework.Controls.MetroLabel();
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Comanda:";
            // 
            // mbtnAddComanda
            // 
            this.mbtnAddComanda.Location = new System.Drawing.Point(177, 92);
            this.mbtnAddComanda.Name = "mbtnAddComanda";
            this.mbtnAddComanda.Size = new System.Drawing.Size(89, 23);
            this.mbtnAddComanda.TabIndex = 1;
            this.mbtnAddComanda.Text = "Adicionar";
            this.mbtnAddComanda.UseSelectable = true;
            this.mbtnAddComanda.Click += new System.EventHandler(this.mbtnAddComanda_Click);
            // 
            // mtxtComanda
            // 
            this.mtxtComanda.Lines = new string[0];
            this.mtxtComanda.Location = new System.Drawing.Point(108, 63);
            this.mtxtComanda.MaxLength = 32767;
            this.mtxtComanda.Name = "mtxtComanda";
            this.mtxtComanda.PasswordChar = '\0';
            this.mtxtComanda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtComanda.SelectedText = "";
            this.mtxtComanda.Size = new System.Drawing.Size(158, 23);
            this.mtxtComanda.TabIndex = 2;
            this.mtxtComanda.UseSelectable = true;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // mlblAvisos
            // 
            this.mlblAvisos.AutoSize = true;
            this.mlblAvisos.Location = new System.Drawing.Point(68, 130);
            this.mlblAvisos.Name = "mlblAvisos";
            this.mlblAvisos.Size = new System.Drawing.Size(0, 0);
            this.mlblAvisos.TabIndex = 27;
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 99);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 28;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // frmComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 162);
            this.Controls.Add(this.mTileVoltar);
            this.Controls.Add(this.mlblAvisos);
            this.Controls.Add(this.mtxtComanda);
            this.Controls.Add(this.mbtnAddComanda);
            this.Controls.Add(this.metroLabel1);
            this.Name = "frmComanda";
            this.Text = "Adicionar comanda";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mbtnAddComanda;
        private MetroFramework.Controls.MetroTextBox mtxtComanda;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroLabel mlblAvisos;
        private MetroFramework.Controls.MetroTile mTileVoltar;
    }
}