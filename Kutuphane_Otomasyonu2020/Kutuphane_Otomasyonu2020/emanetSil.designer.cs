﻿namespace Kutuphane_Otomasyonu2020
{
    partial class emanetSil
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
            this.dgvSilTablo = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSilTablo
            // 
            this.dgvSilTablo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSilTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSilTablo.Location = new System.Drawing.Point(9, 10);
            this.dgvSilTablo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSilTablo.Name = "dgvSilTablo";
            this.dgvSilTablo.ReadOnly = true;
            this.dgvSilTablo.RowHeadersWidth = 51;
            this.dgvSilTablo.RowTemplate.Height = 24;
            this.dgvSilTablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSilTablo.Size = new System.Drawing.Size(844, 458);
            this.dgvSilTablo.TabIndex = 0;
            this.dgvSilTablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSilTablo_CellContentClick);
            this.dgvSilTablo.SelectionChanged += new System.EventHandler(this.dgvSilTablo_SelectionChanged);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.Location = new System.Drawing.Point(375, 484);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 37);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "button1";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // emanetSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvSilTablo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "emanetSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emanetSil";
            this.Load += new System.EventHandler(this.emanetSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilTablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSilTablo;
        private System.Windows.Forms.Button btnSil;
    }
}