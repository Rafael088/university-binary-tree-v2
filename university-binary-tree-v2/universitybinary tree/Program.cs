using System;

namespace universitybinary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;
            rectorPosition.tax = 0.02;

            Position vicPosition = new Position();
            vicPosition.Name = "vicerector financiero";
            vicPosition.Salary = 750;
            vicPosition.tax = 0.03;

            Position contadorPosition = new Position();
            contadorPosition.Name = "contador";
            contadorPosition.Salary = 500;
            contadorPosition.tax = 0.04;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "jefe financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.tax = 0.05;

            Position secFin1Position = new Position();
            secFin1Position.Name = "secretaria financiera 1";
            secFin1Position.Salary = 350;
            secFin1Position.tax = 0.06;

            Position secFin2Position = new Position();
            secFin2Position.Name = "secretaria financiera 2";
            secFin2Position.Salary = 310;
            secFin2Position.tax = 0.07;


            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "vicerector academico";
            vicAcadPosition.Salary = 780;
            vicAcadPosition.tax = 0.08;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "jefe de registro";
            jefeRegPosition.Salary = 640;
            jefeRegPosition.tax = 0.09;

            Position secReg1Position = new Position();
            secReg1Position.Name = "secretaria registro 1";
            secReg1Position.Salary = 400;
            secReg1Position.tax = 0.10;

            Position asi1Position = new Position();
            asi1Position.Name = "asistente 1";
            asi1Position.Salary = 250;
            asi1Position.tax = 0.11;

            Position asi2Position = new Position();
            asi2Position.Name = "asistente 2";
            asi2Position.Salary = 170;
            asi2Position.tax = 0.12;

            Position menPosition = new Position();
            menPosition.Name = "mesajero";
            menPosition.Salary = 90;
            menPosition.tax = 0.13;

            Position secReg2Position = new Position();
            secReg2Position.Name = "secretaria registro 2";
            secReg2Position.Salary = 360;
            secReg2Position.tax = 0.14;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg2Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asi1Position, secReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asi2Position, secReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, menPosition, asi2Position.Name);

            universityTree.PrintTree(universityTree.Root);
            float totalSalary = universityTree.AddSalary(universityTree.Root);
            Console.WriteLine($"Total salaries :  {totalSalary}");
            Console.ReadLine();
            float salaryHigh = universityTree.SalaryLg(universityTree.Root);
            Console.WriteLine($"the highest salary apart from the rector is : {salaryHigh}");

            float PromedioSalario = universityTree.AvgSalary(universityTree.Root);
            Console.WriteLine($"Average wages is : {PromedioSalario}");
            
            Console.WriteLine("whose salary do you want to know?");
            String find = Console.ReadLine();
            float salaryForPosition = universityTree.SalaryForPosition(universityTree.Root, find);
            if (salaryForPosition == 0)
            {
                Console.WriteLine("the name is not valid");
            }
            else
            {
                Console.WriteLine($"this person's salary is: {salaryForPosition}");
            }

            float taxSalary = universityTree.taxSalary(universityTree.Root);
            Console.WriteLine($"the sumatory tax is {taxSalary}");
        }
    }
}
