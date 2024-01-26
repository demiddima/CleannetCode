using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Operations;

namespace ToDoList.Infrastructure
{
    internal class Menu
    {
        private IOperation[] _operations;

        public Menu(IOperation[] operations)
        {
            _operations = operations;
        }

        public string[] GetOperationNames()
        {
            List<string> operationNames = new List<string>();

            for (int i = 0; i < _operations.Length; i++)
            {
                IOperation operation = _operations[i];
                operationNames.Add($"{i} - {operation.Name}");
            }

            return operationNames.ToArray();
        }

        public void Enter(int operationNumber)
        {
            if (operationNumber < 0 || operationNumber >= _operations.Length)
                throw new ArgumentOutOfRangeException("Считать научись");

            _operations[operationNumber].Execute();
        }
    }
}
