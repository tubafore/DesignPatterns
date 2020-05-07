using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class Team : IDeployable
    {
        private List<IDeployable> children;

        public Team()
        {
            children = new List<IDeployable>();
        }

        public void Add(IDeployable deployable)
        {
            children.Add(deployable);
        }

        public void Remove(IDeployable deployable)
        {
            children.Remove(deployable);
        }

        public void Deploy()
        {
            foreach (IDeployable deployable in children)
                deployable.Deploy();
        }
    }
}
