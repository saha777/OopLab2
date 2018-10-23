using Lab2.Command;
using Lab2.Model;
using Lab2.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommand command = null;
            Context context = new Context();

            Console.WriteLine("Start program!");

            do
            {
                List<ICommand> commands = context.Execute(command);
                if (commands == null) break;
                command = ChooseCommand(commands, context.Robot);
            } while (command != null);

            Console.WriteLine("End program!");
        }

        static ICommand ChooseCommand(List<ICommand> commands, Robot robot, bool error = false)
        {
            Console.Clear();

            if (error) Console.WriteLine("Error input, please, try again!");

            StringBuilder stringBuilder = new StringBuilder();

            if (robot != null)
            {
                stringBuilder.AppendLine("Robot state")
                    .AppendLine(robot.ToString());
            }

            stringBuilder.AppendLine("Actions: ");

            int i = 0;

            foreach (ICommand command in commands)
            {
                stringBuilder.AppendLine(++i + " " + command.ToString());
            }

            stringBuilder.AppendLine("Input number of action: ");

            Console.Write(stringBuilder);
            try
            {
                int index = Int32.Parse(Console.ReadLine());
                if (index > 0 && index <= commands.Count)
                {
                    return commands[index - 1];
                }
            } catch (FormatException e) {  }
            return chooseCommand(commands, robot, true);
        }
    }
}
