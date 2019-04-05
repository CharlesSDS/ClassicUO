using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicUO.ECS;
using ClassicUO.Renderer;

namespace ClassicUO.Game
{
    sealed class TextureComponent : Component
    {
        public SpriteTexture Texture;
    }
}
