using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class HangmanService
    {
        private string[] vocabulary = { "Programmer", "Variable", "Constant", "Conditional", "Function" };
        private Random random = new Random();
        private int index;
        private string result;
       
        private enum CheckAnswer {
            Correct, //0
            Incorrect, //1
            Duplicate //2
        }
        public HangmanService() {

            GetDisplay();

        }
        public void Restart() {
            index = random.Next(vocabulary.Length);
            result = vocabulary[index];
        }
        public void GetDisplay() {
            Restart();
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(" _ ");
               
            }
            Console.Write("\n");
            Console.Write("please enter character : ");
            string inputChar = Console.ReadLine();
            if (inputChar == "")
            {
                GetDisplay();
            }
            else { 
            
            Input(Convert.ToChar(inputChar));
            }
        }
        public void Input(char get_input) {

          
                Console.WriteLine(get_input);
           



        }

    }

}
