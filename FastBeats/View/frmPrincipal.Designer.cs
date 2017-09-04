namespace FastBeats
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new MetroFramework.Controls.MetroLabel();
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mlblNivel = new MetroFramework.Controls.MetroLabel();
            this.mlblNome = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(641, 37);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(46, 19);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "HORA";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(693, 37);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 19);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "DATA";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(614, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 17);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mlblNivel
            // 
            this.mlblNivel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mlblNivel.AutoSize = true;
            this.mlblNivel.Location = new System.Drawing.Point(515, 37);
            this.mlblNivel.Name = "mlblNivel";
            this.mlblNivel.Size = new System.Drawing.Size(0, 0);
            this.mlblNivel.TabIndex = 8;
            this.mlblNivel.Click += new System.EventHandler(this.mlblNivel_Click);
            // 
            // mlblNome
            // 
            this.mlblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mlblNome.AutoSize = true;
            this.mlblNome.Location = new System.Drawing.Point(515, 9);
            this.mlblNome.Name = "mlblNome";
            this.mlblNome.Size = new System.Drawing.Size(0, 0);
            this.mlblNome.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 600);
            this.Controls.Add(this.mlblNome);
            this.Controls.Add(this.mlblNivel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmPrincipal";
            this.Text = "Fast Beats";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lblData;
        private MetroFramework.Controls.MetroLabel lblHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroLabel mlblNome;
        public MetroFramework.Controls.MetroLabel mlblNivel;

    }
}

