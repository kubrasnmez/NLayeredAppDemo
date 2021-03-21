
namespace Library.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwbook = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.gbxBookName = new System.Windows.Forms.GroupBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwbook)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxBookName.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwbook
            // 
            this.dgwbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwbook.Location = new System.Drawing.Point(12, 256);
            this.dgwbook.Name = "dgwbook";
            this.dgwbook.RowHeadersWidth = 51;
            this.dgwbook.RowTemplate.Height = 24;
            this.dgwbook.Size = new System.Drawing.Size(776, 150);
            this.dgwbook.TabIndex = 0;
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(304, 95);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 50);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori : ";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(96, 50);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(164, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // gbxBookName
            // 
            this.gbxBookName.Controls.Add(this.tbxBookName);
            this.gbxBookName.Controls.Add(this.lblBookName);
            this.gbxBookName.Location = new System.Drawing.Point(12, 128);
            this.gbxBookName.Name = "gbxBookName";
            this.gbxBookName.Size = new System.Drawing.Size(304, 100);
            this.gbxBookName.TabIndex = 2;
            this.gbxBookName.TabStop = false;
            this.gbxBookName.Text = "Kitap Adına Göre Ara";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Location = new System.Drawing.Point(96, 47);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(164, 22);
            this.tbxBookName.TabIndex = 1;
            this.tbxBookName.TextChanged += new System.EventHandler(this.tbxBookName_TextChanged);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(6, 47);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(76, 17);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Kitap Adı : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxBookName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwbook);
            this.Name = "Form1";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwbook)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxBookName.ResumeLayout(false);
            this.gbxBookName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwbook;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox gbxBookName;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.Label lblBookName;
    }
}

