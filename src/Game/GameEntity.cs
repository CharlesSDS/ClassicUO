using ClassicUO.ECS;

namespace ClassicUO.Game
{
    internal sealed partial class GameEntity : Entity
    {
        public T CreateAndAddComponent<T>(int index) where T : Component, new()
        {
            T component = CreateComponent<T>(index);
            AddComponent(index, component);
            return component;
        }
    }
}
