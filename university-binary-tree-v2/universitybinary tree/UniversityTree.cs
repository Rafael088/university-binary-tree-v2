using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universitybinary_tree
{
    class UniversityTree
    {
        public PositionNode Root;

        public void CreatePosition(PositionNode parent, Position positionToCreate, String parentPositionName) {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;
            if (Root == null) {
                Root = newNode;
                return;
            }
            if (parent == null) {
                return;
            }
            if (parent.Position.Name == parentPositionName) {
                if (parent.Left == null) {
                    parent.Left = newNode;
                    return;
                }
                parent.Right = newNode;
                return;
            }
            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Right, positionToCreate, parentPositionName);
        }
        public void PrintTree(PositionNode from)
        {
            if (from == null) {
                return;
            }
            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");
            PrintTree(from.Left);
            PrintTree(from.Right);
        }
        public float AddSalary(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return from.Position.Salary + AddSalary(from.Left) + AddSalary(from.Right);

        }
        float salary = 0;
        public float SalaryLg(PositionNode from)
        {

            if (from == null) {
                return 0;
            }
                
            if (salary < from.Position.Salary)
            {
                salary = from.Position.Salary;
                SalaryLg(from.Left);
                SalaryLg(from.Right);
            }
            if (from.Position.Name == "rector")
            {
                salary = 0;
            }
            SalaryLg(from.Left);
            SalaryLg(from.Right);
            return salary;
        }
        public float NodeCounter(PositionNode from)
        {
            float counter = 1;
            if (from.Left != null)
            {
                counter += NodeCounter(from.Left);
            }
            if (from.Right != null)
            {
                counter += NodeCounter(from.Right);
            }
            return counter;
        }
        public float AvgSalary(PositionNode from)
        {
            float suma = AddSalary(from);
            float contador = NodeCounter(from);
            return suma / contador;
        }
        public float SalaryForPosition(PositionNode from, string name)
        {
            if (from == null)
            {
                return 0;
            }
            if (from.Position.Name == name)
            {
                return from.Position.Salary;
            }
            return SalaryForPosition(from.Left, name) + SalaryForPosition(from.Right, name);
        }
        public float taxSalary(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return (from.Position.Salary * Convert.ToSingle(from.Position.tax)) + taxSalary(from.Left) + taxSalary(from.Right);

        }
    }
}
