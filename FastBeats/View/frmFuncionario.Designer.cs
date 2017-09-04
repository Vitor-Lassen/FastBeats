namespace FastBeats.View
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mbtnNovo = new MetroFramework.Controls.MetroButton();
            this.mbtnAtualizar = new MetroFramework.Controls.MetroButton();
            this.mbtnConsultar = new MetroFramework.Controls.MetroButton();
            this.mlblAvisos = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mtxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.mtxtCargo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.mbtnCadastrar = new MetroFramework.Controls.MetroButton();
            this.mPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.mcboAcesso = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.mtglAtivo = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtxtSenha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mtxtLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mtxtNome = new MetroFramework.Controls.MetroTextBox();
            this.mdtmNascimento = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.mtxtEnd = new MetroFramework.Controls.MetroTextBox();
            this.mtxtRG = new MetroFramework.Controls.MetroTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.mPanel.SuspendLayout();
            this.mPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
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
            this.mPanel.Controls.Add(this.mbtnConsultar);
            this.mPanel.Controls.Add(this.mlblAvisos);
            this.mPanel.Controls.Add(this.metroLabel13);
            this.mPanel.Controls.Add(this.mtxtEmail);
            this.mPanel.Controls.Add(this.mtxtCargo);
            this.mPanel.Controls.Add(this.metroLabel12);
            this.mPanel.Controls.Add(this.mbtnCadastrar);
            this.mPanel.Controls.Add(this.mPanel2);
            this.mPanel.Controls.Add(this.metroLabel1);
            this.mPanel.Controls.Add(this.metroLabel8);
            this.mPanel.Controls.Add(this.mtxtNome);
            this.mPanel.Controls.Add(this.mdtmNascimento);
            this.mPanel.Controls.Add(this.metroLabel2);
            this.mPanel.Controls.Add(this.picFoto);
            this.mPanel.Controls.Add(this.mtxtEnd);
            this.mPanel.Controls.Add(this.mtxtRG);
            this.mPanel.Controls.Add(this.mskCPF);
            this.mPanel.Controls.Add(this.metroLabel7);
            this.mPanel.Controls.Add(this.metroLabel3);
            this.mPanel.Controls.Add(this.mskCel);
            this.mPanel.Controls.Add(this.metroLabel5);
            this.mPanel.Controls.Add(this.mskTel);
            this.mPanel.Controls.Add(this.metroLabel4);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(34, 114);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(958, 373);
            this.mPanel.TabIndex = 21;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mbtnNovo
            // 
            this.mbtnNovo.Location = new System.Drawing.Point(838, 308);
            this.mbtnNovo.Name = "mbtnNovo";
            this.mbtnNovo.Size = new System.Drawing.Size(103, 33);
            this.mbtnNovo.TabIndex = 38;
            this.mbtnNovo.Text = "Novo";
            this.mbtnNovo.UseSelectable = true;
            this.mbtnNovo.Visible = false;
            this.mbtnNovo.Click += new System.EventHandler(this.mbtnNovo_Click);
            // 
            // mbtnAtualizar
            // 
            this.mbtnAtualizar.Location = new System.Drawing.Point(620, 308);
            this.mbtnAtualizar.Name = "mbtnAtualizar";
            this.mbtnAtualizar.Size = new System.Drawing.Size(103, 33);
            this.mbtnAtualizar.TabIndex = 37;
            this.mbtnAtualizar.Text = "Atualizar";
            this.mbtnAtualizar.UseSelectable = true;
            this.mbtnAtualizar.Visible = false;
            this.mbtnAtualizar.Click += new System.EventHandler(this.mbtnAtualizar_Click);
            // 
            // mbtnConsultar
            // 
            this.mbtnConsultar.Location = new System.Drawing.Point(729, 308);
            this.mbtnConsultar.Name = "mbtnConsultar";
            this.mbtnConsultar.Size = new System.Drawing.Size(103, 33);
            this.mbtnConsultar.TabIndex = 36;
            this.mbtnConsultar.Text = "Consultar";
            this.mbtnConsultar.UseSelectable = true;
            this.mbtnConsultar.Click += new System.EventHandler(this.mbtnConsultar_Click);
            // 
            // mlblAvisos
            // 
            this.mlblAvisos.AutoSize = true;
            this.mlblAvisos.Location = new System.Drawing.Point(172, 341);
            this.mlblAvisos.Name = "mlblAvisos";
            this.mlblAvisos.Size = new System.Drawing.Size(0, 0);
            this.mlblAvisos.TabIndex = 25;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(188, 148);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(50, 19);
            this.metroLabel13.TabIndex = 23;
            this.metroLabel13.Text = "*Email:";
            // 
            // mtxtEmail
            // 
            this.mtxtEmail.Lines = new string[0];
            this.mtxtEmail.Location = new System.Drawing.Point(238, 146);
            this.mtxtEmail.MaxLength = 32767;
            this.mtxtEmail.Name = "mtxtEmail";
            this.mtxtEmail.PasswordChar = '\0';
            this.mtxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtEmail.SelectedText = "";
            this.mtxtEmail.Size = new System.Drawing.Size(406, 23);
            this.mtxtEmail.TabIndex = 10;
            this.mtxtEmail.UseSelectable = true;
            // 
            // mtxtCargo
            // 
            this.mtxtCargo.Lines = new string[0];
            this.mtxtCargo.Location = new System.Drawing.Point(238, 224);
            this.mtxtCargo.MaxLength = 32767;
            this.mtxtCargo.Name = "mtxtCargo";
            this.mtxtCargo.PasswordChar = '\0';
            this.mtxtCargo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCargo.SelectedText = "";
            this.mtxtCargo.Size = new System.Drawing.Size(143, 23);
            this.mtxtCargo.TabIndex = 16;
            this.mtxtCargo.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(183, 226);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(49, 19);
            this.metroLabel12.TabIndex = 21;
            this.metroLabel12.Text = "Cargo:";
            // 
            // mbtnCadastrar
            // 
            this.mbtnCadastrar.Location = new System.Drawing.Point(620, 308);
            this.mbtnCadastrar.Name = "mbtnCadastrar";
            this.mbtnCadastrar.Size = new System.Drawing.Size(103, 33);
            this.mbtnCadastrar.TabIndex = 28;
            this.mbtnCadastrar.Text = "Cadastrar";
            this.mbtnCadastrar.UseSelectable = true;
            this.mbtnCadastrar.Click += new System.EventHandler(this.mbtnCadastrar_Click);
            // 
            // mPanel2
            // 
            this.mPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel2.Controls.Add(this.metroLabel11);
            this.mPanel2.Controls.Add(this.mcboAcesso);
            this.mPanel2.Controls.Add(this.metroLabel10);
            this.mPanel2.Controls.Add(this.mtglAtivo);
            this.mPanel2.Controls.Add(this.metroLabel6);
            this.mPanel2.Controls.Add(this.mtxtSenha);
            this.mPanel2.Controls.Add(this.metroLabel9);
            this.mPanel2.Controls.Add(this.mtxtLogin);
            this.mPanel2.HorizontalScrollbarBarColor = true;
            this.mPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel2.HorizontalScrollbarSize = 10;
            this.mPanel2.Location = new System.Drawing.Point(678, 31);
            this.mPanel2.Name = "mPanel2";
            this.mPanel2.Size = new System.Drawing.Size(252, 158);
            this.mPanel2.TabIndex = 19;
            this.mPanel2.VerticalScrollbarBarColor = true;
            this.mPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(9, 88);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(52, 19);
            this.metroLabel11.TabIndex = 24;
            this.metroLabel11.Text = "Acesso:";
            // 
            // mcboAcesso
            // 
            this.mcboAcesso.FormattingEnabled = true;
            this.mcboAcesso.ItemHeight = 23;
            this.mcboAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Bar",
            "Atendente"});
            this.mcboAcesso.Location = new System.Drawing.Point(67, 83);
            this.mcboAcesso.Name = "mcboAcesso";
            this.mcboAcesso.Size = new System.Drawing.Size(161, 29);
            this.mcboAcesso.TabIndex = 24;
            this.mcboAcesso.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(102, 127);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(39, 19);
            this.metroLabel10.TabIndex = 22;
            this.metroLabel10.Text = "Atvo:";
            // 
            // mtglAtivo
            // 
            this.mtglAtivo.AutoSize = true;
            this.mtglAtivo.Location = new System.Drawing.Point(147, 129);
            this.mtglAtivo.Name = "mtglAtivo";
            this.mtglAtivo.Size = new System.Drawing.Size(80, 17);
            this.mtglAtivo.TabIndex = 26;
            this.mtglAtivo.Text = "Off";
            this.mtglAtivo.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 53);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Senha:";
            // 
            // mtxtSenha
            // 
            this.mtxtSenha.Lines = new string[0];
            this.mtxtSenha.Location = new System.Drawing.Point(67, 51);
            this.mtxtSenha.MaxLength = 32767;
            this.mtxtSenha.Name = "mtxtSenha";
            this.mtxtSenha.PasswordChar = '\0';
            this.mtxtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtSenha.SelectedText = "";
            this.mtxtSenha.Size = new System.Drawing.Size(161, 23);
            this.mtxtSenha.TabIndex = 22;
            this.mtxtSenha.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(17, 18);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(44, 19);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "Login:";
            // 
            // mtxtLogin
            // 
            this.mtxtLogin.Lines = new string[0];
            this.mtxtLogin.Location = new System.Drawing.Point(67, 16);
            this.mtxtLogin.MaxLength = 32767;
            this.mtxtLogin.Name = "mtxtLogin";
            this.mtxtLogin.PasswordChar = '\0';
            this.mtxtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtLogin.SelectedText = "";
            this.mtxtLogin.Size = new System.Drawing.Size(161, 23);
            this.mtxtLogin.TabIndex = 20;
            this.mtxtLogin.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(183, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "*Nome:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(387, 226);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(131, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Data de Nascimento:";
            // 
            // mtxtNome
            // 
            this.mtxtNome.Lines = new string[0];
            this.mtxtNome.Location = new System.Drawing.Point(238, 74);
            this.mtxtNome.MaxLength = 32767;
            this.mtxtNome.Name = "mtxtNome";
            this.mtxtNome.PasswordChar = '\0';
            this.mtxtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtNome.SelectedText = "";
            this.mtxtNome.Size = new System.Drawing.Size(406, 23);
            this.mtxtNome.TabIndex = 6;
            this.mtxtNome.UseSelectable = true;
            // 
            // mdtmNascimento
            // 
            this.mdtmNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtmNascimento.Location = new System.Drawing.Point(524, 221);
            this.mdtmNascimento.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtmNascimento.Name = "mdtmNascimento";
            this.mdtmNascimento.Size = new System.Drawing.Size(120, 29);
            this.mdtmNascimento.TabIndex = 18;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(167, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Endereço:";
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.White;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Image = global::FastBeats.Properties.Resources.Funcionarios;
            this.picFoto.Location = new System.Drawing.Point(18, 36);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(126, 142);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 14;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // mtxtEnd
            // 
            this.mtxtEnd.Lines = new string[0];
            this.mtxtEnd.Location = new System.Drawing.Point(238, 109);
            this.mtxtEnd.MaxLength = 32767;
            this.mtxtEnd.Name = "mtxtEnd";
            this.mtxtEnd.PasswordChar = '\0';
            this.mtxtEnd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtEnd.SelectedText = "";
            this.mtxtEnd.Size = new System.Drawing.Size(406, 23);
            this.mtxtEnd.TabIndex = 8;
            this.mtxtEnd.UseSelectable = true;
            // 
            // mtxtRG
            // 
            this.mtxtRG.Lines = new string[0];
            this.mtxtRG.Location = new System.Drawing.Point(505, 36);
            this.mtxtRG.MaxLength = 32767;
            this.mtxtRG.Name = "mtxtRG";
            this.mtxtRG.PasswordChar = '\0';
            this.mtxtRG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtRG.SelectedText = "";
            this.mtxtRG.Size = new System.Drawing.Size(139, 23);
            this.mtxtRG.TabIndex = 4;
            this.mtxtRG.UseSelectable = true;
            this.mtxtRG.TextChanged += new System.EventHandler(this.mtxtRG_TextChanged);
            // 
            // mskCPF
            // 
            this.mskCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.mskCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCPF.ForeColor = System.Drawing.Color.Gainsboro;
            this.mskCPF.Location = new System.Drawing.Point(238, 37);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 20);
            this.mskCPF.TabIndex = 2;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(470, 38);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(35, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "*RG:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(196, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "*CPF:";
            // 
            // mskCel
            // 
            this.mskCel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.mskCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCel.ForeColor = System.Drawing.Color.Gainsboro;
            this.mskCel.Location = new System.Drawing.Point(413, 188);
            this.mskCel.Mask = "(00)00000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(100, 20);
            this.mskCel.TabIndex = 14;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(353, 189);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Celular:";
            // 
            // mskTel
            // 
            this.mskTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.mskTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTel.ForeColor = System.Drawing.Color.Gainsboro;
            this.mskTel.Location = new System.Drawing.Point(238, 188);
            this.mskTel.Mask = "(00)0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(100, 20);
            this.mskTel.TabIndex = 12;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(172, 189);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Telefone:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(23, 538);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(40, 40);
            this.mTileVoltar.TabIndex = 5;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 601);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mTileVoltar);
            this.Name = "frmFuncionario";
            this.Text = "Funcionários";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.mPanel2.ResumeLayout(false);
            this.mPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroPanel mPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile mTileVoltar;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroLabel mlblAvisos;
        public MetroFramework.Controls.MetroButton mbtnNovo;
        public MetroFramework.Controls.MetroButton mbtnAtualizar;
        private MetroFramework.Controls.MetroButton mbtnConsultar;
        public MetroFramework.Controls.MetroTextBox mtxtCargo;
        public MetroFramework.Controls.MetroButton mbtnCadastrar;
        public MetroFramework.Controls.MetroComboBox mcboAcesso;
        public MetroFramework.Controls.MetroToggle mtglAtivo;
        public MetroFramework.Controls.MetroTextBox mtxtSenha;
        public MetroFramework.Controls.MetroTextBox mtxtLogin;
        public MetroFramework.Controls.MetroTextBox mtxtNome;
        public MetroFramework.Controls.MetroDateTime mdtmNascimento;
        public MetroFramework.Controls.MetroTextBox mtxtEnd;
        public MetroFramework.Controls.MetroTextBox mtxtRG;
        public System.Windows.Forms.MaskedTextBox mskCPF;
        public System.Windows.Forms.MaskedTextBox mskCel;
        public System.Windows.Forms.MaskedTextBox mskTel;
        public MetroFramework.Controls.MetroTextBox mtxtEmail;
        public System.Windows.Forms.PictureBox picFoto;
    }
}