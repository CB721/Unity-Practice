using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    // create an array of grades
    ArrayList grades = new ArrayList();
    // for each grade, add to the total
    private int total;
    // variable amount of grades to be generated, default to 5
    public int gradeAmount = 5;
    // convert a number to a letter grade
    static string ConvertGrades(int grade)
    {
        string letterGrade = "A";
        switch (grade)
        {
            case 1:
                letterGrade = "A+";
                break;
            case 2:
                letterGrade = "A";
                break;
            case 3:
                letterGrade = "A-";
                break;
            case 4:
                letterGrade = "B+";
                break;
            case 5:
                letterGrade = "B";
                break;
            case 6:
                letterGrade = "B-";
                break;
            case 7:
                letterGrade = "C+";
                break;
            case 8:
                letterGrade = "C";
                break;
            case 9:
                letterGrade = "C-";
                break;
            case 10:
                letterGrade = "D+";
                break;
            case 11:
                letterGrade = "D";
                break;
            case 12:
                letterGrade = "D-";
                break;
            case 13:
                letterGrade = "F";
                break;
            default:
                break;
        };
        return letterGrade;
    }
    void Start()
    {
        // create five random grades
        for (int i = 0; i < gradeAmount; i++)
        {
            // generate random number 1 through 15
            int randomGrade = Random.Range(1, 13);
            // based on the number, add the grade to the grades array
            string convertedGrade = ConvertGrades(randomGrade);
            // add that number to grades array
            grades.Add(ConvertGrades(randomGrade));
            // add the number to the total
            total += randomGrade;
        }
        // get the average grades
        float avg = Mathf.Round(total / grades.Count);
        string avgGrade = ConvertGrades((int)avg);
        // print the all of the grades
        for (int j= 0; j < grades.Count; j++)
        {
            Debug.Log($"Grade number {j + 1} is {grades[j]}.");
        }
        // print the average grade
        Debug.Log($"The average grade is {avgGrade}");
    }
}
