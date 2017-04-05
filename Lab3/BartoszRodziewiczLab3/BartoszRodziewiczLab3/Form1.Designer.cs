namespace BartoszRodziewiczLab3
{
    partial class FormZoo
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
            this.dataGridViewZoo = new System.Windows.Forms.DataGridView();
            this.buttonAllAnimals = new System.Windows.Forms.Button();
            this.buttonShowAllSloths = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZoo
            // 
            this.dataGridViewZoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZoo.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewZoo.Name = "dataGridViewZoo";
            this.dataGridViewZoo.Size = new System.Drawing.Size(660, 208);
            this.dataGridViewZoo.TabIndex = 0;
            // 
            // buttonAllAnimals
            // 
            this.buttonAllAnimals.Location = new System.Drawing.Point(596, 226);
            this.buttonAllAnimals.Name = "buttonAllAnimals";
            this.buttonAllAnimals.Size = new System.Drawing.Size(75, 23);
            this.buttonAllAnimals.TabIndex = 1;
            this.buttonAllAnimals.Text = "Zwierzaki";
            this.buttonAllAnimals.UseVisualStyleBackColor = true;
            this.buttonAllAnimals.Click += new System.EventHandler(this.buttonAllAnimals_Click);
            // 
            // buttonShowAllSloths
            // 
            this.buttonShowAllSloths.Location = new System.Drawing.Point(515, 227);
            this.buttonShowAllSloths.Name = "buttonShowAllSloths";
            this.buttonShowAllSloths.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAllSloths.TabIndex = 2;
            this.buttonShowAllSloths.Text = "Leniwce";
            this.buttonShowAllSloths.UseVisualStyleBackColor = true;
            this.buttonShowAllSloths.Click += new System.EventHandler(this.buttonShowAllSloths_Click);
            // 
            // FormZoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.buttonShowAllSloths);
            this.Controls.Add(this.buttonAllAnimals);
            this.Controls.Add(this.dataGridViewZoo);
            this.Name = "FormZoo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZoo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZoo;
        private System.Windows.Forms.Button buttonAllAnimals;
        private System.Windows.Forms.Button buttonShowAllSloths;
    }
}

