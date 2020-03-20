using System;

namespace week1task1
{
    class message
    {
        private string _text;

        public message(String txt)
        {
            _text = txt;
        }

        public void print()
        {
            Console.WriteLine(_text);
        }
    }
}

