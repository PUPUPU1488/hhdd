using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Kingdom
{
    public partial class Form1 : Form
    {
        List<string> events= new List<string>();
        KingdomFacade kingdomFacade = new KingdomFacade();
        void UpdateEvents()
        {
            if (events.Count != 0)
            {
                labelLNewEvent.Text = events[events.Count-1];
                if (events.Count > 1) labelLastEvent.Text = events[events.Count - 2]; else labelLastEvent.Text = null;
            }
            else
            {
                labelLNewEvent.Text = "Пока что в царстве всё тихо";
                labelLastEvent.Text = null;
            }
            labelLNewEvent.Location = new Point((int)Math.Round(274 / 2 + labelLNewEvent.Text.Length * 2.5), labelLNewEvent.Location.Y);
            if(labelLastEvent.Text!=null) new Point((int)Math.Round(287 / 2 + labelLastEvent.Text.Length * 2.5), labelLastEvent.Location.Y);
        }
        void UpdateUI()
        {
            progressbarMoodPeople.Value = kingdomFacade.PeopleMood;
            if (kingdomFacade.PeopleMood > 75) labelMoodPeopleStatus.Text = "Ликует";
            else if (kingdomFacade.PeopleMood >= 40) labelMoodPeopleStatus.Text = "Нейтральное";
            else if(kingdomFacade.PeopleMood >15) labelMoodPeopleStatus.Text = "Недовольство";
            else labelMoodPeopleStatus.Text = "Угнетённое";

            progressbarTreasury.Value = kingdomFacade.Treasury;
            if (kingdomFacade.Treasury <= 20)
            {
                labelTreasuryStatus.Text = $"Казна пустеет! ({kingdomFacade.Treasury}%)";
                labelTreasuryStatus.ForeColor = Color.Red;
                labelTreasuryStatus.Visible = true;
            }
            else
            {
                labelTreasuryStatus.Text = $"Стабильно ({kingdomFacade.Treasury}%)";
                labelTreasuryStatus.ForeColor = Color.Green;
                labelTreasuryStatus.Visible = true; // Теперь текст состояния виден всегда
            }
            UpdateEvents();
        }
        public Form1()
        {
            InitializeComponent();
            UpdateUI();
        }
        private void trackBarLevelTaxes_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show(trackBarLevelTaxes.Value.ToString());
            kingdomFacade.ChangeTaxes(trackBarLevelTaxes.Value);
            //UpdateUI();
        }
        private void buttonDecree_Click(object sender, EventArgs e)
        {
            kingdomFacade.IssueDecree();
            events.Add("Царь издает указ");
            UpdateUI();
        }
        private void buttonGetTaxes_Click(object sender, EventArgs e)
        {
            kingdomFacade.CollectTaxes();
            events.Add("Царь собирает налоги");
            UpdateUI();
        }
        private void buttonWar_Click(object sender, EventArgs e)
        {
            kingdomFacade.DeclareWar();
            events.Add("Царь объявляет войну соседям");
            UpdateUI();
        }
        private void buttonAwarding_Click(object sender, EventArgs e)
        {
            kingdomFacade.RewardLoyal();
            events.Add("Царь награждает верных");
            UpdateUI();
        }

        private void trackBarLevelTaxes_Scroll_1(object sender, EventArgs e)
        {

        }
    }
}
