using Lab2.Command;
using Lab2.Memento;
using Lab2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.State
{
    public class Context : IContext
    {
        public Robot Robot { get; private set; }
        public State State { get; private set; }

        private List<RobotSnapshot> robotSnapshots;

        public Context()
        {
            State = StateFactory.Create(EState.START, this);
            robotSnapshots = new List<RobotSnapshot>();
        }

        public void SetState(State state)
        {
            this.State = state;
        }

        public void SetRobot(Robot robot)
        {
            if (State is StartGameState || State is BackUpState)
            {
                Robot = robot;
            }
        }

        public List<ICommand> Execute(ICommand command = null)
        {
            if (State == null)
            {
                return null;
            }
            else if (command == null)
            {
                return State.Commands;
            }

            command.Execute();
            return State == null ? null : State.Commands;
        }

        public void AddSnaphot(RobotSnapshot robotSnapshot)
        {
            robotSnapshots.Add(robotSnapshot);
        }

        public List<RobotSnapshot> GetRobotSnapshots()
        {
            return robotSnapshots;
        }
    }
}
