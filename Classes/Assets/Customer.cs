using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer
{
    public string firstName;
    public string lastName;
    public int id;
    public int age;
    public char gender;
    public string occupation;
    public System.DateTime joinedAt;
    public Customer(string firstName, string lastName, int id, int age, char gender, string occupation, System.DateTime joinedAt)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
        this.joinedAt = joinedAt;
    }

}
