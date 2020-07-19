﻿namespace PathCopyCopy.Settings.UI.UserControls
{
    partial class CopyNPathPartsPipelineElementUserControl
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyNPathPartsPipelineElementUserControl));
            this.NumPartsTxt = new System.Windows.Forms.TextBox();
            this.CopyTheNLbl = new System.Windows.Forms.Label();
            this.FirstLastCombo = new System.Windows.Forms.ComboBox();
            this.PathPartsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumPartsTxt
            // 
            resources.ApplyResources(this.NumPartsTxt, "NumPartsTxt");
            this.NumPartsTxt.Name = "NumPartsTxt";
            this.NumPartsTxt.TextChanged += new System.EventHandler(this.NumPartsTxt_TextChanged);
            this.NumPartsTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumPartsTxt_KeyPress);
            // 
            // CopyTheNLbl
            // 
            resources.ApplyResources(this.CopyTheNLbl, "CopyTheNLbl");
            this.CopyTheNLbl.Name = "CopyTheNLbl";
            // 
            // FirstLastCombo
            // 
            resources.ApplyResources(this.FirstLastCombo, "FirstLastCombo");
            this.FirstLastCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstLastCombo.FormattingEnabled = true;
            this.FirstLastCombo.Items.AddRange(new object[] {
            resources.GetString("FirstLastCombo.Items"),
            resources.GetString("FirstLastCombo.Items1")});
            this.FirstLastCombo.Name = "FirstLastCombo";
            this.FirstLastCombo.SelectedIndexChanged += new System.EventHandler(this.FirstLastCombo_SelectedIndexChanged);
            // 
            // PathPartsLbl
            // 
            resources.ApplyResources(this.PathPartsLbl, "PathPartsLbl");
            this.PathPartsLbl.Name = "PathPartsLbl";
            // 
            // CopyNPathPartsPipelineElementUserControl
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.PathPartsLbl);
            this.Controls.Add(this.FirstLastCombo);
            this.Controls.Add(this.CopyTheNLbl);
            this.Controls.Add(this.NumPartsTxt);
            this.Name = "CopyNPathPartsPipelineElementUserControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumPartsTxt;
        private System.Windows.Forms.Label CopyTheNLbl;
        private System.Windows.Forms.ComboBox FirstLastCombo;
        private System.Windows.Forms.Label PathPartsLbl;
    }
}
