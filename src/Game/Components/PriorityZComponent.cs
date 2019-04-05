using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicUO.ECS;

namespace ClassicUO.Game
{
    class PriorityZComponent : Component
    {
        public ushort PriorityZ;
    }

    internal partial class GameEntity
    {
        public void AddPriorityZ(ushort priority)
        {
            PriorityZComponent c = CreateComponent<PriorityZComponent>(ComponentsLookup.PriorityZ);
            c.PriorityZ = priority;
            AddComponent(ComponentsLookup.PriorityZ, c);
        }

        public void ReplacePriorityZ(ushort priority)
        {
            PriorityZComponent c = CreateComponent<PriorityZComponent>(ComponentsLookup.PriorityZ);
            c.PriorityZ = priority;
            ReplaceComponent(ComponentsLookup.PriorityZ, c);
        }
    }
}
