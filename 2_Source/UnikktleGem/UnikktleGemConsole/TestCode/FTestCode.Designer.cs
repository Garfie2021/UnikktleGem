
namespace UnikktleGemConsole
{
    partial class FTestCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTestCode));
            this.btnテストコード生成 = new System.Windows.Forms.Button();
            this.txtテストコード出力先フォルダ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnテストコード出力先フォルダ選択 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnテストコード生成
            // 
            this.btnテストコード生成.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnテストコード生成.Location = new System.Drawing.Point(6, 471);
            this.btnテストコード生成.Name = "btnテストコード生成";
            this.btnテストコード生成.Size = new System.Drawing.Size(116, 23);
            this.btnテストコード生成.TabIndex = 0;
            this.btnテストコード生成.Text = "テストコード生成";
            this.btnテストコード生成.UseVisualStyleBackColor = true;
            this.btnテストコード生成.Click += new System.EventHandler(this.btnテストコード生成_Click);
            // 
            // txtテストコード出力先フォルダ
            // 
            this.txtテストコード出力先フォルダ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtテストコード出力先フォルダ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtテストコード出力先フォルダ.Location = new System.Drawing.Point(142, 18);
            this.txtテストコード出力先フォルダ.Name = "txtテストコード出力先フォルダ";
            this.txtテストコード出力先フォルダ.ReadOnly = true;
            this.txtテストコード出力先フォルダ.Size = new System.Drawing.Size(390, 19);
            this.txtテストコード出力先フォルダ.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "テストコード出力先フォルダ";
            // 
            // btnテストコード出力先フォルダ選択
            // 
            this.btnテストコード出力先フォルダ選択.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnテストコード出力先フォルダ選択.Location = new System.Drawing.Point(538, 16);
            this.btnテストコード出力先フォルダ選択.Name = "btnテストコード出力先フォルダ選択";
            this.btnテストコード出力先フォルダ選択.Size = new System.Drawing.Size(36, 23);
            this.btnテストコード出力先フォルダ選択.TabIndex = 22;
            this.btnテストコード出力先フォルダ選択.UseVisualStyleBackColor = true;
            this.btnテストコード出力先フォルダ選択.Click += new System.EventHandler(this.btnテストコード出力先フォルダ選択_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(568, 168);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(6, 257);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(568, 71);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "    [TestClass()]\r\n    public class Form1Tests\r\n    {\r\n    }\r\n";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(6, 355);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(568, 78);
            this.textBox3.TabIndex = 25;
            this.textBox3.Text = "        [TestMethod()]\r\n        public void Form1Test()\r\n        {\r\n        }";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "namespace単位";
            // 
            // FTestCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnテストコード出力先フォルダ選択);
            this.Controls.Add(this.txtテストコード出力先フォルダ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnテストコード生成);
            this.Name = "FTestCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTestCode";
            this.Load += new System.EventHandler(this.FTestCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnテストコード生成;
        private System.Windows.Forms.TextBox txtテストコード出力先フォルダ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnテストコード出力先フォルダ選択;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}