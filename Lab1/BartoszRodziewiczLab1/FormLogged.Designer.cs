namespace BartoszRodziewiczLab1
{
    partial class FormLogged
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
            this.components = new System.ComponentModel.Container();
            this.timerWindowTimeRunning = new System.Windows.Forms.Timer(this.components);
            this.labelTimerText = new System.Windows.Forms.Label();
            this.labelTimerSeconds = new System.Windows.Forms.Label();
            this.labelsTimerActive = new System.Windows.Forms.Label();
            this.checkBoxIsTimerActive = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonFillBar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFillDataGridRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timerWindowTimeRunning
            // 
            this.timerWindowTimeRunning.Enabled = true;
            this.timerWindowTimeRunning.Interval = 1000;
            this.timerWindowTimeRunning.Tick += new System.EventHandler(this.timerWindowTimeRunning_Tick);
            // 
            // labelTimerText
            // 
            this.labelTimerText.AutoSize = true;
            this.labelTimerText.Location = new System.Drawing.Point(13, 13);
            this.labelTimerText.Name = "labelTimerText";
            this.labelTimerText.Size = new System.Drawing.Size(155, 13);
            this.labelTimerText.TabIndex = 0;
            this.labelTimerText.Text = "Czas od uruchomienia okna [s]:";
            // 
            // labelTimerSeconds
            // 
            this.labelTimerSeconds.AutoSize = true;
            this.labelTimerSeconds.Location = new System.Drawing.Point(165, 13);
            this.labelTimerSeconds.Name = "labelTimerSeconds";
            this.labelTimerSeconds.Size = new System.Drawing.Size(13, 13);
            this.labelTimerSeconds.TabIndex = 1;
            this.labelTimerSeconds.Text = "0";
            // 
            // labelsTimerActive
            // 
            this.labelsTimerActive.AutoSize = true;
            this.labelsTimerActive.Location = new System.Drawing.Point(14, 38);
            this.labelsTimerActive.Name = "labelsTimerActive";
            this.labelsTimerActive.Size = new System.Drawing.Size(78, 13);
            this.labelsTimerActive.TabIndex = 2;
            this.labelsTimerActive.Text = "Timer aktywny:";
            // 
            // checkBoxIsTimerActive
            // 
            this.checkBoxIsTimerActive.AutoSize = true;
            this.checkBoxIsTimerActive.Checked = true;
            this.checkBoxIsTimerActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsTimerActive.Location = new System.Drawing.Point(98, 38);
            this.checkBoxIsTimerActive.Name = "checkBoxIsTimerActive";
            this.checkBoxIsTimerActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsTimerActive.TabIndex = 3;
            this.checkBoxIsTimerActive.UseVisualStyleBackColor = true;
            this.checkBoxIsTimerActive.CheckedChanged += new System.EventHandler(this.checkBoxIsTimerActive_CheckedChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 226);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(175, 23);
            this.progressBar.TabIndex = 4;
            // 
            // buttonFillBar
            // 
            this.buttonFillBar.Location = new System.Drawing.Point(197, 226);
            this.buttonFillBar.Name = "buttonFillBar";
            this.buttonFillBar.Size = new System.Drawing.Size(75, 23);
            this.buttonFillBar.TabIndex = 5;
            this.buttonFillBar.Text = "Kliknij! :)";
            this.buttonFillBar.UseVisualStyleBackColor = true;
            this.buttonFillBar.Click += new System.EventHandler(this.buttonFillBar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView.Location = new System.Drawing.Point(16, 58);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(256, 133);
            this.dataGridView.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Możesz tu";
            this.Column1.Name = "Column1";
            this.Column1.Width = 106;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "coś dodać :)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 107;
            // 
            // buttonFillDataGridRow
            // 
            this.buttonFillDataGridRow.Location = new System.Drawing.Point(168, 197);
            this.buttonFillDataGridRow.Name = "buttonFillDataGridRow";
            this.buttonFillDataGridRow.Size = new System.Drawing.Size(104, 23);
            this.buttonFillDataGridRow.TabIndex = 7;
            this.buttonFillDataGridRow.Text = "Wypełnij tabelkę";
            this.buttonFillDataGridRow.UseVisualStyleBackColor = true;
            this.buttonFillDataGridRow.Click += new System.EventHandler(this.buttonFillDataGridRow_Click);
            // 
            // FormLogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonFillDataGridRow);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonFillBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.checkBoxIsTimerActive);
            this.Controls.Add(this.labelsTimerActive);
            this.Controls.Add(this.labelTimerSeconds);
            this.Controls.Add(this.labelTimerText);
            this.Name = "FormLogged";
            this.Text = "Zalogowany";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerWindowTimeRunning;
        private System.Windows.Forms.Label labelTimerText;
        private System.Windows.Forms.Label labelTimerSeconds;
        private System.Windows.Forms.Label labelsTimerActive;
        private System.Windows.Forms.CheckBox checkBoxIsTimerActive;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonFillBar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button buttonFillDataGridRow;
    }
}