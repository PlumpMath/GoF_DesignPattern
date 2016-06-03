using System;
using GoF.DesignPattern.Command;

namespace GoF.DesignPattern
{
    internal class CommandMain
    {
        public static void Main()
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light();
            Ac ac = new Ac();
            WashingMachine washingMachine = new WashingMachine();

            remoteControl.SetCommand(0, new LightOnCommand(light), new LightOffCommand(light));
            remoteControl.SetCommand(1, new AcOnCommand(ac, 25), new AcOffCommand(ac, 25));
            remoteControl.SetCommand(2, new WashingMachingOnCommand(washingMachine, 10), new WashingMachingOffCommand(washingMachine, 10));

            /*
             *      ON    OFF
             *          
             *      0      0      Slot1       Light
             *      1      1      Slot2       Ac
             *      2      2      Slot3       WashingMachine
             *      3      3      Slot4       Empty
             *      4      4      Slot5       Empty
             * 
             */

            string type;
            int index;
            while (true)
            {
                Console.WriteLine("****Remote Control********\n");
                Console.WriteLine("On or Off or Undo : ");
                type = Console.ReadLine();

                Console.WriteLine("Enter index : ");
                index = Convert.ToInt32(Console.ReadLine());

                if (type == "On")
                {
                    remoteControl.ButtonOnPressed(index);
                }
                if (type == "Off")
                {
                    remoteControl.ButtonOffPressed(index);
                }
                if (type == "Undo")
                {
                    remoteControl.UndoButtonPressed();
                }
            }
        }
    }
}
