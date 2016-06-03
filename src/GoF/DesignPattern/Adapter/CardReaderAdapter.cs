namespace GoF.DesignPattern.Adapter
{
    /// <summary>
    /// Adaptor
    /// </summary>
    internal class CardReaderAdapter : IMemory
    {
        // This should use interface. Just for the sake of simplicity i used concrete class.
        private readonly SdCard _sdCard;

        public CardReaderAdapter(SdCard sdCard)
        {
            _sdCard = sdCard;
        }

        public void ReadDataFromSector()
        {
            _sdCard.ReadDataFromTrack();
        }

        public void WriteDataToSector()
        {
            _sdCard.WriteDataToTrack();
        }
    }
}
