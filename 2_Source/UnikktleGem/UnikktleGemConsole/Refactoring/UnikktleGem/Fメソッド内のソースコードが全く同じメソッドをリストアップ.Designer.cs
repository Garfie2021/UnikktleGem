
namespace UnikktleGemConsole
{
    partial class Fメソッド内のソースコードが全く同じメソッドをリストアップ
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
            this.dgv結果.Location = new System.Drawing.Point(2, 26);
            this.dgv結果.Name = "dgv結果";
            this.dgv結果.ReadOnly = true;
            this.dgv結果.RowHeadersVisible = false;
            this.dgv結果.RowTemplate.Height = 21;
            this.dgv結果.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv結果.Size = new System.Drawing.Size(785, 245);
            this.dgv結果.TabIndex = 2;
            // 
            // Fメソッド内のソースコードが全く同じメソッドをリストアップ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 283);
            this.Controls.Add(this.dgv結果);
            this.Name = "Fメソッド内のソースコードが全く同じメソッドをリストアップ";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "リファクタリング メソッド内のソースコードが全く同じメソッドをリストアップ";
            this.Load += new System.EventHandler(this.FRefactoringList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv結果)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv結果;
    }
}