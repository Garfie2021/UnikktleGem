
namespace UnikktleGemConsole
{
    partial class FRefactoringList
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
            this.btnリファクタリングを行う_VisualStudio = new System.Windows.Forms.Button();
            this.btnリファクタリングを行う_UnikktleGem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnリファクタリングを行う_VisualStudio
            // 
            this.btnリファクタリングを行う_VisualStudio.Location = new System.Drawing.Point(15, 71);
            this.btnリファクタリングを行う_VisualStudio.Name = "btnリファクタリングを行う_VisualStudio";
            this.btnリファクタリングを行う_VisualStudio.Size = new System.Drawing.Size(181, 23);
            this.btnリファクタリングを行う_VisualStudio.TabIndex = 2;
            this.btnリファクタリングを行う_VisualStudio.Text = "リファクタリングを行う";
            this.btnリファクタリングを行う_VisualStudio.UseVisualStyleBackColor = true;
            this.btnリファクタリングを行う_VisualStudio.Click += new System.EventHandler(this.btnリファクタリングを行う_VisualStudio_Click);
            // 
            // btnリファクタリングを行う_UnikktleGem
            // 
            this.btnリファクタリングを行う_UnikktleGem.Location = new System.Drawing.Point(15, 43);
            this.btnリファクタリングを行う_UnikktleGem.Name = "btnリファクタリングを行う_UnikktleGem";
            this.btnリファクタリングを行う_UnikktleGem.Size = new System.Drawing.Size(189, 23);
            this.btnリファクタリングを行う_UnikktleGem.TabIndex = 3;
            this.btnリファクタリングを行う_UnikktleGem.Text = "リファクタリングを行う";
            this.btnリファクタリングを行う_UnikktleGem.UseVisualStyleBackColor = true;
            this.btnリファクタリングを行う_UnikktleGem.Click += new System.EventHandler(this.btnリファクタリングを行う_UnikktleGem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visual Studio 標準機能のリファクタリングが済んでいることを前提に、更なるリファクタリングを行う。";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnリファクタリングを行う_VisualStudio);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. VisualStudio標準";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(699, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Visual Studio 2019 から標準となったコードクリーンアップ機能を使用することで、ソリューション全体に対して基本的なリファクタリングを行うことができ" +
    "る。\r\n他のリファクタリングはこれが済んでいることを前提とし、Visual Studioで出来ることを別途実装することはしていない。\r\n\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnリファクタリングを行う_UnikktleGem);
            this.groupBox2.Location = new System.Drawing.Point(7, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 76);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. UnikktleGem独自";
            // 
            // FRefactoringList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRefactoringList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "リファクタリング";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnリファクタリングを行う_VisualStudio;
        private System.Windows.Forms.Button btnリファクタリングを行う_UnikktleGem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}