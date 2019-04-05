using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicUO.ECS;

namespace ClassicUO.Game
{
    sealed class GraphicComponent : Component
    {
        public ushort Graphic;
    }

    internal partial class GameEntity
    {
        public void AddGraphic(ushort graphic)
        {
            GraphicComponent c = CreateComponent<GraphicComponent>(ComponentsLookup.Graphic);
            c.Graphic = graphic;
            AddComponent(ComponentsLookup.Graphic, c);
        }

        public void ReplaceGraphic(ushort graphic)
        {
            GraphicComponent c = CreateComponent<GraphicComponent>(ComponentsLookup.Graphic);
            c.Graphic = graphic;
            ReplaceComponent(ComponentsLookup.Graphic, c);
        }
    }
}
