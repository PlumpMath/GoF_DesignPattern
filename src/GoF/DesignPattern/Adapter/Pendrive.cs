using System;

namespace GoF.DesignPattern.Adapter
{
    /// <summary>
    /// Concrete implementation of old interface
    /// </summary>
    internal class Pendrive : IMemory
    {
        public void ReadDataFromSector()
        {
            Console.WriteLine("Reading Data from pendrive");
        }

        public void WriteDataToSector()
        {
            Console.WriteLine("Writing Data to pendrive");
        }
    }
}
