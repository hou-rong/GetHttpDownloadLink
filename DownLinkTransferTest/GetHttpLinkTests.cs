using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DownLinkTransfer.Tests
{
    [TestClass()]
    public class GetHttpLinkTests
    {
        private string qqDownloadLink = "qqdl://aHR0cDovL2Rvd25sb2FkLm1pY3Jvc29mdC5jb21odHRwOi8vZG93bmxvYWQubWljcm9zb2Z0LmNvbS9kb3dubG9hZC8xL0MvNC8xQzQxQkM2Qi1GOEFCLTQwM0ItQjA0RS1DOTZFRDYwNDc0ODgvTWVkaWFDcmVhdGlvblRvb2wuZXhl";
        private string thunderDownloadLink = "thunder://QUFodHRwOi8vZG93bmxvYWQubWljcm9zb2Z0LmNvbWh0dHA6Ly9kb3dubG9hZC5taWNyb3NvZnQuY29tL2Rvd25sb2FkLzEvQy80LzFDNDFCQzZCLUY4QUItNDAzQi1CMDRFLUM5NkVENjA0NzQ4OC9NZWRpYUNyZWF0aW9uVG9vbC5leGVaWg==";
        private string flashgetDownloadLink = "flashget://W0ZMQVNIR0VUXWh0dHA6Ly9kb3dubG9hZC5taWNyb3NvZnQuY29taHR0cDovL2Rvd25sb2FkLm1pY3Jvc29mdC5jb20vZG93bmxvYWQvMS9DLzQvMUM0MUJDNkItRjhBQi00MDNCLUIwNEUtQzk2RUQ2MDQ3NDg4L01lZGlhQ3JlYXRpb25Ub29sLmV4ZVtGTEFTSEdFVF0=&1926";
        private string httpDownloadLink = "http://download.microsoft.comhttp://download.microsoft.com/download/1/C/4/1C41BC6B-F8AB-403B-B04E-C96ED6047488/MediaCreationTool.exe";
        [TestMethod()]
        public void FromQqDownloadReturnTrueTest()
        {
            string result = String.Empty;
            Assert.IsTrue(GetHttpLink.FromQqDownload(qqDownloadLink, out result));
        }

        [TestMethod()]
        public void FromQqDownloadReturnFalseTest()
        {
            string result = String.Empty;
            Assert.IsFalse(GetHttpLink.FromQqDownload(flashgetDownloadLink, out result));
        }

        [TestMethod()]
        public void FromQqDownloadResultTest()
        {
            string result = String.Empty;
            GetHttpLink.FromQqDownload(qqDownloadLink, out result);
            Assert.AreEqual(httpDownloadLink, result);
        }

        [TestMethod()]
        public void FromFlashGetReturnTrueTest()
        {
            string result = String.Empty;
            Assert.IsTrue(GetHttpLink.FromFlashGet(flashgetDownloadLink, out result));
        }

        [TestMethod()]
        public void FromFlashGetReturnFalseTest()
        {
            string result = String.Empty;
            Assert.IsFalse(GetHttpLink.FromFlashGet(qqDownloadLink, out result));
        }

        [TestMethod()]
        public void FromFlashGetResultTest()
        {
            string result = String.Empty;
            GetHttpLink.FromFlashGet(flashgetDownloadLink, out result);
            Assert.AreEqual(httpDownloadLink, result);
        }

        [TestMethod()]
        public void FromThunderReturnTrueTest()
        {
            string result = String.Empty;
            Assert.IsTrue(GetHttpLink.FromThunder(thunderDownloadLink, out result));
        }

        [TestMethod()]
        public void FromThunderReturnFalseTest()
        {
            string result = String.Empty;
            Assert.IsFalse(GetHttpLink.FromThunder(qqDownloadLink, out result));
        }

        [TestMethod()]
        public void FromThunderResultTest()
        {
            string result = String.Empty;
            GetHttpLink.FromThunder(thunderDownloadLink, out result);
            Assert.AreEqual(httpDownloadLink, result);
        }
    }
}