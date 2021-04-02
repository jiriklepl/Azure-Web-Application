namespace SearchUI
{
    partial class AzureSearchPlayground
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
            this.label2 = new System.Windows.Forms.Label();
            this.InputTitle = new System.Windows.Forms.TextBox();
            this.InputCategory = new System.Windows.Forms.TextBox();
            this.InputText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Keyword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultGrid = new System.Windows.Forms.DataGridView();
            this.ButtonIndex = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(370, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // InputTitle
            // 
            this.InputTitle.Location = new System.Drawing.Point(21, 72);
            this.InputTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InputTitle.Name = "InputTitle";
            this.InputTitle.Size = new System.Drawing.Size(185, 20);
            this.InputTitle.TabIndex = 2;
            // 
            // InputCategory
            // 
            this.InputCategory.Location = new System.Drawing.Point(21, 112);
            this.InputCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InputCategory.Name = "InputCategory";
            this.InputCategory.Size = new System.Drawing.Size(185, 20);
            this.InputCategory.TabIndex = 3;
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(21, 154);
            this.InputText.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(280, 189);
            this.InputText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Text";
            // 
            // Keyword
            // 
            this.Keyword.Location = new System.Drawing.Point(374, 72);
            this.Keyword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(185, 20);
            this.Keyword.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Keyword";
            // 
            // ResultGrid
            // 
            this.ResultGrid.AllowUserToAddRows = false;
            this.ResultGrid.AllowUserToDeleteRows = false;
            this.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid.Location = new System.Drawing.Point(374, 112);
            this.ResultGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.ReadOnly = true;
            this.ResultGrid.RowTemplate.Height = 33;
            this.ResultGrid.Size = new System.Drawing.Size(446, 228);
            this.ResultGrid.TabIndex = 10;
            // 
            // ButtonIndex
            // 
            this.ButtonIndex.Location = new System.Drawing.Point(234, 72);
            this.ButtonIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonIndex.Name = "ButtonIndex";
            this.ButtonIndex.Size = new System.Drawing.Size(65, 57);
            this.ButtonIndex.TabIndex = 11;
            this.ButtonIndex.Text = "Add Item";
            this.ButtonIndex.UseVisualStyleBackColor = true;
            this.ButtonIndex.Click += new System.EventHandler(this.ButtonIndex_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(592, 71);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(124, 31);
            this.ButtonSearch.TabIndex = 12;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // AzureSearchPlayground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 382);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonIndex);
            this.Controls.Add(this.ResultGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Keyword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.InputCategory);
            this.Controls.Add(this.InputTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AzureSearchPlayground";
            this.Text = "Azure Search Playground";
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputTitle;
        private System.Windows.Forms.TextBox InputCategory;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Keyword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ResultGrid;
        private System.Windows.Forms.Button ButtonIndex;
        private System.Windows.Forms.Button ButtonSearch;
    }
}

