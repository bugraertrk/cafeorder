namespace PazzoCafe.UI
{
    partial class Çalışanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Çalışanlar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnÇalışanEkle = new System.Windows.Forms.ToolStripButton();
            this.btnÇalışanDüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnÇalışanSil = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.toolStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ÇALIŞANLAR";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView3.Location = new System.Drawing.Point(3, 34);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(786, 387);
            this.dataGridView3.TabIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnÇalışanEkle,
            this.btnÇalışanDüzenle,
            this.btnÇalışanSil});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(786, 31);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnÇalışanEkle
            // 
            this.btnÇalışanEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnÇalışanEkle.Image")));
            this.btnÇalışanEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇalışanEkle.Name = "btnÇalışanEkle";
            this.btnÇalışanEkle.Size = new System.Drawing.Size(56, 28);
            this.btnÇalışanEkle.Text = "Ekle";
            this.btnÇalışanEkle.Click += new System.EventHandler(this.btnÇalışanEkle_Click);
            // 
            // btnÇalışanDüzenle
            // 
            this.btnÇalışanDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnÇalışanDüzenle.Image")));
            this.btnÇalışanDüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇalışanDüzenle.Name = "btnÇalışanDüzenle";
            this.btnÇalışanDüzenle.Size = new System.Drawing.Size(77, 28);
            this.btnÇalışanDüzenle.Text = "Düzenle";
            this.btnÇalışanDüzenle.Click += new System.EventHandler(this.btnÇalışanDüzenle_Click);
            // 
            // btnÇalışanSil
            // 
            this.btnÇalışanSil.Image = ((System.Drawing.Image)(resources.GetObject("btnÇalışanSil.Image")));
            this.btnÇalışanSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnÇalışanSil.Name = "btnÇalışanSil";
            this.btnÇalışanSil.Size = new System.Drawing.Size(47, 28);
            this.btnÇalışanSil.Text = "Sil";
            this.btnÇalışanSil.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // Çalışanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Çalışanlar";
            this.Text = "Çalışanlar";
            this.Load += new System.EventHandler(this.Çalışanlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnÇalışanEkle;
        private System.Windows.Forms.ToolStripButton btnÇalışanDüzenle;
        private System.Windows.Forms.ToolStripButton btnÇalışanSil;
    }
}