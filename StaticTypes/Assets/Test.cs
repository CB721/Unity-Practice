using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee
{
    public int employeeID;
    public string firstName, lastName;
    public int salary;
    public static string company;
    public Employee(int employeeID, string firstName, string lastName, int salary)
    {
        this.employeeID = employeeID;
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
        Debug.Log("Initialized instances");
    }
    static Employee()
    {
        company = "CB721";
        Debug.Log("Initialized static members");
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Employee john = new Employee(1, "john", "appleseed", 345677);
        Employee miles = new Employee(2, "miles", "prior", 70000);
        Employee james = new Employee(3, "james", "mcguil", 20000);
    }
}
