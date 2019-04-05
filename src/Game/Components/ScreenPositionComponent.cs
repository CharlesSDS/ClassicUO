using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicUO.ECS;

namespace ClassicUO.Game
{
    class ScreenPositionComponent : Component
    {
        public float X, Y;
    }

    internal partial class GameEntity
    {
        public void AddScreenPosition(float x, float y)
        {
            ScreenPositionComponent c = CreateComponent<ScreenPositionComponent>(ComponentsLookup.ScreenPosition);
            c.X = x;
            c.Y = y;
            AddComponent(ComponentsLookup.ScreenPosition, c);
        }

        public void ReplaceScreenPosition(float x, float y)
        {
            ScreenPositionComponent c = CreateComponent<ScreenPositionComponent>(ComponentsLookup.ScreenPosition);
            c.X = x;
            c.Y = y;
            ReplaceComponent(ComponentsLookup.ScreenPosition, c);
        }
    }
}
