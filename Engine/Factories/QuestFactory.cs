using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quest = new List<Quest>();
        static QuestFactory()
        {
            _quest.Add(new Quest(1,
                "Clear the herb garden",
                "Defeat the snakes in the Herbalist's garden",
                new List<ItemQuantity> { new ItemQuantity(9001, 5) },
                25, 10,
                new List<ItemQuantity> { new ItemQuantity(1002, 1) }));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quest.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
