using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicUO.ECS;

namespace ClassicUO.Game
{
    class RenderIndexComponent : Component
    {
        public int RenderIndex;
    }

    internal partial class GameEntity
    {
        public void AddRenderIndex(int i)
        {
            RenderIndexComponent c = CreateComponent<RenderIndexComponent>(ComponentsLookup.RenderIndex);
            c.RenderIndex = i;
            AddComponent(ComponentsLookup.RenderIndex, c);
        }

        public void ReplaceRenderIndex(int i)
        {
            RenderIndexComponent c = CreateComponent<RenderIndexComponent>(ComponentsLookup.RenderIndex);
            c.RenderIndex = i;
            ReplaceComponent(ComponentsLookup.RenderIndex, c);
        }
    }
}
