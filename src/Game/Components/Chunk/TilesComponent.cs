using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassicUO.ECS;

namespace ClassicUO.Game
{
    internal sealed class TilesComponent : Component
    {
        public int[,] Tiles;
    }

    internal partial class GameEntity
    {
        public void AddTiles(int[,] tiles)
        {
            TilesComponent component = CreateComponent<TilesComponent>(ComponentsLookup.Tiles);
            component.Tiles = tiles;
            AddComponent(ComponentsLookup.Tiles, component);
        }
    }
}
