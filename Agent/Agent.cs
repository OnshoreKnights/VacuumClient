namespace IntelligentVacuum.Agent
{
    using System;
    using System.Collections.Generic;
    using Environments;

    public class Agent
    {
        public Agent()
        {
        }

        public AgentAction DecideAction(Room room)
        {
            AgentAction nextAction;
            if(room.IsDirty) 
            {
                nextAction = AgentAction.CLEAN;
            }
            else 
            {
                Random random = new Random();
                int nextDirection = random.Next(0,3);
                switch(nextDirection)
                {
                    case 0:
                        nextAction = AgentAction.MOVE_RIGHT;
                        break;
                    case 1:
                        nextAction = AgentAction.MOVE_DOWN;
                        break;
                    case 2:
                        nextAction = AgentAction.MOVE_LEFT;
                        break;
                    default:
                        nextAction = AgentAction.MOVE_UP;
                        break;
                }       
            }
            return nextAction;
        }
    }
}