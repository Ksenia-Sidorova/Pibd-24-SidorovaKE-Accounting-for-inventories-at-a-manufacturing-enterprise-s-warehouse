using System.Collections.Generic;

namespace WinFormsApp1
{
    public interface ISkladOperationRepository
    {
        void Add(SkladOperation operation);
        IEnumerable<SkladOperation> GetAll();
    }
}