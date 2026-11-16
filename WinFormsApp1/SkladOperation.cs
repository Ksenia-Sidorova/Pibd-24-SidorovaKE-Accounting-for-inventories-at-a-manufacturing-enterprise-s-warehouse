using System;

namespace WinFormsApp1
{
    public enum OperationType
    {
        Income, //приход
        Expense,//расход
        DefectiveReturn//возврат брака
    }

    public class SkladOperation
    {
        public int Id { get; private set; }
        public int MaterialId { get; private set; }
        public OperationType Type { get; private set; }
        public int Quantity { get; private set; }
        public DateTime Date { get; private set; }

        private SkladOperation() { }

        public static SkladOperation Create(int materialId, OperationType type, int quantity, DateTime date)
        {
            if (quantity <= 0)
                throw new ArgumentException("Количество должно быть положительным", nameof(quantity));

            return new SkladOperation
            {
                MaterialId = materialId,
                Type = type,
                Quantity = quantity,
                Date = date
            };
        }
    }
}