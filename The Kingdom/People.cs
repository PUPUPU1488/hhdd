using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Kingdom
{
    internal class People
    {
        public int Mood { get; private set; } = 50;
        private Random _random = new Random();

        // Случайная реакция на обычное действие (изменение на ±15%)
        public void ReactRandomly()
        {
            int reaction = _random.Next(-15, 16);
            Mood = Math.Max(0, Math.Min(Mood + reaction, 100));
        }

        // Прямое изменение настроения (например, при сборе налогов или войне)
        public void ChangeMood(int amount)
        {
            Mood = Math.Max(0, Math.Min(Mood + amount, 100));
        }
    }
}
