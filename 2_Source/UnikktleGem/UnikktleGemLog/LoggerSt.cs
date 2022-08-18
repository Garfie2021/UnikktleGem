using System;
using System.Windows.Forms;
using NLog;

namespace UnikktleGemLog
{
    public static class LoggerSt
    {
        private static object obj = new object();
        private static Logger _Logger = LogManager.GetCurrentClassLogger();

        public static void Trace(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);

            lock (obj)
            {
#if DEBUG
                _Logger.Trace(msg);
#else
                // 詳細なログがユーザに見えるのはセキュリティ上良くない。
                _Logger.Debug("想定外のパターン。");
#endif
            }
        }

        public static void Trace(Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message + "\r\n" + ex.StackTrace);

            lock (obj)
            {
#if DEBUG
                _Logger.Trace(ex);
#else
                // 詳細なログがユーザに見えるのはセキュリティ上良くない。
                _Logger.Debug("想定外のパターン。");
#endif
            }
        }

        public static void Debug(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);

            lock (obj)
            {
#if DEBUG
                _Logger.Debug(msg);
#else
                // 詳細なログがユーザに見えるのはセキュリティ上良くない。
                _Logger.Debug("想定外のパターン。");
#endif
            }
        }

        public static void Debug(Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message + "\r\n" + ex.StackTrace);

            lock (obj)
            {
#if DEBUG
                _Logger.Debug(ex);
#else
                // 詳細なログがユーザに見えるのはセキュリティ上良くない。
                _Logger.Debug("想定外のパターン。");
#endif
            }
        }

        public static void Info(string title, Exception ex, string source)
        {
            var log = title + "\r\n" + ex.Message + "\r\n" + ex.StackTrace + "\r\n" + source;

            System.Diagnostics.Debug.WriteLine(log);

            lock (obj)
            {
#if DEBUG
                _Logger.Info(log);
#else
                // 例外の内容をログに出して、ユーザに見えるのはセキュリティ上良くない。
                // sourceは出しておいて、ログを送って貰う。
                _Logger.Info(title + "\r\n" + source);
#endif
            }

        }

        public static void Info(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);

            lock (obj)
            {
                _Logger.Info(msg);
            }
        }

        public static void Warn(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);

            lock (obj)
            {
                _Logger.Warn(msg);
            }
        }

        /// <summary>
        /// Exception用のログ出力
        /// </summary>
        /// <param name="ex"></param>
        public static void Error(Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message + "\r\n" + ex.StackTrace);

            lock (obj)
            {
                _Logger.Error(ex);
            }

#if DEBUG
            MessageBox.Show(ex.Message + "\r\n\r\n" + ex.StackTrace);
#else
            MessageBox.Show("予期せぬ例外が発生し、処理の実行に失敗しました。");
#endif
        }

        /// <summary>
        /// Exception以外のエラー用ログ出力
        /// </summary>
        /// <param name="ex"></param>
        public static void Error(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);

            lock (obj)
            {
                _Logger.Error(msg);
            }

#if DEBUG
            MessageBox.Show(msg);
#else
            MessageBox.Show("予期せぬ例外が発生し、処理の実行に失敗しました。");
#endif
        }
    }
}
