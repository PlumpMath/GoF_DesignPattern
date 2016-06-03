using System;

namespace GoF.DesignPattern.Adapter
{
    /// <summary>
    /// Adaptee
    /// Concrete implementation of New Interface. Different from that of existing one. 
    /// </summary>
    internal class SdCard
    {
        public void ReadDataFromTrack()
        {
            Console.WriteLine("Reading Data from SD card");
        }

        public void WriteDataToTrack()
        {
            Console.WriteLine("Writing Data to SD Card");
        }
    }
}
