namespace GoF.DesignPattern.Adapter
{
    /// <summary>
    /// Client
    /// </summary>
    internal class SonyLaptop
    {
        private readonly IMemory _memory;

        public SonyLaptop(IMemory memory)
        {
            _memory = memory;
        }

        public void ReadData()
        {
            _memory.ReadDataFromSector();
        }

        public void WriteData()
        {
            _memory.WriteDataToSector();
        }
    }
}
