﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			
			var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

			Console.WriteLine("Enter a Word");
			string answer = Console.ReadLine();

			//Defining Terms
			
			string lastLetter = answer.Substring(answer.Length - 1, 1);

			int lastLetterVowel = lastLetter.IndexOfAny(vowels);
			int firstVowel = answer.IndexOfAny(vowels);

			string firstHalfOfWord = "";
			string secondHalfOfWord = "";
			string anyVowel ="";

			if(firstVowel>-1) {
				firstHalfOfWord = answer.Substring(0, firstVowel);
				secondHalfOfWord = answer.Substring(firstVowel);
				anyVowel = answer.Substring(1, firstVowel);
			}


			//if there if a vowel at the end and beginnning of a word add 'yay'
			if ((0 == firstVowel) && (lastLetter.IndexOfAny(vowels)== 0))
			{
				Console.WriteLine(answer + "yay");
				Console.ReadLine();
			}
			
			//if there is a vowel at the beginning and a consonant at the end add 'ay'
			if ((0 == firstVowel) && (lastLetter.IndexOfAny(vowels) == -1))
			{
				Console.WriteLine(answer + "ay");
				Console.ReadLine();
			}

			//if there is no vowel ad 'ay'
			if (firstVowel == -1)
			{
				Console.WriteLine(answer + "ay");
				Console.ReadLine();
			}

			//if starts with consonant and has vowel then will move the first few letters to the end and adds 'ay'
			if (firstVowel>0)
			{
				Console.WriteLine(secondHalfOfWord + firstHalfOfWord + "ay");
				Console.ReadLine();
			}

		}
	}
}
