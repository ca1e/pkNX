using pkNX.Game;
using pkNX.Structures.FlatBuffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pkNX.WinForms.Simple
{
    public partial class DropItemUI : Form
    {
        private readonly DataCache<NestHoleReward8Table> Cache;
        private readonly uint[] dropCounts = { 999, 999, 999, 999, 999 };
        public bool Modified { get; set; }

        public DropItemUI(DataCache<NestHoleReward8Table> cache)
        {
            InitializeComponent();
            Cache = cache;
        }

        private void DropItemUI_Load(object sender, EventArgs e)
        {
            DenTypecb.SelectedIndex = 0;
        }
        private void DenTypecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems(DenTypecb.SelectedIndex);
        }

        private void LoadItems(int index)
        {
            var table = Cache[index % 10];
            tablehash.Text = table.TableID.ToString();
            if (table.Rewards.Length < 15)
            {
                List<NestHoleReward8> rewardsList = new List<NestHoleReward8>();
                rewardsList.AddRange(table.Entries);
                foreach (int value in Enumerable.Range(1, 15 - table.Rewards.Length))
                {
                    rewardsList.Add(new NestHoleReward8());
                }
                table.Entries = rewardsList.ToArray();
            }
            FLP_ctrls.Controls.Clear();
            foreach (var reward in table.Rewards)
            {
                var cbcontrol = GenItemComboBox(reward);
                FLP_ctrls.Controls.Add(cbcontrol);
            }
            var savebtn = new Button
            {
                Width = 95,
                Height = 35,
                Text = "保存"
            };
            savebtn.Click += (_, __) =>
                        {
                            Modified = true;
                            System.Media.SystemSounds.Asterisk.Play();
                            MessageBox.Show("奖励修改成功！", "提示");
                        };
            FLP_ctrls.Controls.Add(savebtn);
        }

        private ComboBox GenItemComboBox(INestHoleReward reward)
        {
            reward.Item = reward.Item == 0x0 ? 0x1 : reward.Item;
            reward.Values = dropCounts;
            var cbcontrol = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDown,
                Text = PokeItems.Items.Where((z, i) => z.ItemId == reward.Item).First().ToString()
            };
            cbcontrol.DropDown += (_, __) =>
                    {
                        if (cbcontrol.Items.Count == 0)
                            cbcontrol.Items.AddRange(PokeItems.Items);
                    };
            cbcontrol.TextUpdate += (_, __) =>
                    {
                        var inputN = cbcontrol.Text;
                        cbcontrol.Items.Clear();
                        if (string.IsNullOrWhiteSpace(inputN)) cbcontrol.Items.AddRange(PokeItems.Items);
                        else
                        {
                            var newItem = PokeItems.Items.Where(x => x.Name.Contains(inputN)).ToArray();
                            cbcontrol.Items.AddRange(newItem);
                        }
                        cbcontrol.SelectionStart = cbcontrol.Text.Length;
                        cbcontrol.DroppedDown = true;
                        Cursor = Cursors.Default;
                    };
            cbcontrol.SelectedIndexChanged += (_, __) =>
                    {
                        reward.Item = (cbcontrol.SelectedItem as PokeItem).ItemId;
                        reward.Values = dropCounts;
                    };

            return cbcontrol;
        }
    }
}
