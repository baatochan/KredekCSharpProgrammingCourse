namespace BartoszRodziewiczLab3Task1
{
    partial class FormLibrary
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
            this.dataGridViewLibrary = new System.Windows.Forms.DataGridView();
            this.labelShow = new System.Windows.Forms.Label();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonReservations = new System.Windows.Forms.Button();
            this.buttonBranches = new System.Windows.Forms.Button();
            this.buttonLibrarians = new System.Windows.Forms.Button();
            this.labelLibrarian = new System.Windows.Forms.Label();
            this.textBoxLibrarianName = new System.Windows.Forms.TextBox();
            this.textBoxLibrarianSurname = new System.Windows.Forms.TextBox();
            this.labelLibrarianName = new System.Windows.Forms.Label();
            this.labelLibrarianSurname = new System.Windows.Forms.Label();
            this.labelLibrarianHireDate = new System.Windows.Forms.Label();
            this.textBoxLibrarianHireDate = new System.Windows.Forms.TextBox();
            this.buttonLibrarianAdd = new System.Windows.Forms.Button();
            this.buttonLibrarianRemove = new System.Windows.Forms.Button();
            this.labelBookSearch = new System.Windows.Forms.Label();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.labelLibrarianID = new System.Windows.Forms.Label();
            this.textBoxLibrarianID = new System.Windows.Forms.TextBox();
            this.buttonLibrarianEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrary)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLibrary
            // 
            this.dataGridViewLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibrary.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLibrary.Name = "dataGridViewLibrary";
            this.dataGridViewLibrary.Size = new System.Drawing.Size(492, 237);
            this.dataGridViewLibrary.TabIndex = 0;
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(13, 256);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(52, 13);
            this.labelShow.TabIndex = 1;
            this.labelShow.Text = "Wyświetl:";
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(13, 273);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(75, 23);
            this.buttonBooks.TabIndex = 2;
            this.buttonBooks.Text = "Książki";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(94, 273);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(75, 23);
            this.buttonCategories.TabIndex = 3;
            this.buttonCategories.Text = "Kategorie";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(175, 273);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(75, 23);
            this.buttonClients.TabIndex = 4;
            this.buttonClients.Text = "Klienci";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonReservations
            // 
            this.buttonReservations.Location = new System.Drawing.Point(256, 273);
            this.buttonReservations.Name = "buttonReservations";
            this.buttonReservations.Size = new System.Drawing.Size(75, 23);
            this.buttonReservations.TabIndex = 5;
            this.buttonReservations.Text = "Rezerwacje";
            this.buttonReservations.UseVisualStyleBackColor = true;
            this.buttonReservations.Click += new System.EventHandler(this.buttonReservations_Click);
            // 
            // buttonBranches
            // 
            this.buttonBranches.Location = new System.Drawing.Point(337, 273);
            this.buttonBranches.Name = "buttonBranches";
            this.buttonBranches.Size = new System.Drawing.Size(75, 23);
            this.buttonBranches.TabIndex = 6;
            this.buttonBranches.Text = "Filie";
            this.buttonBranches.UseVisualStyleBackColor = true;
            this.buttonBranches.Click += new System.EventHandler(this.buttonBranches_Click);
            // 
            // buttonLibrarians
            // 
            this.buttonLibrarians.Location = new System.Drawing.Point(418, 273);
            this.buttonLibrarians.Name = "buttonLibrarians";
            this.buttonLibrarians.Size = new System.Drawing.Size(86, 23);
            this.buttonLibrarians.TabIndex = 7;
            this.buttonLibrarians.Text = "Pracowników";
            this.buttonLibrarians.UseVisualStyleBackColor = true;
            this.buttonLibrarians.Click += new System.EventHandler(this.buttonLibrarians_Click);
            // 
            // labelLibrarian
            // 
            this.labelLibrarian.AutoSize = true;
            this.labelLibrarian.Location = new System.Drawing.Point(10, 309);
            this.labelLibrarian.Name = "labelLibrarian";
            this.labelLibrarian.Size = new System.Drawing.Size(60, 13);
            this.labelLibrarian.TabIndex = 8;
            this.labelLibrarian.Text = "Pracownik:";
            // 
            // textBoxLibrarianName
            // 
            this.textBoxLibrarianName.Location = new System.Drawing.Point(45, 326);
            this.textBoxLibrarianName.Name = "textBoxLibrarianName";
            this.textBoxLibrarianName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLibrarianName.TabIndex = 9;
            // 
            // textBoxLibrarianSurname
            // 
            this.textBoxLibrarianSurname.Location = new System.Drawing.Point(213, 326);
            this.textBoxLibrarianSurname.Name = "textBoxLibrarianSurname";
            this.textBoxLibrarianSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxLibrarianSurname.TabIndex = 10;
            // 
            // labelLibrarianName
            // 
            this.labelLibrarianName.AutoSize = true;
            this.labelLibrarianName.Location = new System.Drawing.Point(10, 329);
            this.labelLibrarianName.Name = "labelLibrarianName";
            this.labelLibrarianName.Size = new System.Drawing.Size(29, 13);
            this.labelLibrarianName.TabIndex = 11;
            this.labelLibrarianName.Text = "Imię:";
            // 
            // labelLibrarianSurname
            // 
            this.labelLibrarianSurname.AutoSize = true;
            this.labelLibrarianSurname.Location = new System.Drawing.Point(151, 329);
            this.labelLibrarianSurname.Name = "labelLibrarianSurname";
            this.labelLibrarianSurname.Size = new System.Drawing.Size(56, 13);
            this.labelLibrarianSurname.TabIndex = 12;
            this.labelLibrarianSurname.Text = "Nazwisko:";
            // 
            // labelLibrarianHireDate
            // 
            this.labelLibrarianHireDate.AutoSize = true;
            this.labelLibrarianHireDate.Location = new System.Drawing.Point(10, 355);
            this.labelLibrarianHireDate.Name = "labelLibrarianHireDate";
            this.labelLibrarianHireDate.Size = new System.Drawing.Size(148, 13);
            this.labelLibrarianHireDate.TabIndex = 13;
            this.labelLibrarianHireDate.Text = "Data zatrudnienia (rrrr-mm-dd):";
            // 
            // textBoxLibrarianHireDate
            // 
            this.textBoxLibrarianHireDate.Location = new System.Drawing.Point(164, 352);
            this.textBoxLibrarianHireDate.Name = "textBoxLibrarianHireDate";
            this.textBoxLibrarianHireDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxLibrarianHireDate.TabIndex = 14;
            // 
            // buttonLibrarianAdd
            // 
            this.buttonLibrarianAdd.Location = new System.Drawing.Point(337, 323);
            this.buttonLibrarianAdd.Name = "buttonLibrarianAdd";
            this.buttonLibrarianAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonLibrarianAdd.TabIndex = 15;
            this.buttonLibrarianAdd.Text = "Dodaj";
            this.buttonLibrarianAdd.UseVisualStyleBackColor = true;
            this.buttonLibrarianAdd.Click += new System.EventHandler(this.buttonLibrarianAdd_Click);
            // 
            // buttonLibrarianRemove
            // 
            this.buttonLibrarianRemove.Location = new System.Drawing.Point(418, 323);
            this.buttonLibrarianRemove.Name = "buttonLibrarianRemove";
            this.buttonLibrarianRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonLibrarianRemove.TabIndex = 16;
            this.buttonLibrarianRemove.Text = "Usuń";
            this.buttonLibrarianRemove.UseVisualStyleBackColor = true;
            this.buttonLibrarianRemove.Click += new System.EventHandler(this.buttonLibrarianRemove_Click);
            // 
            // labelBookSearch
            // 
            this.labelBookSearch.AutoSize = true;
            this.labelBookSearch.Location = new System.Drawing.Point(9, 384);
            this.labelBookSearch.Name = "labelBookSearch";
            this.labelBookSearch.Size = new System.Drawing.Size(77, 13);
            this.labelBookSearch.TabIndex = 17;
            this.labelBookSearch.Text = "Szukaj książki:";
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(50, 400);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxBookTitle.TabIndex = 18;
            this.textBoxBookTitle.TextChanged += new System.EventHandler(this.textBoxBookTitle_TextChanged);
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(11, 403);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(33, 13);
            this.labelBookTitle.TabIndex = 19;
            this.labelBookTitle.Text = "Tytul:";
            // 
            // labelLibrarianID
            // 
            this.labelLibrarianID.AutoSize = true;
            this.labelLibrarianID.Location = new System.Drawing.Point(270, 355);
            this.labelLibrarianID.Name = "labelLibrarianID";
            this.labelLibrarianID.Size = new System.Drawing.Size(89, 13);
            this.labelLibrarianID.TabIndex = 20;
            this.labelLibrarianID.Text = "(index (do edycji))";
            // 
            // textBoxLibrarianID
            // 
            this.textBoxLibrarianID.Location = new System.Drawing.Point(365, 352);
            this.textBoxLibrarianID.Name = "textBoxLibrarianID";
            this.textBoxLibrarianID.Size = new System.Drawing.Size(47, 20);
            this.textBoxLibrarianID.TabIndex = 21;
            // 
            // buttonLibrarianEdit
            // 
            this.buttonLibrarianEdit.Location = new System.Drawing.Point(418, 352);
            this.buttonLibrarianEdit.Name = "buttonLibrarianEdit";
            this.buttonLibrarianEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonLibrarianEdit.TabIndex = 22;
            this.buttonLibrarianEdit.Text = "Edytuj";
            this.buttonLibrarianEdit.UseVisualStyleBackColor = true;
            this.buttonLibrarianEdit.Click += new System.EventHandler(this.buttonLibrarianEdit_Click);
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 432);
            this.Controls.Add(this.buttonLibrarianEdit);
            this.Controls.Add(this.textBoxLibrarianID);
            this.Controls.Add(this.labelLibrarianID);
            this.Controls.Add(this.labelBookTitle);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.labelBookSearch);
            this.Controls.Add(this.buttonLibrarianRemove);
            this.Controls.Add(this.buttonLibrarianAdd);
            this.Controls.Add(this.textBoxLibrarianHireDate);
            this.Controls.Add(this.labelLibrarianHireDate);
            this.Controls.Add(this.labelLibrarianSurname);
            this.Controls.Add(this.labelLibrarianName);
            this.Controls.Add(this.textBoxLibrarianSurname);
            this.Controls.Add(this.textBoxLibrarianName);
            this.Controls.Add(this.labelLibrarian);
            this.Controls.Add(this.buttonLibrarians);
            this.Controls.Add(this.buttonBranches);
            this.Controls.Add(this.buttonReservations);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonCategories);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.dataGridViewLibrary);
            this.Name = "FormLibrary";
            this.Text = "Biblioteka";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibrary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLibrary;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonReservations;
        private System.Windows.Forms.Button buttonBranches;
        private System.Windows.Forms.Button buttonLibrarians;
        private System.Windows.Forms.Label labelLibrarian;
        private System.Windows.Forms.TextBox textBoxLibrarianName;
        private System.Windows.Forms.TextBox textBoxLibrarianSurname;
        private System.Windows.Forms.Label labelLibrarianName;
        private System.Windows.Forms.Label labelLibrarianSurname;
        private System.Windows.Forms.Label labelLibrarianHireDate;
        private System.Windows.Forms.TextBox textBoxLibrarianHireDate;
        private System.Windows.Forms.Button buttonLibrarianAdd;
        private System.Windows.Forms.Button buttonLibrarianRemove;
        private System.Windows.Forms.Label labelBookSearch;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.Label labelLibrarianID;
        private System.Windows.Forms.TextBox textBoxLibrarianID;
        private System.Windows.Forms.Button buttonLibrarianEdit;
    }
}

