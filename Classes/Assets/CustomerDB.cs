using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDB : MonoBehaviour
{
    public Customer charlie;
    public Customer snoopy;
    public Customer linus;
    // Start is called before the first frame update
    void Start()
    {
        charlie = CreateCustomer("Charlie", "Brown", 0, 8, 'M', "Kicker");
        snoopy = CreateCustomer("Snoopy", "Brown", 1, 3, 'M', "Dog");
        linus = CreateCustomer("Linus", "van Pelt", 2, 8, 'M', "Blanket Holder");
    }
    private Customer CreateCustomer(string firstName, string lastName, int id, int age, char gender, string occupation)
    {
        return new Customer(firstName, lastName, id, age, gender, occupation, System.DateTime.Now);
    }
}
