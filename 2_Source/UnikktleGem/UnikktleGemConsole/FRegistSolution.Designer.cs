
namespace UnikktleGemConsole
{
    partial class FRegistSolution
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
            this.btn登録 = new System.Windows.Forms.Button();
            this.btnキャンセル = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSolutionFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn登録
            // 
            this.btn登録.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn登録.Location = new System.Drawing.Point(669, 44);
            this.btn登録.Name = "btn登録";
            this.btn登録.Size = new System.Drawing.Size(107, 23);
            this.btn登録.TabIndex = 4;
            this.btn登録.Text = "登録";
            this.btn登録.UseVisualStyleBackColor = true;
            this.btn登録.Click += new System.EventHandler(this.btn登録_Click);
            // 
            // btnキャンセル
            // 
            this.btnキャンセル.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnキャンセル.Location = new System.Drawing.Point(782, 44);
            this.btnキャンセル.Name = "btnキャンセル";
            this.btnキャンセル.Size = new System.Drawing.Size(107, 23);
            this.btnキャンセル.TabIndex = 5;
            this.btnキャンセル.Text = "キャンセル";
            this.btnキャンセル.UseVisualStyleBackColor = true;
            this.btnキャンセル.Click += new System.EventHandler(this.btnキャンセル_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(848, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSolutionFilePath
            // 
            this.txtSolutionFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolutionFilePath.Location = new System.Drawing.Point(114, 12);
            this.txtSolutionFilePath.Name = "txtSolutionFilePath";
            this.txtSolutionFilePath.Size = new System.Drawing.Size(734, 19);
            this.txtSolutionFilePath.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "ソリューションファイル";
            // 
            // FRegistSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 77);
            this.Controls.Add(this.txtSolutionFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnキャンセル);
            this.Controls.Add(this.btn登録);
            this.Name = "FRegistSolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ソリューション登録";
            this.Load += new System.EventHandler(this.FRegistSolution_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn登録;
        private System.Windows.Forms.Button btnキャンセル;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSolutionFilePath;
        private System.Windows.Forms.Label label2;
    }
}