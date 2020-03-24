using System;

namespace week1task1
{
    class Message
    {
        private string _text;

        public Message(String txt)
        {
            _text = txt;
        }

        public void print()
        {
            Console.WriteLine(_text);
        }
    }
}

