using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicUO.ECS;

namespace ClassicUO.Game
{
    class PositionComponent : Component
    {
        public ushort X, Y;
        public sbyte Z;
    }

    internal partial class GameEntity
    {
        public void AddPosition(int x, int y, int z) => AddPosition((ushort) x, (ushort) y, (sbyte) z);
        public void AddPosition(ushort x, ushort y, sbyte z)
        {
            PositionComponent c = CreateComponent<PositionComponent>(ComponentsLookup.Position);
            c.X = x;
            c.Y = y;
            c.Z = z;
            AddComponent(ComponentsLookup.Position, c);
        }

        public void ReplacePosition(int x, int y, int z) => ReplacePosition((ushort)x, (ushort)y, (sbyte)z);

        public void ReplacePosition(ushort x, ushort y, sbyte z)
        {
            PositionComponent c = CreateComponent<PositionComponent>(ComponentsLookup.Position);
            c.X = x;
            c.Y = y;
            c.Z = z;
            ReplaceComponent(ComponentsLookup.Position, c);
        }
    }
}
