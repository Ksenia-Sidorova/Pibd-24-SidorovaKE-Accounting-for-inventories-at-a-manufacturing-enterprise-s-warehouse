using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp1
{
    public class MaterialRepositoryStub : IMaterialRepository
    {
        private readonly List<Material> _materials = new List<Material>();

        public void Add(Material material)
        {
            if (material.ID == 0)
                material.SetId(_materials.Count > 0 ? _materials.Max(m => m.ID) + 1 : 1);

            _materials.Add(material);
        }

        public IEnumerable<Material> GetAll() => _materials;

        public Material GetById(int id) => _materials.FirstOrDefault(m => m.ID == id);

        public void Update(Material material)
        {
            var existing = GetById(material.ID);
            if (existing != null)
            {
                existing.UpdateInfo(material.Name, material.UnitIzmereniya, material.MinOstatok);
            }
        }

        public void Delete(int id)
        {
            var material = GetById(id);
            if (material != null) _materials.Remove(material);
        }
    }
}