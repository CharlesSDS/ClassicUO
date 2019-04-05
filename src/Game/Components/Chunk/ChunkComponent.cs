using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassicUO.ECS;

namespace ClassicUO.Game
{
    sealed class ChunkComponent : Component
    {
    }

    internal partial class GameEntity
    {
        public void AddChunk()
        {
            ChunkComponent c = CreateComponent<ChunkComponent>(ComponentsLookup.Chunk);
            AddComponent(ComponentsLookup.Chunk, c);
        }
    }
}
