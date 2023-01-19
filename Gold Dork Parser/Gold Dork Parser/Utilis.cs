using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Leaf.xNet;

namespace Gold_Dork_Parser
{
	// Token: 0x02000004 RID: 4
	internal class Utilis
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00006C08 File Offset: 0x00004E08
		public static List<string> LoadList(string Title)
		{
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Title = "Open " + Title + " file";
					openFileDialog.Filter = "Text file | *.txt";
					openFileDialog.Multiselect = false;
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						HashSet<string> hashSet = new HashSet<string>();
						hashSet = new HashSet<string>(File.ReadLines(openFileDialog.FileName));
						if (hashSet.Count == 0)
						{
							MessageBox.Show("Empty File", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return null;
						}
						return hashSet.ToList<string>();
					}
				}
			}
			catch
			{
				return null;
			}
			return null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public static void Save(string fileName, string dataToSave, string mainFolder = "Results")
		{
			Utilis.writerLock.EnterWriteLock();
			try
			{
				if (!Directory.Exists(mainFolder))
				{
					Directory.CreateDirectory(mainFolder);
				}
				string arg = DateTime.Now.ToString("yyyy-MM-dd").ToString();
				if (!Directory.Exists(string.Format("{0}\\{1}", mainFolder, arg)))
				{
					Directory.CreateDirectory(string.Format("{0}\\{1}", mainFolder, arg));
				}
				using (StreamWriter streamWriter = File.AppendText(string.Format("{0}\\{1}\\{2}", mainFolder, arg, fileName)))
				{
					streamWriter.WriteLine(dataToSave);
					streamWriter.Close();
				}
			}
			finally
			{
				Utilis.writerLock.ExitWriteLock();
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00006D78 File Offset: 0x00004F78
		public static List<string> ScrapeProxies(string ProxyAPI)
		{
			HashSet<string> hashSet = new HashSet<string>();
			try
			{
				using (HttpRequest httpRequest = new HttpRequest())
				{
					httpRequest.Proxy = null;
					httpRequest.IgnoreProtocolErrors = true;
					httpRequest.IgnoreInvalidCookie = true;
					HttpResponse httpResponse = httpRequest.Get(ProxyAPI, null);
					if (!httpResponse.HasError)
					{
						string pattern = "\\b(\\d{1,3}\\.){3}\\d{1,3}\\:\\d{1,8}\\b";
						foreach (object obj in Regex.Matches(httpResponse.ToString(), pattern, RegexOptions.Singleline))
						{
							Match match = (Match)obj;
							hashSet.Add(match.Groups[0].Value);
						}
						return hashSet.ToList<string>();
					}
					MessageBox.Show("Error connecting to API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch
			{
				MessageBox.Show("Error connecting to API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return null;
			}
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00006E94 File Offset: 0x00005094
		public static string RandomUserAgent()
		{
			return Utilis.UserAgentList[Utilis.random.Next(Utilis.UserAgentList.Count - 1)];
		}

		// Token: 0x04000051 RID: 81
		private static ReaderWriterLockSlim writerLock = new ReaderWriterLockSlim();

		// Token: 0x04000052 RID: 82
		private static Random random = new Random();

		// Token: 0x04000053 RID: 83
		public static List<string> AntipublicList = new List<string>
		{
			"www.bing.com",
			"www.google.com",
			"www.wikipedia.com",
			"www.play.google.com",
			"www.wikipedia.org",
			"www.stackoverflow.com",
			"www.amazon.com",
			"www.amazon.in",
			"www.amazon.us",
			"www.microsoft.com",
			"www.social.msdn.com",
			"www.youtube.com",
			"www.reddit.com",
			"www.quora.com",
			"www.telegram.org",
			"www.facebook.com",
			"www.instagram.com",
			"www.cracked.to",
			"www.github.com",
			"www.scribd.com",
			"www.nulled.to",
			"www.apple.com",
			"www.google.com.jp",
			"www.google.com.uk",
			"www.twitter.com",
			"www.reddit.com",
			"www.quora.com",
			"www.telegram.org",
			"www.apple.com",
			"www.cracked.to",
			"www.nulled.to",
			"www.pastebin.com",
			"sourceforge.net",
			"chrome.google.com",
			"go.microsoft.com",
			"play.google.com",
			"support.google.com",
			"books.google.co.in",
			"bing.com",
			"google.com",
			"wikipedia.com",
			"play.google.com",
			"wikipedia.org",
			"stackoverflow.com",
			"amazon.com",
			"amazon.in",
			"amazon.us",
			"www.stackoverflow.com",
			"microsoft.com",
			"microsoft.com",
			"social.msdn.com",
			"youtube.com",
			"youtube.com",
			"reddit.com",
			"quora.com",
			"telegram.org",
			"facebook.com",
			"instagram.com",
			"cracked.to",
			"scribd.com",
			"scribd.com",
			"nulled.to",
			"apple.com",
			"twitter.com",
			"reddit.com",
			"quora.com",
			"telegram.org",
			"apple.com",
			"cracked.to",
			"nulled.to",
			"pastebin.com",
			"myaccount.google.com",
			"github.com"
		};

		// Token: 0x04000054 RID: 84
		private static List<string> UserAgentList = new List<string>
		{
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.77 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.1.1 Safari/605.1.15",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.101 Safari/537.36",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:89.0) Gecko/20100101 Firefox/89.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15; rv:89.0) Gecko/20100101 Firefox/89.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.77 Safari/537.36",
			"Mozilla/5.0 (Windows NT 10.0; rv:78.0) Gecko/20100101 Firefox/78.0",
			"Mozilla/5.0 (X11; Linux x86_64; rv:89.0) Gecko/20100101 Firefox/89.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.101 Safari/537.36",
			"Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.101 Safari/537.36 Edg/91.0.864.48",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36 Edg/91.0.864.54",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36 Edg/91.0.864.59",
			"Mozilla/5.0 (X11; Linux x86_64; rv:78.0) Gecko/20100101 Firefox/78.0",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.77 Safari/537.36 Edg/91.0.864.41",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36 Edg/91.0.864.64",
			"Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.77 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.0.3 Safari/605.1.15",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36 OPR/76.0.4017.177",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.1 Safari/605.1.15",
			"Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.101 Safari/537.36",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:78.0) Gecko/20100101 Firefox/78.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36",
			"Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.1.1 Safari/605.1.15",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.101 Safari/537.36 OPR/77.0.4054.90",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/88.0",
			"Mozilla/5.0 (X11; Fedora; Linux x86_64; rv:89.0) Gecko/20100101 Firefox/89.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.14; rv:89.0) Gecko/20100101 Firefox/89.0",
			"Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.77 Safari/537.36",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:90.0) Gecko/20100101 Firefox/90.0",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.100 Safari/537.36",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.93 Safari/537.36",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.77 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15; rv:88.0) Gecko/20100101 Firefox/88.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.101 Safari/537.36",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.106 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.0.2 Safari/605.1.15",
			"Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.15; rv:90.0) Gecko/20100101 Firefox/90.0",
			"Mozilla/5.0 (Windows NT 6.3; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0",
			"Mozilla/5.0 (Windows NT 10.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/99.0.7113.93 Safari/537.36",
			"Mozilla/5.0 (X11; Linux x86_64; rv:88.0) Gecko/20100101 Firefox/88.0",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:88.0) Gecko/20100101 Firefox/88.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/14.1.1 Safari/605.1.15",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.13; rv:89.0) Gecko/20100101 Firefox/89.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.1.3 Safari/605.1.15",
			"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36 OPR/77.0.4054.172",
			"Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.101 Safari/537.36",
			"Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko",
			"Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.114 Safari/537.36"
		};
	}
}
