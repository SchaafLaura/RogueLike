﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecsRL
{
    public class Creature : Actor
    {
        public override Action getAction()
        {
            MovementAction ret = new MovementAction(this.ID);
            Random rng = new Random();

            int number = rng.Next(0, 100);

            if(number <= 25)
            {
                ret.direction = MovementAction.N;
            }
            else if(number <= 50)
            {
                ret.direction = MovementAction.E;
            }
            else if(number <= 75)
            {
                ret.direction = MovementAction.S;
            }
            else
            {
                ret.direction = MovementAction.W;
            }
            return ret;
        }
    }
}