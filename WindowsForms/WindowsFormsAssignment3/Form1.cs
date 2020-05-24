using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsAssignment3.Constants;

namespace WindowsFormsAssignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbClass.DataSource = Enum.GetValues(typeof(Constants.Classes));
            cbClass.SelectedItem = null;          
            cbServer.DataSource = GetServers();
            cbServer.SelectedItem = null;
            cbPercentageServer.DataSource = GetServers();
            cbPercentageServer.SelectedItem = null;
            nudMinAllRoll.Maximum = Constants.MAX_LEVEL;
            nudMaxAllRoll.Maximum = Constants.MAX_LEVEL;
            cbAllRoll.DataSource = Enum.GetValues(typeof(Constants.Role));
            cbAllRoll.SelectedItem = null;
            cbAllRollServer.DataSource = GetServers();
            cbAllRollServer.SelectedItem = null;
            Dictionary<uint, string> guildTypes = new Dictionary<uint, string>();
            guildTypes.Add(0, "Causal");
            guildTypes.Add(1, "Questing");
            guildTypes.Add(2, "Mythic+");
            guildTypes.Add(3, "Raiding");
            guildTypes.Add(4, "PVP");
            cbGuildTypes.DataSource = new BindingSource(guildTypes, null);
            cbGuildTypes.DisplayMember = "Value";
            cbGuildTypes.ValueMember = "Key";
            cbGuildTypes.SelectedItem = null;
        }

        private List<string> GetServers()
        {
            List<string> servers = new List<string>();
            foreach (var guild in GlobalOjects.allguilds.Values)
            {
                if (!servers.Contains(guild.Server))
                    servers.Add(guild.Server);
            }
            return servers;
        }

        private void allClassTypes_Click(object sender, EventArgs e)
        {
            if (cbClass.SelectedValue == null)
            {
                rtbQuery.Text = "Please select a Class Type to complete this query";
                return;
            }
            if (cbServer.SelectedValue == null)
            {
                rtbQuery.Text = "Please select a Server to complete this query";
                return;
            }
            var @class = (Classes)cbClass.SelectedValue;
            var server = cbServer.SelectedValue.ToString();
            var classPlayersList = GlobalOjects.allPlayers.Values.Where(p => p.Class == @class).ToList();
            var serverGuildsList = GlobalOjects.allguilds.Values.Where(g => g.Server == server).ToList();
            var allPlayers = (from p in classPlayersList
                              join s in serverGuildsList on p.GuildID equals s.Id
                              orderby p.Level
                              select p).ToList();
            var sb = new StringBuilder();
            if (allPlayers.Any())
            {
                sb.Append(string.Format("All {0} from {1}\n", @class, server));
                sb.Append("--------------------------------------------\n");
                foreach (var player in allPlayers)
                {
                    sb.Append(player.ToString() + "\n");
                }
                sb.Append("END RESULTS\n");
                sb.Append("--------------------------------------------\n");
                rtbQuery.Text = sb.ToString();
            }
            else
            {
                rtbQuery.Text = "No Results";
            }

        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (cbPercentageServer.SelectedValue == null)
            {
                rtbQuery.Text = "Please select a Server to complete this query";
                return;
            }
            var server = cbPercentageServer.SelectedValue.ToString();

            var serverGuildsList = GlobalOjects.allguilds.Values.Where(g => g.Server == server).ToList();
            var allPlayers = (from p in GlobalOjects.allPlayers.Values
                              join s in serverGuildsList on p.GuildID equals s.Id
                              select p).ToList();
            var playerByGroup = from player in allPlayers
                                group player by player.Race into player
                                orderby player.Key
                                select player;

            var sb = new StringBuilder();
            sb.Append("Percentage of Each Race from " + server + "\n");
            sb.Append("--------------------------------------------\n");
            foreach (var player in playerByGroup)
            {
                sb.Append(string.Format("{0}:{1}%\n", player.Key, Math.Round((player.Count() * 100m / allPlayers.Count()), 2)));

            }
            sb.Append("END RESULTS\n");
            sb.Append("--------------------------------------------\n");
            rtbQuery.Text = sb.ToString();

        }

        private void nudMinAllRoll_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinAllRoll.Value > nudMaxAllRoll.Value)
            {
                nudMaxAllRoll.Value = nudMinAllRoll.Value + 1 >= Constants.MAX_LEVEL ? Constants.MAX_LEVEL : nudMinAllRoll.Value + 1;
            }
        }

        private void nudMaxAllRoll_ValueChanged(object sender, EventArgs e)
        {
            if (nudMaxAllRoll.Value < nudMinAllRoll.Value)
            {
                nudMinAllRoll.Value = nudMaxAllRoll.Value - 1 <= 0 ? 1 : nudMaxAllRoll.Value - 1;
            }
        }

        private void btnAllRoll_Click(object sender, EventArgs e)
        {
            if (cbAllRoll.SelectedValue == null)
            {
                rtbQuery.Text = "Please select a Role Type to complete this query";
                return;
            }
            if (cbAllRollServer.SelectedValue == null)
            {
                rtbQuery.Text = "Please select a Server to complete this query";
                return;
            }
            var role = (Role)cbAllRoll.SelectedValue;
            var server = cbAllRollServer.SelectedValue.ToString();
            var classPlayersList = GlobalOjects.allPlayers.Values.Where(p => p.Role == role && p.Level >= nudMinAllRoll.Value && p.Level <= nudMaxAllRoll.Value).ToList();
            classPlayersList.Sort();
            var serverGuildsList = GlobalOjects.allguilds.Values.Where(g => g.Server == server).ToList();
            var allPlayers = (from p in classPlayersList
                              join s in serverGuildsList on p.GuildID equals s.Id
                              orderby p.Level
                              select p).ToList();
            var sb = new StringBuilder();
            sb.Append(string.Format("All {0} from [{1}], Levels 1 to 60\n", role, server));
            sb.Append("--------------------------------------------\n");
            foreach (var player in allPlayers)
            {
                sb.Append(player.ToString() + "\n");
            }
            sb.Append("END RESULTS\n");
            sb.Append("--------------------------------------------\n");
            rtbQuery.Text = sb.ToString();
        }

        private void btnAllGuildType_Click(object sender, EventArgs e)
        {
            if (cbGuildTypes.SelectedValue == null)
            {
                rtbQuery.Text = "Please select a Guild Type to complete this query";
                return;
            }
            var guildType = (uint)cbGuildTypes.SelectedValue;
            var allGuilds = (from g in GlobalOjects.allguilds.Values
                             where g.Type == guildType
                             group g by g.Server into g
                             orderby g.Key descending
                             select g);
            var sb = new StringBuilder();
            sb.Append(string.Format("All {0}-Type of Guilds\n", cbGuildTypes.SelectedText));
            sb.Append("--------------------------------------------\n");
            foreach (var guildServer in allGuilds)
            {
                sb.Append(guildServer.Key + "\n");
                foreach (var guild in guildServer)
                {
                    sb.Append(string.Format("<{0}>\n", guild.Name.Split('-')[0]));
                }
            }
            sb.Append("END RESULTS\n");
            sb.Append("--------------------------------------------\n");
            rtbQuery.Text = sb.ToString();
        }

        private void btnAllPlayersArenot_Click(object sender, EventArgs e)
        {
            var checkedButton = pRoles.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton == null)
            {
                rtbQuery.Text = "Please select a Role Type to complete this query";
                return;
            }
            var players = new List<Player>();
            if (checkedButton.Text == Role.Tank.ToString())
            {
                players = GlobalOjects.allPlayers.Values.Where(p => p.Class == Classes.Warrior || p.Class == Classes.Druid || p.Class == Classes.Paladin).ToList();
                players.Sort();
                players = players.Where(p => p.Role != Role.Tank).OrderBy(l => l.Level).ToList();
            }
            if (checkedButton.Text == Role.Healer.ToString())
            {
                players = GlobalOjects.allPlayers.Values.Where(p => p.Class == Classes.Priest || p.Class == Classes.Druid || p.Class == Classes.Paladin).ToList();
                players.Sort();
                players = players.Where(p => p.Role != Role.Healer).OrderBy(l => l.Level).ToList();
            }
            if (checkedButton.Text == Role.Damage.ToString())
            {
                players = GlobalOjects.allPlayers.Values.Where(p => p.Class == Classes.Warrior
                || p.Class == Classes.Druid
                || p.Class == Classes.Paladin
                ||p.Class==Classes.Priest
                ||p.Class==Classes.Rogue
                ||p.Class==Classes.Shaman
                ||p.Class==Classes.Warlock
                ||p.Class==Classes.Hunter
                ||p.Class==Classes.Mage).ToList();
                players.Sort();
                players = players.Where(p => p.Role != Role.Damage).OrderBy(l => l.Level).ToList();
            }
            var sb = new StringBuilder();
            sb.Append(string.Format("All Eligible Players Not Fulfilling the {0} Role\n", checkedButton.Text));
            sb.Append("--------------------------------------------\n");
            foreach (var player in players)
            {
                sb.Append(player.ToString()+"\n");
            }
            sb.Append("END RESULTS\n");
            sb.Append("--------------------------------------------\n");
            rtbQuery.Text = sb.ToString();
        }

        private void btnPercentageAllGuilds_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.Append("Percentage of Max Level Players in all guilds\n");
            sb.Append("--------------------------------------------\n");

            foreach (var guild in GlobalOjects.allguilds.Values)
            {
                var guildMaxPlayersCount = GlobalOjects.allPlayers.Values.Where(g => g.GuildID == guild.Id && g.Level == Constants.MAX_LEVEL).Count();
                var allPlayersCount = GlobalOjects.allPlayers.Values.Where(g => g.GuildID == guild.Id).Count();
                if (allPlayersCount > 0)
                {
                    var result = guildMaxPlayersCount == 0 ? 0 : Math.Round(((guildMaxPlayersCount * 100m) /allPlayersCount), 2);
                    sb.Append(string.Format("<{0}>\t\t\t{1}%\n", guild.Name.Split('-')[0], result));
                }
            }
            sb.Append("END RESULTS\n");
            sb.Append("--------------------------------------------\n");
            rtbQuery.Text = sb.ToString();
        }
    }
}
