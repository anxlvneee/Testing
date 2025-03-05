using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTests
{
    public class GuessNumber
    {
        private int _numberToGuess;
        private int _attempts;

        // Конструктор, який дозволяє задати число для тестів
        public GuessNumber(int? numberToGuess = null)
        {
            Random random = new Random();
            _numberToGuess = numberToGuess ?? random.Next(1, 101); // Якщо не передано число, генерується випадкове
            _attempts = 0;
        }

        public string Guess(int userGuess)
        {
            _attempts++;
            if (userGuess < _numberToGuess)
            {
                return "Бiльше";
            }
            else if (userGuess > _numberToGuess)
            {
                return "Менше";
            }
            else
            {
                return $"Вiрно! Ви вгадали число за {_attempts} спроб.";
            }
        }

        public int GetAttempts() => _attempts;
    }
}
