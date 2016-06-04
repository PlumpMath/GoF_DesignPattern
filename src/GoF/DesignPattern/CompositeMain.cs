using GoF.DesignPattern.Composite;

namespace GoF.DesignPattern
{
    internal class CompositeMain
    {
        public static void Main(string[] args)
        {
            
            Menu breakfastMenu = new Menu("Breakfast", "Start your day Heavy...");
            breakfastMenu.AddMenuItem(new MenuItem("Idli", "South Indian", 30, true));
            breakfastMenu.AddMenuItem(new MenuItem("Samosa", "North Indian", 10, true));
            breakfastMenu.AddMenuItem(new MenuItem("Dhokla", "Gujrati Special", 20, true));
            breakfastMenu.AddMenuItem(new MenuItem("Chicken Momos", "Taste of East", 40, false));

            Menu iceCreamMenu = new Menu("Ice-Creams", "Ice in Desert");
            iceCreamMenu.AddMenuItem(new MenuItem("Vanila", "Simple", 35, true));
            iceCreamMenu.AddMenuItem(new MenuItem("Kaju-Draksh", "Healthy", 40, true));
            iceCreamMenu.AddMenuItem(new MenuItem("Almond", "Power", 40, true));

            Menu milkShakeMenu = new Menu("Milk Shakes", "Thick and Healthy");
            milkShakeMenu.AddMenuItem(new MenuItem("Banana Shake", "Power", 35, true));
            milkShakeMenu.AddMenuItem(new MenuItem("Mango Shake", "Season Fresh", 40, true));
            milkShakeMenu.AddMenuItem(new MenuItem("Chocolate Shake", "All time favourite", 30, true));

            Menu desertMenu = new Menu("Desert", "Leave Happy");
            desertMenu.AddMenuItem(new MenuItem("Pan", "Pleasure", 15, true));
            desertMenu.AddMenuItem(new MenuItem("Lassi", "Got More", 30, true));
            desertMenu.AddMenuItem(iceCreamMenu);
            desertMenu.AddMenuItem(milkShakeMenu);

            Menu mainCourseMenu = new Menu("Main Course", "Delicious");
            mainCourseMenu.AddMenuItem(new MenuItem("Paneer Tikka", "Roast", 140, true));
            mainCourseMenu.AddMenuItem(new MenuItem("Butter Chicken", "Buttery", 150, false));
            mainCourseMenu.AddMenuItem(new MenuItem("Chicken Masala", "Spicy", 150, false));
            mainCourseMenu.AddMenuItem(new MenuItem("Veg Makhanwala", "Sweet", 130, true));

            Menu mainMenu = new Menu("Food", "Finger Lickin' taste");
            mainMenu.AddMenuItem(new MenuItem("Tea", "Dhadkan", 10, true));
            mainMenu.AddMenuItem(new MenuItem("Coffee", "Expresso", 15, true));
            mainMenu.AddMenuItem(new MenuItem("Cream Roll", "Sides", 8, true));
            mainMenu.AddMenuItem(breakfastMenu);
            mainMenu.AddMenuItem(mainCourseMenu);
            mainMenu.AddMenuItem(desertMenu);

            mainMenu.Print();

        }
    }
}
