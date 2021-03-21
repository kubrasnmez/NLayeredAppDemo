
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
            this.gbxBookAdd = new System.Windows.Forms.GroupBox();
            this.dtpRealeseDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxPublisher = new System.Windows.Forms.ComboBox();
            this.cbxAuthor = new System.Windows.Forms.ComboBox();
            this.cbmCategory = new System.Windows.Forms.ComboBox();
            this.tbxNumberOfPrints = new System.Windows.Forms.TextBox();
            this.tbxNumberOfPages = new System.Windows.Forms.TextBox();
            this.tbxLanguage = new System.Windows.Forms.TextBox();
            this.tbxBookName2 = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblNumberPrint = new System.Windows.Forms.Label();
            this.lblNumberPages = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblRealeseDate = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwbook)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxBookName.SuspendLayout();
            this.gbxBookAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwbook
            // 
            this.dgwbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwbook.Location = new System.Drawing.Point(12, 209);
            this.dgwbook.Name = "dgwbook";
            this.dgwbook.RowHeadersWidth = 51;
            this.dgwbook.RowTemplate.Height = 24;
            this.dgwbook.Size = new System.Drawing.Size(541, 150);
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
            this.lblCategory.Location = new System.Drawing.Point(6, 38);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori : ";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(96, 35);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(164, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // gbxBookName
            // 
            this.gbxBookName.Controls.Add(this.tbxBookName);
            this.gbxBookName.Controls.Add(this.lblBookName);
            this.gbxBookName.Location = new System.Drawing.Point(12, 113);
            this.gbxBookName.Name = "gbxBookName";
            this.gbxBookName.Size = new System.Drawing.Size(304, 90);
            this.gbxBookName.TabIndex = 2;
            this.gbxBookName.TabStop = false;
            this.gbxBookName.Text = "Kitap Adına Göre Ara";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Location = new System.Drawing.Point(96, 35);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(164, 22);
            this.tbxBookName.TabIndex = 1;
            this.tbxBookName.TextChanged += new System.EventHandler(this.tbxBookName_TextChanged);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(6, 38);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(76, 17);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Kitap Adı : ";
            // 
            // gbxBookAdd
            // 
            this.gbxBookAdd.Controls.Add(this.dtpRealeseDate);
            this.gbxBookAdd.Controls.Add(this.btnAdd);
            this.gbxBookAdd.Controls.Add(this.btnUpdate);
            this.gbxBookAdd.Controls.Add(this.btnDelete);
            this.gbxBookAdd.Controls.Add(this.cbxPublisher);
            this.gbxBookAdd.Controls.Add(this.cbxAuthor);
            this.gbxBookAdd.Controls.Add(this.cbmCategory);
            this.gbxBookAdd.Controls.Add(this.tbxNumberOfPrints);
            this.gbxBookAdd.Controls.Add(this.tbxNumberOfPages);
            this.gbxBookAdd.Controls.Add(this.tbxLanguage);
            this.gbxBookAdd.Controls.Add(this.tbxBookName2);
            this.gbxBookAdd.Controls.Add(this.lblPublisher);
            this.gbxBookAdd.Controls.Add(this.lblAuthor);
            this.gbxBookAdd.Controls.Add(this.lblCategoryName);
            this.gbxBookAdd.Controls.Add(this.lblNumberPrint);
            this.gbxBookAdd.Controls.Add(this.lblNumberPages);
            this.gbxBookAdd.Controls.Add(this.lblLanguage);
            this.gbxBookAdd.Controls.Add(this.lblRealeseDate);
            this.gbxBookAdd.Controls.Add(this.lblBook);
            this.gbxBookAdd.Location = new System.Drawing.Point(12, 376);
            this.gbxBookAdd.Name = "gbxBookAdd";
            this.gbxBookAdd.Size = new System.Drawing.Size(462, 243);
            this.gbxBookAdd.TabIndex = 3;
            this.gbxBookAdd.TabStop = false;
            this.gbxBookAdd.Text = "Yeni Kitap Ekle";
            // 
            // dtpRealeseDate
            // 
            this.dtpRealeseDate.Location = new System.Drawing.Point(107, 64);
            this.dtpRealeseDate.Name = "dtpRealeseDate";
            this.dtpRealeseDate.Size = new System.Drawing.Size(127, 22);
            this.dtpRealeseDate.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(123, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 36);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbxPublisher
            // 
            this.cbxPublisher.FormattingEnabled = true;
            this.cbxPublisher.Location = new System.Drawing.Point(318, 162);
            this.cbxPublisher.Name = "cbxPublisher";
            this.cbxPublisher.Size = new System.Drawing.Size(121, 24);
            this.cbxPublisher.TabIndex = 15;
            // 
            // cbxAuthor
            // 
            this.cbxAuthor.FormattingEnabled = true;
            this.cbxAuthor.Location = new System.Drawing.Point(318, 96);
            this.cbxAuthor.Name = "cbxAuthor";
            this.cbxAuthor.Size = new System.Drawing.Size(121, 24);
            this.cbxAuthor.TabIndex = 14;
            // 
            // cbmCategory
            // 
            this.cbmCategory.FormattingEnabled = true;
            this.cbmCategory.Location = new System.Drawing.Point(318, 29);
            this.cbmCategory.Name = "cbmCategory";
            this.cbmCategory.Size = new System.Drawing.Size(121, 24);
            this.cbmCategory.TabIndex = 13;
            // 
            // tbxNumberOfPrints
            // 
            this.tbxNumberOfPrints.Location = new System.Drawing.Point(109, 162);
            this.tbxNumberOfPrints.Name = "tbxNumberOfPrints";
            this.tbxNumberOfPrints.Size = new System.Drawing.Size(100, 22);
            this.tbxNumberOfPrints.TabIndex = 12;
            // 
            // tbxNumberOfPages
            // 
            this.tbxNumberOfPages.Location = new System.Drawing.Point(109, 128);
            this.tbxNumberOfPages.Name = "tbxNumberOfPages";
            this.tbxNumberOfPages.Size = new System.Drawing.Size(100, 22);
            this.tbxNumberOfPages.TabIndex = 11;
            // 
            // tbxLanguage
            // 
            this.tbxLanguage.Location = new System.Drawing.Point(107, 96);
            this.tbxLanguage.Name = "tbxLanguage";
            this.tbxLanguage.Size = new System.Drawing.Size(100, 22);
            this.tbxLanguage.TabIndex = 10;
            // 
            // tbxBookName2
            // 
            this.tbxBookName2.Location = new System.Drawing.Point(107, 29);
            this.tbxBookName2.Name = "tbxBookName2";
            this.tbxBookName2.Size = new System.Drawing.Size(100, 22);
            this.tbxBookName2.TabIndex = 8;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(232, 165);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(69, 17);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Yayınevi :";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(232, 96);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 17);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Yazar : ";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(232, 29);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(73, 17);
            this.lblCategoryName.TabIndex = 5;
            this.lblCategoryName.Text = "Kategori : ";
            // 
            // lblNumberPrint
            // 
            this.lblNumberPrint.AutoSize = true;
            this.lblNumberPrint.Location = new System.Drawing.Point(6, 165);
            this.lblNumberPrint.Name = "lblNumberPrint";
            this.lblNumberPrint.Size = new System.Drawing.Size(95, 17);
            this.lblNumberPrint.TabIndex = 4;
            this.lblNumberPrint.Text = "Baskı Sayısı : ";
            // 
            // lblNumberPages
            // 
            this.lblNumberPages.AutoSize = true;
            this.lblNumberPages.Location = new System.Drawing.Point(6, 128);
            this.lblNumberPages.Name = "lblNumberPages";
            this.lblNumberPages.Size = new System.Drawing.Size(97, 17);
            this.lblNumberPages.TabIndex = 3;
            this.lblNumberPages.Text = "Sayfa Sayısı : ";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(6, 96);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(36, 17);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "Dil : ";
            // 
            // lblRealeseDate
            // 
            this.lblRealeseDate.AutoSize = true;
            this.lblRealeseDate.Location = new System.Drawing.Point(6, 64);
            this.lblRealeseDate.Name = "lblRealeseDate";
            this.lblRealeseDate.Size = new System.Drawing.Size(95, 17);
            this.lblRealeseDate.TabIndex = 1;
            this.lblRealeseDate.Text = "Yayın Tarihi : ";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(6, 29);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(76, 17);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Kitap Adı : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 779);
            this.Controls.Add(this.gbxBookAdd);
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
            this.gbxBookAdd.ResumeLayout(false);
            this.gbxBookAdd.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxBookAdd;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblNumberPrint;
        private System.Windows.Forms.Label lblNumberPages;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblRealeseDate;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private System.Windows.Forms.ComboBox cbxAuthor;
        private System.Windows.Forms.ComboBox cbmCategory;
        private System.Windows.Forms.TextBox tbxNumberOfPrints;
        private System.Windows.Forms.TextBox tbxNumberOfPages;
        private System.Windows.Forms.TextBox tbxLanguage;
        private System.Windows.Forms.TextBox tbxBookName2;
        private System.Windows.Forms.DateTimePicker dtpRealeseDate;
    }
}

