using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace iCloudJelly
{
	// Token: 0x02000003 RID: 3
	public partial class Activation : Form
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000209B File Offset: 0x0000029B
		public Activation()
		{
			this.a();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020B4 File Offset: 0x000002B4
		private void f(object A_0, EventArgs A_1)
		{
			bool flag = this.o.Text.Length == 0;
			if (flag)
			{
				this.p.Text = "Erreur : le champ ne doit pas rester vide";
				this.p.ForeColor = Color.Red;
				this.p.Visible = true;
			}
			else
			{
				bool flag2 = this.o.Text.Length < 10;
				if (flag2)
				{
					this.p.Text = "Erreur : le format du code est incorrect";
					this.p.ForeColor = Color.Red;
					this.p.Visible = true;
				}
				else
				{
					global::c.a(this.o.Text);
					this.q.Enabled = false;
					this.x.Start();
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002183 File Offset: 0x00000383
		private void e(object A_0, EventArgs A_1)
		{
			this.s.Text = P1.fullVersionInfos;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002197 File Offset: 0x00000397
		private void a(object A_0, FormClosedEventArgs A_1)
		{
			global::a.a();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021A0 File Offset: 0x000003A0
		private void d(object A_0, EventArgs A_1)
		{
			Process.Start("https://www.recharge.fr/carte-pcs");
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021AE File Offset: 0x000003AE
		private void c(object A_0, EventArgs A_1)
		{
			Process.Start("https://www.becharge.fr/fr-fr/Acheter/Paiements-en-ligne-PCS-2-188");
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021BC File Offset: 0x000003BC
		private void b(object A_0, EventArgs A_1)
		{
			Process.Start("https://www.mypcs.com/points-de-vente/");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021CC File Offset: 0x000003CC
		private void a(object A_0, EventArgs A_1)
		{
			this.y.Increment(1);
			this.p.Visible = false;
			this.p.Text = "Vérification de votre code en cours...";
			this.p.ForeColor = Color.DarkOliveGreen;
			this.p.Visible = true;
			this.q.Enabled = false;
			bool flag = this.y.Value == this.y.Maximum;
			if (flag)
			{
				this.x.Stop();
				this.y.Value = 0;
				bool flag2 = !Array.Exists<string>(global::a.a, new Predicate<string>(this.a));
				if (flag2)
				{
					this.p.Text = "Erreur : le code entré est incorrect";
				}
				else
				{
					this.p.Text = "Erreur : le nombre de déblocage maximal avec ce coupon a été atteint. (10 déblocages effectués)";
				}
				this.p.ForeColor = Color.Red;
				this.q.Enabled = true;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002304 File Offset: 0x00000504
		private void a()
		{
			this.a = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Activation));
			this.b = new Label();
			this.c = new Label();
			this.d = new Label();
			this.e = new Label();
			this.f = new Label();
			this.g = new Label();
			this.h = new Label();
			this.i = new Label();
			this.j = new Label();
			this.k = new Label();
			this.l = new Label();
			this.m = new Label();
			this.n = new GroupBox();
			this.q = new Button();
			this.p = new Label();
			this.o = new TextBox();
			this.r = new PictureBox();
			this.s = new Label();
			this.t = new Label();
			this.u = new Label();
			this.v = new Label();
			this.w = new Label();
			this.x = new Timer(this.a);
			this.y = new ProgressBar();
			this.n.SuspendLayout();
			((ISupportInitialize)this.r).BeginInit();
			base.SuspendLayout();
			this.b.AutoSize = true;
			this.b.Font = new Font("Microsoft PhagsPa", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.b.ForeColor = Color.MidnightBlue;
			this.b.Location = new Point(300, 11);
			this.b.Name = "label1";
			this.b.Size = new Size(408, 34);
			this.b.TabIndex = 17;
			this.b.Text = "Activation du logiciel iCloud Jelly";
			this.c.AutoSize = true;
			this.c.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.c.Location = new Point(44, 55);
			this.c.Name = "versionNumberLabel";
			this.c.Size = new Size(908, 24);
			this.c.TabIndex = 18;
			this.c.Text = "Avant de pouvoir commencé à utiliser le logiciel et débloquer des appareils, une activation sera nécessaire.";
			this.d.AutoSize = true;
			this.d.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.d.ForeColor = Color.MidnightBlue;
			this.d.Location = new Point(44, 88);
			this.d.Name = "label2";
			this.d.Size = new Size(231, 21);
			this.d.TabIndex = 19;
			this.d.Text = "Comment activer le logiciel ?";
			this.e.AutoSize = true;
			this.e.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.e.Location = new Point(44, 109);
			this.e.Name = "label3";
			this.e.Size = new Size(427, 21);
			this.e.TabIndex = 20;
			this.e.Text = "L'activation se fait via une recharge PCS d'une valeur de 20€";
			this.f.AutoSize = true;
			this.f.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.f.Location = new Point(44, 165);
			this.f.Name = "label4";
			this.f.Size = new Size(547, 21);
			this.f.TabIndex = 22;
			this.f.Text = "Vous pouvez acheter une recharge en ligne (réception immédiate par e-mail) :";
			this.g.AutoSize = true;
			this.g.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.g.ForeColor = Color.MidnightBlue;
			this.g.Location = new Point(44, 144);
			this.g.Name = "label5";
			this.g.Size = new Size(334, 21);
			this.g.TabIndex = 21;
			this.g.Text = "Où peut-on se procurer une recharge PCS ?";
			this.h.AutoSize = true;
			this.h.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.h.ForeColor = Color.MidnightBlue;
			this.h.Location = new Point(42, 283);
			this.h.Name = "label6";
			this.h.Size = new Size(243, 21);
			this.h.TabIndex = 23;
			this.h.Text = "Combien de fois faut-il payer ?";
			this.i.AutoSize = true;
			this.i.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.i.Location = new Point(42, 304);
			this.i.Name = "label7";
			this.i.Size = new Size(405, 21);
			this.i.TabIndex = 24;
			this.i.Text = "Un seul paiement via une recharge de 20€ est nécessaire.";
			this.j.AutoSize = true;
			this.j.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.j.ForeColor = Color.MidnightBlue;
			this.j.Location = new Point(42, 335);
			this.j.Name = "label8";
			this.j.Size = new Size(330, 21);
			this.j.TabIndex = 25;
			this.j.Text = "Combien de déblocage je peux effectuer ?";
			this.k.AutoSize = true;
			this.k.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.k.Location = new Point(42, 361);
			this.k.Name = "label9";
			this.k.Size = new Size(264, 21);
			this.k.TabIndex = 26;
			this.k.Text = "Après l'activation, vous aurez le droit";
			this.l.AutoSize = true;
			this.l.Font = new Font("Microsoft PhagsPa", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.l.Location = new Point(18, 394);
			this.l.Name = "label11";
			this.l.Size = new Size(783, 27);
			this.l.TabIndex = 33;
			this.l.Text = "Une fois que vous aurez votre recharge PCS de 20€, vous pouvez activer le logiciel :";
			this.m.AutoSize = true;
			this.m.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m.ForeColor = Color.MidnightBlue;
			this.m.Location = new Point(17, 16);
			this.m.Name = "label12";
			this.m.Size = new Size(398, 25);
			this.m.TabIndex = 34;
			this.m.Text = "Entrez le code de la recharge PCS (20 EUR) :";
			this.n.Controls.Add(this.q);
			this.n.Controls.Add(this.p);
			this.n.Controls.Add(this.o);
			this.n.Controls.Add(this.m);
			this.n.Location = new Point(12, 424);
			this.n.Name = "groupBox1";
			this.n.Size = new Size(982, 142);
			this.n.TabIndex = 35;
			this.n.TabStop = false;
			this.q.BackColor = Color.FromArgb(0, 0, 64);
			this.q.Cursor = Cursors.Hand;
			this.q.FlatStyle = FlatStyle.Flat;
			this.q.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.q.ForeColor = Color.White;
			this.q.Location = new Point(637, 50);
			this.q.Name = "softwareActivationButton";
			this.q.Size = new Size(293, 48);
			this.q.TabIndex = 36;
			this.q.Text = "Activer le logiciel";
			this.q.UseVisualStyleBackColor = false;
			this.q.Click += this.f;
			this.p.AutoSize = true;
			this.p.Font = new Font("Microsoft PhagsPa", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p.Location = new Point(18, 104);
			this.p.Name = "softwareActivationStatusLabel";
			this.p.Size = new Size(243, 25);
			this.p.TabIndex = 36;
			this.p.Text = "Status Activation Message";
			this.p.Visible = false;
			this.o.Font = new Font("Courier New", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.o.Location = new Point(22, 56);
			this.o.MaxLength = 10;
			this.o.Name = "pcsActivationTextbox";
			this.o.Size = new Size(609, 31);
			this.o.TabIndex = 35;
			this.r.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.r.Location = new Point(220, 2);
			this.r.Name = "pictureBox1";
			this.r.Size = new Size(74, 50);
			this.r.TabIndex = 36;
			this.r.TabStop = false;
			this.s.AutoSize = true;
			this.s.Font = new Font("Microsoft PhagsPa", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.s.ForeColor = Color.Gray;
			this.s.Location = new Point(706, 23);
			this.s.Name = "infoVersionReleaseLabel";
			this.s.Size = new Size(168, 20);
			this.s.TabIndex = 41;
			this.s.Text = "INFO VERSION RELEASE";
			this.t.AutoSize = true;
			this.t.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.t.ForeColor = Color.Green;
			this.t.Location = new Point(300, 361);
			this.t.Name = "label16";
			this.t.Size = new Size(136, 21);
			this.t.TabIndex = 44;
			this.t.Text = "à 10 déblocages.";
			this.u.AutoSize = true;
			this.u.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.u.Location = new Point(43, 199);
			this.u.Name = "label17";
			this.u.Size = new Size(403, 21);
			this.u.TabIndex = 45;
			this.u.Text = "Sites web sécurisés vendant des recharges en ligne :";
			this.v.AutoSize = true;
			this.v.Cursor = Cursors.Hand;
			this.v.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.v.ForeColor = Color.FromArgb(0, 0, 192);
			this.v.Location = new Point(42, 220);
			this.v.Name = "label18";
			this.v.Size = new Size(243, 21);
			this.v.TabIndex = 46;
			this.v.Text = "https://www.recharge.fr/carte-pcs";
			this.v.Click += this.d;
			this.w.AutoSize = true;
			this.w.Cursor = Cursors.Hand;
			this.w.Font = new Font("Microsoft PhagsPa", 12f, FontStyle.Underline, GraphicsUnit.Point, 0);
			this.w.ForeColor = Color.FromArgb(0, 0, 192);
			this.w.Location = new Point(43, 251);
			this.w.Name = "label19";
			this.w.Size = new Size(493, 21);
			this.w.TabIndex = 47;
			this.w.Text = "https://www.becharge.fr/fr-fr/Acheter/Paiements-en-ligne-PCS-2-188";
			this.w.Click += this.c;
			this.x.Tick += this.a;
			this.y.Location = new Point(12, 11);
			this.y.Maximum = 50;
			this.y.Name = "progressBar1";
			this.y.Size = new Size(24, 23);
			this.y.TabIndex = 48;
			this.y.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(1055, 581);
			base.Controls.Add(this.y);
			base.Controls.Add(this.w);
			base.Controls.Add(this.v);
			base.Controls.Add(this.u);
			base.Controls.Add(this.t);
			base.Controls.Add(this.s);
			base.Controls.Add(this.r);
			base.Controls.Add(this.n);
			base.Controls.Add(this.l);
			base.Controls.Add(this.k);
			base.Controls.Add(this.j);
			base.Controls.Add(this.i);
			base.Controls.Add(this.h);
			base.Controls.Add(this.f);
			base.Controls.Add(this.g);
			base.Controls.Add(this.e);
			base.Controls.Add(this.d);
			base.Controls.Add(this.c);
			base.Controls.Add(this.b);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Name = "Activation";
			base.ShowIcon = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Activation";
			base.FormClosed += this.a;
			base.Load += this.e;
			this.n.ResumeLayout(false);
			this.n.PerformLayout();
			((ISupportInitialize)this.r).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003455 File Offset: 0x00001655
		[CompilerGenerated]
		private bool a(string A_0)
		{
			return A_0 == this.o.Text;
		}

		// Token: 0x04000004 RID: 4
		private Label b;

		// Token: 0x04000005 RID: 5
		private Label c;

		// Token: 0x04000006 RID: 6
		private Label d;

		// Token: 0x04000007 RID: 7
		private Label e;

		// Token: 0x04000008 RID: 8
		private Label f;

		// Token: 0x04000009 RID: 9
		private Label g;

		// Token: 0x0400000A RID: 10
		private Label h;

		// Token: 0x0400000B RID: 11
		private Label i;

		// Token: 0x0400000C RID: 12
		private Label j;

		// Token: 0x0400000D RID: 13
		private Label k;

		// Token: 0x0400000E RID: 14
		private Label l;

		// Token: 0x0400000F RID: 15
		private Label m;

		// Token: 0x04000010 RID: 16
		private GroupBox n;

		// Token: 0x04000011 RID: 17
		private TextBox o;

		// Token: 0x04000012 RID: 18
		private Label p;

		// Token: 0x04000013 RID: 19
		private Button q;

		// Token: 0x04000014 RID: 20
		private PictureBox r;

		// Token: 0x04000015 RID: 21
		private Label s;

		// Token: 0x04000016 RID: 22
		private Label t;

		// Token: 0x04000017 RID: 23
		private Label u;

		// Token: 0x04000018 RID: 24
		private Label v;

		// Token: 0x04000019 RID: 25
		private Label w;

		// Token: 0x0400001A RID: 26
		private Timer x;

		// Token: 0x0400001B RID: 27
		private ProgressBar y;
	}
}
