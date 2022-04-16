using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI.BT
{
    public class Repeat : Decorator
    {
        protected int limit;
        protected int counter;

        protected bool haslimit = true;

        public Repeat(int limit, Behavior child)
            : base(child)
        {
            this.limit = limit;
        }
        public Repeat(bool haslimit, Behavior child)
            : base(child)
        {
            this.haslimit = haslimit;
        }

        public override void OnInitialize()
        {
            counter = 0;

        }

        public override Status Update()
        {
            while (true)
            {
                Status childStatus = child.Tick();

                if (childStatus == Status.Running) return Status.Running;
                if (childStatus == Status.Failure) return Status.Failure;
                if (haslimit)
                {
                    if (++counter == limit) return Status.Success;

                }


            }
        }
    }
}