using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicUO.ECS
{
    class System<TEntity> where TEntity: class
    {
        public virtual void Initialize()
        {

        }

        public virtual void Execute()
        {

        }

        public virtual void Cleanup()
        {

        }
    }
}
