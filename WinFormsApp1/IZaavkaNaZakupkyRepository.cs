using System.Collections.Generic;

namespace WinFormsApp1
{
    public interface IZaavkaNaZakupkyRepository
    {
        void Add(ZaavkaNaZakupky request);
        IEnumerable<ZaavkaNaZakupky> GetAll();
        void Update(ZaavkaNaZakupky request);
    }
}