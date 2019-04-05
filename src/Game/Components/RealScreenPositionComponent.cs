using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicUO.ECS;

namespace ClassicUO.Game
{
    class RealScreenPositionComponent : Component
    {
        public float X, Y;
    }

    internal partial class GameEntity
    {
        public void AddRealScreenPosition(float x, float y)
        {
            RealScreenPositionComponent c = CreateComponent<RealScreenPositionComponent>(ComponentsLookup.RealScreenPosition);
            c.X = x;
            c.Y = y;
            AddComponent(ComponentsLookup.RealScreenPosition, c);
        }

        public void ReplaceRealScreenPosition(float x, float y)
        {
            RealScreenPositionComponent c = CreateComponent<RealScreenPositionComponent>(ComponentsLookup.RealScreenPosition);
            c.X = x;
            c.Y = y;
            ReplaceComponent(ComponentsLookup.RealScreenPosition, c);
        }
    }
}
