
namespace UnikktleGemConsole
{
    partial class FMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.btn解析実行 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnテストコード = new System.Windows.Forms.Button();
            this.listSolution = new System.Windows.Forms.ListBox();
            this.btnソリューション登録 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnソリューション編集 = new System.Windows.Forms.Button();
            this.txtSolutionFile = new System.Windows.Forms.TextBox();
            this.txtSolutionName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnリファクタリング = new System.Windows.Forms.Button();
            this.btn抽出 = new System.Windows.Forms.Button();
            this.dgv解析実行履歴 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョンToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv解析実行履歴)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn解析実行
            // 
            this.btn解析実行.Enabled = false;
            this.btn解析実行.Location = new System.Drawing.Point(14, 21);
            this.btn解析実行.Name = "btn解析実行";
            this.btn解析実行.Size = new System.Drawing.Size(105, 23);
            this.btn解析実行.TabIndex = 0;
            this.btn解析実行.Text = "解析実行";
            this.btn解析実行.UseVisualStyleBackColor = true;
            this.btn解析実行.Click += new System.EventHandler(this.btn解析実行_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ソリューションファイル";
            // 
            // btnテストコード
            // 
            this.btnテストコード.Enabled = false;
            this.btnテストコード.Location = new System.Drawing.Point(343, 20);
            this.btnテストコード.Name = "btnテストコード";
            this.btnテストコード.Size = new System.Drawing.Size(102, 23);
            this.btnテストコード.TabIndex = 8;
            this.btnテストコード.Text = "テストコード";
            this.btnテストコード.UseVisualStyleBackColor = true;
            this.btnテストコード.Click += new System.EventHandler(this.btnテストコード_Click);
            // 
            // listSolution
            // 
            this.listSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listSolution.FormattingEnabled = true;
            this.listSolution.ItemHeight = 12;
            this.listSolution.Location = new System.Drawing.Point(6, 53);
            this.listSolution.Name = "listSolution";
            this.listSolution.Size = new System.Drawing.Size(141, 352);
            this.listSolution.TabIndex = 10;
            this.listSolution.SelectedIndexChanged += new System.EventHandler(this.listSolution_SelectedIndexChanged);
            this.listSolution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listSolution_KeyDown);
            // 
            // btnソリューション登録
            // 
            this.btnソリューション登録.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnソリューション登録.Location = new System.Drawing.Point(6, 24);
            this.btnソリューション登録.Name = "btnソリューション登録";
            this.btnソリューション登録.Size = new System.Drawing.Size(125, 23);
            this.btnソリューション登録.TabIndex = 11;
            this.btnソリューション登録.Text = "ソリューション登録";
            this.btnソリューション登録.UseVisualStyleBackColor = true;
            this.btnソリューション登録.Click += new System.EventHandler(this.btnソリューション登録_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "ソリューション名";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnソリューション編集);
            this.groupBox1.Controls.Add(this.txtSolutionFile);
            this.groupBox1.Controls.Add(this.txtSolutionName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(167, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 69);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ソリューション設定";
            // 
            // btnソリューション編集
            // 
            this.btnソリューション編集.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnソリューション編集.Enabled = false;
            this.btnソリューション編集.Location = new System.Drawing.Point(766, 14);
            this.btnソリューション編集.Name = "btnソリューション編集";
            this.btnソリューション編集.Size = new System.Drawing.Size(86, 23);
            this.btnソリューション編集.TabIndex = 19;
            this.btnソリューション編集.Text = "編集";
            this.btnソリューション編集.UseVisualStyleBackColor = true;
            this.btnソリューション編集.Click += new System.EventHandler(this.btn編集_Click);
            // 
            // txtSolutionFile
            // 
            this.txtSolutionFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolutionFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtSolutionFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSolutionFile.Location = new System.Drawing.Point(149, 44);
            this.txtSolutionFile.Name = "txtSolutionFile";
            this.txtSolutionFile.ReadOnly = true;
            this.txtSolutionFile.Size = new System.Drawing.Size(703, 12);
            this.txtSolutionFile.TabIndex = 18;
            // 
            // txtSolutionName
            // 
            this.txtSolutionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolutionName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSolutionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSolutionName.Location = new System.Drawing.Point(149, 24);
            this.txtSolutionName.Name = "txtSolutionName";
            this.txtSolutionName.ReadOnly = true;
            this.txtSolutionName.Size = new System.Drawing.Size(594, 12);
            this.txtSolutionName.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnリファクタリング);
            this.groupBox2.Controls.Add(this.btn抽出);
            this.groupBox2.Controls.Add(this.btn解析実行);
            this.groupBox2.Controls.Add(this.dgv解析実行履歴);
            this.groupBox2.Controls.Add(this.btnテストコード);
            this.groupBox2.Location = new System.Drawing.Point(167, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 343);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "解析実行履歴";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnリファクタリング
            // 
            this.btnリファクタリング.Enabled = false;
            this.btnリファクタリング.Location = new System.Drawing.Point(234, 21);
            this.btnリファクタリング.Name = "btnリファクタリング";
            this.btnリファクタリング.Size = new System.Drawing.Size(103, 23);
            this.btnリファクタリング.TabIndex = 10;
            this.btnリファクタリング.Text = "リファクタリング";
            this.btnリファクタリング.UseVisualStyleBackColor = true;
            this.btnリファクタリング.Click += new System.EventHandler(this.btnリファクタリング_Click);
            // 
            // btn抽出
            // 
            this.btn抽出.Enabled = false;
            this.btn抽出.Location = new System.Drawing.Point(125, 21);
            this.btn抽出.Name = "btn抽出";
            this.btn抽出.Size = new System.Drawing.Size(103, 23);
            this.btn抽出.TabIndex = 9;
            this.btn抽出.Text = "解析結果抽出";
            this.btn抽出.UseVisualStyleBackColor = true;
            this.btn抽出.Click += new System.EventHandler(this.btn抽出_Click);
            // 
            // dgv解析実行履歴
            // 
            this.dgv解析実行履歴.AllowUserToAddRows = false;
            this.dgv解析実行履歴.AllowUserToDeleteRows = false;
            this.dgv解析実行履歴.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv解析実行履歴.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv解析実行履歴.Location = new System.Drawing.Point(14, 50);
            this.dgv解析実行履歴.Name = "dgv解析実行履歴";
            this.dgv解析実行履歴.RowHeadersVisible = false;
            this.dgv解析実行履歴.RowTemplate.Height = 21;
            this.dgv解析実行履歴.RowTemplate.ReadOnly = true;
            this.dgv解析実行履歴.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv解析実行履歴.Size = new System.Drawing.Size(831, 278);
            this.dgv解析実行履歴.TabIndex = 0;
            this.dgv解析実行履歴.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv解析履歴_CellContentClick);
            this.dgv解析実行履歴.SelectionChanged += new System.EventHandler(this.dgv解析実行履歴_SelectionChanged);
            this.dgv解析実行履歴.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv解析実行履歴_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnソリューション登録);
            this.groupBox3.Controls.Add(this.listSolution);
            this.groupBox3.Location = new System.Drawing.Point(8, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 418);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ソリューション一覧";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.閉じるToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル (&F)";
            // 
            // 閉じるToolStripMenuItem
            // 
            this.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            this.閉じるToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.閉じるToolStripMenuItem.Text = "終了 (&C)";
            this.閉じるToolStripMenuItem.Click += new System.EventHandler(this.閉じるToolStripMenuItem_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョンToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ (&H)";
            // 
            // バージョンToolStripMenuItem
            // 
            this.バージョンToolStripMenuItem.Name = "バージョンToolStripMenuItem";
            this.バージョンToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.バージョンToolStripMenuItem.Text = "バージョン (&V)";
            this.バージョンToolStripMenuItem.Click += new System.EventHandler(this.バージョンToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(864, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv解析実行履歴)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn解析実行;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnテストコード;
        private System.Windows.Forms.ListBox listSolution;
        private System.Windows.Forms.Button btnソリューション登録;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSolutionFile;
        private System.Windows.Forms.TextBox txtSolutionName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnソリューション編集;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv解析実行履歴;
        private System.Windows.Forms.Button btnリファクタリング;
        private System.Windows.Forms.Button btn抽出;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 閉じるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョンToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

