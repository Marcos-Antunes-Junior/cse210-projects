using System;

public class SalaryEmployee : Employee {
    
    private float salary = 100f;

    public override float CalculatePay()
    {
        return salary;
    }
}