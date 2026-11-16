using System;

namespace WinFormsApp1
{
    public class Product
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int UnitIzmereniya { get; private set; }

        private Product() { }

        public static Product Create(string name, int unitIzmereniya)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название продукции не может быть пустым", nameof(name));

            return new Product { Name = name, UnitIzmereniya = unitIzmereniya };
        }

        public void UpdateInfo(string name, int unitIzmereniya)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название продукции не может быть пустым", nameof(name));

            Name = name;
            UnitIzmereniya = unitIzmereniya;
        }
        public void SetId(int id)
        {
            ID = id;
        }
    }
}