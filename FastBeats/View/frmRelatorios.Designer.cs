namespace FastBeats.View
{
    partial class frmRelatorios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageGerais = new MetroFramework.Controls.MetroTabPage();
            this.mdgvRProduto = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.mlblFun = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mchbFun = new MetroFramework.Controls.MetroToggle();
            this.mtxtTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mlblConsulta = new MetroFramework.Controls.MetroLabel();
            this.mchbConsulta = new MetroFramework.Controls.MetroToggle();
            this.mlblDatafim = new MetroFramework.Controls.MetroLabel();
            this.mdtpDataFim = new MetroFramework.Controls.MetroDateTime();
            this.mlblData = new MetroFramework.Controls.MetroLabel();
            this.mdtpData = new MetroFramework.Controls.MetroDateTime();
            this.mdgvRCaixa = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtxtCodComanda = new MetroFramework.Controls.MetroTextBox();
            this.mdgvRComanda = new MetroFramework.Controls.MetroGrid();
            this.metroTileLogoff = new MetroFramework.Controls.MetroTile();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroTabControl.SuspendLayout();
            this.metroTabPageGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvRProduto)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvRCaixa)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvRComanda)).BeginInit();
            this.mPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.metroTabPageGerais);
            this.metroTabControl.Controls.Add(this.metroTabPage1);
            this.metroTabControl.Controls.Add(this.metroTabPage2);
            this.metroTabControl.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 1;
            this.metroTabControl.Size = new System.Drawing.Size(583, 376);
            this.metroTabControl.TabIndex = 1;
            this.metroTabControl.UseSelectable = true;
            // 
            // metroTabPageGerais
            // 
            this.metroTabPageGerais.Controls.Add(this.mdgvRProduto);
            this.metroTabPageGerais.HorizontalScrollbarBarColor = true;
            this.metroTabPageGerais.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageGerais.HorizontalScrollbarSize = 10;
            this.metroTabPageGerais.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageGerais.Name = "metroTabPageGerais";
            this.metroTabPageGerais.Padding = new System.Windows.Forms.Padding(25);
            this.metroTabPageGerais.Size = new System.Drawing.Size(575, 334);
            this.metroTabPageGerais.TabIndex = 2;
            this.metroTabPageGerais.Text = "Produtos";
            this.metroTabPageGerais.VerticalScrollbarBarColor = true;
            this.metroTabPageGerais.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageGerais.VerticalScrollbarSize = 10;
            this.metroTabPageGerais.Visible = false;
            // 
            // mdgvRProduto
            // 
            this.mdgvRProduto.AllowUserToAddRows = false;
            this.mdgvRProduto.AllowUserToDeleteRows = false;
            this.mdgvRProduto.AllowUserToResizeRows = false;
            this.mdgvRProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvRProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvRProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvRProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvRProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvRProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvRProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvRProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvRProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdgvRProduto.EnableHeadersVisualStyles = false;
            this.mdgvRProduto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvRProduto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvRProduto.Location = new System.Drawing.Point(25, 25);
            this.mdgvRProduto.Name = "mdgvRProduto";
            this.mdgvRProduto.ReadOnly = true;
            this.mdgvRProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvRProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvRProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvRProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvRProduto.Size = new System.Drawing.Size(525, 284);
            this.mdgvRProduto.TabIndex = 3;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cboFuncionario);
            this.metroTabPage1.Controls.Add(this.mlblFun);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.mchbFun);
            this.metroTabPage1.Controls.Add(this.mtxtTotal);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.mlblConsulta);
            this.metroTabPage1.Controls.Add(this.mchbConsulta);
            this.metroTabPage1.Controls.Add(this.mlblDatafim);
            this.metroTabPage1.Controls.Add(this.mdtpDataFim);
            this.metroTabPage1.Controls.Add(this.mlblData);
            this.metroTabPage1.Controls.Add(this.mdtpData);
            this.metroTabPage1.Controls.Add(this.mdgvRCaixa);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(25);
            this.metroTabPage1.Size = new System.Drawing.Size(575, 334);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "Caixa";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Visible = false;
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cboFuncionario.ForeColor = System.Drawing.Color.Gainsboro;
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(100, 89);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(283, 21);
            this.cboFuncionario.TabIndex = 77;
            this.cboFuncionario.Visible = false;
            this.cboFuncionario.SelectedIndexChanged += new System.EventHandler(this.cboFuncionario_SelectedIndexChanged);
            // 
            // mlblFun
            // 
            this.mlblFun.AutoSize = true;
            this.mlblFun.Location = new System.Drawing.Point(4, 91);
            this.mlblFun.Name = "mlblFun";
            this.mlblFun.Size = new System.Drawing.Size(80, 19);
            this.mlblFun.TabIndex = 76;
            this.mlblFun.Text = "Funcionário:";
            this.mlblFun.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(433, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(139, 19);
            this.metroLabel2.TabIndex = 75;
            this.metroLabel2.Text = "Filtrar Por Funcionário";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mchbFun
            // 
            this.mchbFun.AutoSize = true;
            this.mchbFun.DisplayStatus = false;
            this.mchbFun.Location = new System.Drawing.Point(478, 91);
            this.mchbFun.Name = "mchbFun";
            this.mchbFun.Size = new System.Drawing.Size(50, 17);
            this.mchbFun.TabIndex = 74;
            this.mchbFun.Text = "Off";
            this.mchbFun.UseSelectable = true;
            this.mchbFun.CheckedChanged += new System.EventHandler(this.mchbFun_CheckedChanged);
            // 
            // mtxtTotal
            // 
            this.mtxtTotal.Lines = new string[0];
            this.mtxtTotal.Location = new System.Drawing.Point(490, 311);
            this.mtxtTotal.MaxLength = 32767;
            this.mtxtTotal.Name = "mtxtTotal";
            this.mtxtTotal.PasswordChar = '\0';
            this.mtxtTotal.ReadOnly = true;
            this.mtxtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTotal.SelectedText = "";
            this.mtxtTotal.Size = new System.Drawing.Size(82, 23);
            this.mtxtTotal.TabIndex = 73;
            this.mtxtTotal.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(445, 311);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 72;
            this.metroLabel1.Text = "Total:";
            // 
            // mlblConsulta
            // 
            this.mlblConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlblConsulta.AutoSize = true;
            this.mlblConsulta.Location = new System.Drawing.Point(433, 18);
            this.mlblConsulta.Name = "mlblConsulta";
            this.mlblConsulta.Size = new System.Drawing.Size(83, 19);
            this.mlblConsulta.TabIndex = 71;
            this.mlblConsulta.Text = "metroLabel2";
            this.mlblConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mchbConsulta
            // 
            this.mchbConsulta.AutoSize = true;
            this.mchbConsulta.DisplayStatus = false;
            this.mchbConsulta.Location = new System.Drawing.Point(478, 43);
            this.mchbConsulta.Name = "mchbConsulta";
            this.mchbConsulta.Size = new System.Drawing.Size(50, 17);
            this.mchbConsulta.TabIndex = 70;
            this.mchbConsulta.Text = "Off";
            this.mchbConsulta.UseSelectable = true;
            this.mchbConsulta.CheckedChanged += new System.EventHandler(this.mchbConsulta_CheckedChanged);
            // 
            // mlblDatafim
            // 
            this.mlblDatafim.AutoSize = true;
            this.mlblDatafim.Location = new System.Drawing.Point(4, 53);
            this.mlblDatafim.Name = "mlblDatafim";
            this.mlblDatafim.Size = new System.Drawing.Size(90, 19);
            this.mlblDatafim.TabIndex = 69;
            this.mlblDatafim.Text = "Data Término:";
            // 
            // mdtpDataFim
            // 
            this.mdtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtpDataFim.Location = new System.Drawing.Point(100, 53);
            this.mdtpDataFim.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtpDataFim.Name = "mdtpDataFim";
            this.mdtpDataFim.Size = new System.Drawing.Size(283, 29);
            this.mdtpDataFim.TabIndex = 68;
            this.mdtpDataFim.ValueChanged += new System.EventHandler(this.mdtpDataFim_ValueChanged);
            // 
            // mlblData
            // 
            this.mlblData.AutoSize = true;
            this.mlblData.Location = new System.Drawing.Point(4, 21);
            this.mlblData.Name = "mlblData";
            this.mlblData.Size = new System.Drawing.Size(73, 19);
            this.mlblData.TabIndex = 67;
            this.mlblData.Text = "Data Início:";
            // 
            // mdtpData
            // 
            this.mdtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtpData.Location = new System.Drawing.Point(100, 18);
            this.mdtpData.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtpData.Name = "mdtpData";
            this.mdtpData.Size = new System.Drawing.Size(283, 29);
            this.mdtpData.TabIndex = 66;
            this.mdtpData.ValueChanged += new System.EventHandler(this.mdtpData_ValueChanged);
            // 
            // mdgvRCaixa
            // 
            this.mdgvRCaixa.AllowUserToAddRows = false;
            this.mdgvRCaixa.AllowUserToDeleteRows = false;
            this.mdgvRCaixa.AllowUserToResizeRows = false;
            this.mdgvRCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvRCaixa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvRCaixa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvRCaixa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvRCaixa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvRCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mdgvRCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvRCaixa.DefaultCellStyle = dataGridViewCellStyle5;
            this.mdgvRCaixa.EnableHeadersVisualStyles = false;
            this.mdgvRCaixa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvRCaixa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvRCaixa.Location = new System.Drawing.Point(0, 134);
            this.mdgvRCaixa.Name = "mdgvRCaixa";
            this.mdgvRCaixa.ReadOnly = true;
            this.mdgvRCaixa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvRCaixa.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mdgvRCaixa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvRCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvRCaixa.Size = new System.Drawing.Size(572, 175);
            this.mdgvRCaixa.TabIndex = 3;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.mtxtCodComanda);
            this.metroTabPage2.Controls.Add(this.mdgvRComanda);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Padding = new System.Windows.Forms.Padding(25);
            this.metroTabPage2.Size = new System.Drawing.Size(575, 334);
            this.metroTabPage2.TabIndex = 4;
            this.metroTabPage2.Text = "Comandas";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(28, 14);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 70;
            this.metroLabel4.Text = "Código:";
            // 
            // mtxtCodComanda
            // 
            this.mtxtCodComanda.Lines = new string[0];
            this.mtxtCodComanda.Location = new System.Drawing.Point(99, 14);
            this.mtxtCodComanda.MaxLength = 32767;
            this.mtxtCodComanda.Name = "mtxtCodComanda";
            this.mtxtCodComanda.PasswordChar = '\0';
            this.mtxtCodComanda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtCodComanda.SelectedText = "";
            this.mtxtCodComanda.Size = new System.Drawing.Size(362, 23);
            this.mtxtCodComanda.TabIndex = 69;
            this.mtxtCodComanda.UseSelectable = true;
            this.mtxtCodComanda.TextChanged += new System.EventHandler(this.mtxtCodComanda_TextChanged);
            // 
            // mdgvRComanda
            // 
            this.mdgvRComanda.AllowUserToAddRows = false;
            this.mdgvRComanda.AllowUserToDeleteRows = false;
            this.mdgvRComanda.AllowUserToResizeRows = false;
            this.mdgvRComanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvRComanda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvRComanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvRComanda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvRComanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvRComanda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mdgvRComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvRComanda.DefaultCellStyle = dataGridViewCellStyle8;
            this.mdgvRComanda.EnableHeadersVisualStyles = false;
            this.mdgvRComanda.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvRComanda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvRComanda.Location = new System.Drawing.Point(0, 74);
            this.mdgvRComanda.Name = "mdgvRComanda";
            this.mdgvRComanda.ReadOnly = true;
            this.mdgvRComanda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvRComanda.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mdgvRComanda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvRComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvRComanda.Size = new System.Drawing.Size(572, 260);
            this.mdgvRComanda.TabIndex = 2;
            // 
            // metroTileLogoff
            // 
            this.metroTileLogoff.ActiveControl = null;
            this.metroTileLogoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTileLogoff.Location = new System.Drawing.Point(23, 486);
            this.metroTileLogoff.Name = "metroTileLogoff";
            this.metroTileLogoff.Size = new System.Drawing.Size(40, 40);
            this.metroTileLogoff.TabIndex = 2;
            this.metroTileLogoff.TileImage = global::FastBeats.Properties.Resources.setaEsquerda;
            this.metroTileLogoff.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileLogoff.UseSelectable = true;
            this.metroTileLogoff.UseTileImage = true;
            this.metroTileLogoff.Click += new System.EventHandler(this.metroTileLogoff_Click);
            // 
            // mPanel
            // 
            this.mPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel.Controls.Add(this.metroTabControl);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(43, 63);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(591, 385);
            this.mPanel.TabIndex = 25;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 549);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.metroTileLogoff);
            this.Name = "frmRelatorios";
            this.Text = "Relatórios";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroTabControl.ResumeLayout(false);
            this.metroTabPageGerais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mdgvRProduto)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvRCaixa)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvRComanda)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPageGerais;
        private MetroFramework.Controls.MetroGrid mdgvRProduto;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroGrid mdgvRCaixa;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid mdgvRComanda;
        private MetroFramework.Controls.MetroLabel mlblDatafim;
        public MetroFramework.Controls.MetroDateTime mdtpDataFim;
        private MetroFramework.Controls.MetroLabel mlblData;
        public MetroFramework.Controls.MetroDateTime mdtpData;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtxtCodComanda;
        private MetroFramework.Controls.MetroTile metroTileLogoff;
        private MetroFramework.Controls.MetroLabel mlblConsulta;
        private MetroFramework.Controls.MetroToggle mchbConsulta;
        private MetroFramework.Controls.MetroTextBox mtxtTotal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle mchbFun;
        private MetroFramework.Controls.MetroLabel mlblFun;
        private System.Windows.Forms.ComboBox cboFuncionario;
    }
}