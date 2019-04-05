using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassicUO.ECS;

namespace ClassicUO.Game
{
    internal sealed class LandComponent : Component
    {
    }

    internal partial class GameEntity
    {
        public void AddLand()
        {
            LandComponent component = CreateComponent<LandComponent>(ComponentsLookup.Land);
            AddComponent(ComponentsLookup.Land, component);
        }
    }
}
