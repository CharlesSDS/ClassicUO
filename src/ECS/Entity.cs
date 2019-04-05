using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicUO.ECS
{
    class Entity
    {
        private readonly List<Component> _componentsBuffer;
        private readonly List<int> _indexBuffer;

        private Component[] _components, _componentsCache;
        private Stack<Component>[] _componentsPools;
        private int[] _indecesCache;
        private int _totalComponents;

        public Entity()
        {
            _componentsBuffer = new List<Component>();
            _indexBuffer = new List<int>();
        }

        public int Index { get; }


        public void Initialize(int totalComponents)
        {
            _totalComponents = totalComponents;
            _components = new Component[totalComponents];

        }

        public Component CreateComponent(int index, Type type)
        {
            var componentPool = GetComponentPool(index);
            return componentPool.Count != 0 ? componentPool.Pop() : (Component) Activator.CreateInstance(type);
        }

        public T CreateComponent<T>(int index) where T : Component, new()
        {
            var componentPool = GetComponentPool(index);
            return componentPool.Count != 0 ? (T)componentPool.Pop() : new T();
        }

        public Component AddComponent(int index, Component component)
        {          
            if (HasComponent(index))
                throw new Exception("Component already added");

            _components[index] = component;
            _componentsCache = null;
            _indecesCache = null;

            return component;
        }

        public void RemoveComponent(int index)
        {
            if (!HasComponent(index))
                throw new Exception("Component not found during replacing");

            ReplaceComponent(index, null);
        }

        public void RemoveAllComponents()
        {
            for (int i = 0; i < _components.Length; i++)
            {
                if (_components[i] != null)
                    ReplaceComponent(i, null);
            }
        }

        public void ReplaceComponent(int index, Component component)
        {
            if (HasComponent(index))
                ReplaceComponentInternal(index, component);
            else if (component != null)
                AddComponent(index, component);
        }

        private void ReplaceComponentInternal(int index, Component c)
        {
            Component prev = _components[index];
            if (prev != c)
            {
                _components[index] = c;
                _componentsCache = null;

                if (c != null)
                {

                }
                else
                {
                    _indecesCache = null;

                }

                GetComponentPool(index).Push(prev);
            }
            else
            {

            }
        }

        public bool HasComponent(int index) => _components[index] != null;

        public bool HasComponents(int[] indices)
        {
            for (int i = 0; i < indices.Length; i++)
            {
                if (_components[indices[i]] == null)
                    return false;
            }

            return true;
        }

        public bool HasAnyComponent(int[] indices)
        {
            for (int i = 0; i < indices.Length; i++)
            {
                if (_components[indices[i]] != null)
                    return true;
            }

            return false;
        }

        public Component GetComponent(int index)
        {
            if (!HasComponent(index))
                throw new Exception("No component found");

            return _components[index];
        }

        public Component[] GetComponents()
        {
            if (_componentsCache == null)
            {
                for (int i = 0; i < _components.Length; i++)
                {
                    Component c = _components[i];
                    if (c != null)
                        _componentsBuffer.Add(c);
                }

                _componentsCache = _componentsBuffer.ToArray();
                _componentsBuffer.Clear();
            }

            return _componentsCache;
        }

        public int[] GetComponentIndices()
        {
            if (_indecesCache == null)
            {
                for (int i = 0; i < _components.Length; i++)
                {
                    if (_components[i] != null)
                        _indexBuffer.Add(i);
                }

                _indecesCache = _indexBuffer.ToArray();
                _indexBuffer.Clear();
            }

            return _indecesCache;
        }

        public Stack<Component> GetComponentPool(int index)
        {
            var componentPool = _componentsPools[index];

            if (componentPool == null)
            {
                componentPool = new Stack<Component>();
                _componentsPools[index] = componentPool;
            }

            return componentPool;
        }
    }
}
