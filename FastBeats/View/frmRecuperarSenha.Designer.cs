namespace FastBeats.View
{
    partial class frmRecuperarSenha
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mlinkJaPossueCod = new MetroFramework.Controls.MetroLink();
            this.mtxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mbtnProximo1 = new MetroFramework.Controls.MetroButton();
            this.mpanel2Confirmacao = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mbtnProximo2 = new MetroFramework.Controls.MetroButton();
            this.mtxtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.mpainel3Senha = new MetroFramework.Controls.MetroPanel();
            this.mlblAvisos = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mbtnConcluir = new MetroFramework.Controls.MetroButton();
            this.mtxtConfirmaSenha = new MetroFramework.Controls.MetroTextBox();
            this.mtxtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.mpanel2Confirmacao.SuspendLayout();
            this.mpainel3Senha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.mlinkJaPossueCod);
            this.metroPanel1.Controls.Add(this.mtxtEmail);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.mbtnProximo1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(199, 71);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(386, 136);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mlinkJaPossueCod
            // 
            this.mlinkJaPossueCod.Location = new System.Drawing.Point(-1, 112);
            this.mlinkJaPossueCod.Name = "mlinkJaPossueCod";
            this.mlinkJaPossueCod.Size = new System.Drawing.Size(109, 23);
            this.mlinkJaPossueCod.TabIndex = 7;
            this.mlinkJaPossueCod.Text = "Já tenho o codigo";
            this.mlinkJaPossueCod.UseSelectable = true;
            this.mlinkJaPossueCod.Click += new System.EventHandler(this.mlinkJaPossueCod_Click);
            // 
            // mtxtEmail
            // 
            this.mtxtEmail.Lines = new string[] {
        "Email"};
            this.mtxtEmail.Location = new System.Drawing.Point(31, 61);
            this.mtxtEmail.MaxLength = 32767;
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.PasswordChar = '\0';
            this.mtxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtEmail.SelectedText = "";
            this.mtxtEmail.Size = new System.Drawing.Size(254, 23);
            this.mtxtEmail.TabIndex = 6;
            this.mtxtEmail.Text = "Email";
            this.mtxtEmail.UseSelectable = true;
            this.mtxtEmail.Enter += new System.EventHandler(this.mtxtEmail_Enter);
            this.mtxtEmail.Leave += new System.EventHandler(this.mtxtEmail_Leave);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(3, 2);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(22, 25);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Digite seu email:";
            // 
            // mbtnProximo1
            // 
            this.mbtnProximo1.Location = new System.Drawing.Point(295, 95);
            this.mbtnProximo1.Name = "mbtnProximo1";
            this.mbtnProximo1.Size = new System.Drawing.Size(75, 23);
            this.mbtnProximo1.TabIndex = 2;
            this.mbtnProximo1.Text = "Próximo";
            this.mbtnProximo1.UseSelectable = true;
            this.mbtnProximo1.Click += new System.EventHandler(this.mbtnProximo1_Click);
            // 
            // mpanel2Confirmacao
            // 
            this.mpanel2Confirmacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mpanel2Confirmacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpanel2Confirmacao.Controls.Add(this.metroLabel7);
            this.mpanel2Confirmacao.Controls.Add(this.metroLabel5);
            this.mpanel2Confirmacao.Controls.Add(this.metroLabel2);
            this.mpanel2Confirmacao.Controls.Add(this.mbtnProximo2);
            this.mpanel2Confirmacao.Controls.Add(this.mtxtCodigo);
            this.mpanel2Confirmacao.HorizontalScrollbarBarColor = true;
            this.mpanel2Confirmacao.HorizontalScrollbarHighlightOnWheel = false;
            this.mpanel2Confirmacao.HorizontalScrollbarSize = 10;
            this.mpanel2Confirmacao.Location = new System.Drawing.Point(199, 213);
            this.mpanel2Confirmacao.Name = "mpanel2Confirmacao";
            this.mpanel2Confirmacao.Size = new System.Drawing.Size(386, 136);
            this.mpanel2Confirmacao.TabIndex = 2;
            this.mpanel2Confirmacao.VerticalScrollbarBarColor = true;
            this.mpanel2Confirmacao.VerticalScrollbarHighlightOnWheel = false;
            this.mpanel2Confirmacao.VerticalScrollbarSize = 10;
            this.mpanel2Confirmacao.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(3, 10);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(22, 25);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "2";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(91, 74);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(140, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Copie-o e cole-o aqui";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(309, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Enviamos um email com o código de recuperação.";
            // 
            // mbtnProximo2
            // 
            this.mbtnProximo2.Location = new System.Drawing.Point(295, 96);
            this.mbtnProximo2.Name = "mbtnProximo2";
            this.mbtnProximo2.Size = new System.Drawing.Size(75, 23);
            this.mbtnProximo2.TabIndex = 4;
            this.mbtnProximo2.Text = "Próximo";
            this.mbtnProximo2.UseSelectable = true;
            this.mbtnProximo2.Click += new System.EventHandler(this.mbtnProximo2_Click);
            // 
            // mtxtCodigo
            // 
            this.mtxtCodigo.Lines = new string[] {
        "Código de recuperação"};
            this.mtxtCodigo.Location = new System.Drawing.Point(91, 96);
            this.mtxtCodigo.MaxLength = 32767;
            this.mtxtCodigo.Name = "mtxtCodigo";
            this.mtxtCodigo.PasswordChar = '\0';
            this.mtxtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCodigo.SelectedText = "";
            this.mtxtCodigo.Size = new System.Drawing.Size(147, 23);
            this.mtxtCodigo.TabIndex = 4;
            this.mtxtCodigo.Text = "Código de recuperação";
            this.mtxtCodigo.UseSelectable = true;
            this.mtxtCodigo.Enter += new System.EventHandler(this.mtxtCodigo_Enter);
            this.mtxtCodigo.Leave += new System.EventHandler(this.mtxtCodigo_Leave);
            // 
            // mpainel3Senha
            // 
            this.mpainel3Senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mpainel3Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpainel3Senha.Controls.Add(this.mlblAvisos);
            this.mpainel3Senha.Controls.Add(this.metroLabel8);
            this.mpainel3Senha.Controls.Add(this.metroLabel4);
            this.mpainel3Senha.Controls.Add(this.metroLabel3);
            this.mpainel3Senha.Controls.Add(this.mbtnConcluir);
            this.mpainel3Senha.Controls.Add(this.mtxtConfirmaSenha);
            this.mpainel3Senha.Controls.Add(this.mtxtSenha);
            this.mpainel3Senha.HorizontalScrollbarBarColor = true;
            this.mpainel3Senha.HorizontalScrollbarHighlightOnWheel = false;
            this.mpainel3Senha.HorizontalScrollbarSize = 10;
            this.mpainel3Senha.Location = new System.Drawing.Point(199, 355);
            this.mpainel3Senha.Name = "mpainel3Senha";
            this.mpainel3Senha.Size = new System.Drawing.Size(386, 136);
            this.mpainel3Senha.TabIndex = 3;
            this.mpainel3Senha.VerticalScrollbarBarColor = true;
            this.mpainel3Senha.VerticalScrollbarHighlightOnWheel = false;
            this.mpainel3Senha.VerticalScrollbarSize = 10;
            this.mpainel3Senha.Visible = false;
            // 
            // mlblAvisos
            // 
            this.mlblAvisos.AutoSize = true;
            this.mlblAvisos.Location = new System.Drawing.Point(3, 115);
            this.mlblAvisos.Name = "mlblAvisos";
            this.mlblAvisos.Size = new System.Drawing.Size(0, 0);
            this.mlblAvisos.TabIndex = 11;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(3, 11);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(22, 25);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "3";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(84, 70);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Repita Senha";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(84, 22);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Nova senha:";
            // 
            // mbtnConcluir
            // 
            this.mbtnConcluir.Location = new System.Drawing.Point(295, 102);
            this.mbtnConcluir.Name = "mbtnConcluir";
            this.mbtnConcluir.Size = new System.Drawing.Size(75, 23);
            this.mbtnConcluir.TabIndex = 7;
            this.mbtnConcluir.Text = "Concluir";
            this.mbtnConcluir.UseSelectable = true;
            this.mbtnConcluir.Click += new System.EventHandler(this.mbtnConcluir_Click);
            // 
            // mtxtConfirmaSenha
            // 
            this.mtxtConfirmaSenha.Lines = new string[] {
        "Senha"};
            this.mtxtConfirmaSenha.Location = new System.Drawing.Point(84, 92);
            this.mtxtConfirmaSenha.MaxLength = 32767;
            this.mtxtConfirmaSenha.Name = "mtxtConfirmaSenha";
            this.mtxtConfirmaSenha.PasswordChar = '♫';
            this.mtxtConfirmaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtConfirmaSenha.SelectedText = "";
            this.mtxtConfirmaSenha.Size = new System.Drawing.Size(147, 23);
            this.mtxtConfirmaSenha.TabIndex = 8;
            this.mtxtConfirmaSenha.Text = "Senha";
            this.mtxtConfirmaSenha.UseSelectable = true;
            this.mtxtConfirmaSenha.TextChanged += new System.EventHandler(this.mtxtConfirmaSenha_TextChanged);
            this.mtxtConfirmaSenha.Enter += new System.EventHandler(this.mtxtConfirmaSenha_Enter);
            this.mtxtConfirmaSenha.Leave += new System.EventHandler(this.mtxtConfirmaSenha_Leave);
            // 
            // mtxtSenha
            // 
            this.mtxtSenha.Lines = new string[] {
        "Senha"};
            this.mtxtSenha.Location = new System.Drawing.Point(84, 44);
            this.mtxtSenha.MaxLength = 32767;
            this.mtxtSenha.Name = "mtxtSenha";
            this.mtxtSenha.PasswordChar = '♫';
            this.mtxtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSenha.SelectedText = "";
            this.mtxtSenha.Size = new System.Drawing.Size(147, 23);
            this.mtxtSenha.TabIndex = 6;
            this.mtxtSenha.Text = "Senha";
            this.mtxtSenha.UseSelectable = true;
            this.mtxtSenha.Enter += new System.EventHandler(this.mtxtSenha_Enter);
            this.mtxtSenha.Leave += new System.EventHandler(this.mtxtSenha_Leave);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 501);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 4;
            this.mTileVoltar.TileImage = global::FastBeats.Properties.Resources.setaEsquerda;
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // frmRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(788, 564);
            this.Controls.Add(this.mTileVoltar);
            this.Controls.Add(this.mpainel3Senha);
            this.Controls.Add(this.mpanel2Confirmacao);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmRecuperarSenha";
            this.Load += new System.EventHandler(this.frmRecuperarSenha_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.mpanel2Confirmacao.ResumeLayout(false);
            this.mpanel2Confirmacao.PerformLayout();
            this.mpainel3Senha.ResumeLayout(false);
            this.mpainel3Senha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel mpanel2Confirmacao;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mbtnProximo1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mbtnProximo2;
        private MetroFramework.Controls.MetroTextBox mtxtCodigo;
        private MetroFramework.Controls.MetroPanel mpainel3Senha;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton mbtnConcluir;
        private MetroFramework.Controls.MetroTextBox mtxtConfirmaSenha;
        private MetroFramework.Controls.MetroTextBox mtxtSenha;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox mtxtEmail;
        private MetroFramework.Controls.MetroLink mlinkJaPossueCod;
        private MetroFramework.Controls.MetroTile mTileVoltar;
        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroLabel mlblAvisos;
    }
}