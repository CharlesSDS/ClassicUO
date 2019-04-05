using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassicUO.ECS;

namespace ClassicUO.Game
{
    internal sealed class HeightComponent : Component
    {
        public sbyte Average;
        public sbyte Minimum;
    }

    internal partial class GameEntity
    {
        public void AddHeight(sbyte average, sbyte minimum)
        {
            HeightComponent component = CreateComponent<HeightComponent>(ComponentsLookup.Height);
            component.Average = average;
            component.Minimum = minimum;
            AddComponent(ComponentsLookup.Height, component);
        }
    }
}
