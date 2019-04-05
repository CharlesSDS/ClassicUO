using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicUO.Game
{
    internal static class ComponentsLookup
    {
        public const int AlphaHue = 0;
        public const int Bounds = 1;
        public const int Center = 1;
        public const int Chunk = -1;
        public const int Chunks = -1;
        public const int Draw = 2;
        public const int DrawTransparent = 3;
        public const int Graphic = 4;
        public const int Height = -1;
        public const int Hue = 5;
        public const int Id = -1;
        public const int Index = 6;
        public const int Item = 6;
        public const int Land = 7;
        public const int LastAccessTime = -1;
        public const int Map = -1;
        public const int MapIndex = -1;
        public const int Mobile = -1;
        public const int Normals = -1;
        public const int Player = 0;
        public const int Position = 0;
        public const int Position2D = 0;
        public const int RealScreenPosition = -1;
        public const int Rectangle = -1;
        public const int ScreenPosition = -1;
        public const int Shadow = 0;
        public const int Stretched = -1;
        public const int Texture = -1;
        public const int Tile = -1;
        public const int Tiles = -1;
        public const int TileData = -1;
        public const int UsedIndices = -1;
        public const int Vertices = -1;
        public const int World = -1;
        public const int PriorityZ = -1;
        public const int RenderIndex = -1;

        public const int TotalComponents = 18 + 2;

        public static readonly string[] ComponentNames =
        {
            "AlphaHue",
            "Bounds",
            "DrawTransparent",
            "Graphic",
            "Height",
            "Hue",
            "Land",
            "Position",
            "Shadow",
            "Texture",
            "Tile",
        };

        //public static readonly Type[] ComponentTypes =
        //{
        //    typeof(AlphaHueComponent),
        //    typeof(DrawTransparentComponent),
        //    typeof(GraphicComponent),
        //    typeof(HueComponent),
        //    typeof(LandComponent),
        //    typeof(PositionComponent),
        //};
    }
}
