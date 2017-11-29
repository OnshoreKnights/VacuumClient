namespace IntelligentVacuum.Agent
{
    using System;
    using System.Collections.Generic;
    using Environments;

    public class Agent
    {
        public Agent(Sensor sensor)
        {
        }

        // Agent action is determined based off of randomization. 
        public AgentAction DecideAction(Room room)
        {
            // Assignment of variables and instances of classes.
            AgentAction action;
            bool isDirty = room.IsDirty;
            Random random = new System.Random();
            int number = random.Next(1, 5);

            // If the room is not dirty step into switch/case
            if (!isDirty)
            {         
                // Use of RNG to determine the agents actions.   
                switch(number)
                {
                    case 1:
                        action = AgentAction.MOVE_DOWN;
                        return action;
                    case 2:
                        action = AgentAction.MOVE_LEFT;
                        return action;
                    case 3:
                        action = AgentAction.MOVE_UP;
                        return action;
                    case 4:
                        action = AgentAction.MOVE_RIGHT;
                        return action;
                    default:
                        action = AgentAction.MOVE_RIGHT;
                        return action;
                }
            }
            // If the room is dirty, clean it up.
            else
            {
                action = AgentAction.CLEAN;
                return action;
            }
        }
    }
}