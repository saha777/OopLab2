using Lab2.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Model
{
    public class Robot : ICloneable
    {
        public ERobot RobotType { get; private set; }
        public int StartBatteryBalance { get; private set; }
        public int BatteryBalance { get; private set; }
        public int MaxMass { get; private set; }
        public int Mass { get; private set; }
        public int MassCostly { get; private set; }

        public Robot(int batteryBalance, int maxMass, ERobot robotType)
        {
            StartBatteryBalance = batteryBalance;
            BatteryBalance = batteryBalance;
            MaxMass = maxMass;
            RobotType = robotType;
            MassCostly = 0;
            Mass = 0;
        }

        public void MinusBattery(int AdditionalMinus = 0)
        {
            BatteryBalance -= AdditionalMinus;
            BatteryBalance -= (StartBatteryBalance * Mass) / (MaxMass * 10);
        }

        public void AddMass(Box box)
        {
            if (box.GetMass() + Mass < MaxMass)
            {
                MassCostly += box.GetCost();
                Mass += box.GetMass();
            }
        }

        public string ToString()
        {
            return " Robot { mass: " + Mass + "; battery: " + BatteryBalance + "; costly: " + MassCostly + "} ";
        }

        public object Clone()
        {
            Robot clone = new Robot(BatteryBalance, MaxMass, RobotType);
            clone.BatteryBalance = BatteryBalance;
            clone.Mass = Mass;
            clone.MassCostly = MassCostly;
            return clone;
        }
    }
}
