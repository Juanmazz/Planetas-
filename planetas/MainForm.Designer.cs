/*
 * Created by SharpDevelop.
 * User: LAB03
 * Date: 4/10/2021
 * Time: 20:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace planetas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pic1;
		private System.Windows.Forms.PictureBox pic3;
		private System.Windows.Forms.PictureBox pic5;
		private System.Windows.Forms.PictureBox pic7;
		private System.Windows.Forms.PictureBox pic8;
		private System.Windows.Forms.PictureBox pic6;
		private System.Windows.Forms.PictureBox pic4;
		private System.Windows.Forms.PictureBox pic2;
		private System.Windows.Forms.PictureBox piccenter;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl3;
		private System.Windows.Forms.Label lbl4;
		private System.Windows.Forms.Label lbl5;
		private System.Windows.Forms.Label lbl6;
		private System.Windows.Forms.Label lbl7;
		private System.Windows.Forms.Label lbl8;
		private System.Windows.Forms.Label lblcenter;
		private System.Windows.Forms.Label lblcenter2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pic1 = new System.Windows.Forms.PictureBox();
			this.pic3 = new System.Windows.Forms.PictureBox();
			this.pic5 = new System.Windows.Forms.PictureBox();
			this.pic7 = new System.Windows.Forms.PictureBox();
			this.pic8 = new System.Windows.Forms.PictureBox();
			this.pic6 = new System.Windows.Forms.PictureBox();
			this.pic4 = new System.Windows.Forms.PictureBox();
			this.pic2 = new System.Windows.Forms.PictureBox();
			this.piccenter = new System.Windows.Forms.PictureBox();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl3 = new System.Windows.Forms.Label();
			this.lbl4 = new System.Windows.Forms.Label();
			this.lbl5 = new System.Windows.Forms.Label();
			this.lbl6 = new System.Windows.Forms.Label();
			this.lbl7 = new System.Windows.Forms.Label();
			this.lbl8 = new System.Windows.Forms.Label();
			this.lblcenter = new System.Windows.Forms.Label();
			this.lblcenter2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.piccenter)).BeginInit();
			this.SuspendLayout();
			// 
			// pic1
			// 
			this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
			this.pic1.Location = new System.Drawing.Point(19, 44);
			this.pic1.Name = "pic1";
			this.pic1.Size = new System.Drawing.Size(111, 109);
			this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic1.TabIndex = 0;
			this.pic1.TabStop = false;
			this.pic1.Tag = "1";
			this.pic1.Click += new System.EventHandler(this.Pic1Click);
			// 
			// pic3
			// 
			this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
			this.pic3.Location = new System.Drawing.Point(19, 184);
			this.pic3.Name = "pic3";
			this.pic3.Size = new System.Drawing.Size(111, 109);
			this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic3.TabIndex = 1;
			this.pic3.TabStop = false;
			this.pic3.Tag = "3";
			this.pic3.Click += new System.EventHandler(this.Pic1Click);
			// 
			// pic5
			// 
			this.pic5.Image = ((System.Drawing.Image)(resources.GetObject("pic5.Image")));
			this.pic5.Location = new System.Drawing.Point(19, 329);
			this.pic5.Name = "pic5";
			this.pic5.Size = new System.Drawing.Size(111, 109);
			this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic5.TabIndex = 2;
			this.pic5.TabStop = false;
			this.pic5.Tag = "5";
			this.pic5.Click += new System.EventHandler(this.Pic1Click);
			// 
			// pic7
			// 
			this.pic7.Image = ((System.Drawing.Image)(resources.GetObject("pic7.Image")));
			this.pic7.Location = new System.Drawing.Point(19, 476);
			this.pic7.Name = "pic7";
			this.pic7.Size = new System.Drawing.Size(111, 109);
			this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic7.TabIndex = 3;
			this.pic7.TabStop = false;
			this.pic7.Tag = "7";
			this.pic7.Click += new System.EventHandler(this.Pic1Click);
			// 
			// pic8
			// 
			this.pic8.Image = ((System.Drawing.Image)(resources.GetObject("pic8.Image")));
			this.pic8.Location = new System.Drawing.Point(160, 476);
			this.pic8.Name = "pic8";
			this.pic8.Size = new System.Drawing.Size(111, 109);
			this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic8.TabIndex = 7;
			this.pic8.TabStop = false;
			this.pic8.Tag = "8";
			this.pic8.Click += new System.EventHandler(this.Pic1Click);
			// 
			// pic6
			// 
			this.pic6.Image = ((System.Drawing.Image)(resources.GetObject("pic6.Image")));
			this.pic6.Location = new System.Drawing.Point(160, 329);
			this.pic6.Name = "pic6";
			this.pic6.Size = new System.Drawing.Size(111, 109);
			this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pic6.TabIndex = 6;
			this.pic6.TabStop = false;
			this.pic6.Tag = "6";
			this.pic6.Click += new System.EventHandler(this.Pic1Click);
			// 
			// pic4
			// 
			this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
			this.pic4.Location = new System.Drawing.Point(160, 184);
			this.pic4.Name = "pic4";
			this.pic4.Size = new System.Drawing.Size(111, 109);
			this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic4.TabIndex = 5;
			this.pic4.TabStop = false;
			this.pic4.Tag = "4";
			this.pic4.Click += new System.EventHandler(this.Pic1Click);
			// 
			// pic2
			// 
			this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
			this.pic2.Location = new System.Drawing.Point(160, 44);
			this.pic2.Name = "pic2";
			this.pic2.Size = new System.Drawing.Size(111, 109);
			this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic2.TabIndex = 4;
			this.pic2.TabStop = false;
			this.pic2.Tag = "2";
			this.pic2.Click += new System.EventHandler(this.Pic1Click);
			// 
			// piccenter
			// 
			this.piccenter.Location = new System.Drawing.Point(523, 44);
			this.piccenter.Name = "piccenter";
			this.piccenter.Size = new System.Drawing.Size(326, 312);
			this.piccenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.piccenter.TabIndex = 8;
			this.piccenter.TabStop = false;
			// 
			// lbl1
			// 
			this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl1.Location = new System.Drawing.Point(19, 153);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(110, 28);
			this.lbl1.TabIndex = 9;
			this.lbl1.Text = "Mercurio";
			this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl2
			// 
			this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl2.Location = new System.Drawing.Point(160, 153);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(110, 28);
			this.lbl2.TabIndex = 10;
			this.lbl2.Text = "Venus";
			this.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl3
			// 
			this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl3.Location = new System.Drawing.Point(19, 293);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(110, 26);
			this.lbl3.TabIndex = 11;
			this.lbl3.Text = "Tierra";
			this.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl4
			// 
			this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl4.Location = new System.Drawing.Point(161, 293);
			this.lbl4.Name = "lbl4";
			this.lbl4.Size = new System.Drawing.Size(110, 26);
			this.lbl4.TabIndex = 12;
			this.lbl4.Text = "Marte ";
			this.lbl4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl5
			// 
			this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl5.Location = new System.Drawing.Point(19, 439);
			this.lbl5.Name = "lbl5";
			this.lbl5.Size = new System.Drawing.Size(110, 25);
			this.lbl5.TabIndex = 13;
			this.lbl5.Text = "Jupiter";
			this.lbl5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl6
			// 
			this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl6.Location = new System.Drawing.Point(161, 439);
			this.lbl6.Name = "lbl6";
			this.lbl6.Size = new System.Drawing.Size(108, 24);
			this.lbl6.TabIndex = 14;
			this.lbl6.Text = "Saturno";
			this.lbl6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl7
			// 
			this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl7.Location = new System.Drawing.Point(19, 586);
			this.lbl7.Name = "lbl7";
			this.lbl7.Size = new System.Drawing.Size(110, 38);
			this.lbl7.TabIndex = 15;
			this.lbl7.Text = "Urano";
			this.lbl7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl8
			// 
			this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl8.Location = new System.Drawing.Point(161, 586);
			this.lbl8.Name = "lbl8";
			this.lbl8.Size = new System.Drawing.Size(109, 37);
			this.lbl8.TabIndex = 16;
			this.lbl8.Text = "Neptuno ";
			this.lbl8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblcenter
			// 
			this.lblcenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcenter.Location = new System.Drawing.Point(564, 371);
			this.lblcenter.Name = "lblcenter";
			this.lblcenter.Size = new System.Drawing.Size(236, 66);
			this.lblcenter.TabIndex = 17;
			this.lblcenter.Text = "label1";
			// 
			// lblcenter2
			// 
			this.lblcenter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcenter2.Location = new System.Drawing.Point(523, 411);
			this.lblcenter2.Name = "lblcenter2";
			this.lblcenter2.Size = new System.Drawing.Size(326, 213);
			this.lblcenter2.TabIndex = 18;
			this.lblcenter2.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(979, 637);
			this.Controls.Add(this.lblcenter2);
			this.Controls.Add(this.lblcenter);
			this.Controls.Add(this.lbl8);
			this.Controls.Add(this.lbl7);
			this.Controls.Add(this.lbl6);
			this.Controls.Add(this.lbl5);
			this.Controls.Add(this.lbl4);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.piccenter);
			this.Controls.Add(this.pic8);
			this.Controls.Add(this.pic6);
			this.Controls.Add(this.pic4);
			this.Controls.Add(this.pic2);
			this.Controls.Add(this.pic7);
			this.Controls.Add(this.pic5);
			this.Controls.Add(this.pic3);
			this.Controls.Add(this.pic1);
			this.Name = "MainForm";
			this.Text = "planetas";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.piccenter)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
