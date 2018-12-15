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
	public partial class Win : Form
	{
		public Win(string winner)
		{
			InitializeComponent();
			label1.Text = winner;
			switch (winner)
			{
				case "Werewolfwin":
					break;
				case "Villagerwin":
					BackgroundImage = Properties.Resources.Icon_villager_win;
					//pictureBox1.Image = Properties.Resources.Icon_villager_win;
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
