namespace Migração
{
    partial class Migração
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Migração));
            this.lblOrigem = new DevExpress.XtraEditors.LabelControl();
            this.txtOrigem = new DevExpress.XtraEditors.TextEdit();
            this.lblDestino = new DevExpress.XtraEditors.LabelControl();
            this.txtDestino = new DevExpress.XtraEditors.TextEdit();
            this.cmdCopiar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdMover = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrigem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestino.Properties)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrigem
            // 
            resources.ApplyResources(this.lblOrigem, "lblOrigem");
            this.lblOrigem.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblOrigem.Appearance.Font")));
            this.lblOrigem.Appearance.Options.UseFont = true;
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Click += new System.EventHandler(this.lblOrigem_Click);
            // 
            // txtOrigem
            // 
            resources.ApplyResources(this.txtOrigem, "txtOrigem");
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtOrigem.Properties.Appearance.Font")));
            this.txtOrigem.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOrigem.Properties.Appearance.Options.UseFont = true;
            this.txtOrigem.Properties.Appearance.Options.UseForeColor = true;
            this.txtOrigem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtOrigem.EditValueChanged += new System.EventHandler(this.txtOrigem_EditValueChanged);
            this.txtOrigem.DoubleClick += new System.EventHandler(this.txtOrigem_DoubleClick);
            this.txtOrigem.Enter += new System.EventHandler(this.txtOrigem_Enter);
            this.txtOrigem.Leave += new System.EventHandler(this.txtOrigem_Leave);
            // 
            // lblDestino
            // 
            resources.ApplyResources(this.lblDestino, "lblDestino");
            this.lblDestino.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblDestino.Appearance.Font")));
            this.lblDestino.Appearance.Options.UseFont = true;
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Click += new System.EventHandler(this.lblDestino_Click);
            // 
            // txtDestino
            // 
            resources.ApplyResources(this.txtDestino, "txtDestino");
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtDestino.Properties.Appearance.Font")));
            this.txtDestino.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDestino.Properties.Appearance.Options.UseFont = true;
            this.txtDestino.Properties.Appearance.Options.UseForeColor = true;
            this.txtDestino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDestino.EditValueChanged += new System.EventHandler(this.txtDestino_EditValueChanged);
            this.txtDestino.DoubleClick += new System.EventHandler(this.txtDestino_DoubleClick);
            this.txtDestino.Enter += new System.EventHandler(this.txtDestino_Enter);
            this.txtDestino.Leave += new System.EventHandler(this.txtDestino_Leave);
            // 
            // cmdCopiar
            // 
            resources.ApplyResources(this.cmdCopiar, "cmdCopiar");
            this.cmdCopiar.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("cmdCopiar.Appearance.Font")));
            this.cmdCopiar.Appearance.Options.UseFont = true;
            this.cmdCopiar.Name = "cmdCopiar";
            this.cmdCopiar.Click += new System.EventHandler(this.cmdCopiar_Click);
            // 
            // cmdMover
            // 
            resources.ApplyResources(this.cmdMover, "cmdMover");
            this.cmdMover.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("cmdMover.Appearance.Font")));
            this.cmdMover.Appearance.Options.UseFont = true;
            this.cmdMover.Name = "cmdMover";
            this.cmdMover.Click += new System.EventHandler(this.cmdMover_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // Migração
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdMover);
            this.Controls.Add(this.cmdCopiar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Migração";
            this.Load += new System.EventHandler(this.Migração_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrigem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestino.Properties)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblOrigem;
        private DevExpress.XtraEditors.LabelControl lblDestino;
        private DevExpress.XtraEditors.TextEdit txtDestino;
        private DevExpress.XtraEditors.SimpleButton cmdCopiar;
        private DevExpress.XtraEditors.SimpleButton cmdMover;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DevExpress.XtraEditors.TextEdit txtOrigem;
    }
}

