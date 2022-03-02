/*
 * Created by SharpDevelop.
 * User: XTS
 * Date: 3/2/2022
 * Time: 2:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LatihanKelas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.nameInput = new System.Windows.Forms.TextBox();
			this.nimInput = new System.Windows.Forms.TextBox();
			this.classInput = new System.Windows.Forms.TextBox();
			this.matkulInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(127, 203);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// nameInput
			// 
			this.nameInput.Location = new System.Drawing.Point(145, 40);
			this.nameInput.Name = "nameInput";
			this.nameInput.Size = new System.Drawing.Size(168, 20);
			this.nameInput.TabIndex = 1;
			// 
			// nimInput
			// 
			this.nimInput.Location = new System.Drawing.Point(145, 80);
			this.nimInput.Name = "nimInput";
			this.nimInput.Size = new System.Drawing.Size(168, 20);
			this.nimInput.TabIndex = 2;
			// 
			// classInput
			// 
			this.classInput.Location = new System.Drawing.Point(145, 120);
			this.classInput.Name = "classInput";
			this.classInput.Size = new System.Drawing.Size(168, 20);
			this.classInput.TabIndex = 3;
			// 
			// matkulInput
			// 
			this.matkulInput.Location = new System.Drawing.Point(145, 156);
			this.matkulInput.Name = "matkulInput";
			this.matkulInput.Size = new System.Drawing.Size(168, 20);
			this.matkulInput.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(92, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nama : ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(92, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "NIM : ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(92, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Kelas : ";

			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(64, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Mata Kuliah : ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 261);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.matkulInput);
			this.Controls.Add(this.classInput);
			this.Controls.Add(this.nimInput);
			this.Controls.Add(this.nameInput);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "LatihanKelas";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox matkulInput;
		private System.Windows.Forms.TextBox classInput;
		private System.Windows.Forms.TextBox nimInput;
		private System.Windows.Forms.TextBox nameInput;
		private System.Windows.Forms.Button button1;
	}
}
