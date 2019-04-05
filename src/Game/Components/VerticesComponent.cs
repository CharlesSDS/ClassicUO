using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassicUO.ECS;
using ClassicUO.Renderer;

namespace ClassicUO.Game
{
    sealed class VerticesComponent : Component
    {
        public SpriteVertex[] Vertices;
    }

    internal partial class GameEntity
    {
        public void AddVertices(ref SpriteVertex[] vertices)
        {
            VerticesComponent c = CreateComponent<VerticesComponent>(ComponentsLookup.Vertices);
            c.Vertices = vertices;
            AddComponent(ComponentsLookup.Vertices, c);
        }
    }
}
