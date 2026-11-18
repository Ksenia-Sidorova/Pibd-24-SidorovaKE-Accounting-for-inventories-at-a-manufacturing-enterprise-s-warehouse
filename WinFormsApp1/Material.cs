
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public class Material
    {// 1. Приватные сеттеры
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int UnitIzmereniya { get; private set; }
        public decimal SkladQuantity { get; private set; }
        public decimal MinOstatok { get; private set; }
        // Пустой конструктор (нужен для некоторых библиотек)
        private Material() { }

        // Статический метод для создания с защитой от null
        public static Material Create(string name, int unitIzmereniya, decimal minOstatok)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название материала не может быть пустым", nameof(name));

            if (minOstatok < 0)
                throw new ArgumentException("Минимальный остаток не может быть отрицательным", nameof(minOstatok));

            return new Material
            {
                Name = name,
                UnitIzmereniya = unitIzmereniya,
                MinOstatok = minOstatok,
             
                SkladQuantity = 0// при создании остаток на складе равен 0
            };
        }
        // Методы для изменения остатков (для операций)
        public void AddStock(decimal quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Количество должно быть больше нуля");
            SkladQuantity += quantity;
            
        }

        public void WriteOffStock(decimal quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Количество должно быть больше нуля");
            if (quantity > SkladQuantity) throw new InvalidOperationException("Недостаточно материала на складе");
            SkladQuantity -= quantity;
           
        }

        public void UpdateInfo(string name, int unitIzmereniya, decimal minOstatok)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название материала не может быть пустым", nameof(name));

            Name = name;
            UnitIzmereniya = unitIzmereniya;
            MinOstatok = minOstatok;
        }

        public void SetId(int id)
        {
            ID = id;
        }

        public MaterialStatus CurrentStatus
        {
            get
            {
                MaterialStatus status = MaterialStatus.None;

                if (SkladQuantity > 0)
                    status |= MaterialStatus.InStock;

                if (SkladQuantity <= MinOstatok)
                    status |= MaterialStatus.Expected;

                if (SkladQuantity == 0)
                    status |= MaterialStatus.Defective;

                return status;
            }
        }
    }
}