using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace iCloudJelly.Properties
{
	// Token: 0x0200000C RID: 12
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Resources
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00006A46 File Offset: 0x00004C46
		internal Resources()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00006A50 File Offset: 0x00004C50
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.a == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("iCloudJelly.Properties.Resources", typeof(Resources).Assembly);
					Resources.a = resourceManager;
				}
				return Resources.a;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00006A98 File Offset: 0x00004C98
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00006AAF File Offset: 0x00004CAF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.b;
			}
			set
			{
				Resources.b = value;
			}
		}

		// Token: 0x0400007A RID: 122
		private static ResourceManager a;

		// Token: 0x0400007B RID: 123
		private static CultureInfo b;
	}
}
