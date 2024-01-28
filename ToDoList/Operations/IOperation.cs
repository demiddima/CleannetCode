namespace ToDoList.Operations
{
    public interface IOperation
    {
        public string Name { get; }
        void Execute();
    }
}
