/*
 * Created by SharpDevelop.
 * User: XTS
 * Date: 3/2/2022
 * Time: 3:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LatihanKelasPV
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
			void Button1Click(object sender, EventArgs e)
			{
				  MessageBox.Show ("Hello World " + this.textBox1.Text);
			}
	}
}
