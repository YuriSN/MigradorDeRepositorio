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
            this.cmdRenomear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrigem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestino.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrigem
            // 
            this.lblOrigem.Appearance.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem.Appearance.Options.UseFont = true;
            this.lblOrigem.Location = new System.Drawing.Point(16, 30);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(40, 19);
            this.lblOrigem.TabIndex = 0;
            this.lblOrigem.Text = "Origem:";
            this.lblOrigem.Click += new System.EventHandler(this.lblOrigem_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(16, 51);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigem.Properties.Appearance.Options.UseFont = true;
            this.txtOrigem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtOrigem.Size = new System.Drawing.Size(326, 26);
            this.txtOrigem.TabIndex = 1;
            this.txtOrigem.EditValueChanged += new System.EventHandler(this.txtOrigem_EditValueChanged);
            this.txtOrigem.DoubleClick += new System.EventHandler(this.txtOrigem_DoubleClick);
            // 
            // lblDestino
            // 
            this.lblDestino.Appearance.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Appearance.Options.UseFont = true;
            this.lblDestino.Location = new System.Drawing.Point(364, 30);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(39, 19);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Destino";
            this.lblDestino.Click += new System.EventHandler(this.lblDestino_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(364, 51);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Properties.Appearance.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Properties.Appearance.Options.UseFont = true;
            this.txtDestino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDestino.Size = new System.Drawing.Size(326, 26);
            this.txtDestino.TabIndex = 1;
            this.txtDestino.EditValueChanged += new System.EventHandler(this.txtDestino_EditValueChanged);
            this.txtDestino.DoubleClick += new System.EventHandler(this.txtDestino_DoubleClick);
            // 
            // cmdCopiar
            // 
            this.cmdCopiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCopiar.Appearance.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCopiar.Appearance.Options.UseFont = true;
            this.cmdCopiar.Location = new System.Drawing.Point(225, 95);
            this.cmdCopiar.Name = "cmdCopiar";
            this.cmdCopiar.Size = new System.Drawing.Size(81, 26);
            this.cmdCopiar.TabIndex = 2;
            this.cmdCopiar.Text = "Copiar";
            this.cmdCopiar.Click += new System.EventHandler(this.cmdCopiar_Click);
            // 
            // cmdMover
            // 
            this.cmdMover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdMover.Appearance.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMover.Appearance.Options.UseFont = true;
            this.cmdMover.Location = new System.Drawing.Point(312, 95);
            this.cmdMover.Name = "cmdMover";
            this.cmdMover.Size = new System.Drawing.Size(81, 26);
            this.cmdMover.TabIndex = 2;
            this.cmdMover.Text = "Mover";
            this.cmdMover.Click += new System.EventHandler(this.cmdMover_Click);
            // 
            // cmdRenomear
            // 
            this.cmdRenomear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdRenomear.Appearance.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRenomear.Appearance.Options.UseFont = true;
            this.cmdRenomear.Location = new System.Drawing.Point(399, 95);
            this.cmdRenomear.Name = "cmdRenomear";
            this.cmdRenomear.Size = new System.Drawing.Size(81, 26);
            this.cmdRenomear.TabIndex = 2;
            this.cmdRenomear.Text = "Renomear";
            this.cmdRenomear.Click += new System.EventHandler(this.cmdRenomear_Click);
            // 
            // Migração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(702, 162);
            this.Controls.Add(this.cmdRenomear);
            this.Controls.Add(this.cmdMover);
            this.Controls.Add(this.cmdCopiar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Migração";
            this.Text = "Migração de Diretório";
            this.Load += new System.EventHandler(this.Migração_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrigem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestino.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblOrigem;
        private DevExpress.XtraEditors.TextEdit txtOrigem;
        private DevExpress.XtraEditors.LabelControl lblDestino;
        private DevExpress.XtraEditors.TextEdit txtDestino;
        private DevExpress.XtraEditors.SimpleButton cmdCopiar;
        private DevExpress.XtraEditors.SimpleButton cmdMover;
        private DevExpress.XtraEditors.SimpleButton cmdRenomear;
    }
}

