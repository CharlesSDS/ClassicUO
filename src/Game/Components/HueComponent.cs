using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicUO.ECS;

namespace ClassicUO.Game
{
    class HueComponent : Component
    {
        public ushort Hue;
    }

    internal partial class GameEntity
    {
        public void AddHue(ushort hue)
        {
            HueComponent c = CreateComponent<HueComponent>(ComponentsLookup.Hue);
            c.Hue = hue;
            AddComponent(ComponentsLookup.Hue, c);
        }

        public void ReplaceHue(ushort hue)
        {
            HueComponent c = CreateComponent<HueComponent>(ComponentsLookup.Hue);
            c.Hue = hue;
            ReplaceComponent(ComponentsLookup.Hue, c);
        }
    }
}
