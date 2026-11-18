using System;

namespace WinFormsApp1
{
    public class ZaavkaNaZakupky
    {
        public int Id { get; private set; }
        public int MaterialId { get; private set; }
        public int Quantity { get; private set; }
        public DateTime DataSozdania { get; private set; }
        public bool Zaverheno { get; private set; }

        private ZaavkaNaZakupky() { }

        public static ZaavkaNaZakupky Create(int materialId, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Количество должно быть положительным", nameof(quantity));

            return new ZaavkaNaZakupky
            {
                MaterialId = materialId,
                Quantity = quantity,
                DataSozdania = DateTime.Now,
                Zaverheno = false
            };
        }

        public void Complete()
        {
            Zaverheno = true;
        }
    }
}