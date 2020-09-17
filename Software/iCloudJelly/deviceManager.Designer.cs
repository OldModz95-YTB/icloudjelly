namespace iCloudJelly
{
	// Token: 0x02000009 RID: 9
	public partial class deviceManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00003B64 File Offset: 0x00001D64
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.a != null;
			if (flag)
			{
				this.a.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x04000035 RID: 53
		private global::System.ComponentModel.IContainer a = null;
	}
}
