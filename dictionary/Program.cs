using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
			////deklarasi output dalam bentuk data collection list
			//List<string> output = new List<string>();

			////karena input berupa kata, harus diparsing ke tiap huruf
			//foreach (char huruf in input.ToUpper())
			//{
			//	string morseCode = _textToMorse[huruf];
			//	output.Add(morseCode);
			//}

            //Console.WriteLine(string.Join(" ", output));
            Console.WriteLine(toMorse(input));
        }

        public static string toMorse(string input)
        {
            //deklarasi output dalam bentuk data collection list
            List<string> output = new List<string>();

            //karena input berupa kata, harus diparsing ke tiap huruf
            foreach (char huruf in input.ToUpper()){
                string morseCode = _textToMorse[huruf];
                output.Add(morseCode);
            }

            return string.Join(" ",output);
        }

		// in MorseCodeTranslator class
		private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>()
		{
			{' ', "/"},
			{'A', ".-"},
			{'B', "-..."},
			{'C', "-.-."},
			{'D', "-.."},
			{'E', "."},
			{'F', "..-."},
			{'G', "--."},
			{'H', "...."},
			{'I', ".."},
			{'J', ".---"},
			{'K', "-.-"},
			{'L', ".-.."},
			{'M', "--"},
			{'N', "-."},
			{'O', "---"},
			{'P', ".--."},
			{'Q', "--.-"},
			{'R', ".-."},
			{'S', "..."},
			{'T', "-"},
			{'U', "..-"},
			{'V', "...-"},
			{'W', ".--"},
			{'X', "-..-"},
			{'Y', "-.--"},
			{'Z', "--.."},
			{'1', ".----"},
			{'2', "..---"},
			{'3', "...--"},
			{'4', "....-"},
			{'5', "....."},
			{'6', "-...."},
			{'7', "--..."},
			{'8', "---.."},
			{'9', "----."},
			{'0', "-----"},
		};
    }
}
