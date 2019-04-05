using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicUO.ECS;

namespace ClassicUO.Game
{
    class AlphaHueComponent : Component
    {
        public byte Value;
    }

    internal partial class GameEntity
    {
        public void ReplaceAlphaHue(byte alpha)
        {
            AlphaHueComponent c = CreateComponent<AlphaHueComponent>(ComponentsLookup.AlphaHue);
            c.Value = alpha;
            ReplaceComponent(ComponentsLookup.AlphaHue, c);
        }
    }
}
