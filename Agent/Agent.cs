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
            Console.WriteLine("This is a git/VS test");
            return AgentAction.NONE;
        }
    }
}