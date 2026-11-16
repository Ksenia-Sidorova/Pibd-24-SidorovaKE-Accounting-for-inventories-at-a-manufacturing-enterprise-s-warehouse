using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp1
{
    public class NormaRashodovRepositoryStub : INormaRashodovRepository
    {
        private readonly List<NormaRashodov> _normas = new List<NormaRashodov>();

        public void Add(NormaRashodov norma) => _normas.Add(norma);

        public IEnumerable<NormaRashodov> GetAll() => _normas;

        public IEnumerable<NormaRashodov> GetByProductId(int productId)
        {
            return _normas.Where(n => n.ProductId == productId).ToList();
        }
    }
}