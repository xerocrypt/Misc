namespace Simple_REST_Example
{
    partial class restMaihnForm
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
            this.webSearchResult = new System.Windows.Forms.WebBrowser();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.lblEnterTerm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webSearchResult
            // 
            this.webSearchResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webSearchResult.Location = new System.Drawing.Point(0, 63);
            this.webSearchResult.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSearchResult.Name = "webSearchResult";
            this.webSearchResult.Size = new System.Drawing.Size(846, 344);
            this.webSearchResult.TabIndex = 0;
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTerm.Location = new System.Drawing.Point(107, 21);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(264, 15);
            this.txtSearchTerm.TabIndex = 1;
            // 
            // cmdSearch
            // 
            this.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Location = new System.Drawing.Point(377, 9);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 38);
            this.cmdSearch.TabIndex = 2;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEnterTerm
            // 
            this.lblEnterTerm.AutoSize = true;
            this.lblEnterTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTerm.Location = new System.Drawing.Point(12, 20);
            this.lblEnterTerm.Name = "lblEnterTerm";
            this.lblEnterTerm.Size = new System.Drawing.Size(89, 16);
            this.lblEnterTerm.TabIndex = 3;
            this.lblEnterTerm.Text = "Search Term:";
            // 
            // restMaihnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 407);
            this.Controls.Add(this.lblEnterTerm);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.webSearchResult);
            this.Name = "restMaihnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitter REST API Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webSearchResult;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Label lblEnterTerm;
    }
}

