
namespace UnikktleGemConsole
{
    partial class FViewAnalyze
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
            this.btn更新 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn全て選択 = new System.Windows.Forms.Button();
            this.txt表示テンプレート名 = new System.Windows.Forms.TextBox();
            this.btn表示条件を保存 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkソースファイル = new System.Windows.Forms.CheckBox();
            this.chkリソースファイル = new System.Windows.Forms.CheckBox();
            this.grpソースファイル = new System.Windows.Forms.GroupBox();
            this.chkNamespace = new System.Windows.Forms.CheckBox();
            this.grpNamespace = new System.Windows.Forms.GroupBox();
            this.chkClass = new System.Windows.Forms.CheckBox();
            this.chkNamespaceInner = new System.Windows.Forms.CheckBox();
            this.chkDelegate = new System.Windows.Forms.CheckBox();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.chkMethod = new System.Windows.Forms.CheckBox();
            this.chk継承有り = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkFormOnly = new System.Windows.Forms.CheckBox();
            this.grpMethod = new System.Windows.Forms.GroupBox();
            this.chkLiteral = new System.Windows.Forms.CheckBox();
            this.grpLiteral = new System.Windows.Forms.GroupBox();
            this.chkLiteralOther = new System.Windows.Forms.CheckBox();
            this.chkLiteralBoolean = new System.Windows.Forms.CheckBox();
            this.chkLiteralNumeric = new System.Windows.Forms.CheckBox();
            this.chkLiteralString = new System.Windows.Forms.CheckBox();
            this.chkResourcesを呼び出し元のメソッドに纏める = new System.Windows.Forms.CheckBox();
            this.chkイベントハンドラのみ = new System.Windows.Forms.CheckBox();
            this.chkResources = new System.Windows.Forms.CheckBox();
            this.chkThrow = new System.Windows.Forms.CheckBox();
            this.chkCallMethod = new System.Windows.Forms.CheckBox();
            this.chkMethodParameter = new System.Windows.Forms.CheckBox();
            this.chk継承無し = new System.Windows.Forms.CheckBox();
            this.chkEnum = new System.Windows.Forms.CheckBox();
            this.chkStruct = new System.Windows.Forms.CheckBox();
            this.chkInterface = new System.Windows.Forms.CheckBox();
            this.cmb表示テンプレート = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn表示テンプレート削除 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.grpソースファイル.SuspendLayout();
            this.grpNamespace.SuspendLayout();
            this.grpClass.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grpMethod.SuspendLayout();
            this.grpLiteral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn更新
            // 
            this.btn更新.Location = new System.Drawing.Point(12, 438);
            this.btn更新.Name = "btn更新";
            this.btn更新.Size = new System.Drawing.Size(132, 26);
            this.btn更新.TabIndex = 2;
            this.btn更新.Text = "表示条件で表示";
            this.btn更新.UseVisualStyleBackColor = true;
            this.btn更新.Click += new System.EventHandler(this.btn表示条件で表示_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn全て選択);
            this.groupBox1.Controls.Add(this.txt表示テンプレート名);
            this.groupBox1.Controls.Add(this.btn表示条件を保存);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 379);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "表示条件";
            // 
            // btn全て選択
            // 
            this.btn全て選択.Location = new System.Drawing.Point(865, 15);
            this.btn全て選択.Name = "btn全て選択";
            this.btn全て選択.Size = new System.Drawing.Size(60, 26);
            this.btn全て選択.TabIndex = 22;
            this.btn全て選択.Text = "全て選択";
            this.btn全て選択.UseVisualStyleBackColor = true;
            this.btn全て選択.Click += new System.EventHandler(this.btn全て選択_Click);
            // 
            // txt表示テンプレート名
            // 
            this.txt表示テンプレート名.Location = new System.Drawing.Point(103, 20);
            this.txt表示テンプレート名.Name = "txt表示テンプレート名";
            this.txt表示テンプレート名.Size = new System.Drawing.Size(407, 19);
            this.txt表示テンプレート名.TabIndex = 21;
            // 
            // btn表示条件を保存
            // 
            this.btn表示条件を保存.Location = new System.Drawing.Point(516, 15);
            this.btn表示条件を保存.Name = "btn表示条件を保存";
            this.btn表示条件を保存.Size = new System.Drawing.Size(110, 26);
            this.btn表示条件を保存.TabIndex = 20;
            this.btn表示条件を保存.Text = "表示条件を保存";
            this.btn表示条件を保存.UseVisualStyleBackColor = true;
            this.btn表示条件を保存.Click += new System.EventHandler(this.btn表示条件を保存_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "表示テンプレート：";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.chkソースファイル);
            this.groupBox7.Controls.Add(this.chkリソースファイル);
            this.groupBox7.Controls.Add(this.grpソースファイル);
            this.groupBox7.Location = new System.Drawing.Point(6, 48);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(919, 327);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "プロジェクト";
            // 
            // chkソースファイル
            // 
            this.chkソースファイル.AutoSize = true;
            this.chkソースファイル.Checked = true;
            this.chkソースファイル.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkソースファイル.Location = new System.Drawing.Point(13, 16);
            this.chkソースファイル.Name = "chkソースファイル";
            this.chkソースファイル.Size = new System.Drawing.Size(86, 16);
            this.chkソースファイル.TabIndex = 18;
            this.chkソースファイル.Text = "ソースファイル";
            this.chkソースファイル.UseVisualStyleBackColor = true;
            this.chkソースファイル.CheckedChanged += new System.EventHandler(this.chkソースファイル_CheckedChanged);
            // 
            // chkリソースファイル
            // 
            this.chkリソースファイル.AutoSize = true;
            this.chkリソースファイル.Checked = true;
            this.chkリソースファイル.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkリソースファイル.Location = new System.Drawing.Point(7, 313);
            this.chkリソースファイル.Name = "chkリソースファイル";
            this.chkリソースファイル.Size = new System.Drawing.Size(93, 16);
            this.chkリソースファイル.TabIndex = 21;
            this.chkリソースファイル.Text = "リソースファイル";
            this.chkリソースファイル.UseVisualStyleBackColor = true;
            // 
            // grpソースファイル
            // 
            this.grpソースファイル.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpソースファイル.Controls.Add(this.chkNamespace);
            this.grpソースファイル.Controls.Add(this.grpNamespace);
            this.grpソースファイル.Location = new System.Drawing.Point(6, 18);
            this.grpソースファイル.Name = "grpソースファイル";
            this.grpソースファイル.Size = new System.Drawing.Size(907, 289);
            this.grpソースファイル.TabIndex = 18;
            this.grpソースファイル.TabStop = false;
            this.grpソースファイル.Text = "ソースファイル";
            // 
            // chkNamespace
            // 
            this.chkNamespace.AutoSize = true;
            this.chkNamespace.Checked = true;
            this.chkNamespace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNamespace.Location = new System.Drawing.Point(14, 17);
            this.chkNamespace.Name = "chkNamespace";
            this.chkNamespace.Size = new System.Drawing.Size(83, 16);
            this.chkNamespace.TabIndex = 19;
            this.chkNamespace.Text = "Namespace";
            this.chkNamespace.UseVisualStyleBackColor = true;
            this.chkNamespace.CheckedChanged += new System.EventHandler(this.chkNamespace_CheckedChanged);
            // 
            // grpNamespace
            // 
            this.grpNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNamespace.Controls.Add(this.chkClass);
            this.grpNamespace.Controls.Add(this.chkNamespaceInner);
            this.grpNamespace.Controls.Add(this.chkDelegate);
            this.grpNamespace.Controls.Add(this.grpClass);
            this.grpNamespace.Controls.Add(this.chkEnum);
            this.grpNamespace.Controls.Add(this.chkStruct);
            this.grpNamespace.Controls.Add(this.chkInterface);
            this.grpNamespace.Location = new System.Drawing.Point(6, 18);
            this.grpNamespace.Name = "grpNamespace";
            this.grpNamespace.Size = new System.Drawing.Size(895, 265);
            this.grpNamespace.TabIndex = 14;
            this.grpNamespace.TabStop = false;
            this.grpNamespace.Text = "Namespace";
            // 
            // chkClass
            // 
            this.chkClass.AutoSize = true;
            this.chkClass.Checked = true;
            this.chkClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClass.Location = new System.Drawing.Point(21, 39);
            this.chkClass.Name = "chkClass";
            this.chkClass.Size = new System.Drawing.Size(53, 16);
            this.chkClass.TabIndex = 11;
            this.chkClass.Text = "Class";
            this.chkClass.UseVisualStyleBackColor = true;
            this.chkClass.CheckedChanged += new System.EventHandler(this.chkClass_CheckedChanged);
            // 
            // chkNamespaceInner
            // 
            this.chkNamespaceInner.AutoSize = true;
            this.chkNamespaceInner.Location = new System.Drawing.Point(311, 18);
            this.chkNamespaceInner.Name = "chkNamespaceInner";
            this.chkNamespaceInner.Size = new System.Drawing.Size(83, 16);
            this.chkNamespaceInner.TabIndex = 16;
            this.chkNamespaceInner.Text = "Namespace";
            this.chkNamespaceInner.UseVisualStyleBackColor = true;
            // 
            // chkDelegate
            // 
            this.chkDelegate.AutoSize = true;
            this.chkDelegate.Location = new System.Drawing.Point(230, 19);
            this.chkDelegate.Name = "chkDelegate";
            this.chkDelegate.Size = new System.Drawing.Size(69, 16);
            this.chkDelegate.TabIndex = 15;
            this.chkDelegate.Text = "Delegate";
            this.chkDelegate.UseVisualStyleBackColor = true;
            // 
            // grpClass
            // 
            this.grpClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClass.Controls.Add(this.chkMethod);
            this.grpClass.Controls.Add(this.chk継承有り);
            this.grpClass.Controls.Add(this.groupBox6);
            this.grpClass.Controls.Add(this.grpMethod);
            this.grpClass.Controls.Add(this.chk継承無し);
            this.grpClass.Location = new System.Drawing.Point(14, 39);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(875, 220);
            this.grpClass.TabIndex = 12;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Class";
            // 
            // chkMethod
            // 
            this.chkMethod.AutoSize = true;
            this.chkMethod.Checked = true;
            this.chkMethod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMethod.Location = new System.Drawing.Point(15, 61);
            this.chkMethod.Name = "chkMethod";
            this.chkMethod.Size = new System.Drawing.Size(61, 16);
            this.chkMethod.TabIndex = 20;
            this.chkMethod.Text = "Method";
            this.chkMethod.UseVisualStyleBackColor = true;
            this.chkMethod.CheckedChanged += new System.EventHandler(this.chkMethod_CheckedChanged);
            // 
            // chk継承有り
            // 
            this.chk継承有り.AutoSize = true;
            this.chk継承有り.Location = new System.Drawing.Point(97, 17);
            this.chk継承有り.Name = "chk継承有り";
            this.chk継承有り.Size = new System.Drawing.Size(68, 16);
            this.chk継承有り.TabIndex = 14;
            this.chk継承有り.Text = "継承有り";
            this.chk継承有り.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkFormOnly);
            this.groupBox6.Location = new System.Drawing.Point(91, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(98, 40);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "継承有り";
            // 
            // chkFormOnly
            // 
            this.chkFormOnly.AutoSize = true;
            this.chkFormOnly.Checked = true;
            this.chkFormOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFormOnly.Location = new System.Drawing.Point(11, 17);
            this.chkFormOnly.Name = "chkFormOnly";
            this.chkFormOnly.Size = new System.Drawing.Size(71, 16);
            this.chkFormOnly.TabIndex = 5;
            this.chkFormOnly.Text = "Formのみ";
            this.chkFormOnly.UseVisualStyleBackColor = true;
            // 
            // grpMethod
            // 
            this.grpMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMethod.Controls.Add(this.chkLiteral);
            this.grpMethod.Controls.Add(this.grpLiteral);
            this.grpMethod.Controls.Add(this.chkResourcesを呼び出し元のメソッドに纏める);
            this.grpMethod.Controls.Add(this.chkイベントハンドラのみ);
            this.grpMethod.Controls.Add(this.chkResources);
            this.grpMethod.Controls.Add(this.chkThrow);
            this.grpMethod.Controls.Add(this.chkCallMethod);
            this.grpMethod.Controls.Add(this.chkMethodParameter);
            this.grpMethod.Location = new System.Drawing.Point(7, 64);
            this.grpMethod.Name = "grpMethod";
            this.grpMethod.Size = new System.Drawing.Size(862, 150);
            this.grpMethod.TabIndex = 13;
            this.grpMethod.TabStop = false;
            this.grpMethod.Text = "Method";
            // 
            // chkLiteral
            // 
            this.chkLiteral.AutoSize = true;
            this.chkLiteral.Checked = true;
            this.chkLiteral.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLiteral.Location = new System.Drawing.Point(19, 43);
            this.chkLiteral.Name = "chkLiteral";
            this.chkLiteral.Size = new System.Drawing.Size(56, 16);
            this.chkLiteral.TabIndex = 19;
            this.chkLiteral.Text = "Literal";
            this.chkLiteral.UseVisualStyleBackColor = true;
            this.chkLiteral.CheckedChanged += new System.EventHandler(this.chkLiteral_CheckedChanged);
            // 
            // grpLiteral
            // 
            this.grpLiteral.Controls.Add(this.chkLiteralOther);
            this.grpLiteral.Controls.Add(this.chkLiteralBoolean);
            this.grpLiteral.Controls.Add(this.chkLiteralNumeric);
            this.grpLiteral.Controls.Add(this.chkLiteralString);
            this.grpLiteral.Location = new System.Drawing.Point(13, 43);
            this.grpLiteral.Name = "grpLiteral";
            this.grpLiteral.Size = new System.Drawing.Size(267, 41);
            this.grpLiteral.TabIndex = 16;
            this.grpLiteral.TabStop = false;
            this.grpLiteral.Text = "Literal";
            // 
            // chkLiteralOther
            // 
            this.chkLiteralOther.AutoSize = true;
            this.chkLiteralOther.Checked = true;
            this.chkLiteralOther.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLiteralOther.Location = new System.Drawing.Point(205, 17);
            this.chkLiteralOther.Name = "chkLiteralOther";
            this.chkLiteralOther.Size = new System.Drawing.Size(52, 16);
            this.chkLiteralOther.TabIndex = 18;
            this.chkLiteralOther.Text = "Other";
            this.chkLiteralOther.UseVisualStyleBackColor = true;
            // 
            // chkLiteralBoolean
            // 
            this.chkLiteralBoolean.AutoSize = true;
            this.chkLiteralBoolean.Checked = true;
            this.chkLiteralBoolean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLiteralBoolean.Location = new System.Drawing.Point(138, 17);
            this.chkLiteralBoolean.Name = "chkLiteralBoolean";
            this.chkLiteralBoolean.Size = new System.Drawing.Size(65, 16);
            this.chkLiteralBoolean.TabIndex = 17;
            this.chkLiteralBoolean.Text = "Boolean";
            this.chkLiteralBoolean.UseVisualStyleBackColor = true;
            // 
            // chkLiteralNumeric
            // 
            this.chkLiteralNumeric.AutoSize = true;
            this.chkLiteralNumeric.Checked = true;
            this.chkLiteralNumeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLiteralNumeric.Location = new System.Drawing.Point(68, 17);
            this.chkLiteralNumeric.Name = "chkLiteralNumeric";
            this.chkLiteralNumeric.Size = new System.Drawing.Size(66, 16);
            this.chkLiteralNumeric.TabIndex = 16;
            this.chkLiteralNumeric.Text = "Numeric";
            this.chkLiteralNumeric.UseVisualStyleBackColor = true;
            // 
            // chkLiteralString
            // 
            this.chkLiteralString.AutoSize = true;
            this.chkLiteralString.Checked = true;
            this.chkLiteralString.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLiteralString.Location = new System.Drawing.Point(10, 17);
            this.chkLiteralString.Name = "chkLiteralString";
            this.chkLiteralString.Size = new System.Drawing.Size(54, 16);
            this.chkLiteralString.TabIndex = 15;
            this.chkLiteralString.Text = "String";
            this.chkLiteralString.UseVisualStyleBackColor = true;
            // 
            // chkResourcesを呼び出し元のメソッドに纏める
            // 
            this.chkResourcesを呼び出し元のメソッドに纏める.AutoSize = true;
            this.chkResourcesを呼び出し元のメソッドに纏める.Checked = true;
            this.chkResourcesを呼び出し元のメソッドに纏める.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResourcesを呼び出し元のメソッドに纏める.Location = new System.Drawing.Point(440, 51);
            this.chkResourcesを呼び出し元のメソッドに纏める.Name = "chkResourcesを呼び出し元のメソッドに纏める";
            this.chkResourcesを呼び出し元のメソッドに纏める.Size = new System.Drawing.Size(341, 16);
            this.chkResourcesを呼び出し元のメソッドに纏める.TabIndex = 6;
            this.chkResourcesを呼び出し元のメソッドに纏める.Text = "呼び出し先で使用するResourcesを、呼び出し元のメソッドに纏める";
            this.chkResourcesを呼び出し元のメソッドに纏める.UseVisualStyleBackColor = true;
            // 
            // chkイベントハンドラのみ
            // 
            this.chkイベントハンドラのみ.AutoSize = true;
            this.chkイベントハンドラのみ.Checked = true;
            this.chkイベントハンドラのみ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkイベントハンドラのみ.Location = new System.Drawing.Point(293, 51);
            this.chkイベントハンドラのみ.Name = "chkイベントハンドラのみ";
            this.chkイベントハンドラのみ.Size = new System.Drawing.Size(141, 16);
            this.chkイベントハンドラのみ.TabIndex = 5;
            this.chkイベントハンドラのみ.Text = "イベントハンドラのみ表示";
            this.chkイベントハンドラのみ.UseVisualStyleBackColor = true;
            // 
            // chkResources
            // 
            this.chkResources.AutoSize = true;
            this.chkResources.Checked = true;
            this.chkResources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResources.Location = new System.Drawing.Point(302, 18);
            this.chkResources.Name = "chkResources";
            this.chkResources.Size = new System.Drawing.Size(78, 16);
            this.chkResources.TabIndex = 14;
            this.chkResources.Text = "Resources";
            this.chkResources.UseVisualStyleBackColor = true;
            // 
            // chkThrow
            // 
            this.chkThrow.AutoSize = true;
            this.chkThrow.Location = new System.Drawing.Point(240, 17);
            this.chkThrow.Name = "chkThrow";
            this.chkThrow.Size = new System.Drawing.Size(55, 16);
            this.chkThrow.TabIndex = 13;
            this.chkThrow.Text = "Throw";
            this.chkThrow.UseVisualStyleBackColor = true;
            // 
            // chkCallMethod
            // 
            this.chkCallMethod.AutoSize = true;
            this.chkCallMethod.Location = new System.Drawing.Point(140, 17);
            this.chkCallMethod.Name = "chkCallMethod";
            this.chkCallMethod.Size = new System.Drawing.Size(81, 16);
            this.chkCallMethod.TabIndex = 12;
            this.chkCallMethod.Text = "CallMethod";
            this.chkCallMethod.UseVisualStyleBackColor = true;
            // 
            // chkMethodParameter
            // 
            this.chkMethodParameter.AutoSize = true;
            this.chkMethodParameter.Location = new System.Drawing.Point(13, 17);
            this.chkMethodParameter.Name = "chkMethodParameter";
            this.chkMethodParameter.Size = new System.Drawing.Size(113, 16);
            this.chkMethodParameter.TabIndex = 11;
            this.chkMethodParameter.Text = "MethodParameter";
            this.chkMethodParameter.UseVisualStyleBackColor = true;
            // 
            // chk継承無し
            // 
            this.chk継承無し.AutoSize = true;
            this.chk継承無し.Location = new System.Drawing.Point(15, 18);
            this.chk継承無し.Name = "chk継承無し";
            this.chk継承無し.Size = new System.Drawing.Size(69, 16);
            this.chk継承無し.TabIndex = 11;
            this.chk継承無し.Text = "継承無し";
            this.chk継承無し.UseVisualStyleBackColor = true;
            // 
            // chkEnum
            // 
            this.chkEnum.AutoSize = true;
            this.chkEnum.Location = new System.Drawing.Point(163, 19);
            this.chkEnum.Name = "chkEnum";
            this.chkEnum.Size = new System.Drawing.Size(52, 16);
            this.chkEnum.TabIndex = 14;
            this.chkEnum.Text = "Enum";
            this.chkEnum.UseVisualStyleBackColor = true;
            // 
            // chkStruct
            // 
            this.chkStruct.AutoSize = true;
            this.chkStruct.Location = new System.Drawing.Point(97, 19);
            this.chkStruct.Name = "chkStruct";
            this.chkStruct.Size = new System.Drawing.Size(55, 16);
            this.chkStruct.TabIndex = 13;
            this.chkStruct.Text = "Struct";
            this.chkStruct.UseVisualStyleBackColor = true;
            // 
            // chkInterface
            // 
            this.chkInterface.AutoSize = true;
            this.chkInterface.Location = new System.Drawing.Point(13, 19);
            this.chkInterface.Name = "chkInterface";
            this.chkInterface.Size = new System.Drawing.Size(69, 16);
            this.chkInterface.TabIndex = 12;
            this.chkInterface.Text = "Interface";
            this.chkInterface.UseVisualStyleBackColor = true;
            // 
            // cmb表示テンプレート
            // 
            this.cmb表示テンプレート.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb表示テンプレート.FormattingEnabled = true;
            this.cmb表示テンプレート.Location = new System.Drawing.Point(100, 6);
            this.cmb表示テンプレート.Name = "cmb表示テンプレート";
            this.cmb表示テンプレート.Size = new System.Drawing.Size(422, 20);
            this.cmb表示テンプレート.TabIndex = 15;
            this.cmb表示テンプレート.SelectedIndexChanged += new System.EventHandler(this.cmb表示テンプレート_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "表示テンプレート";
            // 
            // btn表示テンプレート削除
            // 
            this.btn表示テンプレート削除.Enabled = false;
            this.btn表示テンプレート削除.Location = new System.Drawing.Point(528, 6);
            this.btn表示テンプレート削除.Name = "btn表示テンプレート削除";
            this.btn表示テンプレート削除.Size = new System.Drawing.Size(71, 26);
            this.btn表示テンプレート削除.TabIndex = 21;
            this.btn表示テンプレート削除.Text = "削除";
            this.btn表示テンプレート削除.UseVisualStyleBackColor = true;
            this.btn表示テンプレート削除.Click += new System.EventHandler(this.btn表示テンプレート削除_Click);
            // 
            // FViewAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 474);
            this.Controls.Add(this.btn表示テンプレート削除);
            this.Controls.Add(this.cmb表示テンプレート);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn更新);
            this.Name = "FViewAnalyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "解析結果抽出";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.grpソースファイル.ResumeLayout(false);
            this.grpソースファイル.PerformLayout();
            this.grpNamespace.ResumeLayout(false);
            this.grpNamespace.PerformLayout();
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.grpMethod.ResumeLayout(false);
            this.grpMethod.PerformLayout();
            this.grpLiteral.ResumeLayout(false);
            this.grpLiteral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn更新;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkResourcesを呼び出し元のメソッドに纏める;
        private System.Windows.Forms.CheckBox chkFormOnly;
        private System.Windows.Forms.CheckBox chk継承無し;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.GroupBox grpMethod;
        private System.Windows.Forms.CheckBox chkResources;
        private System.Windows.Forms.CheckBox chkThrow;
        private System.Windows.Forms.CheckBox chkCallMethod;
        private System.Windows.Forms.CheckBox chkMethodParameter;
        private System.Windows.Forms.GroupBox grpNamespace;
        private System.Windows.Forms.CheckBox chkEnum;
        private System.Windows.Forms.CheckBox chkStruct;
        private System.Windows.Forms.CheckBox chkInterface;
        private System.Windows.Forms.CheckBox chkClass;
        private System.Windows.Forms.CheckBox chkNamespaceInner;
        private System.Windows.Forms.CheckBox chkDelegate;
        private System.Windows.Forms.CheckBox chkイベントハンドラのみ;
        private System.Windows.Forms.CheckBox chkLiteralString;
        private System.Windows.Forms.GroupBox grpLiteral;
        private System.Windows.Forms.CheckBox chkLiteralOther;
        private System.Windows.Forms.CheckBox chkLiteralBoolean;
        private System.Windows.Forms.CheckBox chkLiteralNumeric;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmb表示テンプレート;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox grpソースファイル;
        private System.Windows.Forms.CheckBox chkソースファイル;
        private System.Windows.Forms.CheckBox chkNamespace;
        private System.Windows.Forms.CheckBox chkMethod;
        private System.Windows.Forms.CheckBox chk継承有り;
        private System.Windows.Forms.CheckBox chkリソースファイル;
        private System.Windows.Forms.CheckBox chkLiteral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn表示条件を保存;
        private System.Windows.Forms.TextBox txt表示テンプレート名;
        private System.Windows.Forms.Button btn表示テンプレート削除;
        private System.Windows.Forms.Button btn全て選択;
    }
}