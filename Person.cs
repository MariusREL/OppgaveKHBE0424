using System;

public class Person
{
    public bool isYoung = false;
    public void PersonDetails()
    {
        double age = 25.2;
        string name = "Marius";
        bool isOld = true;
        char grade = 'B';
        int a = 5, b = 10, c = 20;
        Console.WriteLine("My name is " + name);
        Console.WriteLine(name + " " + "is " + age + " old");
        Console.WriteLine(isOld);

        string[] phones = {"Iphone", "Samsung", "Huawei", "Pixel", "Motorola"};

        List<string> shoppingList = new List<string>(){"Milk", "Salmon", "Butter", "Ice"};

        Console.WriteLine(phones[3]);
        {
        for(int i = 0; i < shoppingList.Count; i++ )
        Console.WriteLine(shoppingList[i]);
        }
    }
}






