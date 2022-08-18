
namespace UnikktleGemConsole
{
    partial class FViewAnalyzeResult
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
            this.dgv結果 = new System.Windows.Forms.DataGridView();
            this.txt件数 = new System.Windows.Forms.TextBox();
            this.chkオブジェクトカテゴリ = new System.Windows.Forms.CheckBox();
            this.chkファイルパス = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv結果)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv結果
            // 
            this.dgv結果.AllowUserToAddRows = false;
            this.dgv結果.AllowUserToDeleteRows = false;
            this.dgv結果.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv結果.Location = new System.Drawing.Point(0, 34);
            this.dgv結果.Name = "dgv結果";
            this.dgv結果.ReadOnly = true;
            this.dgv結果.RowHeadersVisible = false;
            this.dgv結果.RowTemplate.Height = 21;
            this.dgv結果.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv結果.Size = new System.Drawing.Size(720, 313);
            this.dgv結果.TabIndex = 1;
            // 
            // txt件数
            // 
            this.txt件数.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt件数.Location = new System.Drawing.Point(0, 345);
            this.txt件数.Multiline = true;
            this.txt件数.Name = "txt件数";
            this.txt件数.Size = new System.Drawing.Size(720, 31);
            this.txt件数.TabIndex = 11;
            this.txt件数.Text = "１\r\n２";
            // 
            // chkオブジェクトカテゴリ
            // 
            this.chkオブジェクトカテゴリ.AutoSize = true;
            this.chkオブジェクトカテゴリ.Checked = true;
            this.chkオブジェクトカテゴリ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkオブジェクトカテゴリ.Location = new System.Drawing.Point(9, 6);
            this.chkオブジェクトカテゴリ.Name = "chkオブジェクトカテゴリ";
            this.chkオブジェクトカテゴリ.Size = new System.Drawing.Size(109, 16);
            this.chkオブジェクトカテゴリ.TabIndex = 12;
            this.chkオブジェクトカテゴリ.Text = "オブジェクトカテゴリ";
            this.chkオブジェクトカテゴリ.UseVisualStyleBackColor = true;
            this.chkオブジェクトカテゴリ.CheckedChanged += new System.EventHandler(this.chkオブジェクトカテゴリ_CheckedChanged);
            // 
            // chkファイルパス
            // 
            this.chkファイルパス.AutoSize = true;
            this.chkファイルパス.Checked = true;
            this.chkファイルパス.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkファイルパス.Location = new System.Drawing.Point(128, 6);
            this.chkファイルパス.Name = "chkファイルパス";
            this.chkファイルパス.Size = new System.Drawing.Size(77, 16);
            this.chkファイルパス.TabIndex = 13;
            this.chkファイルパス.Text = "ファイルパス";
            this.chkファイルパス.UseVisualStyleBackColor = true;
            this.chkファイルパス.CheckedChanged += new System.EventHandler(this.chkファイルパス_CheckedChanged);
            // 
            // FViewAnalyzeResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 376);
            this.Controls.Add(this.chkファイルパス);
            this.Controls.Add(this.chkオブジェクトカテゴリ);
            this.Controls.Add(this.txt件数);
            this.Controls.Add(this.dgv結果);
            this.Name = "FViewAnalyzeResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽出結果";
            this.Load += new System.EventHandler(this.FViewAnalyzeResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv結果)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv結果;
        private System.Windows.Forms.TextBox txt件数;
        private System.Windows.Forms.CheckBox chkオブジェクトカテゴリ;
        private System.Windows.Forms.CheckBox chkファイルパス;
    }
}