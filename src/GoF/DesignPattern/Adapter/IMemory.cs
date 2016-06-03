namespace GoF.DesignPattern.Adapter
{
    /// <summary>
    /// Old Interace. Currently used by client.
    /// </summary>
    internal interface IMemory
    {
        void ReadDataFromSector();
        void WriteDataToSector();
    }
}