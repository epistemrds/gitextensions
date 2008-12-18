﻿namespace GitUI
{
    partial class FormClone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClone));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ToBrowse = new System.Windows.Forms.Button();
            this.FromBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.OutPut = new System.Windows.Forms.RichTextBox();
            this.To = new System.Windows.Forms.ComboBox();
            this.From = new System.Windows.Forms.ComboBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.From);
            this.splitContainer1.Panel1.Controls.Add(this.To);
            this.splitContainer1.Panel1.Controls.Add(this.ToBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.FromBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Ok);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OutPut);
            this.splitContainer1.Size = new System.Drawing.Size(460, 312);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // ToBrowse
            // 
            this.ToBrowse.Location = new System.Drawing.Point(263, 44);
            this.ToBrowse.Name = "ToBrowse";
            this.ToBrowse.Size = new System.Drawing.Size(75, 23);
            this.ToBrowse.TabIndex = 6;
            this.ToBrowse.Text = "Browse";
            this.ToBrowse.UseVisualStyleBackColor = true;
            this.ToBrowse.Click += new System.EventHandler(this.ToBrowse_Click);
            // 
            // FromBrowse
            // 
            this.FromBrowse.Location = new System.Drawing.Point(263, 17);
            this.FromBrowse.Name = "FromBrowse";
            this.FromBrowse.Size = new System.Drawing.Size(75, 23);
            this.FromBrowse.TabIndex = 5;
            this.FromBrowse.Text = "Browse";
            this.FromBrowse.UseVisualStyleBackColor = true;
            this.FromBrowse.Click += new System.EventHandler(this.FromBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(373, 17);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Clone";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // OutPut
            // 
            this.OutPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutPut.Location = new System.Drawing.Point(0, 0);
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(460, 211);
            this.OutPut.TabIndex = 0;
            this.OutPut.Text = "";
            // 
            // To
            // 
            this.To.FormattingEnabled = true;
            this.To.Location = new System.Drawing.Point(66, 45);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(190, 21);
            this.To.TabIndex = 7;
            this.To.DropDown += new System.EventHandler(this.To_DropDown);
            // 
            // From
            // 
            this.From.FormattingEnabled = true;
            this.From.Location = new System.Drawing.Point(66, 17);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(191, 21);
            this.From.TabIndex = 8;
            this.From.DropDown += new System.EventHandler(this.From_DropDown);
            // 
            // FormClone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 312);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClone";
            this.Text = "Clone";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.RichTextBox OutPut;
        private System.Windows.Forms.Button ToBrowse;
        private System.Windows.Forms.Button FromBrowse;
        private System.Windows.Forms.ComboBox From;
        private System.Windows.Forms.ComboBox To;
    }
}