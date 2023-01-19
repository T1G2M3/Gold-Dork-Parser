using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Leaf.xNet;

namespace Gold_Dork_Parser
{
	// Token: 0x02000002 RID: 2
	public partial class Main : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Main()
		{
			this.InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
			this.Protocol_Dropdown.SelectedIndex = 1;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020F8 File Offset: 0x000002F8
		private void ExitButton_Click(object sender, EventArgs e)
		{
			foreach (Thread thread in this.Threadlist)
			{
				thread.Abort();
			}
			Application.Exit();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002150 File Offset: 0x00000350
		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000215C File Offset: 0x0000035C
		private void Bots_Scroll_Scroll(object sender, ScrollEventArgs e)
		{
			this.Bots_Numeric.Value = this.Bots_Scroll.Value;
			this.LabelBots.Text = this.Bots_Numeric.Value.ToString();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021A2 File Offset: 0x000003A2
		private void Golden_Bullet_Click(object sender, EventArgs e)
		{
			Process.Start("https://t.me/Golden_Bullet69");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002248 File Offset: 0x00000448
		private void Start_Click(object sender, EventArgs e)
		{
			if (this.Dorklist.Count == 0)
			{
				MessageBox.Show("Load Dorks First!", "No dorks", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.Logs.AppendText("Load Dorks First!\n");
				this.Logs.ScrollToCaret();
				return;
			}
			new Thread(delegate()
			{
				while (this.isRunning)
				{
					Thread.Sleep(300000);
					try
					{
						lock (this.logsLock)
						{
							base.Invoke(new Action(delegate()
							{
								this.Logs.Clear();
							}));
						}
					}
					catch
					{
					}
				}
			})
			{
				IsBackground = true
			}.Start();
			if (this.Proxyless)
			{
				this.isRunning = true;
				this.Dork.Enabled = false;
				this.Proxy.Enabled = false;
				this.Proxyless_Checkbox.Enabled = false;
				this.ProxyAPI_Checbox.Enabled = false;
				this.OKButton.Enabled = false;
				this.ProxyAPI_Textbox.Enabled = false;
				this.Proxyscrape_Button.Enabled = false;
				for (int i = 0; i < (int)this.Bots_Numeric.Value; i++)
				{
					Thread thread = new Thread(delegate()
					{
						this.StartAll();
					});
					thread.IsBackground = true;
					this.Threadlist.Add(thread);
					thread.Start();
				}
				return;
			}
			if (this.Proxylist.Count == 0)
			{
				MessageBox.Show("Load Proxy First!", "No proxy", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.Logs.AppendText("Load Proxy First!\n");
				this.Logs.ScrollToCaret();
				return;
			}
			this.isRunning = true;
			this.Dork.Enabled = false;
			this.Proxy.Enabled = false;
			for (int j = 0; j < (int)this.Bots_Numeric.Value; j++)
			{
				Thread thread2 = new Thread(delegate()
				{
					this.StartAll();
				});
				thread2.IsBackground = true;
				this.Threadlist.Add(thread2);
				thread2.Start();
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002424 File Offset: 0x00000624
		private void StartAll()
		{
			while (this.GetDork() != null)
			{
				string dork = this.GetDork();
				this.DorkCounter++;
				this.Bing(HttpUtility.UrlEncode(dork));
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000245C File Offset: 0x0000065C
		private void Stop_Click(object sender, EventArgs e)
		{
			if (this.isRunning)
			{
				foreach (Thread thread in this.Threadlist)
				{
					thread.Abort();
				}
				this.isRunning = false;
				this.Dork.Enabled = true;
				this.Proxy.Enabled = true;
				this.Dork.Enabled = true;
				this.Proxy.Enabled = true;
				this.Proxyless_Checkbox.Enabled = true;
				this.ProxyAPI_Checbox.Enabled = true;
				this.OKButton.Enabled = true;
				this.ProxyAPI_Textbox.Enabled = true;
				this.Proxyscrape_Button.Enabled = true;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000252C File Offset: 0x0000072C
		private void Dork_Click(object sender, EventArgs e)
		{
			List<string> list = Utilis.LoadList("Dork");
			if (list != null && list.Count > 0)
			{
				this.Dorklist.Clear();
				foreach (string item in list)
				{
					this.Dorklist.Add(item);
				}
				list.Clear();
				this.LabelDorks.Text = this.Dorklist.Count.ToString();
				this.Logs.AppendText("Loaded " + this.Dorklist.Count + " dorks\n");
				this.Progressbar.Maximum = this.Dorklist.Count;
				this.Logs.ScrollToCaret();
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002618 File Offset: 0x00000818
		private void Proxy_Click(object sender, EventArgs e)
		{
			List<string> list = Utilis.LoadList("Proxy");
			if (list != null && list.Count > 0)
			{
				this.Proxylist.Clear();
				foreach (string item in list)
				{
					this.Proxylist.Add(item);
				}
				list.Clear();
				this.LabelProxy.Text = this.Proxylist.Count.ToString();
				this.Logs.AppendText("Loaded " + this.Proxylist.Count + " proxies\n");
				this.Logs.ScrollToCaret();
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000026EC File Offset: 0x000008EC
		private string GetDork()
		{
			string result;
			try
			{
				result = this.Dorklist[this.DorkCounter];
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002724 File Offset: 0x00000924
		private void Proxyless_Checkbox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.Proxyless_Checkbox.Checked)
			{
				this.Proxyless = true;
				this.Proxy.Enabled = false;
				this.ProxyAPI_Textbox.Enabled = false;
				this.ProxyAPI_Checbox.Enabled = false;
				this.Proxyscrape_Button.Enabled = false;
				this.OKButton.Enabled = false;
				this.Protocol_Dropdown.Enabled = false;
				return;
			}
			this.Proxyless = false;
			this.Proxy.Enabled = true;
			this.ProxyAPI_Textbox.Enabled = true;
			this.ProxyAPI_Checbox.Enabled = true;
			this.Proxyscrape_Button.Enabled = true;
			this.OKButton.Enabled = true;
			this.Protocol_Dropdown.Enabled = true;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000027E0 File Offset: 0x000009E0
		private void ProxyAPI_Checbox_CheckedChanged(object sender, EventArgs e)
		{
			this.Proxyscrape_Button.Enabled = this.ProxyAPI_Checbox.Checked;
			this.OKButton.Enabled = this.ProxyAPI_Checbox.Checked;
			this.ProxyAPI_Textbox.Enabled = this.ProxyAPI_Checbox.Checked;
			if (this.ProxyAPI_Checbox.Checked)
			{
				this.Proxy.Enabled = false;
				return;
			}
			this.Proxy.Enabled = true;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002855 File Offset: 0x00000A55
		private void Save_Public_TextBox_CheckedChanged(object sender, EventArgs e)
		{
			this.savePublicUrls = this.Save_Public_TextBox.Checked;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002868 File Offset: 0x00000A68
		private void Proxyscrape_Button_Click(object sender, EventArgs e)
		{
			this.ProxyAPI_Textbox.Text = "https://api.proxyscrape.com/v2/?request=getproxies&protocol=socks4&timeout=5000&country=all&simplified=true";
			this.Protocol_Dropdown.SelectedIndex = 1;
			this.Timeout_Scroll.Value = 5;
			this.Timeout_Numeric.Value = 5m;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002980 File Offset: 0x00000B80
		private void OKButton_Click(object sender, EventArgs e)
		{
			Task.Factory.StartNew(delegate()
			{
				List<string> list = Utilis.ScrapeProxies(this.ProxyAPI_Textbox.Text);
				if (list != null && list.Count > 0)
				{
					this.Proxylist.Clear();
					foreach (string item in list)
					{
						this.Proxylist.Add(item);
					}
					list.Clear();
					this.LabelProxy.Text = this.Proxylist.Count.ToString();
					this.Logs.AppendText("Loaded " + this.Proxylist.Count + " proxies from API\n");
					this.Logs.ScrollToCaret();
				}
			});
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002999 File Offset: 0x00000B99
		private void Pages_Scroll_Scroll(object sender, ScrollEventArgs e)
		{
			this.Pages_Numeric.Value = this.Pages_Scroll.Value;
			this.Pages = this.Pages_Scroll.Value;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029C8 File Offset: 0x00000BC8
		private void Bots_Numeric_ValueChanged(object sender, EventArgs e)
		{
			this.Bots_Scroll.Value = (int)this.Bots_Numeric.Value;
			this.LabelBots.Text = this.Bots_Scroll.Value.ToString();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002A0E File Offset: 0x00000C0E
		private void Pages_Numeric_ValueChanged(object sender, EventArgs e)
		{
			this.Pages_Scroll.Value = (int)this.Pages_Numeric.Value;
			this.Pages = (int)this.Pages_Numeric.Value;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002A41 File Offset: 0x00000C41
		private void Timeout_Scroll_Scroll(object sender, ScrollEventArgs e)
		{
			this.Timeout_Numeric.Value = this.Timeout_Scroll.Value;
			this.Timeout = this.Timeout_Scroll.Value * 1000;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002A78 File Offset: 0x00000C78
		private void Timeout_Numeric_ValueChanged(object sender, EventArgs e)
		{
			this.Timeout_Scroll.Value = (int)this.Timeout_Numeric.Value;
			this.Timeout = (int)(this.Timeout_Numeric.Value * 1000m);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002B00 File Offset: 0x00000D00
		private void AntipublicCheck(string url)
		{
			Interlocked.Increment(ref this.Gathered);
			try
			{
				if (!url.Contains("http://"))
				{
					if (!url.Contains("https://"))
					{
						goto IL_178;
					}
				}
				try
				{
					string item = url.Split(new char[]
					{
						'/'
					})[2];
					if (url.Contains("="))
					{
						File.WriteAllText("public.txt", url);
					}

					if (!Utilis.AntipublicList.Contains(item))
						{
						 if (this.Domainlist.Contains(item))
						{
							Interlocked.Increment(ref this.Duplicates);
							this.Domainlist.Add(item);
							if (url.Contains("="))
							{
								File.WriteAllText("public.txt", url);
								Utilis.Save("Public.txt", url, "Results");

								Interlocked.Increment(ref this.Private);
								try
								{
									lock (this.urlLock)
									{
										base.Invoke(new Action(delegate()
										{
											this.UrlBox.AppendText(url + "\n");
											this.UrlBox.ScrollToCaret();
										}));
									}
									Utilis.Save("Private.txt", url, "Results");

								}
								catch
								{
								}
								Interlocked.Increment(ref this.Public);
							}
						}
					}
					else
					{
						Interlocked.Increment(ref this.Public);
					}
					goto IL_184;
				}
				catch
				{
					Interlocked.Increment(ref this.Public);
					if (this.savePublicUrls)
					{
						Utilis.Save("Public.txt", url, "Results");
					}
					goto IL_184;
				}
				IL_178:
				Interlocked.Increment(ref this.Public);
				IL_184:;
			}
			catch
			{
				Interlocked.Increment(ref this.Duplicates);
			}
			finally
			{
				this.UpdateLabels();
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002D9C File Offset: 0x00000F9C
		private void Bing(string dork)
		{
			int num = 0;
			int finalLine = 50;
			int i = this.Pages * 50 + 1;
			while (i > finalLine)
			{
				try
				{
					lock (this.logsLock)
					{
						base.Invoke(new Action(delegate()
						{
							this.Logs.AppendText(string.Concat(new object[]
							{
								HttpUtility.UrlDecode(dork),
								" | Page - ",
								finalLine / 50,
								"\n"
							}));
							this.Logs.ScrollToCaret();
						}));
					}
				}
				catch
				{
				}
				string address = string.Concat(new object[]
				{
					"http://www.bing.com/search?q=",
					dork,
					"&first=",
					num,
					"&last=",
					finalLine,
					"&count=50"
				});
				try
				{
					using (Leaf.xNet.HttpRequest httpRequest = new Leaf.xNet.HttpRequest())
					{
						httpRequest.IgnoreProtocolErrors = true;
						httpRequest.IgnoreInvalidCookie = true;
						httpRequest.ConnectTimeout = this.Timeout;
						httpRequest.ReadWriteTimeout = this.Timeout;
						httpRequest.UserAgent = Utilis.RandomUserAgent();
						httpRequest.Referer = "https://bing.com";
						if (!this.Proxyless)
						{
							string proxyAddress = this.RandomProxy();
							if (this.Protocol == "HTTP")
							{
								httpRequest.Proxy = HttpProxyClient.Parse(proxyAddress);
							}
							else if (this.Protocol == "SOCKS4")
							{
								httpRequest.Proxy = Socks4ProxyClient.Parse(proxyAddress);
							}
							else
							{
								httpRequest.Proxy = Socks5ProxyClient.Parse(proxyAddress);
							}
						}
						Leaf.xNet.HttpResponse httpResponse = httpRequest.Get(address, null);
						if (httpResponse.IsOK)
						{
							if (httpResponse.ToString().Contains("There are no results for") || httpResponse.ToString().Contains("Check your spelling or try different keywords"))
							{
								break;
							}
							foreach (object obj2 in Regex.Matches(httpResponse.ToString(), "<a target=\"_blank\" href=\"(.*?)\""))
							{
								Match match = (Match)obj2;
								this.AntipublicCheck(match.Groups[1].Value);
							}
							num += 50;
							finalLine += 50;
						}
						else
						{
							Interlocked.Increment(ref this.Error);
						}
					}
				}
				catch
				{
					Interlocked.Increment(ref this.Error);
				}
			}
			Interlocked.Increment(ref this.Completed);
			this.UpdateLabels();
			this.UpdateProgressBar();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000030AC File Offset: 0x000012AC
		private string RandomProxy()
		{
			return this.Proxylist[this.random.Next(this.Proxylist.Count - 1)];
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000030D1 File Offset: 0x000012D1
		private void Protocol_Dropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Protocol = this.Protocol_Dropdown.Text;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003178 File Offset: 0x00001378
		private void UpdateLabels()
		{
			try
			{
				lock (this.labelLock)
				{
					base.BeginInvoke(new Action(delegate()
					{
						this.LabelCompleted.Text = this.Completed.ToString();
						this.LabelGathered.Text = this.Gathered.ToString();
						this.LabelPublic.Text = this.Public.ToString();
						this.LabelPrivate.Text = this.Private.ToString();
						this.LabelError.Text = this.Error.ToString();
						this.LabelDuplicates.Text = this.Duplicates.ToString();
					}));
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000031F4 File Offset: 0x000013F4
		private void UpdateProgressBar()
		{
			try
			{
				lock (this.urlLock)
				{
					base.Invoke(new Action(delegate()
					{
						this.Progressbar.Value = this.Completed;
					}));
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000001 RID: 1
		public Random random = new Random();

		// Token: 0x04000002 RID: 2
		public List<string> Dorklist = new List<string>();

		// Token: 0x04000003 RID: 3
		public List<string> Proxylist = new List<string>();

		// Token: 0x04000004 RID: 4
		public List<Thread> Threadlist = new List<Thread>();

		// Token: 0x04000005 RID: 5
		public List<string> Domainlist = new List<string>();

		// Token: 0x04000006 RID: 6
		public object labelLock = new object();

		// Token: 0x04000007 RID: 7
		public object logsLock = new object();

		// Token: 0x04000008 RID: 8
		public object urlLock = new object();

		// Token: 0x04000009 RID: 9
		public int Completed;

		// Token: 0x0400000A RID: 10
		public int Gathered;

		// Token: 0x0400000B RID: 11
		public int Private;

		// Token: 0x0400000C RID: 12
		public int Public;

		// Token: 0x0400000D RID: 13
		public int Duplicates;

		// Token: 0x0400000E RID: 14
		public int Error;

		// Token: 0x0400000F RID: 15
		public int Pages = 20;

		// Token: 0x04000010 RID: 16
		public int DorkCounter;

		// Token: 0x04000011 RID: 17
		public int Timeout = 10000;

		// Token: 0x04000012 RID: 18
		public string Protocol = "SOCKS4";

		// Token: 0x04000013 RID: 19
		public bool Proxyless;

		// Token: 0x04000014 RID: 20
		public bool isRunning;

		// Token: 0x04000015 RID: 21
		public bool savePublicUrls = true;

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
