using System;
using System.Windows.Forms;
using iCloudJelly;

// Token: 0x02000005 RID: 5
internal static class b
{
	// Token: 0x06000012 RID: 18 RVA: 0x000034C8 File Offset: 0x000016C8
	[STAThread]
	private static void a()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		bool result = c.b().Result;
		if (result)
		{
			P1 p = new P1();
			p.Show();
			Application.Run();
		}
		else
		{
			Application.Exit();
		}
	}
}
