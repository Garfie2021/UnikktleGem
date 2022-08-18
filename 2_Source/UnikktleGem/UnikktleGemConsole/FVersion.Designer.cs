
namespace UnikktleGemConsole
{
    partial class FVersion
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
            this.btnサポートファイル作成 = new System.Windows.Forms.Button();
            this.lblバージョン = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnサポートファイル作成
            // 
            this.btnサポートファイル作成.Location = new System.Drawing.Point(9, 58);
            this.btnサポートファイル作成.Name = "btnサポートファイル作成";
            this.btnサポートファイル作成.Size = new System.Drawing.Size(141, 23);
            this.btnサポートファイル作成.TabIndex = 0;
            this.btnサポートファイル作成.Text = "サポートファイル作成";
            this.btnサポートファイル作成.UseVisualStyleBackColor = true;
            // 
            // lblバージョン
            // 
            this.lblバージョン.AutoSize = true;
            this.lblバージョン.Location = new System.Drawing.Point(3, 9);
            this.lblバージョン.Name = "lblバージョン";
            this.lblバージョン.Size = new System.Drawing.Size(74, 12);
            this.lblバージョン.TabIndex = 1;
            this.lblバージョン.Text = "バージョン情報";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnサポートファイル作成);
            this.groupBox1.Location = new System.Drawing.Point(5, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "サポートを受けるにはサポートファイルの送付が必要です。\r\nサポートファイルには、実行環境の情報、設定ファイル、ログファイルのみ含まれます。";
            // 
            // txtVersion
            // 
            this.txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersion.BackColor = System.Drawing.SystemColors.Control;
            this.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVersion.Location = new System.Drawing.Point(5, 31);
            this.txtVersion.Multiline = true;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(473, 119);
            this.txtVersion.TabIndex = 3;
            // 
            // FVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 264);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblバージョン);
            this.Name = "FVersion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "バージョン情報";
            this.Load += new System.EventHandler(this.FVersion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnサポートファイル作成;
        private System.Windows.Forms.Label lblバージョン;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVersion;
    }
}