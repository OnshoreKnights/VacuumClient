namespace IntelligentVacuum.Agent
{
    using System;
    using System.Collections.Generic;
    using Environments;

    public class Agent
    {
        static Random rnd = new Random();
        public Agent()
        {
        }

        public AgentAction DecideAction(Room room)
        {
            AgentAction action;
            List<AgentAction> options = new List<AgentAction>();
            AgentAction[] array = new AgentAction[] {AgentAction.MOVE_DOWN, AgentAction.MOVE_LEFT, AgentAction.MOVE_RIGHT, AgentAction.MOVE_UP};
            options.AddRange(array);
            //SENSE
            bool isDirty = room.IsDirty;
            //PLAN
            if (isDirty)
            {
                action = AgentAction.CLEAN;
            }
            else
            {
                int x = rnd.Next(0, options.Count);
                action = options[x];
            }
            //ACTION
            return action;
        }
    }
}