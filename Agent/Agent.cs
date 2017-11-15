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

        public AgentAction DecideAction(Room room)
        {
            return AgentAction.NONE;
        }
    }
}