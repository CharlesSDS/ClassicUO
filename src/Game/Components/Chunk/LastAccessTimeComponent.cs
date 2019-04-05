using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassicUO.ECS;

namespace ClassicUO.Game
{
    class LastAccessTimeComponent : Component
    {
        public ulong LastAccessTime;
    }

    internal partial class GameEntity
    {
        public void AddLastAccessTime(ulong time)
        {
            LastAccessTimeComponent c = CreateComponent<LastAccessTimeComponent>(ComponentsLookup.LastAccessTime);
            c.LastAccessTime = time;
            AddComponent(ComponentsLookup.LastAccessTime, c);
        }

        public void ReplaceLastAccessTime(ulong time)
        {
            LastAccessTimeComponent c = CreateComponent<LastAccessTimeComponent>(ComponentsLookup.LastAccessTime);
            c.LastAccessTime = time;
            ReplaceComponent(ComponentsLookup.LastAccessTime, c);
        }
    }
}
