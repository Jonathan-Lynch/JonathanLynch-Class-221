using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
	class Program
	{
		static void Main(string[] args)
		{

			var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };


			Console.WriteLine("Enter a Word");
			string answer = Console.ReadLine();

			//defining terms
			string firstLetter = answer.Substring(0, 1);
			string lastLetter = answer.Substring(answer.Length - 1, 1);
			int firstVowel = answer.IndexOfAny(vowels);

			string firstPartOfWord = answer.Substring(0, firstVowel);   //  if eagle....starts 0, goes how many spaces...0....returns ""  if 1 like hello, h
			string secondPartOfWord = answer.Substring(firstVowel);

			string anyVowel = answer.Substring(1, firstVowel);
			var doesFirstLetterHaveVowel = false;
			var doesLastLetterHaveVowel = false;


			
			if (firstVowel == 0)
			{
				doesFirstLetterHaveVowel = true;
			}	
			if (lastLetter.IndexOfAny(vowels) == 0)
			{
				doesLastLetterHaveVowel = true;
			}
			if (firstVowel == -1)
			{
				doesFirstLetterHaveVowel = true;
			}

			//find first vowel

			if(!doesFirstLetterHaveVowel) { 
				Console.WriteLine(secondPartOfWord + firstPartOfWord);
				Console.ReadLine();
			}

			//if word starts and ends with a vowel then it will add 'yay'
			foreach (char letter in vowels)
			{
				if (firstLetter == letter.ToString())
				{
					doesFirstLetterHaveVowel = true;
				}
				if (lastLetter == letter.ToString())
				{
					doesLastLetterHaveVowel = true;
				}	

			}
			    if (doesFirstLetterHaveVowel && doesLastLetterHaveVowel)
			     {
		 			Console.WriteLine(answer + "yay");
					Console.ReadLine();
			     }

				if (doesFirstLetterHaveVowel && !(doesLastLetterHaveVowel))
				{
					Console.WriteLine(answer + "ay");
					Console.ReadLine();
				}

				if (firstVowel == -1)
				{
				Console.WriteLine(answer + "ay");
				Console.ReadLine();
				}




		}
	}
}
