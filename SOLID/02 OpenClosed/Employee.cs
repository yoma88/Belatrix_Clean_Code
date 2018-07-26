namespace SOLID._02_OpenClosed
{
    abstract class Employee
    {
        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        public abstract decimal CalculateBonus(decimal salary);
    }

    internal class EmployeePermanent : Employee
    {
        public EmployeePermanent(int id, string name, string type)
        {
            ID = id;
            Name = name;
            EmployeeType = EmployeeTypeList.Permanent;
        }
           
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    internal class EmployeeTemporary : Employee
    {
        public EmployeeTemporary(int id, string name, string type)
        {
            ID = id;
            Name = name;
            EmployeeType = EmployeeTypeList.Temporary;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

    static class EmployeeTypeList
    {
        public const string Permanent = "Permanent";
        public const string Temporary = "Temporary";
    }

}

