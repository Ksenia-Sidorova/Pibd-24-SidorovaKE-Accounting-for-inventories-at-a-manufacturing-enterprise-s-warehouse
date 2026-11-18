using System.Collections.Generic;

namespace WinFormsApp1
{
    public interface IMaterialRepository
    {
        void Add(Material material);
        IEnumerable<Material> GetAll();
        Material GetById(int id);
        void Update(Material material);
        void Delete(int id);
    }
}