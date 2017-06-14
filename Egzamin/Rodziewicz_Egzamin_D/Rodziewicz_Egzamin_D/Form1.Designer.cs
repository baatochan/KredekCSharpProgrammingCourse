namespace Rodziewicz_Egzamin_D
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonSuppliers = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.textBoxPriceToFilter = new System.Windows.Forms.TextBox();
            this.buttonFilterByPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 13);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(745, 238);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonSuppliers
            // 
            this.buttonSuppliers.Location = new System.Drawing.Point(12, 257);
            this.buttonSuppliers.Name = "buttonSuppliers";
            this.buttonSuppliers.Size = new System.Drawing.Size(105, 23);
            this.buttonSuppliers.TabIndex = 1;
            this.buttonSuppliers.Text = "A1 Dostawcy";
            this.buttonSuppliers.UseVisualStyleBackColor = true;
            this.buttonSuppliers.Click += new System.EventHandler(this.buttonSuppliers_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(123, 257);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(109, 23);
            this.buttonProducts.TabIndex = 2;
            this.buttonProducts.Text = "A1 Produkty";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // textBoxPriceToFilter
            // 
            this.textBoxPriceToFilter.Location = new System.Drawing.Point(324, 259);
            this.textBoxPriceToFilter.Name = "textBoxPriceToFilter";
            this.textBoxPriceToFilter.Size = new System.Drawing.Size(126, 20);
            this.textBoxPriceToFilter.TabIndex = 3;
            // 
            // buttonFilterByPrice
            // 
            this.buttonFilterByPrice.Location = new System.Drawing.Point(457, 256);
            this.buttonFilterByPrice.Name = "buttonFilterByPrice";
            this.buttonFilterByPrice.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterByPrice.TabIndex = 4;
            this.buttonFilterByPrice.Text = "A3 Ceny";
            this.buttonFilterByPrice.UseVisualStyleBackColor = true;
            this.buttonFilterByPrice.Click += new System.EventHandler(this.buttonFilterByPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 303);
            this.Controls.Add(this.buttonFilterByPrice);
            this.Controls.Add(this.textBoxPriceToFilter);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonSuppliers);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSuppliers;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.TextBox textBoxPriceToFilter;
        private System.Windows.Forms.Button buttonFilterByPrice;
    }
}

