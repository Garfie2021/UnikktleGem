
namespace UnikktleGemConsole
{
    partial class FNotUseMethod
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
            this.btn削除 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn未使用メソッドを抽出 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv結果)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv結果
            // 
            this.dgv結果.AllowUserToAddRows = false;
            this.dgv結果.AllowUserToDeleteRows = false;
            this.dgv結果.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv結果.Location = new System.Drawing.Point(3, 101);
            this.dgv結果.Name = "dgv結果";
            this.dgv結果.ReadOnly = true;
            this.dgv結果.RowHeadersVisible = false;
            this.dgv結果.RowTemplate.Height = 21;
            this.dgv結果.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv結果.Size = new System.Drawing.Size(640, 270);
            this.dgv結果.TabIndex = 2;
            // 
            // btn削除
            // 
            this.btn削除.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn削除.Location = new System.Drawing.Point(3, 377);
            this.btn削除.Name = "btn削除";
            this.btn削除.Size = new System.Drawing.Size(113, 23);
            this.btn削除.TabIndex = 3;
            this.btn削除.Text = "削除";
            this.btn削除.UseVisualStyleBackColor = true;
            this.btn削除.Click += new System.EventHandler(this.btn削除_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "直接使用されていないメソッド一覧。\r\n※リフレクションを除く。\r\nリフレクションされているメソッド。　※リフレクションされているかどうかわからない問題がある";
            // 
            // btn未使用メソッドを抽出
            // 
            this.btn未使用メソッドを抽出.Location = new System.Drawing.Point(4, 72);
            this.btn未使用メソッドを抽出.Name = "btn未使用メソッドを抽出";
            this.btn未使用メソッドを抽出.Size = new System.Drawing.Size(169, 23);
            this.btn未使用メソッドを抽出.TabIndex = 7;
            this.btn未使用メソッドを抽出.Text = "未使用メソッドを抽出";
            this.btn未使用メソッドを抽出.UseVisualStyleBackColor = true;
            this.btn未使用メソッドを抽出.Click += new System.EventHandler(this.btn未使用メソッドを抽出_Click);
            // 
            // FNotUseMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 407);
            this.Controls.Add(this.btn未使用メソッドを抽出);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn削除);
            this.Controls.Add(this.dgv結果);
            this.Name = "FNotUseMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "使われていないメソッド";
            this.Load += new System.EventHandler(this.FNotUseMethod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv結果)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv結果;
        private System.Windows.Forms.Button btn削除;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn未使用メソッドを抽出;
    }
}