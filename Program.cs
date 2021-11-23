using System;

namespace cypherTranslator
{
    class Program
    {
        private static string wordIn;
        private static string codeIn;

        private static char[] wordArray;
        private static char[] codeArray;

        private static string type;

        private static void Main(string[] args)
        {
            Console.WriteLine("please enter the type of operation you want this to perform");
            type = Console.ReadLine();
            if(type == "toCode")
            {
                Console.WriteLine("please enter the word to encode");
                wordIn = Console.ReadLine();
                toCode(wordIn);
                Console.ReadKey();
            }

            if(type == "toWord")
            {
                Console.WriteLine("please enter the code to decode");
                codeIn = Console.ReadLine();
                toWord(codeIn);
                Console.ReadKey();
            }
        }

        private static void toCode(string wordIn)
        {
            wordArray = wordIn.ToCharArray();

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] == 'a')
                {
                    Console.Write('.');
                }

                if (wordArray[i] == 'b')
                {
                    Console.Write(',');
                }

                if (wordArray[i] == 'c')
                {
                    Console.Write('<');
                }

                if (wordArray[i] == 'd')
                {
                    Console.Write('>');
                }

                if (wordArray[i] == 'e')
                {
                    Console.Write('/');
                }

                if (wordArray[i] == 'f')
                {
                    Console.Write('|');
                }

                if (wordArray[i] == 'g')
                {
                    Console.Write('[');
                }

                if (wordArray[i] == 'h')
                {
                    Console.Write(']');
                }

                if (wordArray[i] == 'i')
                {
                    Console.Write('{');
                }

                if (wordArray[i] == 'j')
                {
                    Console.Write('}');
                }

                if (wordArray[i] == 'k')
                {
                    Console.Write('-');
                }

                if (wordArray[i] == 'l')
                {
                    Console.Write(':');
                }

                if (wordArray[i] == 'm')
                {
                    Console.Write('=');
                }

                if (wordArray[i] == 'n')
                {
                    Console.Write('+');
                }

                if (wordArray[i] == 'o')
                {
                    Console.Write('%');
                }

                if (wordArray[i] == 'p')
                {
                    Console.Write('#');
                }

                if (wordArray[i] == 'q')
                {
                    Console.Write('*');
                }

                if (wordArray[i] == 'r')
                {
                    Console.Write('$');
                }

                if (wordArray[i] == 's')
                {
                    Console.Write('!');
                }

                if (wordArray[i] == 't')
                {
                    Console.Write('@');
                }

                if (wordArray[i] == 'u')
                {
                    Console.Write('&');
                }

                if (wordArray[i] == 'v')
                {
                    Console.Write('(');
                }

                if (wordArray[i] == 'w')
                {
                    Console.Write(')');
                }

                if (wordArray[i] == 'x')
                {
                    Console.Write('^');
                }

                if (wordArray[i] == 'y')
                {
                    Console.Write('?');
                }

                if (wordArray[i] == 'z')
                {
                    Console.Write(';');
                }

                if (wordArray[i] == ' ')
                {
                    Console.Write('_');
                }
            }
        }

        private static void toWord(string codeIn)
        {
            codeArray = codeIn.ToCharArray();

            for (int i = 0; i < codeArray.Length; i++)
            {
                if (codeArray[i] == '.')
                {
                    Console.Write('a');
                }

                if (codeArray[i] == ',')
                {
                    Console.Write('b');
                }

                if (codeArray[i] == '<')
                {
                    Console.Write('c');
                }

                if (codeArray[i] == '>')
                {
                    Console.Write('d');
                }

                if (codeArray[i] == '/')
                {
                    Console.Write('e');
                }

                if (codeArray[i] == '|')
                {
                    Console.Write('f');
                }

                if (codeArray[i] == '[')
                {
                    Console.Write('g');
                }

                if (codeArray[i] == ']')
                {
                    Console.Write('h');
                }

                if (codeArray[i] == '{')
                {
                    Console.Write('i');
                }

                if (codeArray[i] == '}')
                {
                    Console.Write('j');
                }

                if (codeArray[i] == '-')
                {
                    Console.Write('k');
                }

                if (codeArray[i] == ':')
                {
                    Console.Write('l');
                }

                if (codeArray[i] == '=')
                {
                    Console.Write('m');
                }

                if (codeArray[i] == '+')
                {
                    Console.Write('n');
                }

                if (codeArray[i] == '%')
                {
                    Console.Write('o');
                }

                if (codeArray[i] == '#')
                {
                    Console.Write('p');
                }

                if (codeArray[i] == '*')
                {
                    Console.Write('q');
                }

                if (codeArray[i] == '$')
                {
                    Console.Write('r');
                }

                if (codeArray[i] == '!')
                {
                    Console.Write('s');
                }

                if (codeArray[i] == '@')
                {
                    Console.Write('t');
                }

                if (codeArray[i] == '&')
                {
                    Console.Write('u');
                }

                if (codeArray[i] == '(')
                {
                    Console.Write('v');
                }

                if (codeArray[i] == ')')
                {
                    Console.Write('w');
                }

                if (codeArray[i] == '^')
                {
                    Console.Write('x');
                }

                if (codeArray[i] == '?')
                {
                    Console.Write('y');
                }

                if (codeArray[i] == ';')
                {
                    Console.Write('z');
                }

                if (codeArray[i] == '_')
                {
                    Console.Write(' ');
                }
            }
        }
    }
}
