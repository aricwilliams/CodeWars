/*Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.

Examples
nameShuffle("Donald Trump") ➞ "Trump Donald"

nameShuffle("Rosie O'Donnell") ➞ "O'Donnell Rosie"

nameShuffle("Seymour Butts") ➞ "Butts Seymour"
Notes
There will be exactly one space between the first and last name.
If you get stuck on a challenge, find help in the Resources tab.
If you're really stuck, unlock solutions in the Solutions tab.



public class program
{
	function nameShuffle(str)
	{
		return str.split(' ').reverse().join(' ');
	}*/
}

//////////////////////////////////////////////////////////////////////////////////////////////////////

//Write a function that converts hours into seconds.

//one hour = 3600 seconds because 60 seconds is one minute and i need 60 minutes to get 1 hour... so 60 * 60 =3600
/*
public class program
{
	function howManySeconds(hours)
	{
		return hours * 3600;
	}

}*/
//////////////////////////////////////////////////////////////////////////////////////////////////////

// Complete the solution so that it reverses the string passed into it.

// 'world'  =>  'dlrow'
// 'word'   =>  'drow'




// using System;
// using System.Linq;

// public static class Kata
// {
//   public static string Solution(string str) 
//   {
//      return new string(str.ToArray().Reverse().ToArray());
//   }
// }



// using System;
// using System.Linq;

// public static class Kata
// {
//   public static string Solution(string str) 
//   {
//     char[] newstr = str.ToCharArray();
//     Array.Reverse(newstr);
//     return new String(newstr);
//   }
// }

// using System;
// using System.Linq;
// public static class Kata
// {
//   public static string Solution(string str) 
//   {
//     return string.Concat(str.Reverse());
//   }
// }
//////////////////////////////////////////////////////////////////////////////////////////////////////
// Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.


// using System;
// using System.Linq;

// public static class Kata
// {
//   public static string boolToWord(bool word)
//   {
//     return word ? "Yes" : "No";
//   }
// }


// using System;
// using System.Linq;

// public static class Kata
// {
//   public static string boolToWord(bool word) => word ? "Yes": "No";
// }



// using System;
// using System.Linq;

// public static class Kata
// {
//   static string BOOL_FALSE = "No";
//   static string BOOL_TRUE = "Yes";

//   public static string boolToWord(bool word)
//   {
//     return word ? BOOL_TRUE : BOOL_FALSE;
//   }
// }
//////////////////////////////////////////////////////////////////////////////////////////////////////
// Convert number to reversed array of digits
// Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

// Example(Input => Output):
// 348597 => [7,9,5,8,4,3]
// 0 => [0]


// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace Solution
// {
//   class Digitizer
//   {
//     public static long[] Digitize(long n)
//     {
//       return n.ToString()
//               .Reverse()
//               .Select(t => Convert.ToInt64(t.ToString()))
//               .ToArray();
//     }
//   }
// }



// using System.Linq;

// class Digitizer
// {
//   public static long[] Digitize(long n)
//   {
//     return $"{n}".Select(c => (long) c - '0').Reverse().ToArray();
//   }
// }



// using System;
// using System.Collections.Generic;
// using System.Linq;

//     class Digitizer
//     {
//         public static long[] Digitize(long n)
//         {
//             return n.ToString().Reverse().Select(x => long.Parse(x.ToString())).ToArray();
//         }
//     }

//////////////////////////////////////////////////////////////////////////////////////////////////////
// Sentence Smash
// Write a function that takes an array of words and smashes them together into a sentence and returns the sentence. You can ignore any need to sanitize words or add punctuation, but you should add spaces between each word. Be careful, there shouldn't be a space at the beginning or the end of the sentence!

// Example
// ['hello', 'world', 'this', 'is', 'great']  =>  'hello world this is great'



// using System;

// public class Kata
// {
//   public static string Smash(string[] words)
//   {
//     return string.Join(" ", words);
//   }
// }
// //////////////////////////////////////////////////////////////////////////////////////////////////////
// Rock Paper Scissors
// Let's play! You have to return which player won! In case of a draw return Draw!.

// Examples(Input1, Input2 --> Output):

// "scissors", "paper" --> "Player 1 won!"
// "scissors", "rock" --> "Player 2 won!"
// "paper", "paper" --> "Draw!"




// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// public class Kata
// {
//   public string Rps(string p1, string p2)
//   {
//     if (p1 == p2)
//       return "Draw!";

//     if (((p1 == "rock") && (p2 == "scissors")) ||
//         ((p1 == "scissors") && (p2 == "paper")) ||
//         ((p1 == "paper") && (p2 == "rock")))
//     {
//       return "Player 1 won!";
//     }
//     else
//     {
//       return "Player 2 won!";
//     }
//   }
// }


//////////////////////////////////////////////////////////////////////////////////////////////////////

// Very simple, given an integer or a floating-point number, find its opposite.

// Examples:

// 1: -1
// 14: -14
// -34: 34


// using System;

// public class Kata
//     {
//         public static int Opposite(int number)
//         {
//             // Happy Coding
//             return -number;
//         }
//     }


//////////////////////////////////////////////////////////////////////////////////////////////////////
// Simple, remove the spaces from the string, then return the resultant string.


// namespace Solution 
// {
//   public static class SpacesRemover
//   {
//     public static string NoSpace(string input)
//     {
//       return input.Replace(" ", "");
// 	  or
// 		return input.Replace(" ", string.Empty);
//     }  
//   }
// }




//////////////////////////////////////////////////////////////////////////////////////////////////////

// Given a set of numbers, return the additive inverse of each. Each positive becomes negatives, and the negatives become positives.

// invert([1,2,3,4,5]) == [-1,-2,-3,-4,-5]
// invert([1,-2,3,-4,5]) == [-1,2,-3,4,-5]
// invert([]) == []


// using System.Linq;
// namespace Solution
// {
//   public static class ArraysInversion
//   {
//     public static int[] InvertValues(int[] input)
//     {
//         for (int i = 0; i < input.Length; i++)
//         {
//             input[i] = input[i] * -1;
//         }
//         return input;
//     }
//   }
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////
// Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.




// using System;

// namespace Solution
// {
//   public class SolutionClass
//   {
//     public static string EvenOrOdd(int number)
//     {
//       return number % 2 == 0 ? "Even" : "Odd";
//     }
//   }
// }


//////////////////////////////////////////////////////////////////////////////////////////////////////

// Implement a function which convert the given boolean value into its string representation.




// using System;

// public class kata
// {
//   public static string boolean_to_string(bool b)
//   {
//   return b.ToString();
//   }
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////






