using System.Collections.Generic;

namespace WinFormsApp1
{
    public interface INormaRashodovRepository
    {
        void Add(NormaRashodov norma);
        IEnumerable<NormaRashodov> GetAll();
        IEnumerable<NormaRashodov> GetByProductId(int productId);
    }
}