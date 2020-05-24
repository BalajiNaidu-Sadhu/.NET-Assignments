using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Constants;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindLbPlayer(GlobalOjects.allPlayers);
            BindLbGuilds(GlobalOjects.allguilds);
        }

        void BindLbPlayer(Dictionary<uint , Player> PlayersToBind)
        {
            Dictionary<uint, string> players = new Dictionary<uint, string>();
            foreach (var player in PlayersToBind)
            {
                var displayMember = String.Format("{0,-40}{1,20}{2,-10}", player.Value.Name, player.Value.Class, player.Value.Level);
                players.Add(player.Key, displayMember);
            }
            lbPlayers.DataSource = new BindingSource(players.OrderBy(x => x.Value), null);
            lbPlayers.DisplayMember = "Value";
            lbPlayers.ValueMember = "Key";
        }

        void BindLbGuilds(Dictionary<uint, string> guildsToBind)
        {
            Dictionary<uint, string> guilds = new Dictionary<uint, string>();
            foreach (var guild in guildsToBind)
            {
                var guildAndLocation = guild.Value.Split('-');
                var displayMember = String.Format("{0,-40}[{1}]", guildAndLocation[0], guildAndLocation[1]);
                guilds.Add(guild.Key, displayMember);
            }
            lbGuilds.DataSource = new BindingSource(guilds.OrderBy(x => x.Value), null);
            lbGuilds.DisplayMember = "Value";
            lbGuilds.ValueMember = "Key";
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PrintGuildRoster_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.Append(String.Format("Guild Listing for {0}\n",lbGuilds.GetItemText(lbGuilds.SelectedItem).ToString()));
            sb.Append("-----------------------------------------------------------------------------------------------\n");
            var playersInGuild= GlobalOjects.allPlayers.Values.Where(p =>p.GuildID == (uint)lbGuilds.SelectedValue ).ToList();
            playersInGuild.Sort();
            foreach (var player in playersInGuild )
            {
                sb.Append(player.ToString()+"\n");
            }
            rtOutput.Text = sb.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ApplySearchCriteria_Click(object sender, EventArgs e)
        {

        }

        private void LeaveGuild_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
