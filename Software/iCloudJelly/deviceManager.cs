using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace iCloudJelly
{
	// Token: 0x02000009 RID: 9
	public partial class deviceManager : Form
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003B4A File Offset: 0x00001D4A
		public deviceManager()
		{
			this.a();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003B9C File Offset: 0x00001D9C
		private void a()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(deviceManager));
			this.b = new Label();
			this.c = new Label();
			this.d = new Label();
			this.e = new Label();
			this.f = new GroupBox();
			this.g = new Label();
			this.h = new Button();
			this.i = new Button();
			this.j = new Button();
			this.k = new Button();
			this.l = new Button();
			this.m = new PictureBox();
			this.n = new PictureBox();
			this.o = new Label();
			this.p = new Label();
			this.q = new Label();
			this.r = new Label();
			this.s = new PictureBox();
			this.t = new Label();
			this.u = new Label();
			this.v = new Label();
			this.w = new Label();
			this.x = new Button();
			this.y = new GroupBox();
			this.z = new Label();
			this.aa = new Label();
			this.ab = new PictureBox();
			this.ac = new PictureBox();
			this.ad = new PictureBox();
			((ISupportInitialize)this.m).BeginInit();
			((ISupportInitialize)this.n).BeginInit();
			((ISupportInitialize)this.s).BeginInit();
			this.y.SuspendLayout();
			((ISupportInitialize)this.ab).BeginInit();
			((ISupportInitialize)this.ac).BeginInit();
			((ISupportInitialize)this.ad).BeginInit();
			base.SuspendLayout();
			this.b.AutoSize = true;
			this.b.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.b.ForeColor = Color.FromArgb(64, 64, 64);
			this.b.Location = new Point(34, 398);
			this.b.Name = "label13";
			this.b.Size = new Size(232, 25);
			this.b.TabIndex = 38;
			this.b.Text = "INFORMATIONS ICLOUD";
			this.c.AutoSize = true;
			this.c.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.c.Location = new Point(24, 232);
			this.c.Name = "label28";
			this.c.Size = new Size(190, 24);
			this.c.TabIndex = 26;
			this.c.Text = "Blacklisté opérateur : ";
			this.d.AutoSize = true;
			this.d.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.d.Location = new Point(24, 205);
			this.d.Name = "label25";
			this.d.Size = new Size(171, 24);
			this.d.TabIndex = 24;
			this.d.Text = "Bloqué opérateur : ";
			this.e.AutoSize = true;
			this.e.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.e.Location = new Point(21, 117);
			this.e.Name = "label24";
			this.e.Size = new Size(122, 24);
			this.e.TabIndex = 22;
			this.e.Text = "Version iOS : ";
			this.f.Location = new Point(16, 422);
			this.f.Name = "groupBox2";
			this.f.Size = new Size(558, 78);
			this.f.TabIndex = 39;
			this.f.TabStop = false;
			this.g.AutoSize = true;
			this.g.Cursor = Cursors.Hand;
			this.g.Font = new Font("Microsoft PhagsPa", 11.25f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.g.ForeColor = Color.Navy;
			this.g.Location = new Point(764, 43);
			this.g.Name = "label30";
			this.g.Size = new Size(145, 20);
			this.g.TabIndex = 46;
			this.g.Text = "www.icloudjelly.com";
			this.h.BackColor = Color.Teal;
			this.h.Cursor = Cursors.Hand;
			this.h.FlatStyle = FlatStyle.Flat;
			this.h.Font = new Font("Microsoft PhagsPa", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.h.ForeColor = Color.White;
			this.h.ImageAlign = ContentAlignment.MiddleLeft;
			this.h.Location = new Point(698, 645);
			this.h.Name = "button5";
			this.h.Size = new Size(192, 52);
			this.h.TabIndex = 45;
			this.h.Text = "Consulter les cycles de batterie";
			this.h.UseVisualStyleBackColor = false;
			this.i.BackColor = Color.Green;
			this.i.Cursor = Cursors.Hand;
			this.i.FlatStyle = FlatStyle.Flat;
			this.i.Font = new Font("Microsoft PhagsPa", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.i.ForeColor = Color.White;
			this.i.Location = new Point(10, 510);
			this.i.Name = "button4";
			this.i.Size = new Size(564, 54);
			this.i.TabIndex = 44;
			this.i.Text = "Démarrer le processus de déblocage";
			this.i.UseVisualStyleBackColor = false;
			this.j.BackColor = Color.Teal;
			this.j.Cursor = Cursors.Hand;
			this.j.FlatStyle = FlatStyle.Flat;
			this.j.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.j.ForeColor = Color.White;
			this.j.Image = (Image)componentResourceManager.GetObject("button3.Image");
			this.j.ImageAlign = ContentAlignment.MiddleLeft;
			this.j.Location = new Point(698, 603);
			this.j.Name = "button3";
			this.j.Size = new Size(192, 38);
			this.j.TabIndex = 43;
			this.j.Text = "Mode DFU";
			this.j.UseVisualStyleBackColor = false;
			this.k.BackColor = Color.Teal;
			this.k.Cursor = Cursors.Hand;
			this.k.FlatStyle = FlatStyle.Flat;
			this.k.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.k.ForeColor = Color.White;
			this.k.Image = (Image)componentResourceManager.GetObject("button2.Image");
			this.k.ImageAlign = ContentAlignment.MiddleLeft;
			this.k.Location = new Point(698, 562);
			this.k.Name = "button2";
			this.k.Size = new Size(192, 39);
			this.k.TabIndex = 42;
			this.k.Text = "Redémarrer";
			this.k.UseVisualStyleBackColor = false;
			this.l.BackColor = Color.Teal;
			this.l.Cursor = Cursors.Hand;
			this.l.FlatStyle = FlatStyle.Flat;
			this.l.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.l.ForeColor = Color.White;
			this.l.Image = (Image)componentResourceManager.GetObject("button1.Image");
			this.l.ImageAlign = ContentAlignment.MiddleLeft;
			this.l.Location = new Point(698, 521);
			this.l.Name = "button1";
			this.l.Size = new Size(192, 39);
			this.l.TabIndex = 41;
			this.l.Text = "Ouvrir dans iTunes";
			this.l.UseVisualStyleBackColor = false;
			this.m.Image = (Image)componentResourceManager.GetObject("pictureBox5.Image");
			this.m.Location = new Point(17, 404);
			this.m.Name = "pictureBox5";
			this.m.Size = new Size(20, 23);
			this.m.TabIndex = 40;
			this.m.TabStop = false;
			this.n.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
			this.n.Location = new Point(12, 66);
			this.n.Name = "pictureBox4";
			this.n.Size = new Size(29, 23);
			this.n.TabIndex = 30;
			this.n.TabStop = false;
			this.o.AutoSize = true;
			this.o.Font = new Font("Microsoft PhagsPa", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.o.ForeColor = Color.MidnightBlue;
			this.o.Location = new Point(12, 9);
			this.o.Name = "label1";
			this.o.Size = new Size(167, 34);
			this.o.TabIndex = 31;
			this.o.Text = "Device name";
			this.p.AutoSize = true;
			this.p.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.p.Location = new Point(25, 256);
			this.p.Name = "label21";
			this.p.Size = new Size(204, 24);
			this.p.TabIndex = 20;
			this.p.Text = "Numéro de téléphone :";
			this.q.AutoSize = true;
			this.q.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.q.ForeColor = Color.FromArgb(64, 64, 64);
			this.q.Location = new Point(29, 61);
			this.q.Name = "label2";
			this.q.Size = new Size(308, 25);
			this.q.TabIndex = 32;
			this.q.Text = "INFORMATIONS SUR L'APPAREIL";
			this.r.AutoSize = true;
			this.r.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.r.ForeColor = Color.ForestGreen;
			this.r.Location = new Point(612, 566);
			this.r.Name = "label11";
			this.r.Size = new Size(48, 25);
			this.r.TabIndex = 35;
			this.r.Text = "N/A";
			this.s.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.s.Location = new Point(610, 572);
			this.s.Name = "pictureBox2";
			this.s.Size = new Size(69, 58);
			this.s.SizeMode = PictureBoxSizeMode.StretchImage;
			this.s.TabIndex = 34;
			this.s.TabStop = false;
			this.t.AutoSize = true;
			this.t.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.t.Location = new Point(24, 92);
			this.t.Name = "label17";
			this.t.Size = new Size(61, 24);
			this.t.TabIndex = 18;
			this.t.Text = "IMEI : ";
			this.u.AutoSize = true;
			this.u.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.u.Location = new Point(17, 33);
			this.u.Name = "label3";
			this.u.Size = new Size(174, 24);
			this.u.TabIndex = 6;
			this.u.Text = "Nom de l'appareil : ";
			this.v.AutoSize = true;
			this.v.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.v.Location = new Point(22, 63);
			this.v.Name = "label5";
			this.v.Size = new Size(83, 24);
			this.v.TabIndex = 8;
			this.v.Text = "Modèle :";
			this.w.AutoSize = true;
			this.w.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.w.Location = new Point(24, 144);
			this.w.Name = "label7";
			this.w.Size = new Size(257, 24);
			this.w.TabIndex = 10;
			this.w.Text = "Date de première activation : ";
			this.x.BackColor = Color.FromArgb(64, 64, 64);
			this.x.Cursor = Cursors.Hand;
			this.x.FlatStyle = FlatStyle.Flat;
			this.x.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.x.ForeColor = Color.White;
			this.x.Image = (Image)componentResourceManager.GetObject("button6.Image");
			this.x.ImageAlign = ContentAlignment.MiddleLeft;
			this.x.Location = new Point(16, 570);
			this.x.Name = "button6";
			this.x.Size = new Size(560, 47);
			this.x.TabIndex = 47;
			this.x.Text = "Restaurer l'appareil";
			this.x.UseVisualStyleBackColor = false;
			this.y.Controls.Add(this.c);
			this.y.Controls.Add(this.d);
			this.y.Controls.Add(this.e);
			this.y.Controls.Add(this.p);
			this.y.Controls.Add(this.t);
			this.y.Controls.Add(this.u);
			this.y.Controls.Add(this.v);
			this.y.Controls.Add(this.w);
			this.y.Controls.Add(this.z);
			this.y.Location = new Point(18, 90);
			this.y.Name = "groupBox1";
			this.y.Size = new Size(558, 305);
			this.y.TabIndex = 37;
			this.y.TabStop = false;
			this.z.AutoSize = true;
			this.z.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.z.Location = new Point(25, 177);
			this.z.Name = "label9";
			this.z.Size = new Size(110, 24);
			this.z.TabIndex = 12;
			this.z.Text = "Opérateur : ";
			this.aa.AutoSize = true;
			this.aa.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.aa.ForeColor = Color.FromArgb(64, 64, 64);
			this.aa.Location = new Point(603, 542);
			this.aa.Name = "label12";
			this.aa.Size = new Size(89, 24);
			this.aa.TabIndex = 36;
			this.aa.Text = "BATTERIE";
			this.ab.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.ab.Location = new Point(617, 74);
			this.ab.Name = "pictureBox1";
			this.ab.Size = new Size(265, 437);
			this.ab.SizeMode = PictureBoxSizeMode.StretchImage;
			this.ab.TabIndex = 33;
			this.ab.TabStop = false;
			this.ac.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.ac.Location = new Point(617, 74);
			this.ac.Name = "pictureBox3";
			this.ac.Size = new Size(265, 437);
			this.ac.SizeMode = PictureBoxSizeMode.StretchImage;
			this.ac.TabIndex = 48;
			this.ac.TabStop = false;
			this.ad.Image = (Image)componentResourceManager.GetObject("pictureBox6.Image");
			this.ad.Location = new Point(617, 74);
			this.ad.Name = "pictureBox6";
			this.ad.Size = new Size(265, 437);
			this.ad.SizeMode = PictureBoxSizeMode.StretchImage;
			this.ad.TabIndex = 49;
			this.ad.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(930, 706);
			base.Controls.Add(this.ad);
			base.Controls.Add(this.ac);
			base.Controls.Add(this.b);
			base.Controls.Add(this.f);
			base.Controls.Add(this.g);
			base.Controls.Add(this.h);
			base.Controls.Add(this.i);
			base.Controls.Add(this.j);
			base.Controls.Add(this.k);
			base.Controls.Add(this.l);
			base.Controls.Add(this.m);
			base.Controls.Add(this.n);
			base.Controls.Add(this.o);
			base.Controls.Add(this.q);
			base.Controls.Add(this.r);
			base.Controls.Add(this.s);
			base.Controls.Add(this.ab);
			base.Controls.Add(this.x);
			base.Controls.Add(this.y);
			base.Controls.Add(this.aa);
			base.Name = "deviceManager";
			this.Text = "deviceManager";
			((ISupportInitialize)this.m).EndInit();
			((ISupportInitialize)this.n).EndInit();
			((ISupportInitialize)this.s).EndInit();
			this.y.ResumeLayout(false);
			this.y.PerformLayout();
			((ISupportInitialize)this.ab).EndInit();
			((ISupportInitialize)this.ac).EndInit();
			((ISupportInitialize)this.ad).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000036 RID: 54
		private Label b;

		// Token: 0x04000037 RID: 55
		private Label c;

		// Token: 0x04000038 RID: 56
		private Label d;

		// Token: 0x04000039 RID: 57
		private Label e;

		// Token: 0x0400003A RID: 58
		private GroupBox f;

		// Token: 0x0400003B RID: 59
		private Label g;

		// Token: 0x0400003C RID: 60
		private Button h;

		// Token: 0x0400003D RID: 61
		private Button i;

		// Token: 0x0400003E RID: 62
		private Button j;

		// Token: 0x0400003F RID: 63
		private Button k;

		// Token: 0x04000040 RID: 64
		private Button l;

		// Token: 0x04000041 RID: 65
		private PictureBox m;

		// Token: 0x04000042 RID: 66
		private PictureBox n;

		// Token: 0x04000043 RID: 67
		private Label o;

		// Token: 0x04000044 RID: 68
		private Label p;

		// Token: 0x04000045 RID: 69
		private Label q;

		// Token: 0x04000046 RID: 70
		private Label r;

		// Token: 0x04000047 RID: 71
		private PictureBox s;

		// Token: 0x04000048 RID: 72
		private Label t;

		// Token: 0x04000049 RID: 73
		private Label u;

		// Token: 0x0400004A RID: 74
		private Label v;

		// Token: 0x0400004B RID: 75
		private Label w;

		// Token: 0x0400004C RID: 76
		private Button x;

		// Token: 0x0400004D RID: 77
		private GroupBox y;

		// Token: 0x0400004E RID: 78
		private Label z;

		// Token: 0x0400004F RID: 79
		private Label aa;

		// Token: 0x04000050 RID: 80
		private PictureBox ab;

		// Token: 0x04000051 RID: 81
		private PictureBox ac;

		// Token: 0x04000052 RID: 82
		private PictureBox ad;
	}
}
