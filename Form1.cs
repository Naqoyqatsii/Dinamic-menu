using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDZ29081
{
	public partial class Form1 : Form
	{
		MenuStrip menuStrip;
		ToolStripMenuItem toolStrip;
		public Form1()
		{
			InitializeComponent();
			menuStrip = new MenuStrip();
			menuStrip.Visible = false;
			Controls.Add(menuStrip);
			
		}

		private void AddPrimary_Click(object sender, EventArgs e)
		{
			if (TopLevelMenu.Text.Length == 0)
			{
				//Тут можно бы вывести сообщение
				//MessageBox.Show("Введите название пункта основного меню!");
				return;
			}
			menuStrip.Visible = true;
			toolStrip = new ToolStripMenuItem(TopLevelMenu.Text);
			toolStrip.MouseDown += ToolStrip_MouseDown;
			menuStrip.Items.Add(toolStrip);
		}

		private void ToolStrip_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				menuStrip.Items.Remove(sender as ToolStripMenuItem);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if(menuStrip.Items.Count == 0)
			{
				//Тут можно бы вывести сообщение
				//MessageBox.Show("Нет ни одного пункта меню!");
				return;
			}
			if(SubItem.Text.Length == 0)
			{
				//Тут можно бы вывести сообщение
				//MessageBox.Show("Введите название пункта подменю!");
				return;
			}
			toolStrip.DropDownItems.Add(SubItem.Text);
		}
	}
}
