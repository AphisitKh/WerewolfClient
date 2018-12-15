using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerewolfClient
{
	public partial class myRole : Form
	{
		public myRole(string _myRole)
		{
			InitializeComponent();
			label1.Text = _myRole;
			switch (_myRole)
			{
				case "Werewolf":
					break;
				case "Gunner":
					//BackgroundImage = Properties.Resources.Icon_villager_win;
					pictureBox1.BackgroundImage = Properties.Resources.Icon_gunner;
					break;
			}
		}
		private void Closing_Click(object sender, EventArgs e)
		{
			this.Close();
			//Environment.Exit(0);
		}
	}
}
