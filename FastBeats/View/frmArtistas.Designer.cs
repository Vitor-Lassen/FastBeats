namespace FastBeats.View
{
    partial class frmArtistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtistas));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mbtnNovo = new MetroFramework.Controls.MetroButton();
            this.mbtnAtualizar = new MetroFramework.Controls.MetroButton();
            this.mtxtEmpresario = new MetroFramework.Controls.MetroTextBox();
            this.mbtnMaisGenero = new MetroFramework.Controls.MetroButton();
            this.mbtnConsultar = new MetroFramework.Controls.MetroButton();
            this.mlblAvisos = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.mcboGenero = new MetroFramework.Controls.MetroComboBox();
            this.mbtnCadastrar = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mtxtArtista = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
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
            this.mPanel.Controls.Add(this.mbtnNovo);
            this.mPanel.Controls.Add(this.mbtnAtualizar);
            this.mPanel.Controls.Add(this.mtxtEmpresario);
            this.mPanel.Controls.Add(this.mbtnMaisGenero);
            this.mPanel.Controls.Add(this.mbtnConsultar);
            this.mPanel.Controls.Add(this.mlblAvisos);
            this.mPanel.Controls.Add(this.metroLabel3);
            this.mPanel.Controls.Add(this.metroLabel2);
            this.mPanel.Controls.Add(this.mtxtEmail);
            this.mPanel.Controls.Add(this.mcboGenero);
            this.mPanel.Controls.Add(this.mbtnCadastrar);
            this.mPanel.Controls.Add(this.metroLabel13);
            this.mPanel.Controls.Add(this.mtxtArtista);
            this.mPanel.Controls.Add(this.metroLabel16);
            this.mPanel.Controls.Add(this.mskTel);
            this.mPanel.Controls.Add(this.metroLabel17);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(26, 74);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(687, 252);
            this.mPanel.TabIndex = 24;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mbtnNovo
            // 
            this.mbtnNovo.Location = new System.Drawing.Point(568, 203);
            this.mbtnNovo.Name = "mbtnNovo";
            this.mbtnNovo.Size = new System.Drawing.Size(103, 33);
            this.mbtnNovo.TabIndex = 32;
            this.mbtnNovo.Text = "Novo";
            this.mbtnNovo.UseSelectable = true;
            this.mbtnNovo.Visible = false;
            this.mbtnNovo.Click += new System.EventHandler(this.mbtnNovo_Click);
            // 
            // mbtnAtualizar
            // 
            this.mbtnAtualizar.Location = new System.Drawing.Point(350, 203);
            this.mbtnAtualizar.Name = "mbtnAtualizar";
            this.mbtnAtualizar.Size = new System.Drawing.Size(103, 33);
            this.mbtnAtualizar.TabIndex = 31;
            this.mbtnAtualizar.Text = "Atualizar";
            this.mbtnAtualizar.UseSelectable = true;
            this.mbtnAtualizar.Visible = false;
            this.mbtnAtualizar.Click += new System.EventHandler(this.mbtnAtualizar_Click);
            // 
            // mtxtEmpresario
            // 
            this.mtxtEmpresario.Lines = new string[0];
            this.mtxtEmpresario.Location = new System.Drawing.Point(84, 102);
            this.mtxtEmpresario.MaxLength = 32767;
            this.mtxtEmpresario.Name = "mtxtEmpresario";
            this.mtxtEmpresario.PasswordChar = '\0';
            this.mtxtEmpresario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtEmpresario.SelectedText = "";
            this.mtxtEmpresario.Size = new System.Drawing.Size(409, 19);
            this.mtxtEmpresario.TabIndex = 6;
            this.mtxtEmpresario.UseSelectable = true;
            // 
            // mbtnMaisGenero
            // 
            this.mbtnMaisGenero.Location = new System.Drawing.Point(215, 138);
            this.mbtnMaisGenero.Name = "mbtnMaisGenero";
            this.mbtnMaisGenero.Size = new System.Drawing.Size(36, 23);
            this.mbtnMaisGenero.TabIndex = 7;
            this.mbtnMaisGenero.Text = "+";
            this.mbtnMaisGenero.UseSelectable = true;
            this.mbtnMaisGenero.Click += new System.EventHandler(this.mbtnMaisGenero_Click);
            // 
            // mbtnConsultar
            // 
            this.mbtnConsultar.Location = new System.Drawing.Point(459, 203);
            this.mbtnConsultar.Name = "mbtnConsultar";
            this.mbtnConsultar.Size = new System.Drawing.Size(103, 33);
            this.mbtnConsultar.TabIndex = 29;
            this.mbtnConsultar.Text = "Consultar";
            this.mbtnConsultar.UseSelectable = true;
            this.mbtnConsultar.Click += new System.EventHandler(this.mbtnConsultar_Click);
            // 
            // mlblAvisos
            // 
            this.mlblAvisos.AutoSize = true;
            this.mlblAvisos.Location = new System.Drawing.Point(66, 231);
            this.mlblAvisos.Name = "mlblAvisos";
            this.mlblAvisos.Size = new System.Drawing.Size(0, 0);
            this.mlblAvisos.TabIndex = 28;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 102);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Empresário:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Email:";
            // 
            // mtxtEmail
            // 
            this.mtxtEmail.Lines = new string[0];
            this.mtxtEmail.Location = new System.Drawing.Point(87, 61);
            this.mtxtEmail.MaxLength = 32767;
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.PasswordChar = '\0';
            this.mtxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtEmail.SelectedText = "";
            this.mtxtEmail.Size = new System.Drawing.Size(406, 19);
            this.mtxtEmail.TabIndex = 4;
            this.mtxtEmail.UseSelectable = true;
            // 
            // mcboGenero
            // 
            this.mcboGenero.FormattingEnabled = true;
            this.mcboGenero.ItemHeight = 23;
            this.mcboGenero.Location = new System.Drawing.Point(87, 135);
            this.mcboGenero.Name = "mcboGenero";
            this.mcboGenero.Size = new System.Drawing.Size(121, 29);
            this.mcboGenero.TabIndex = 8;
            this.mcboGenero.UseSelectable = true;
            // 
            // mbtnCadastrar
            // 
            this.mbtnCadastrar.Location = new System.Drawing.Point(350, 203);
            this.mbtnCadastrar.Name = "mbtnCadastrar";
            this.mbtnCadastrar.Size = new System.Drawing.Size(103, 33);
            this.mbtnCadastrar.TabIndex = 12;
            this.mbtnCadastrar.Text = "Cadastrar";
            this.mbtnCadastrar.UseSelectable = true;
            this.mbtnCadastrar.Click += new System.EventHandler(this.mbtnCadastrar_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(12, 25);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(54, 19);
            this.metroLabel13.TabIndex = 0;
            this.metroLabel13.Text = "*Artista:";
            // 
            // mtxtArtista
            // 
            this.mtxtArtista.Lines = new string[0];
            this.mtxtArtista.Location = new System.Drawing.Point(87, 24);
            this.mtxtArtista.MaxLength = 32767;
            this.mtxtArtista.Name = "mtxtArtista";
            this.mtxtArtista.PasswordChar = '\0';
            this.mtxtArtista.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtArtista.SelectedText = "";
            this.mtxtArtista.Size = new System.Drawing.Size(406, 19);
            this.mtxtArtista.TabIndex = 2;
            this.mtxtArtista.UseSelectable = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(13, 145);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(55, 19);
            this.metroLabel16.TabIndex = 10;
            this.metroLabel16.Text = "Gênero:";
            // 
            // mskTel
            // 
            this.mskTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.mskTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTel.ForeColor = System.Drawing.Color.Gainsboro;
            this.mskTel.Location = new System.Drawing.Point(328, 144);
            this.mskTel.Mask = "(00)0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(100, 20);
            this.mskTel.TabIndex = 10;
            this.mskTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(257, 145);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(66, 19);
            this.metroLabel17.TabIndex = 9;
            this.metroLabel17.Text = "*Telefone:";
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 337);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 23;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // frmArtistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 400);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mTileVoltar);
            this.Name = "frmArtistas";
            this.Text = "Artistas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmArtistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mTileVoltar;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel mlblAvisos;
        private MetroFramework.Controls.MetroButton mbtnConsultar;
        private MetroFramework.Controls.MetroButton mbtnMaisGenero;
        public MetroFramework.Controls.MetroComboBox mcboGenero;
        public MetroFramework.Controls.MetroTextBox mtxtArtista;
        public MetroFramework.Controls.MetroTextBox mtxtEmpresario;
        public MetroFramework.Controls.MetroTextBox mtxtEmail;
        public System.Windows.Forms.MaskedTextBox mskTel;
        public MetroFramework.Controls.MetroButton mbtnAtualizar;
        public MetroFramework.Controls.MetroButton mbtnCadastrar;
        public MetroFramework.Controls.MetroButton mbtnNovo;
    }
}