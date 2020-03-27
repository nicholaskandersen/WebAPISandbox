namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IToDoRepository ToDo { get; }
        IAccountRepository Account { get; }
        void Save();
    }
}
