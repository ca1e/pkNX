using pkNX.Game;
using pkNX.Structures.FlatBuffers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace pkNX.WinForms.Simple
{
    public partial class ChangeSpeciesUI : Form
    {
        private readonly DataCache<EncounterNest8> Cache;
        private readonly EncounterNest8 Pokemon;
        public bool Modified { get; set; }


        public ChangeSpeciesUI(DataCache<EncounterNest8> cache)
        {
            InitializeComponent();
            Cache = cache;
            Pokemon = cache[cache.Length - 1];
        }

        private void ChangeSpeciesUI_Load(object sender, System.EventArgs e)
        {
            speciesCb.DropDown += (_, __) =>
            {
                if (speciesCb.Items.Count == 0)
                    speciesCb.Items.AddRange(Species.GetSpes());
            };
            speciesCb.SelectedIndexChanged += (_, __) =>
            {
                Pokemon.Species = (speciesCb.SelectedItem as PokemonDetail).SpeciesId;
                spnlabel.Text = $"图鉴编号：{Pokemon.Species}";
            };
            speciesCb.TextUpdate += (_, __) =>
            {
                var inputN = speciesCb.Text;
                speciesCb.Items.Clear();
                if (string.IsNullOrWhiteSpace(inputN)) speciesCb.Items.AddRange(Species.GetSpes());
                else
                {
                    var newItem = Species.spe.Where(x => x.Contains(inputN)).ToArray();
                    speciesCb.Items.AddRange(newItem);
                }
                speciesCb.SelectionStart = speciesCb.Text.Length;
                speciesCb.DroppedDown = true;
                Cursor = Cursors.Default;
            };
            speciesCb.Text = Species.GetSpeciesName(Pokemon.Species);
            spnlabel.Text = $"图鉴编号：{Pokemon.Species}";
            Abilitycb.SelectedIndex = Pokemon.Ability;
            FlawlessIVscb.SelectedIndex = Pokemon.FlawlessIVs - 1;
            IsGmaxcb.Checked = Pokemon.IsGigantamax;
        }
        private void Abilitycb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pokemon.Ability = (byte)Abilitycb.SelectedIndex;
        }
        private void FlawlessIVscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pokemon.FlawlessIVs = (byte)(FlawlessIVscb.SelectedIndex + 1);
        }

        private void IsGmaxcb_CheckedChanged(object sender, EventArgs e)
        {
            Pokemon.IsGigantamax = IsGmaxcb.Checked;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Modified = true;
            Visible = false;
            if (IwannaAllcb.Checked)
            {
                for (var i = 0; i < Cache.Length; i++)
                {
                    Cache[i].AbilityPermitted = Pokemon.AbilityPermitted;
                    Cache[i].FlawlessIVs = Pokemon.FlawlessIVs;
                    Cache[i].Species = Pokemon.Species;
                    Cache[i].IsGigantamax = Pokemon.IsGigantamax;
                }
            }
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
