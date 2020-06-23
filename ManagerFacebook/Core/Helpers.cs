using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerFacebook.DAO.models;
using Newtonsoft.Json;
using OtpNet;

namespace ManagerFacebook.Core
{
    public static class Helpers
    {
        public static bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{6,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa kí tự thường.";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa kí tự In hoa.";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa số.";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa kí tự đặc biệt.";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải từ 6 đến 15 kí tự.";
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string ExpiryUser(decimal offset)
        {
            var days = Math.Floor(offset / 1000 / 60 / 60 / 24);
            offset -= days * 1000 * 60 * 60 * 24; // giảm offset đi
            var hours = Math.Floor(offset / 1000 / 60 / 60);
            offset -= hours * 1000 * 60 * 60; // giảm offset đi
            var minutes = Math.Floor(offset / 1000 / 60);
            offset -= minutes * 1000 * 60;
            var seconds = Math.Floor(offset / 1000);

            return "Còn " + days + " ngày " + hours + " giờ " + minutes + " phút " + seconds + " giây.";
        }
        public static void OpenLinkBrowser()
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/BSD-Software-103368244659086/");
        }

        public static List<String> GetImagesPath_X(String folderName)
        {


            return new List<String>(Directory.GetFiles(folderName, "*.jpg"));

        }
        public static List<string> GetImagesPath(string path)
        {
            var exts = new[] { "png", "jpg" };
            var files =
                Directory
                .EnumerateFiles(path, "*.*")
                .Where(file => exts.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase))).ToList();
            return files;
        }

        public static string getRandomItem(List<string> t)
        {
            Random random = new Random();
            return t[random.Next(t.Count)];
        }
        public static void WriteText(string path, string str)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(path);
                fileInfo.Delete();
                StreamWriter streamWriter = new StreamWriter(path, true);
                streamWriter.WriteLine(str);
                streamWriter.Close();
            }
            catch (Exception exception)
            {
                throw;
            }
        }


        public static List<List<T>> SplitList<T>(IEnumerable<T> values, int groupSize, int? maxCount = null)
        {
            List<List<T>> result = new List<List<T>>();
            // Quick and special scenario
            if (values.Count() <= groupSize)
            {
                result.Add(values.ToList());
            }
            else
            {
                List<T> valueList = values.ToList();
                int startIndex = 0;
                int count = valueList.Count;
                int elementCount = 0;

                while (startIndex < count && (!maxCount.HasValue || (maxCount.HasValue && startIndex < maxCount)))
                {
                    elementCount = (startIndex + groupSize > count) ? count - startIndex : groupSize;
                    result.Add(valueList.GetRange(startIndex, elementCount));
                    startIndex += elementCount;
                }
            }


            return result;
        }
        public static bool IsAdministrator()
        {
            bool result;
            try
            {
                WindowsIdentity current = WindowsIdentity.GetCurrent();
                WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
                result = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public static void SaveSetting(SettingModel setting)
        {
            WriteText(Application.StartupPath + "\\SettingApplication.ini", JsonConvert.SerializeObject(setting));
        }

        public static SettingModel GetSetting()
        {
            try
            {
                return JsonConvert.DeserializeObject<SettingModel>(File.ReadAllText(Application.StartupPath + "\\SettingApplication.ini"));
            }
            catch (Exception e)
            {
                return new SettingModel();
            }

        }
        public static object GetKey2FA(string key)
        {

            object result;
            try
            {
                object obj;
                try
                {
                    byte[] array = Base32Encoding.ToBytes(key.Trim().Replace(" ", ""));
                    Totp totp = new Totp(array, 30, 0, 6, null);
                    obj = totp.ComputeTotp(DateTime.UtcNow);
                    goto IL_44;
                }
                catch (Exception)
                {
                }
                obj = null;
            IL_44:
                result = obj;
            }
            catch (Exception exception)
            {
                return "";
            }
            return result;
        }
        public static string GetKeyTool()
        {

            return EncodeMD5(GetUUID() + "bsdsoftware.net");
        }

        public static string GetUUID()
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "CMD.exe",
                Arguments = "/C wmic csproduct get UUID"
            };
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;

            process.Start();
            process.WaitForExit();
            string text = process.StandardOutput.ReadToEnd();
            return text.Replace("UUID", "").Replace("\n", "").Replace(" ", "").Replace("-", "").Replace("\r", "");
        }
        public static string EncodeMD5(string txt)
        {
            string text = "";
            byte[] array = Encoding.UTF8.GetBytes(txt);
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            array = md5CryptoServiceProvider.ComputeHash(array);
            foreach (byte b in array)
            {
                text += b.ToString("X2");
            }
            return text.ToLower();
        }
        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);


        [DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
    }
}
