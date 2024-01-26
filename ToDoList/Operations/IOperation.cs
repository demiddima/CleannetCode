namespace ToDoList.Operations
{
    internal interface IOperation
    {
        public string Name { get; }
        void Execute();
    }
}
