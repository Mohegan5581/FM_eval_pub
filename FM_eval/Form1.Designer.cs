namespace FM_eval
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
            this.fileBrowse = new System.Windows.Forms.Button();
            this.playerFileLabel = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fileBrowse
            // 
            this.fileBrowse.Location = new System.Drawing.Point(364, 11);
            this.fileBrowse.Name = "fileBrowse";
            this.fileBrowse.Size = new System.Drawing.Size(75, 23);
            this.fileBrowse.TabIndex = 0;
            this.fileBrowse.Text = "Browse";
            this.fileBrowse.UseVisualStyleBackColor = true;
            this.fileBrowse.Click += new System.EventHandler(this.fileBrowse_Click);
            // 
            // playerFileLabel
            // 
            this.playerFileLabel.AutoSize = true;
            this.playerFileLabel.Location = new System.Drawing.Point(12, 17);
            this.playerFileLabel.Name = "playerFileLabel";
            this.playerFileLabel.Size = new System.Drawing.Size(88, 13);
            this.playerFileLabel.TabIndex = 1;
            this.playerFileLabel.Text = "Player File (CSV):";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(106, 14);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(252, 20);
            this.fileTextBox.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(106, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1328, 569);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 621);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.playerFileLabel);
            this.Controls.Add(this.fileBrowse);
            this.Name = "Form1";
            this.Text = "FM Eval";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileBrowse;
        private System.Windows.Forms.Label playerFileLabel;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

