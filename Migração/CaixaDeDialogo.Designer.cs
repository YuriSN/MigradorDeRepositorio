namespace Migração
{
    partial class CaixaDeDialogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaixaDeDialogo));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdCopiarArquivo = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCopiarPasta = new DevExpress.XtraEditors.SimpleButton();
            this.cmdVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // cmdCopiarArquivo
            // 
            resources.ApplyResources(this.cmdCopiarArquivo, "cmdCopiarArquivo");
            this.cmdCopiarArquivo.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("cmdCopiarArquivo.Appearance.Font")));
            this.cmdCopiarArquivo.Appearance.Options.UseFont = true;
            this.cmdCopiarArquivo.Name = "cmdCopiarArquivo";
            this.cmdCopiarArquivo.Click += new System.EventHandler(this.cmdCopiarArquivo_Click);
            // 
            // cmdCopiarPasta
            // 
            resources.ApplyResources(this.cmdCopiarPasta, "cmdCopiarPasta");
            this.cmdCopiarPasta.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("cmdCopiarPasta.Appearance.Font")));
            this.cmdCopiarPasta.Appearance.Options.UseFont = true;
            this.cmdCopiarPasta.Name = "cmdCopiarPasta";
            this.cmdCopiarPasta.Click += new System.EventHandler(this.cmdCopiarPasta_Click);
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.cmdVoltar.Appearance.Options.UseForeColor = true;
            this.cmdVoltar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdVoltar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.cmdVoltar.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.cmdVoltar.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.cmdVoltar, "cmdVoltar");
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // CaixaDeDialogo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.cmdVoltar);
            this.Controls.Add(this.cmdCopiarPasta);
            this.Controls.Add(this.cmdCopiarArquivo);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CaixaDeDialogo";
            this.Load += new System.EventHandler(this.CaixaDeDialogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdCopiarArquivo;
        private DevExpress.XtraEditors.SimpleButton cmdCopiarPasta;
        private DevExpress.XtraEditors.SimpleButton cmdVoltar;
    }
}