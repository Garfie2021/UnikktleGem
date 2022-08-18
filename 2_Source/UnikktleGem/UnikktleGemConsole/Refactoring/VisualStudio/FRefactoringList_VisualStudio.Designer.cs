
namespace UnikktleGemConsole
{
    partial class FRefactoringList_VisualStudio
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
            this.btn使われていないメソッド = new System.Windows.Forms.Button();
            this.btnUsingNamespace並び替え = new System.Windows.Forms.Button();
            this.btn使われていないusingnamespaceを削除 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnドキュメントフォーマット = new System.Windows.Forms.Button();
            this.btn使われていない変数を削除 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnオブジェクトコレクションの初期化の基本設定を適用 = new System.Windows.Forms.Button();
            this.btn単一行のコントロールステートメントに対する波かっこの追加削除 = new System.Windows.Forms.Button();
            this.btn言語フレームワークの型の基本設定を適用 = new System.Windows.Forms.Button();
            this.btnインライン変数優先 = new System.Windows.Forms.Button();
            this.btn不要なキャストを削除 = new System.Windows.Forms.Button();
            this.btn型が明確な変数はvarを使う = new System.Windows.Forms.Button();
            this.btnthis修飾子を加える = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnprivateフィールドを可能な限り読み取り専用にする = new System.Windows.Forms.Button();
            this.btnアクセシビリティ修飾子をソート = new System.Windows.Forms.Button();
            this.btnアクセシビリティ修飾子を追加 = new System.Windows.Forms.Button();
            this.btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn使われていないメソッド
            // 
            this.btn使われていないメソッド.Location = new System.Drawing.Point(13, 19);
            this.btn使われていないメソッド.Name = "btn使われていないメソッド";
            this.btn使われていないメソッド.Size = new System.Drawing.Size(253, 23);
            this.btn使われていないメソッド.TabIndex = 0;
            this.btn使われていないメソッド.Text = "使われていないメソッドを削除";
            this.btn使われていないメソッド.UseVisualStyleBackColor = true;
            this.btn使われていないメソッド.Click += new System.EventHandler(this.btn使われていないメソッド_Click);
            // 
            // btnUsingNamespace並び替え
            // 
            this.btnUsingNamespace並び替え.Location = new System.Drawing.Point(283, 18);
            this.btnUsingNamespace並び替え.Name = "btnUsingNamespace並び替え";
            this.btnUsingNamespace並び替え.Size = new System.Drawing.Size(253, 23);
            this.btnUsingNamespace並び替え.TabIndex = 1;
            this.btnUsingNamespace並び替え.Text = "using namespace 並び替え";
            this.btnUsingNamespace並び替え.UseVisualStyleBackColor = true;
            this.btnUsingNamespace並び替え.Click += new System.EventHandler(this.btnUsingNamespace並び替え_Click);
            // 
            // btn使われていないusingnamespaceを削除
            // 
            this.btn使われていないusingnamespaceを削除.Location = new System.Drawing.Point(12, 18);
            this.btn使われていないusingnamespaceを削除.Name = "btn使われていないusingnamespaceを削除";
            this.btn使われていないusingnamespaceを削除.Size = new System.Drawing.Size(239, 23);
            this.btn使われていないusingnamespaceを削除.TabIndex = 2;
            this.btn使われていないusingnamespaceを削除.Text = "使われていない using namespace を削除";
            this.btn使われていないusingnamespaceを削除.UseVisualStyleBackColor = true;
            this.btn使われていないusingnamespaceを削除.Click += new System.EventHandler(this.btn使われていないusingnamespaceを削除_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn使われていないusingnamespaceを削除);
            this.groupBox1.Controls.Add(this.btnUsingNamespace並び替え);
            this.groupBox1.Location = new System.Drawing.Point(7, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "using namespace";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btn使われていないメソッド);
            this.groupBox2.Location = new System.Drawing.Point(7, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 75);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "メソッド";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "メソッド 並び替え";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnドキュメントフォーマット);
            this.groupBox3.Location = new System.Drawing.Point(6, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 55);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "体裁";
            // 
            // btnドキュメントフォーマット
            // 
            this.btnドキュメントフォーマット.Location = new System.Drawing.Point(13, 20);
            this.btnドキュメントフォーマット.Name = "btnドキュメントフォーマット";
            this.btnドキュメントフォーマット.Size = new System.Drawing.Size(190, 23);
            this.btnドキュメントフォーマット.TabIndex = 1;
            this.btnドキュメントフォーマット.Text = "ドキュメントフォーマット";
            this.btnドキュメントフォーマット.UseVisualStyleBackColor = true;
            this.btnドキュメントフォーマット.Click += new System.EventHandler(this.btnドキュメントフォーマット実行_Click);
            // 
            // btn使われていない変数を削除
            // 
            this.btn使われていない変数を削除.Location = new System.Drawing.Point(6, 18);
            this.btn使われていない変数を削除.Name = "btn使われていない変数を削除";
            this.btn使われていない変数を削除.Size = new System.Drawing.Size(329, 23);
            this.btn使われていない変数を削除.TabIndex = 2;
            this.btn使われていない変数を削除.Text = "使われていない変数を削除";
            this.btn使われていない変数を削除.UseVisualStyleBackColor = true;
            this.btn使われていない変数を削除.Click += new System.EventHandler(this.btn使われていない変数を削除_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnオブジェクトコレクションの初期化の基本設定を適用);
            this.groupBox4.Controls.Add(this.btn単一行のコントロールステートメントに対する波かっこの追加削除);
            this.groupBox4.Controls.Add(this.btn言語フレームワークの型の基本設定を適用);
            this.groupBox4.Controls.Add(this.btnインライン変数優先);
            this.groupBox4.Controls.Add(this.btn不要なキャストを削除);
            this.groupBox4.Controls.Add(this.btn型が明確な変数はvarを使う);
            this.groupBox4.Controls.Add(this.btnthis修飾子を加える);
            this.groupBox4.Controls.Add(this.btn使われていない変数を削除);
            this.groupBox4.Location = new System.Drawing.Point(9, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(703, 180);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "メソッド内";
            // 
            // btnオブジェクトコレクションの初期化の基本設定を適用
            // 
            this.btnオブジェクトコレクションの初期化の基本設定を適用.Location = new System.Drawing.Point(345, 131);
            this.btnオブジェクトコレクションの初期化の基本設定を適用.Name = "btnオブジェクトコレクションの初期化の基本設定を適用";
            this.btnオブジェクトコレクションの初期化の基本設定を適用.Size = new System.Drawing.Size(304, 23);
            this.btnオブジェクトコレクションの初期化の基本設定を適用.TabIndex = 9;
            this.btnオブジェクトコレクションの初期化の基本設定を適用.Text = "オブジェクト/コレクションの初期化の基本設定を適用";
            this.btnオブジェクトコレクションの初期化の基本設定を適用.UseVisualStyleBackColor = true;
            this.btnオブジェクトコレクションの初期化の基本設定を適用.Click += new System.EventHandler(this.btnオブジェクトコレクションの初期化の基本設定を適用_Click);
            // 
            // btn単一行のコントロールステートメントに対する波かっこの追加削除
            // 
            this.btn単一行のコントロールステートメントに対する波かっこの追加削除.Location = new System.Drawing.Point(6, 131);
            this.btn単一行のコントロールステートメントに対する波かっこの追加削除.Name = "btn単一行のコントロールステートメントに対する波かっこの追加削除";
            this.btn単一行のコントロールステートメントに対する波かっこの追加削除.Size = new System.Drawing.Size(329, 23);
            this.btn単一行のコントロールステートメントに対する波かっこの追加削除.TabIndex = 8;
            this.btn単一行のコントロールステートメントに対する波かっこの追加削除.Text = "単一行のコントロールステートメントに対する波かっこの追加/削除";
            this.btn単一行のコントロールステートメントに対する波かっこの追加削除.UseVisualStyleBackColor = true;
            this.btn単一行のコントロールステートメントに対する波かっこの追加削除.Click += new System.EventHandler(this.btn単一行のコントロールステートメントに対する波かっこの追加削除_Click);
            // 
            // btn言語フレームワークの型の基本設定を適用
            // 
            this.btn言語フレームワークの型の基本設定を適用.Location = new System.Drawing.Point(345, 96);
            this.btn言語フレームワークの型の基本設定を適用.Name = "btn言語フレームワークの型の基本設定を適用";
            this.btn言語フレームワークの型の基本設定を適用.Size = new System.Drawing.Size(304, 23);
            this.btn言語フレームワークの型の基本設定を適用.TabIndex = 7;
            this.btn言語フレームワークの型の基本設定を適用.Text = "言語/フレームワークの型の基本設定を適用";
            this.btn言語フレームワークの型の基本設定を適用.UseVisualStyleBackColor = true;
            this.btn言語フレームワークの型の基本設定を適用.Click += new System.EventHandler(this.btn言語フレームワークの型の基本設定を適用_Click);
            // 
            // btnインライン変数優先
            // 
            this.btnインライン変数優先.Location = new System.Drawing.Point(6, 96);
            this.btnインライン変数優先.Name = "btnインライン変数優先";
            this.btnインライン変数優先.Size = new System.Drawing.Size(329, 23);
            this.btnインライン変数優先.TabIndex = 6;
            this.btnインライン変数優先.Text = "インライン変数優先";
            this.btnインライン変数優先.UseVisualStyleBackColor = true;
            this.btnインライン変数優先.Click += new System.EventHandler(this.btnインライン変数優先_Click);
            // 
            // btn不要なキャストを削除
            // 
            this.btn不要なキャストを削除.Location = new System.Drawing.Point(6, 58);
            this.btn不要なキャストを削除.Name = "btn不要なキャストを削除";
            this.btn不要なキャストを削除.Size = new System.Drawing.Size(329, 23);
            this.btn不要なキャストを削除.TabIndex = 5;
            this.btn不要なキャストを削除.Text = "不要なキャストを削除";
            this.btn不要なキャストを削除.UseVisualStyleBackColor = true;
            this.btn不要なキャストを削除.Click += new System.EventHandler(this.btn不要なキャストを削除_Click);
            // 
            // btn型が明確な変数はvarを使う
            // 
            this.btn型が明確な変数はvarを使う.Location = new System.Drawing.Point(345, 58);
            this.btn型が明確な変数はvarを使う.Name = "btn型が明確な変数はvarを使う";
            this.btn型が明確な変数はvarを使う.Size = new System.Drawing.Size(304, 23);
            this.btn型が明確な変数はvarを使う.TabIndex = 4;
            this.btn型が明確な変数はvarを使う.Text = "型が明確な変数はvarを使う";
            this.btn型が明確な変数はvarを使う.UseVisualStyleBackColor = true;
            this.btn型が明確な変数はvarを使う.Click += new System.EventHandler(this.btn型が明確な変数はvarを使う_Click);
            // 
            // btnthis修飾子を加える
            // 
            this.btnthis修飾子を加える.Location = new System.Drawing.Point(345, 18);
            this.btnthis修飾子を加える.Name = "btnthis修飾子を加える";
            this.btnthis修飾子を加える.Size = new System.Drawing.Size(304, 23);
            this.btnthis修飾子を加える.TabIndex = 3;
            this.btnthis修飾子を加える.Text = "this修飾子を加える";
            this.btnthis修飾子を加える.UseVisualStyleBackColor = true;
            this.btnthis修飾子を加える.Click += new System.EventHandler(this.btnthis修飾子を加える_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnprivateフィールドを可能な限り読み取り専用にする);
            this.groupBox5.Controls.Add(this.btnアクセシビリティ修飾子をソート);
            this.groupBox5.Controls.Add(this.btnアクセシビリティ修飾子を追加);
            this.groupBox5.Location = new System.Drawing.Point(6, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(588, 101);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Class";
            // 
            // btnprivateフィールドを可能な限り読み取り専用にする
            // 
            this.btnprivateフィールドを可能な限り読み取り専用にする.Location = new System.Drawing.Point(13, 55);
            this.btnprivateフィールドを可能な限り読み取り専用にする.Name = "btnprivateフィールドを可能な限り読み取り専用にする";
            this.btnprivateフィールドを可能な限り読み取り専用にする.Size = new System.Drawing.Size(253, 23);
            this.btnprivateフィールドを可能な限り読み取り専用にする.TabIndex = 2;
            this.btnprivateフィールドを可能な限り読み取り専用にする.Text = "privateフィールドを可能な限り読み取り専用にする";
            this.btnprivateフィールドを可能な限り読み取り専用にする.UseVisualStyleBackColor = true;
            this.btnprivateフィールドを可能な限り読み取り専用にする.Click += new System.EventHandler(this.btnprivateフィールドを可能な限り読み取り専用にする_Click);
            // 
            // btnアクセシビリティ修飾子をソート
            // 
            this.btnアクセシビリティ修飾子をソート.Location = new System.Drawing.Point(284, 19);
            this.btnアクセシビリティ修飾子をソート.Name = "btnアクセシビリティ修飾子をソート";
            this.btnアクセシビリティ修飾子をソート.Size = new System.Drawing.Size(253, 23);
            this.btnアクセシビリティ修飾子をソート.TabIndex = 1;
            this.btnアクセシビリティ修飾子をソート.Text = "アクセシビリティ修飾子をソート";
            this.btnアクセシビリティ修飾子をソート.UseVisualStyleBackColor = true;
            this.btnアクセシビリティ修飾子をソート.Click += new System.EventHandler(this.btnアクセシビリティ修飾子をソート_Click);
            // 
            // btnアクセシビリティ修飾子を追加
            // 
            this.btnアクセシビリティ修飾子を追加.Location = new System.Drawing.Point(13, 19);
            this.btnアクセシビリティ修飾子を追加.Name = "btnアクセシビリティ修飾子を追加";
            this.btnアクセシビリティ修飾子を追加.Size = new System.Drawing.Size(253, 23);
            this.btnアクセシビリティ修飾子を追加.TabIndex = 0;
            this.btnアクセシビリティ修飾子を追加.Text = "アクセシビリティ修飾子を追加";
            this.btnアクセシビリティ修飾子を追加.UseVisualStyleBackColor = true;
            this.btnアクセシビリティ修飾子を追加.Click += new System.EventHandler(this.btnアクセシビリティ修飾子を追加_Click);
            // 
            // btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する
            // 
            this.btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する.Location = new System.Drawing.Point(6, 12);
            this.btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する.Name = "btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する";
            this.btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する.Size = new System.Drawing.Size(473, 23);
            this.btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する.TabIndex = 8;
            this.btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する.Text = "UnikktleGem推奨設定の .editorconfigファイルをソリューションフォルダに配置する";
            this.btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する.UseVisualStyleBackColor = true;
            this.btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する.Click += new System.EventHandler(this.btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Location = new System.Drawing.Point(6, 55);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(745, 550);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "UnikktleGem推奨の設定内容";
            // 
            // FRefactoringList_VisualStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 634);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する);
            this.Name = "FRefactoringList_VisualStudio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "リファクタリング";
            this.Load += new System.EventHandler(this.FRefactoringList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn使われていないメソッド;
        private System.Windows.Forms.Button btnUsingNamespace並び替え;
        private System.Windows.Forms.Button btn使われていないusingnamespaceを削除;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnドキュメントフォーマット;
        private System.Windows.Forms.Button btn使われていない変数を削除;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnthis修飾子を加える;
        private System.Windows.Forms.Button btn型が明確な変数はvarを使う;
        private System.Windows.Forms.Button btn不要なキャストを削除;
        private System.Windows.Forms.Button btnインライン変数優先;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnアクセシビリティ修飾子を追加;
        private System.Windows.Forms.Button btnアクセシビリティ修飾子をソート;
        private System.Windows.Forms.Button btnprivateフィールドを可能な限り読み取り専用にする;
        private System.Windows.Forms.Button btn言語フレームワークの型の基本設定を適用;
        private System.Windows.Forms.Button btn単一行のコントロールステートメントに対する波かっこの追加削除;
        private System.Windows.Forms.Button btnオブジェクトコレクションの初期化の基本設定を適用;
        private System.Windows.Forms.Button btnUnikktleGem推奨設定のeditorconfigファイルをソリューションフォルダに配置する;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}