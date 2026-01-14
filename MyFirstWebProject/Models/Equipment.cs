namespace MyFirstProject.Models
{
    public class Equipment
    {
        public static int equipmentCountId = 0;
        public string Brand;
        public string Model;
        public int Id;

        public Equipment(string brand, string model)
        {
            equipmentCountId++;
            this.Brand = brand;
            this.Model = model;
            this.Id = equipmentCountId;
        }
    }
}
