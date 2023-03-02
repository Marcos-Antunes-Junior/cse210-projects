using System;

public class HourlyEmployee : Employee {


private float rate = 9f;
private float hours = 100f;

    public override float CalculatePay()
    {
        return rate * hours;
    }




}