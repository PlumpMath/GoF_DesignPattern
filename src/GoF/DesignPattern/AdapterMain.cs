using GoF.DesignPattern.Adapter;

namespace GoF.DesignPattern
{
    internal class AdapterMain
    {
        public static void Main(string[] args)
        {
            // SonyLaptop(client in this case) has an USB port that can talk directly with the pendrive as the pendrive adhere to the interace that Sonylaptop require.
            SonyLaptop sonyLaptopUsingPendrive = new SonyLaptop(new Pendrive());
            sonyLaptopUsingPendrive.WriteData();
            sonyLaptopUsingPendrive.ReadData();

            // Now suppose we want to use SD card. The interface of SD card and SonyLaptop are different. We use card reader(adaptor in this case) to access SD Card(adaptee in this case). Card reader adheres to the same interface as that of laptop. 
            SonyLaptop sonyLaptopUsingSdCard = new SonyLaptop(new CardReaderAdapter(new SdCard()));
            sonyLaptopUsingSdCard.WriteData();
            sonyLaptopUsingSdCard.ReadData();
        }
    }
}
