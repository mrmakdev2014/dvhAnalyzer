﻿namespace DVHAnalyzer
{
  partial class Form4
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
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13F);
      this.label1.Location = new System.Drawing.Point(30, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(453, 126);
      this.label1.TabIndex = 0;
      this.label1.Text = "ご質問、ご要望はユーロメディテック医学物理室までお気軽に！\r\nemt-mediphys@euro-meditec.co.jp\r\n\r\nhttps://github." +
    "com/EuroMediTech/dvhAnalyzer\r\n\r\nCopyright (c) 2018 EuroMediTech Co. Ltd.\r\nReleas" +
    "ed under the MIT license";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(390, 164);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(93, 33);
      this.button1.TabIndex = 1;
      this.button1.Text = "OK";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form4
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(515, 209);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Name = "Form4";
      this.Text = "Help";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
  }
}