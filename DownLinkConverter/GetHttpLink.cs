using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DownLinkConverter
{
    public class GetHttpLink
    {
        private static string GetValue(string str, string s, string e)
        {
            Regex rg = new Regex("(?<=(" + s + "))[.\\s\\S]*?(?=(" + e + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(str).Value;
        }
        public static bool FromThunder(string downloadLink, out string result)
        {
            result = String.Empty;
            if (!downloadLink.Contains("thunder://"))
            {
                return false;
            }
            try
            {
                string tmpStr = downloadLink.Remove(0, 10);
                byte[] bytes = Convert.FromBase64String(tmpStr);
                result = GetValue(Encoding.ASCII.GetString(bytes),"AA","ZZ");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool FromFlashGet(string downloadLink, out string result)
        {
            result = String.Empty;
            if (!downloadLink.Contains("flashget://"))
            {
                return false;
            }
            try
            {
                string tmpStr = GetValue(downloadLink, "flashget://", "&");
                byte[] bytes = Convert.FromBase64String(tmpStr);
                tmpStr = Encoding.ASCII.GetString(bytes);
                result = tmpStr.Substring(10, tmpStr.Length - 20);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool FromQqDownload(string downloadLink, out string result)
        {
            result = String.Empty;
            if (!downloadLink.Contains("qqdl://"))
            {
                return false;
            }
            try
            {
                string tmpStr = downloadLink.Remove(0, 7);
                byte[] bytes = Convert.FromBase64String(tmpStr);
                result = Encoding.ASCII.GetString(bytes);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
