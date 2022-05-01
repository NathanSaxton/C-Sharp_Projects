using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        string[] names = { "James", "Jonathan", "Steven", "Marc" }; //create an array of names to be used
        Console.WriteLine("Hey, you! Yeah, you! Write something that someone could do.");
        string response = Console.ReadLine();//get a response from the user

        for (int i = 0; i < names.Length; i++) //use the array of names in a for loop
        {
            names[i] = names[i] + " said they could \"" + response + "\"";
        }

        foreach (string name in names)//use same array in a foreach loop
        {
            Console.WriteLine(name);
        }
        
        int j = 1;
        List<int> numbers = new List<int>();//create a list of integers
        while (j < names.Length+1)//use the integers in a while loop using the less than symbol
        {
            numbers.Add(j * 3);//add to the list
            j++;
        }
        
        int t = 0;
        while (t <= 3)//use the less than or equal to symbol in a while loop
        {
            Console.WriteLine("Here's some multiples of 3: " + numbers[t]);
            t++;
        }

        List<string> supers = new List<string>() { "superman", "flash", "ironman", "thor", "spiderman" }; //create another list of strings
        Console.WriteLine("Input something to search my list.");
        string search = Console.ReadLine().ToLower();//get a response from the user and make it lowercase
        int superIndex = 0;
        bool isThere = false;
        foreach (string super in supers) //iterate through the list
        {
            if (super.Contains(search))//complete a search using the response received from the user. 
            {
                Console.WriteLine("This item is on the list at index: " + superIndex.ToString());
                isThere = true;
                break;
            }
            superIndex++;
        }
        if (isThere == false)//add their item to the list and let them know in the event that their search doesn't exist. 
        {
            supers.Add(search);
            Console.WriteLine("Your item has been added to the list");
        }

        List<string> twins = new List<string>() { "james", "james", "james", "nick", "nicole", "steve", "stephanie" };//create a list of twins
        Console.WriteLine("Lets try and get a match this time");
        string twinSearch = Console.ReadLine().ToLower();//get a search from the user
        bool noMatch = true;
        for (int i = 0; i < twins.Count; i++)//loop through the list once
        {
            if (twins[i] == twinSearch)//if the user search matches something on the list let them know
            {
                Console.WriteLine("There is a match at index: " + i.ToString());
                noMatch = false;
            }
        }
        if (noMatch)//let them know if their search doesn't match. 
        {
            Console.WriteLine("Sorry bruh, you're not on the list.");
        }

        List<string> matchingNames = new List<string>();//create a list to be used to check if a name has appeared before.
        bool match = false;
        foreach (string twin in twins) //iterate through the names on the list
        {
            foreach (string name in matchingNames)//iterate through the checked names
            {
                if (name == twin)//check if the name on the list matches the checked names
                {
                    match = true;
                    break;
                }
            }

            if (match == true)//check if there is a matched name 
            {
                Console.WriteLine(twin + " is already on the list.");
                match = false;//reset the match bool
            } else
            {
                Console.WriteLine("This is the first time " + twin + " has appeared on the list.");
                matchingNames.Add(twin);//if there wasn't a match add that name to the list for future iterations. 
            }
        }
        Console.ReadLine();
    }
}

