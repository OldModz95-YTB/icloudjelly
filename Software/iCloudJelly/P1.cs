using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace iCloudJelly
{
	// Token: 0x0200000A RID: 10
	public partial class P1 : Form
	{
		// Token: 0x06000022 RID: 34 RVA: 0x0000521B File Offset: 0x0000341B
		public P1()
		{
			this.a();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005234 File Offset: 0x00003434
		private void e(object A_0, EventArgs A_1)
		{
			this.b.Text = P1.fullVersionInfos;
			this.j.Text = "Version : " + P1.version;
			this.i.Text = "Date de publication : \n" + P1.releaseDate;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000528C File Offset: 0x0000348C
		[DebuggerStepThrough]
		private void d(object A_0, EventArgs A_1)
		{
			P1.a a = new P1.a();
			a.e = this;
			a.c = A_0;
			a.d = A_1;
			a.b = AsyncVoidMethodBuilder.Create();
			a.a = -1;
			a.b.Start<P1.a>(ref a);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000052D4 File Offset: 0x000034D4
		private void c(object A_0, EventArgs A_1)
		{
			deviceManager deviceManager = new deviceManager();
			deviceManager.Show();
			base.Hide();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000052F8 File Offset: 0x000034F8
		private void b(object A_0, EventArgs A_1)
		{
			deviceManager deviceManager = new deviceManager();
			deviceManager.Show();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005313 File Offset: 0x00003513
		private void a(object A_0, FormClosedEventArgs A_1)
		{
			global::a.a();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000531C File Offset: 0x0000351C
		private void a(object A_0, EventArgs A_1)
		{
			Process.Start("https://icloudjelly.com");
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005364 File Offset: 0x00003564
		private void a()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(P1));
			this.b = new Label();
			this.c = new Button();
			this.d = new Label();
			this.e = new Label();
			this.f = new Label();
			this.g = new Label();
			this.h = new Button();
			this.i = new Label();
			this.j = new Label();
			this.k = new GroupBox();
			this.l = new Label();
			this.m = new PictureBox();
			this.n = new PictureBox();
			this.o = new Label();
			this.p = new Button();
			this.q = new Label();
			this.r = new Label();
			this.s = new GroupBox();
			this.t = new Button();
			this.u = new Label();
			this.v = new Label();
			this.w = new Label();
			this.x = new Label();
			this.y = new Label();
			this.z = new PictureBox();
			this.aa = new Label();
			this.k.SuspendLayout();
			((ISupportInitialize)this.m).BeginInit();
			((ISupportInitialize)this.n).BeginInit();
			this.s.SuspendLayout();
			((ISupportInitialize)this.z).BeginInit();
			base.SuspendLayout();
			this.b.AutoSize = true;
			this.b.Font = new Font("Microsoft PhagsPa", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.b.ForeColor = Color.FromArgb(64, 64, 64);
			this.b.Location = new Point(659, 468);
			this.b.Name = "infoVersionReleaseLabel";
			this.b.Size = new Size(168, 20);
			this.b.TabIndex = 10;
			this.b.Text = "INFO VERSION RELEASE";
			this.c.BackColor = Color.FromArgb(0, 0, 64);
			this.c.Cursor = Cursors.Hand;
			this.c.Enabled = false;
			this.c.FlatStyle = FlatStyle.Flat;
			this.c.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.c.ForeColor = Color.White;
			this.c.Location = new Point(5, 417);
			this.c.Name = "contactButton";
			this.c.Size = new Size(192, 54);
			this.c.TabIndex = 30;
			this.c.Text = "Contact";
			this.c.UseVisualStyleBackColor = false;
			this.d.AutoSize = true;
			this.d.Cursor = Cursors.Hand;
			this.d.Font = new Font("Microsoft PhagsPa", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.d.ForeColor = Color.Navy;
			this.d.Location = new Point(862, 9);
			this.d.Name = "activationModifyLink";
			this.d.Size = new Size(64, 17);
			this.d.TabIndex = 29;
			this.d.Text = "Activation";
			this.d.Click += this.b;
			this.e.AutoSize = true;
			this.e.Font = new Font("Microsoft PhagsPa", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.e.ForeColor = Color.FromArgb(192, 0, 0);
			this.e.Location = new Point(713, 27);
			this.e.Name = "label12";
			this.e.Size = new Size(161, 20);
			this.e.TabIndex = 28;
			this.e.Text = "0 déblocages restants";
			this.f.AutoSize = true;
			this.f.Cursor = Cursors.No;
			this.f.Font = new Font("Microsoft PhagsPa", 9.75f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.f.ForeColor = Color.Navy;
			this.f.Location = new Point(791, 81);
			this.f.Name = "label11";
			this.f.Size = new Size(165, 17);
			this.f.TabIndex = 23;
			this.f.Text = "Historique des déblocages";
			this.g.AutoSize = true;
			this.g.Font = new Font("Microsoft PhagsPa", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.g.ForeColor = Color.Red;
			this.g.Location = new Point(730, 8);
			this.g.Name = "label40";
			this.g.Size = new Size(133, 20);
			this.g.TabIndex = 24;
			this.g.Text = "Logiciel non activé";
			this.h.BackColor = Color.MidnightBlue;
			this.h.Cursor = Cursors.Hand;
			this.h.FlatStyle = FlatStyle.Flat;
			this.h.Font = new Font("Microsoft PhagsPa", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.h.ForeColor = Color.White;
			this.h.Location = new Point(237, 344);
			this.h.Name = "LaunchSoftwareButton";
			this.h.Size = new Size(699, 54);
			this.h.TabIndex = 26;
			this.h.Text = "Poursuivre...";
			this.h.UseVisualStyleBackColor = false;
			this.h.Click += this.d;
			this.i.AutoSize = true;
			this.i.Font = new Font("Microsoft PhagsPa", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.i.Location = new Point(6, 57);
			this.i.Name = "releasedatelabel";
			this.i.Size = new Size(90, 20);
			this.i.TabIndex = 8;
			this.i.Text = "release date";
			this.j.AutoSize = true;
			this.j.Font = new Font("Microsoft PhagsPa", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.j.Location = new Point(6, 36);
			this.j.Name = "versionNumberLabel";
			this.j.Size = new Size(86, 20);
			this.j.TabIndex = 7;
			this.j.Text = "version info";
			this.k.Controls.Add(this.i);
			this.k.Controls.Add(this.j);
			this.k.Controls.Add(this.l);
			this.k.Location = new Point(5, 207);
			this.k.Name = "groupBox1";
			this.k.Size = new Size(192, 117);
			this.k.TabIndex = 20;
			this.k.TabStop = false;
			this.l.AutoSize = true;
			this.l.Cursor = Cursors.Hand;
			this.l.Font = new Font("Microsoft PhagsPa", 11.25f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.l.ForeColor = Color.Navy;
			this.l.Location = new Point(6, 16);
			this.l.Name = "label5";
			this.l.Size = new Size(145, 20);
			this.l.TabIndex = 6;
			this.l.Text = "www.icloudjelly.com";
			this.m.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.m.Location = new Point(5, 7);
			this.m.Name = "pictureBox1";
			this.m.Size = new Size(192, 194);
			this.m.SizeMode = PictureBoxSizeMode.StretchImage;
			this.m.TabIndex = 15;
			this.m.TabStop = false;
			this.n.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.n.Location = new Point(711, 9);
			this.n.Name = "pictureBox2";
			this.n.Size = new Size(23, 23);
			this.n.TabIndex = 27;
			this.n.TabStop = false;
			this.o.AutoSize = true;
			this.o.Font = new Font("Microsoft PhagsPa", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.o.ForeColor = Color.FromArgb(192, 0, 0);
			this.o.Location = new Point(714, 47);
			this.o.Name = "label9";
			this.o.Size = new Size(253, 34);
			this.o.TabIndex = 31;
			this.o.Text = "L'activation du logiciel est nécessaire\r\navant de pouvoir débloqué des appareils.";
			this.p.BackColor = Color.FromArgb(0, 0, 64);
			this.p.Cursor = Cursors.Hand;
			this.p.FlatStyle = FlatStyle.Flat;
			this.p.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.p.ForeColor = Color.White;
			this.p.Location = new Point(135, 164);
			this.p.Name = "updateSoftwareButton";
			this.p.Size = new Size(501, 54);
			this.p.TabIndex = 33;
			this.p.Text = "Télécharger la nouvelle version";
			this.p.UseVisualStyleBackColor = false;
			this.p.Visible = false;
			this.p.Click += this.a;
			this.q.AutoSize = true;
			this.q.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.q.ForeColor = Color.Navy;
			this.q.Location = new Point(224, 119);
			this.q.Name = "UpdateAlertLabel";
			this.q.Size = new Size(330, 42);
			this.q.TabIndex = 32;
			this.q.Text = "Votre version du programme est obsolète.\r\nMerci de télécharger la nouvelle version :";
			this.q.Visible = false;
			this.r.AutoSize = true;
			this.r.Font = new Font("Microsoft PhagsPa", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.r.ForeColor = Color.Navy;
			this.r.Location = new Point(254, 87);
			this.r.Name = "label6";
			this.r.Size = new Size(234, 32);
			this.r.TabIndex = 34;
			this.r.Text = "Mise à jour requise";
			this.r.Visible = false;
			this.s.Controls.Add(this.r);
			this.s.Controls.Add(this.q);
			this.s.Controls.Add(this.p);
			this.s.Location = new Point(218, 103);
			this.s.Name = "groupBox2";
			this.s.Size = new Size(749, 308);
			this.s.TabIndex = 34;
			this.s.TabStop = false;
			this.s.Visible = false;
			this.t.BackColor = Color.FromArgb(0, 0, 64);
			this.t.Cursor = Cursors.Hand;
			this.t.Enabled = false;
			this.t.FlatStyle = FlatStyle.Flat;
			this.t.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.t.ForeColor = Color.White;
			this.t.Location = new Point(5, 357);
			this.t.Name = "checkUpdateButton";
			this.t.Size = new Size(192, 54);
			this.t.TabIndex = 22;
			this.t.Text = "Vérifier les mises à jour";
			this.t.UseVisualStyleBackColor = false;
			this.u.AutoSize = true;
			this.u.Font = new Font("Microsoft PhagsPa", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.u.ForeColor = Color.MidnightBlue;
			this.u.Location = new Point(212, 66);
			this.u.Name = "label1";
			this.u.Size = new Size(151, 34);
			this.u.TabIndex = 16;
			this.u.Text = "iCloud Jelly";
			this.v.AutoSize = true;
			this.v.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.v.Location = new Point(214, 103);
			this.v.Name = "label2";
			this.v.Size = new Size(629, 48);
			this.v.TabIndex = 17;
			this.v.Text = "iCloud Jelly est un logiciel permettant de débloquer de façon permanente\r\nun iPhone, iPad ou iPod bloqué iCloud.";
			this.w.AutoSize = true;
			this.w.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.w.ForeColor = Color.MidnightBlue;
			this.w.Location = new Point(213, 151);
			this.w.Name = "label3";
			this.w.Size = new Size(118, 25);
			this.w.TabIndex = 18;
			this.w.Text = "Instructions";
			this.x.AutoSize = true;
			this.x.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.x.Location = new Point(213, 176);
			this.x.Name = "label4";
			this.x.Size = new Size(713, 25);
			this.x.TabIndex = 19;
			this.x.Text = "Avant d'utiliser le logiciel merci de prendre le temps de lire les points suivants : ";
			this.y.AutoSize = true;
			this.y.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.y.Location = new Point(233, 210);
			this.y.Name = "label8";
			this.y.Size = new Size(696, 120);
			this.y.TabIndex = 21;
			this.y.Text = componentResourceManager.GetString("label8.Text");
			this.z.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.z.Location = new Point(4, 328);
			this.z.Name = "pictureBox3";
			this.z.Size = new Size(23, 23);
			this.z.TabIndex = 36;
			this.z.TabStop = false;
			this.aa.AutoSize = true;
			this.aa.Font = new Font("Microsoft PhagsPa", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.aa.ForeColor = Color.Red;
			this.aa.Location = new Point(23, 327);
			this.aa.Name = "label7";
			this.aa.Size = new Size(133, 20);
			this.aa.TabIndex = 35;
			this.aa.Text = "Logiciel non activé";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(979, 497);
			base.Controls.Add(this.s);
			base.Controls.Add(this.z);
			base.Controls.Add(this.aa);
			base.Controls.Add(this.o);
			base.Controls.Add(this.c);
			base.Controls.Add(this.d);
			base.Controls.Add(this.e);
			base.Controls.Add(this.f);
			base.Controls.Add(this.n);
			base.Controls.Add(this.g);
			base.Controls.Add(this.h);
			base.Controls.Add(this.t);
			base.Controls.Add(this.y);
			base.Controls.Add(this.k);
			base.Controls.Add(this.x);
			base.Controls.Add(this.w);
			base.Controls.Add(this.v);
			base.Controls.Add(this.u);
			base.Controls.Add(this.m);
			base.Controls.Add(this.b);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Name = "P1";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "iCloud Jelly (version 1.0.1)";
			base.FormClosed += this.a;
			base.Load += this.e;
			this.k.ResumeLayout(false);
			this.k.PerformLayout();
			((ISupportInitialize)this.m).EndInit();
			((ISupportInitialize)this.n).EndInit();
			this.s.ResumeLayout(false);
			this.s.PerformLayout();
			((ISupportInitialize)this.z).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000053 RID: 83
		public static string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

		// Token: 0x04000054 RID: 84
		public static string releaseDate = "22/07/2020";

		// Token: 0x04000055 RID: 85
		public static string infoVersion = "Version " + P1.version + " Release : " + P1.releaseDate;

		// Token: 0x04000056 RID: 86
		public static string fullVersionInfos = "Version: " + P1.version + " Publication le : " + P1.releaseDate;

		// Token: 0x04000058 RID: 88
		private Label b;

		// Token: 0x04000059 RID: 89
		private Button c;

		// Token: 0x0400005A RID: 90
		private Label d;

		// Token: 0x0400005B RID: 91
		private Label e;

		// Token: 0x0400005C RID: 92
		private Label f;

		// Token: 0x0400005D RID: 93
		private Label g;

		// Token: 0x0400005E RID: 94
		private Button h;

		// Token: 0x0400005F RID: 95
		private Label i;

		// Token: 0x04000060 RID: 96
		private Label j;

		// Token: 0x04000061 RID: 97
		private GroupBox k;

		// Token: 0x04000062 RID: 98
		private Label l;

		// Token: 0x04000063 RID: 99
		private PictureBox m;

		// Token: 0x04000064 RID: 100
		private PictureBox n;

		// Token: 0x04000065 RID: 101
		private Label o;

		// Token: 0x04000066 RID: 102
		private Button p;

		// Token: 0x04000067 RID: 103
		private Label q;

		// Token: 0x04000068 RID: 104
		private Label r;

		// Token: 0x04000069 RID: 105
		private GroupBox s;

		// Token: 0x0400006A RID: 106
		private Button t;

		// Token: 0x0400006B RID: 107
		private Label u;

		// Token: 0x0400006C RID: 108
		private Label v;

		// Token: 0x0400006D RID: 109
		private Label w;

		// Token: 0x0400006E RID: 110
		private Label x;

		// Token: 0x0400006F RID: 111
		private Label y;

		// Token: 0x04000070 RID: 112
		private PictureBox z;

		// Token: 0x04000071 RID: 113
		private Label aa;
	}
}
