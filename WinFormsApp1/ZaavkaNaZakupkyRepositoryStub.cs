using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp1
{
    public class ZaavkaNaZakupkyRepositoryStub : IZaavkaNaZakupkyRepository
    {
        private readonly List<ZaavkaNaZakupky> _requests = new List<ZaavkaNaZakupky>();

        public void Add(ZaavkaNaZakupky request)
        {
            _requests.Add(request);
        }

        public IEnumerable<ZaavkaNaZakupky> GetAll() => _requests;

        public void Update(ZaavkaNaZakupky request)
        {
            var existing = _requests.FirstOrDefault(r => r.Id == request.Id);
            if (existing != null)
            {
                existing.Complete();
            }
        }
    }
}