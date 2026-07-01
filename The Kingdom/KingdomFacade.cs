using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Kingdom
{
    class KingdomFacade
    {
        public int Taxes { get; private set; } = 20;
        public int Treasury { get; private set; } = 50;
        public int PeopleMood { get; private set; } = 50;
        public string EventLog { get; private set; } = "Царь взошел на престол. В государстве всё спокойно.";
        public bool IsGoldenAge { get; private set; } = false;
        public bool IsOverthrown { get; private set; } = false;
        private Random random = new Random();

        public void ChangeTaxes(int newRate)
        {
            if (IsOverthrown) return;
            Taxes = Math.Max(0, Math.Min(newRate, 100));
        }
        public void IssueDecree()
        {
            if (IsOverthrown) return;
            int reaction = random.Next(-15, 16);
            PeopleMood = Math.Max(0, Math.Min(PeopleMood + reaction, 100));
            EventLog = $"Царь издал новый указ. Настроение народа изменилось на {reaction:+#;-#;0}%.";
            CheckSystemState();
        }
        public void CollectTaxes()
        {
            if (IsOverthrown) return;

            int collected = Taxes / 2;
            Treasury = Math.Max(0, Math.Min(Treasury + collected, 100));

            int anger = Taxes / 3;
            PeopleMood = Math.Max(0, Math.Min(PeopleMood - anger, 100));

            EventLog = $"Царь собрал налоги. Казна: +{collected}%, Настроение народа: -{anger}%.";
            CheckSystemState();
        }
        public void DeclareWar()
        {
            if (IsOverthrown) return;
            KingActionMobilize();
            CheckSystemState();
        }
        private void KingActionMobilize()
        {
            EventLog = "Царь объявил мобилизацию и пошел войной на соседей!";
            PeopleMood = Math.Max(0, Math.Min(PeopleMood - 25, 100));

            if (random.Next(0, 2) == 0)
            {
                Treasury = Math.Max(0, Math.Min(Treasury + 30, 100));
                EventLog += " Война выиграна! В казну везут трофеи (+30%).";
            }
            else
            {
                Treasury = Math.Max(0, Math.Min(Treasury - 20, 100));
                EventLog += " Война затянулась. Казна истощена из-за расходов (-20%).";
            }
        }
        public void RewardLoyal()
        {
            if (IsOverthrown) return;

            if (Treasury >= 20)
            {
                Treasury = Math.Max(0, Math.Min(Treasury - 20, 100));
                PeopleMood = Math.Max(0, Math.Min(PeopleMood + 30, 100));
                EventLog = "Царь щедро наградил верных подданных! Настроение народа резко выросло.";
            }
            else
            {
                EventLog = "Царь хотел наградить верных, но в казне критически мало золота!";
            }

            CheckSystemState();
        }
        private void CheckSystemState()
        {
            // СЦЕНАРИЙ 1: Налоги высокие (>70%) + Настроение критическое (<=10%) + была война = БУНТ
            if (Taxes > 70 && PeopleMood <= 10 && EventLog.Contains("мобилизацию"))
            {
                IsOverthrown = true;
                EventLog = "СЦЕНАРИЙ 1: БУНТ! Народ угнетен налогами и войной. Царь отправлен под присмотр Змея Горыныча!";
                return;
            }
            // СЦЕНАРИЙ 2: Казна упала ниже 15% -> Автоматическая война
            if (Treasury <= 15 && !IsOverthrown)
            {
                EventLog = "СЦЕНАРИЙ 2: Казна опустела! Царь вынужден срочно объявилить войну соседям для пополнения бюджета!";
                KingActionMobilize();
            }
            if (Taxes >= 10 && Taxes <= 40 && Treasury >= 85 && PeopleMood >= 85)
            {
                IsGoldenAge = true;
                EventLog = "СЦЕНАРИЙ 3: ЗОЛОТОЙ ВЕК! Казна полна, налоги умеренны, народ обожает своего правителя. Наступила эпоха процветания!";
            }
        }
    }
}
