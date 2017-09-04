namespace FastBeats.View
{
    partial class frmRecepcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecepcao));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mTileAddComanda = new MetroFramework.Controls.MetroTile();
            this.mbnFinalizar = new MetroFramework.Controls.MetroButton();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtxtComanda = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mcboIngresso = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtValor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mlblAvisos = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.mPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 351);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 23;
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
            this.mPanel.Controls.Add(this.mTileAddComanda);
            this.mPanel.Controls.Add(this.mbnFinalizar);
            this.mPanel.Controls.Add(this.cboClientes);
            this.mPanel.Controls.Add(this.mskCPF);
            this.mPanel.Controls.Add(this.metroLabel5);
            this.mPanel.Controls.Add(this.mtxtComanda);
            this.mPanel.Controls.Add(this.metroLabel4);
            this.mPanel.Controls.Add(this.mcboIngresso);
            this.mPanel.Controls.Add(this.metroLabel3);
            this.mPanel.Controls.Add(this.mtxtValor);
            this.mPanel.Controls.Add(this.metroLabel2);
            this.mPanel.Controls.Add(this.metroLabel1);
            this.mPanel.Controls.Add(this.mlblAvisos);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(67, 81);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(687, 252);
            this.mPanel.TabIndex = 24;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mTileAddComanda
            // 
            this.mTileAddComanda.ActiveControl = null;
            this.mTileAddComanda.Location = new System.Drawing.Point(412, 59);
            this.mTileAddComanda.Name = "mTileAddComanda";
            this.mTileAddComanda.Size = new System.Drawing.Size(24, 24);
            this.mTileAddComanda.TabIndex = 39;
            this.mTileAddComanda.Text = "+";
            this.mTileAddComanda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAddComanda.UseSelectable = true;
            this.mTileAddComanda.Click += new System.EventHandler(this.mTileAddComanda_Click);
            // 
            // mbnFinalizar
            // 
            this.mbnFinalizar.Location = new System.Drawing.Point(588, 218);
            this.mbnFinalizar.Name = "mbnFinalizar";
            this.mbnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.mbnFinalizar.TabIndex = 38;
            this.mbnFinalizar.Text = "Finalizar";
            this.mbnFinalizar.UseSelectable = true;
            this.mbnFinalizar.Click += new System.EventHandler(this.mbnFinalizar_Click);
            // 
            // cboClientes
            // 
            this.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cboClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(91, 23);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(345, 21);
            this.cboClientes.TabIndex = 37;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            this.cboClientes.TextChanged += new System.EventHandler(this.cboClientes_TextChanged);
            // 
            // mskCPF
            // 
            this.mskCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.mskCPF.ForeColor = System.Drawing.Color.Gainsboro;
            this.mskCPF.Location = new System.Drawing.Point(91, 58);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 36;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 58);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "CPF*:";
            // 
            // mtxtComanda
            // 
            this.mtxtComanda.Lines = new string[0];
            this.mtxtComanda.Location = new System.Drawing.Point(296, 59);
            this.mtxtComanda.MaxLength = 32767;
            this.mtxtComanda.Name = "mtxtComanda";
            this.mtxtComanda.PasswordChar = '\0';
            this.mtxtComanda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtComanda.SelectedText = "";
            this.mtxtComanda.Size = new System.Drawing.Size(110, 23);
            this.mtxtComanda.TabIndex = 34;
            this.mtxtComanda.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(214, 59);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Comanda*:";
            // 
            // mcboIngresso
            // 
            this.mcboIngresso.FormattingEnabled = true;
            this.mcboIngresso.ItemHeight = 23;
            this.mcboIngresso.Items.AddRange(new object[] {
            "Pista Homem",
            "Pista Mulher",
            "Vip Homem",
            "Vip Mulher"});
            this.mcboIngresso.Location = new System.Drawing.Point(542, 20);
            this.mcboIngresso.Name = "mcboIngresso";
            this.mcboIngresso.Size = new System.Drawing.Size(113, 29);
            this.mcboIngresso.TabIndex = 32;
            this.mcboIngresso.UseSelectable = true;
            this.mcboIngresso.SelectedIndexChanged += new System.EventHandler(this.mcboIngresso_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(468, 22);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Entrada*:";
            // 
            // mtxtValor
            // 
            this.mtxtValor.Lines = new string[0];
            this.mtxtValor.Location = new System.Drawing.Point(542, 62);
            this.mtxtValor.MaxLength = 32767;
            this.mtxtValor.Name = "mtxtValor";
            this.mtxtValor.PasswordChar = '\0';
            this.mtxtValor.ReadOnly = true;
            this.mtxtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtValor.SelectedText = "";
            this.mtxtValor.Size = new System.Drawing.Size(110, 23);
            this.mtxtValor.TabIndex = 30;
            this.mtxtValor.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(468, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Valor:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Cliente:";
            // 
            // mlblAvisos
            // 
            this.mlblAvisos.AutoSize = true;
            this.mlblAvisos.Location = new System.Drawing.Point(121, 222);
            this.mlblAvisos.Name = "mlblAvisos";
            this.mlblAvisos.Size = new System.Drawing.Size(0, 0);
            this.mlblAvisos.TabIndex = 26;
            // 
            // frmRecepcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 414);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mTileVoltar);
            this.Name = "frmRecepcao";
            this.Text = "Recepção";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmRecepção_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTile mTileVoltar;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLabel mlblAvisos;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox mcboIngresso;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtxtValor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cboClientes;
        private MetroFramework.Controls.MetroButton mbnFinalizar;
        private MetroFramework.Controls.MetroTile mTileAddComanda;
        public MetroFramework.Controls.MetroTextBox mtxtComanda;

    }
}