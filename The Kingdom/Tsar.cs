using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Kingdom
{
    internal class Tsar
    {
        public string LastAction { get; private set; } = "Правит";
        public void IssueDecree() => LastAction = "Издал новый указ";
        public void Reward() => LastAction = "Наградил отличившихся";
        public void Punish() => LastAction = "Наказал провинившихся";
        public void DeclareWar() => LastAction = "Объявил войну соседям";
        public void Mobilize() => LastAction = "Объявил мобилизацию";
        public void Overthrown() => LastAction = "Отправлен к Змею Горынычу";
    }
}
