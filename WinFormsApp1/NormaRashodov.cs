using System;

namespace WinFormsApp1
{
    public class NormaRashodov
    {
        public int ProductId { get; private set; }
        public int MaterialId { get; private set; }
        public int QuantityNaEdinicy { get; private set; }

        private NormaRashodov() { }

        public static NormaRashodov Create(int productId, int materialId, int quantityNaEdinicy)
        {
            if (quantityNaEdinicy <= 0)
                throw new ArgumentException("Количество материала на единицу продукции должно быть положительным", nameof(quantityNaEdinicy));

            return new NormaRashodov
            {
                ProductId = productId,
                MaterialId = materialId,
                QuantityNaEdinicy = quantityNaEdinicy
            };
        }
    }
}