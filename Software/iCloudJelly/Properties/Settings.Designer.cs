using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace iCloudJelly.Properties
{
	// Token: 0x0200000D RID: 13
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00006AB8 File Offset: 0x00004CB8
		public static Settings Default
		{
			get
			{
				return Settings.a;
			}
		}

		// Token: 0x0400007C RID: 124
		private static Settings a = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
