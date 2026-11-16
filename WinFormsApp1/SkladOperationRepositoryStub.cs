using System.Collections.Generic;

namespace WinFormsApp1
{
    public class SkladOperationRepositoryStub : ISkladOperationRepository
    {
        private readonly List<SkladOperation> _operations = new List<SkladOperation>();

        public void Add(SkladOperation operation)
        {
            _operations.Add(operation);
        }

        public IEnumerable<SkladOperation> GetAll() => _operations;
    }
}