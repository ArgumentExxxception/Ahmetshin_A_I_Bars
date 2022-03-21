using System;

namespace Task1
{
    public class FirstClass
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run()
        {
            char pressedCharacter = ' ';
            while (pressedCharacter != 'c')
            {
                pressedCharacter = Console.ReadKey(true).KeyChar;
                OnKeyPressed.Invoke(this, pressedCharacter);
            }
        }
    }
}