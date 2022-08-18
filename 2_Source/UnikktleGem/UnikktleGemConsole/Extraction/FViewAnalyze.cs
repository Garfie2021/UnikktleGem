using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnikktleGemConst;
using UnikktleGemLib;
using UnikktleGemLog;

namespace UnikktleGemConsole
{
    public partial class FViewAnalyze : Form
    {
        private 解析パック _解析パック;

        /// <summary>
        /// 表示テンプレート設定
        /// </summary>
        public static ViewTemplateSettings _ViewTemplateSettings;

        private ViewTemplate _ViewTemplate_Current = new ViewTemplate();


        public FViewAnalyze(解析パック 解析パック)
        {
            InitializeComponent();

            _解析パック = 解析パック;

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                using (var fWait = new FWait())
                {
                    fWait.Show();

                    this.Text += _解析パック._画面タイトル補足;

                    if (File.Exists(SingletonData._ViewTemplateSettingsFilePath))
                    {
                        _ViewTemplateSettings = (ViewTemplateSettings)DirectoryOps.ReadBinaryFile(SingletonData._ViewTemplateSettingsFilePath);

                        foreach (var viewTemplate in _ViewTemplateSettings.ViewTemplateList)
                        {
                            cmb表示テンプレート.Items.Add(viewTemplate);
                        }

                        if (_ViewTemplateSettings.ViewTemplateList.Count > 0)
                        {
                            btn表示テンプレート削除.Enabled = true;
                        }
                    }
                    else
                    {
                        _ViewTemplateSettings = new ViewTemplateSettings();
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }


        private void btn表示条件で表示_Click(object sender, EventArgs e)
        {
            try
            {
                var viewTemplate = CreateViewTemplate().DeepCopy();

                // 上位条件が未選択なら、下位条件も未選択状態にする。
                ViewTemplate調整(viewTemplate);

                var form = new FViewAnalyzeResult(_解析パック._TC_Solution.DeepCopy(), viewTemplate, _解析パック._画面タイトル補足);
                form.Show();
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn表示条件を保存_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt表示テンプレート名.Text))
                {
                    MessageBox.Show("[表示テンプレート名]が入力されていません。");
                    return;
                }

                if (_ViewTemplate_Current.ID == null)
                {
                    // 新規
                    _ViewTemplate_Current.ID = _ViewTemplateSettings.ViewTemplateList.Max(x => x.ID) + 1;
                }
                else
                {
                    // 更新。古い設定を削除してから、新しい設定として登録する。
                    _ViewTemplateSettings.ViewTemplateList.RemoveAll(x => x.ID == _ViewTemplate_Current.ID);
                }

                _ViewTemplateSettings.ViewTemplateList.Add(CreateViewTemplate());

                DirectoryOps.WriteBinaryFile(SingletonData._ViewTemplateSettingsFilePath, _ViewTemplateSettings);

                MessageBox.Show("保存完了");
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void chkソースファイル_CheckedChanged(object sender, EventArgs e)
        {
            grpソースファイル.Enabled = chkソースファイル.Checked;
        }

        private void chkLiteral_CheckedChanged(object sender, EventArgs e)
        {
            grpLiteral.Enabled = chkLiteral.Checked;
        }

        private void chkMethod_CheckedChanged(object sender, EventArgs e)
        {
            grpMethod.Enabled = chkMethod.Checked;
        }

        private void chkClass_CheckedChanged(object sender, EventArgs e)
        {
            grpClass.Enabled = chkClass.Checked;
        }

        private void chkNamespace_CheckedChanged(object sender, EventArgs e)
        {
            grpNamespace.Enabled = chkNamespace.Checked;
        }

        private void cmb表示テンプレート_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _ViewTemplate_Current = (ViewTemplate)cmb表示テンプレート.Items[cmb表示テンプレート.SelectedIndex];

                SetViewTemplate(_ViewTemplate_Current);
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn表示テンプレート削除_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(cmb表示テンプレート.SelectedText + " を削除しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    != DialogResult.OK)
                {
                    return;
                }

                var viewTemplate = (ViewTemplate)cmb表示テンプレート.Items[cmb表示テンプレート.SelectedIndex];

                cmb表示テンプレート.Items.RemoveAt(cmb表示テンプレート.SelectedIndex);

                _ViewTemplate_Current = new ViewTemplate();

                _ViewTemplateSettings.ViewTemplateList.RemoveAll(x => x.ID == viewTemplate.ID);

                DirectoryOps.WriteBinaryFile(SingletonData._ViewTemplateSettingsFilePath, _ViewTemplateSettings);

                MessageBox.Show("削除完了");
            }
            catch (Exception ex)
            {
                LoggerSt.Error(ex);
            }
        }

        private void btn全て選択_Click(object sender, EventArgs e)
        {
            chkソースファイル.Checked = true;
            chkNamespace.Checked = true;
            chkInterface.Checked = true;

            chkStruct.Checked = true;
            chkEnum.Checked = true;
            chkDelegate.Checked = true;
            chkNamespace.Checked = true;
            chkClass.Checked = true;

            chk継承無し.Checked = true;
            chk継承有り.Checked = true;
            chkFormOnly.Checked = true;
            chkMethod.Checked = true;

            chkMethodParameter.Checked = true;
            chkCallMethod.Checked = true;
            chkThrow.Checked = true;
            chkResources.Checked = true;
            chkイベントハンドラのみ.Checked = true;
            chkResourcesを呼び出し元のメソッドに纏める.Checked = true;
            chkLiteral.Checked = true;

            chkLiteralString.Checked = true;
            chkLiteralNumeric.Checked = true;
            chkLiteralBoolean.Checked = true;
            chkLiteralOther.Checked = true;

            chkリソースファイル.Checked = true;
        }

        private ViewTemplate CreateViewTemplate()
        {
            return new ViewTemplate()
            {
                TemplateName = txt表示テンプレート名.Text,
                EC_Project = new EC_Project()
                {
                    SrcFile = chkソースファイル.Checked,
                    EC_SrcFile = new EC_SrcFile()
                    {
                        Namespace = chkNamespace.Checked,
                        EC_Namespace = new EC_Namespace()
                        {
                            Interface = chkInterface.Checked,
                            Struct = chkStruct.Checked,
                            Enum = chkEnum.Checked,
                            Delegate = chkDelegate.Checked,
                            Namespace = chkNamespaceInner.Checked,
                            Class = chkClass.Checked,
                            EC_Class = new EC_Class()
                            {
                                継承無し = chk継承無し.Checked,
                                継承有り = chk継承有り.Checked,
                                FormOnly = chkFormOnly.Checked,
                                Method = chkMethod.Checked,
                                EC_Method = new EC_Method()
                                {
                                    MethodParameter = chkMethodParameter.Checked,
                                    CallMethod = chkCallMethod.Checked,
                                    Throw = chkThrow.Checked,
                                    Resources = chkResources.Checked,
                                    イベントハンドラのみ = chkイベントハンドラのみ.Checked,
                                    Resourcesを呼び出し元のメソッドに纏める = chkResourcesを呼び出し元のメソッドに纏める.Checked,
                                    Literal = chkLiteral.Checked,
                                    EC_Literal = new EC_Literal()
                                    {
                                        String = chkLiteralString.Checked,
                                        Numeric = chkLiteralNumeric.Checked,
                                        Boolean = chkLiteralBoolean.Checked,
                                        Other = chkLiteralOther.Checked,
                                    },
                                },
                            },
                        },
                    },

                    ResourceFile = chkリソースファイル.Checked,
                }
            };
        }

        private void SetViewTemplate(ViewTemplate viewTemplate)
        {
            txt表示テンプレート名.Text = viewTemplate.TemplateName;
            chkソースファイル.Checked = viewTemplate.EC_Project.SrcFile;
            chkNamespace.Checked = viewTemplate.EC_Project.EC_SrcFile.Namespace;
            chkInterface.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Interface;

            chkStruct.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Struct;
            chkEnum.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Enum;
            chkDelegate.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Delegate;
            chkNamespace.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Namespace;
            chkClass.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Class;

            chk継承無し.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.継承無し;
            chk継承有り.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.継承有り;
            chkFormOnly.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.FormOnly;
            chkMethod.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.Method;

            chkMethodParameter.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.MethodParameter;
            chkCallMethod.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.CallMethod;
            chkThrow.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Throw;
            chkResources.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Resources;
            chkイベントハンドラのみ.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.イベントハンドラのみ;
            chkResourcesを呼び出し元のメソッドに纏める.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Resourcesを呼び出し元のメソッドに纏める;
            chkLiteral.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Literal;

            chkLiteralString.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.String;
            chkLiteralNumeric.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.Numeric;
            chkLiteralBoolean.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.Boolean;
            chkLiteralOther.Checked = viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.Other;

            chkリソースファイル.Checked = viewTemplate.EC_Project.ResourceFile;
        }

        /// <summary>
        /// ソースコードをシンプルにする為の調整。
        /// 上位条件が未選択なら、下位条件も未選択状態にする。
        /// </summary>
        private void ViewTemplate調整(ViewTemplate viewTemplate)
        {
            if (!viewTemplate.EC_Project.SrcFile)
            {
                viewTemplate.EC_Project.EC_SrcFile.Namespace = false;
            }

            if (!viewTemplate.EC_Project.EC_SrcFile.Namespace)
            {
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Interface = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Struct = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Enum = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Delegate = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Namespace = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Class = false;
            }
            if (!viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.Class)
            {
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.継承無し = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.継承有り = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.FormOnly = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.Method = false;
            }
            if (!viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.Method)
            {
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.MethodParameter = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.CallMethod = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Throw = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Resources = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.イベントハンドラのみ = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Resourcesを呼び出し元のメソッドに纏める = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Literal = false;
            }
            if (!viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.Literal)
            {
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.String = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.Numeric = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.Boolean = false;
                viewTemplate.EC_Project.EC_SrcFile.EC_Namespace.EC_Class.EC_Method.EC_Literal.Other = false;
            }
        }

    }
}
