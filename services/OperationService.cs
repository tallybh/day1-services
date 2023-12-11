namespace services
{
    public class OperationService : ITransientService, ISingletonService, IScopedService
    {
        Guid id;
        public Guid GetOperationID()
        {
            return id;
        }

        public OperationService()
        {
            id = Guid.NewGuid();
        }
    }
}
