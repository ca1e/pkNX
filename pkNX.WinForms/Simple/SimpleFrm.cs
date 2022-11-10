using pkNX.Containers;
using pkNX.Game;
using pkNX.Structures.FlatBuffers;
using pkNX.WinForms.Properties;
using pkNX.WinForms.Simple;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace pkNX.WinForms
{
    public partial class SimpleFrm : Form
    {
        private string filepath;
        private GFPack data_table;
        readonly string[] gameFolder = { "0100ABF008968000", "01008DB008C2C000" };
        const string commonpath = @"romfs\bin\archive\field\resident";
        const string neste = "nest_hole_encount.bin";
        const string nestr = "nest_hole_drop_rewards.bin";
        const string nestb = "nest_hole_bonus_rewards.bin";
        public SimpleFrm()
        {
            InitializeComponent();
            Settingsave(true);
        }

        private void Settingsave(bool issimple)
        {
            Settings.Default.IsSimple = issimple;
            Settings.Default.Save();
        }

        private void LoadDens()
        {
            GameVercb.SelectedIndex = 0;
            Dencb.Items.Clear();
            for (var i = 0; i < NestLocations.Nests.Length; i++)
            {
                var detail = NestLocations.Nests[i];
                var name = NestLocations.GetLocations(detail.Location);
                Dencb.Items.Add($"{i + 1} - {name}");
            }
            if (Dencb.Items.Count > 0)
                Dencb.SelectedIndex = 0;
        }

        private void LoadPack(string fileurl)
        {
            if (File.Exists(fileurl))
            {
                filepath = fileurl;
                try
                {
                    data_table = new GFPack(filepath);
                }
                catch
                {
                    WinFormsUtil.Alert("Invalid file loaded." + Environment.NewLine + "Unable to recognize game data.", fileurl);
                    return;
                }
                TB_Path.Text = filepath;
                Dencb.SelectedIndex = 0;
            }
            else
                WinFormsUtil.Alert("Invalid file loaded." + Environment.NewLine + "Unable to recognize game data.", fileurl);
        }
        private void SimpleFrm_Load(object sender, EventArgs e)
        {
            LoadDens();
            if (!string.IsNullOrWhiteSpace(Settings.Default.GamePath))
                LoadPack(Settings.Default.GamePath);
        }

        private ulong GetDen()
        {
            var detail = NestLocations.Nests[Dencb.SelectedIndex];
            var denHash = isRarecb.Checked ? detail.RareHash : detail.CommonHash;
            return denHash;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();
            dialog.Title = "请选择文件";
            dialog.Filter = "数据文件(*.gfpak)|*.gfpak";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TB_Path.Text = dialog.FileName;
                Settings.Default.GamePath = TB_Path.Text;
                Settings.Default.Save();
                LoadPack(dialog.FileName);
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var main = new Main();
            main.ShowDialog();
            Settingsave(false);
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("为了方便自己学习魔法而写的，不太清楚其他人的需求。\n如果有什么好的建议，欢迎到Q群1060368159交流。", "关于");
        }

        private void 生成目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(gameFolder[GameVercb.SelectedIndex], commonpath));
        }

        private T GetTables<T>(string tbin)
        {
            var tables = FlatBufferConverter.DeserializeFrom<T>(data_table.GetDataFileName(tbin));
            return tables;
        }

        private void RaidsBtn_Click(object sender, EventArgs e)
        {
            if (data_table == null)
            {
                MessageBox.Show("请选择data_table文件");
                return;
            }

            var nest_encounts = GetTables<EncounterNest8Archive>(neste);
            var arr = nest_encounts.Tables;
            arr = arr.Where((z, i) => GetDen() == z.TableID)
                                 .Where((z, i) => (z.GameVersion - 1 == GameVercb.SelectedIndex)).ToArray();
            var cache = new DataCache<EncounterNest8Table>(arr);
            var names = arr.Select((z, i) => $"{z.TableID}").ToArray();
            using var form = new GenericEditor<EncounterNest8Table>(cache, names, "巢穴精灵");
            form.ShowDialog();
            if (!form.Modified)
                return;

            var data = FlatBufferConverter.SerializeFrom(nest_encounts);
            data_table.SetDataFileName(neste, data);
            File.WriteAllBytes(filepath, data_table.Write());
        }

        private void RewardsBtn_Click(object sender, EventArgs e)
        {
            if (data_table == null)
            {
                MessageBox.Show("请选择data_table文件", "提示");
                return;
            }
            var nest_drops = GetTables<NestHoleReward8Archive>(nestr);
            var arr = nest_drops.Tables;
            //arr = arr.Where((z, i) => ShowDrop(z.TableID)).ToArray();
            var cache = new DataCache<NestHoleReward8Table>(arr);
            var names = arr.Select(z => $"{z.TableID}").ToArray();
            using var form = new GenericEditor<NestHoleReward8Table>(cache, names, "团战普通奖励(取决精灵)");
            form.ShowDialog();
            if (!form.Modified)
                return;

            var data = FlatBufferConverter.SerializeFrom(nest_drops);
            data_table.SetDataFileName(nestr, data);
            File.WriteAllBytes(filepath, data_table.Write());
        }

        private void RBuRewardsBtn_Click(object sender, EventArgs e)
        {
            if (data_table == null)
            {
                MessageBox.Show("请选择data_table文件");
                return;
            }
            var nest_bonus = GetTables<NestHoleReward8Archive>(nestb);
            var arr = nest_bonus.Tables;
            var cache = new DataCache<NestHoleReward8Table>(arr);
            var names = arr.Select((z, i) => $"{z.TableID}").ToArray();
            using var form = new GenericEditor<NestHoleReward8Table>(cache, names, "团战特殊奖励(取决红紫坑)");
            form.ShowDialog();
            if (!form.Modified)
                return;

            var data = FlatBufferConverter.SerializeFrom(nest_bonus);
            data_table.SetDataFileName(nestb, data);
            File.WriteAllBytes(filepath, data_table.Write());
        }

        private void DenChanged(object sender, EventArgs e)
        {
            DenMap.BackgroundImage = GetNestMap(Dencb.SelectedIndex, NestLocations.Nests[Dencb.SelectedIndex], isRarecb.Checked);
        }

        public static Bitmap GetNestMap(int Dindex, NestHashDetail detail, bool israre = false)
        {
            Pen redPen = israre ? new Pen(Color.MediumOrchid, 10) : new Pen(Color.Red, 10);
            var map = Resources.map;
            if (Dindex >= 100)
            {
                if (Dindex >= 190)
                {
                    map = Resources.map_ct;
                }
                else
                {
                    map = Resources.map_ioa;
                }
                using (var graphics = Graphics.FromImage(map))
                    graphics.DrawArc(redPen, detail.MapX - 1, detail.MapY - 1, 2, 2, 0, 360);
                int start_point_x = detail.MapX - 172 / 2;
                int start_point_y = detail.MapY - 402 / 2;
                if (start_point_x < 0) start_point_x = 0;
                if (start_point_x + 172 > map.Width) start_point_x = map.Width - 172;
                if (start_point_y < 0) start_point_y = 0;
                if (start_point_y + 402 > map.Width) start_point_y = map.Height - 402;
                Rectangle cropRect = new Rectangle(start_point_x, start_point_y, 172, 402);
                Bitmap src = map as Bitmap;
                Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                    cropRect,
                    GraphicsUnit.Pixel);
                }
                map = target;
            }
            else
            {
                using (var graphics = Graphics.FromImage(map))
                    graphics.DrawArc(redPen, detail.MapX - 5, detail.MapY - 5, 15, 15, 0, 360);
            }

            return map;
        }

        private void cleanAllRewardBtn_Click(object sender, EventArgs e)
        {
            if (data_table == null)
            {
                MessageBox.Show("请选择data_table文件", "提示");
                return;
            }
            var nest_drops = GetTables<NestHoleReward8Archive>(nestr);
            var arr = nest_drops.Tables;

            foreach (var i in arr)
            {
                i.Entries = new NestHoleReward8[] { };
            }

            var data = FlatBufferConverter.SerializeFrom(nest_drops);
            data_table.SetDataFileName(nestr, data);
            File.WriteAllBytes(filepath, data_table.Write());
            MessageBox.Show("删除成功，已保存！", "提示");
        }

        private void LastSpeciesBtn_Click(object sender, EventArgs e)
        {
            if (data_table == null)
            {
                MessageBox.Show("请选择data_table文件");
                return;
            }
            var nest_encounts = GetTables<EncounterNest8Archive>(neste);
            var arr = nest_encounts.Tables;
            arr = arr.Where((z, i) => GetDen() == z.TableID)
                                 .Where((z, i) => (z.GameVersion - 1 == GameVercb.SelectedIndex)).ToArray();
            var tables = arr.First();
            var cache = new DataCache<EncounterNest8>(tables.Entries);
            using var form = new ChangeSpeciesUI(cache);
            form.ShowDialog();
            if (!form.Modified)
                return;

            var data = FlatBufferConverter.SerializeFrom(nest_encounts);
            data_table.SetDataFileName(neste, data);
            File.WriteAllBytes(filepath, data_table.Write());
            MessageBox.Show("精灵修改成功，已保存！", "提示");
        }

        private void Reward999Btn_Click(object sender, EventArgs e)
        {
            if (data_table == null)
            {
                MessageBox.Show("请选择data_table文件");
                return;
            }
            var nest_bonus = GetTables<NestHoleReward8Archive>(nestb);
            var arr = nest_bonus.Tables.ToArray();
            var cache = new DataCache<NestHoleReward8Table>(arr);
            using var form = new DropItemUI(cache);
            form.ShowDialog();
            if (!form.Modified)
                return;

            var data = FlatBufferConverter.SerializeFrom(nest_bonus);
            data_table.SetDataFileName(nestb, data);
            File.WriteAllBytes(filepath, data_table.Write());
        }
    }
}