// Difference between array and lists. Common methods.

namespace CSharpCourse.Collections.Demo;

public class Demo1
{
    public static void Run()
    {
        // Create a list with four fishes

        //var fishes = new List<string>();
        //fishes.Add("Makrill");
        //fishes.Add("Torsk");
        //fishes.Add("Sill");
        //fishes.Add("Lax");

        // Use collection initialization + count nr of fishes
        var fishes = new List<string>
        {
            "Makrill",
            "Torsk",
            "Sill",
            "Lax"
        };

        int nrOfFishes = fishes.Count; // 4

        // Get first and third element
        string firstFish = fishes[0]; // Makrill
        string thirdFish = fishes[2]; // Sill

        // Remove the first "Sill" + count
        fishes.Remove("Sill");
        nrOfFishes = fishes.Count;   // 3

        // Create a list of three numbers 570, 1492, 1789
        List<int> importantYears = new List<int> { 570, 1492, 1789 };

        // Add 1917 to the list + count
        importantYears.Add(1917);
        int count1 = importantYears.Count; // 4

        // Create an array of three numbers 570, 1492, 1789 + count + try add a number
        int[] importantYears_Array = new[] { 570, 1492, 1789 };
        int count2 = importantYears_Array.Length; // 3
        // importantYears_Array.Add(1917); // doesn't work

        // Create a hashset of three numbers 
        var importantYears_hash = new HashSet<int> { 570, 1492, 1789 };
        int count3 = importantYears_hash.Count; //3
        importantYears_hash.Add(1815);
        importantYears_hash.Add(570);
        int count4 = importantYears_hash.Count; //4
        bool found = importantYears_hash.Contains(1789);
    }
}
