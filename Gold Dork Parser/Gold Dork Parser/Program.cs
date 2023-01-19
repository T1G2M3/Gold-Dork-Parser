using Leaf.xNet;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace Gold_Dork_Parser
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00006BF0 File Offset: 0x00004DF0
		[STAThread]
		private static void Main()
	    {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
    }

}

