using ConsoleUtilities;
using System.Text.RegularExpressions;

namespace CSharpCourse.Exceptions.Ex03;

public class Solution
{
    static ConsoleCompanion cc = new ConsoleCompanion();

    public static void Run()
    {

        while (true)
        {
            bool succeded = AskForAnimalsAndReportTheAmount();

            if (succeded)
                break;
        }

    }

    private static bool AskForAnimalsAndReportTheAmount()
    {
        string animalsString = cc.AskForString("Enter a list of animals:");

        try
        {
            string[] animals = ParseAnimals(animalsString);
            Console.WriteLine($"There are {animals.Length} animals in the list");
            return true;
        }
        catch (ArgumentException ex)
        {
            cc.WriteLineRed(ex.Message);
        }
        catch (Exception)
        {
            cc.WriteLineRed("Unexpected error");
        }
        return false;
    }


    private static string[] ParseAnimals(string animalsString)
    {
        if (string.IsNullOrWhiteSpace(animalsString))
            throw new ArgumentException("Animal string don't contain any letters");

        string[] animals = animalsString.Split(',');

        foreach (string animal in animals)
        {
            if (string.IsNullOrWhiteSpace(animal))
                throw new ArgumentException("One of the animals didn't contain any letters");

            if (!AllowedAnimal(animal))
                throw new ArgumentException($"Animal:'{animal}' contains invalid letters");

            if (animal.Length > 10)
                throw new ArgumentException($"This animal:'{animal}' has too many letters");
        }

        return animals;
    }

    private static bool AllowedChar(char c)
    {
        return c >= 'a' && c <= 'z' || c == 'å' || c == 'ä' || c == 'ö' || c == ' ';
    }

    private static bool AllowedAnimal_Regex(string animal)
    {
        return Regex.IsMatch(animal, @"^[a-zåäö ]+$", RegexOptions.IgnoreCase);
    }

    private static bool AllowedChar_Alternative(char c)
    {
        return c >= 'a' && c <= 'z' || "åäö ".Contains(c.ToString());
    }

    private static bool AllowedAnimal(string animal)
    {
        animal = animal.ToLower();

        foreach (char c in animal)
        {
            if (!AllowedChar(c))
                return false;
        }
        return true;
    }

    private static bool AllowedAnimal_WithLinq(string animal)
    {
        return animal.ToLower().All(AllowedChar);
    }
}
