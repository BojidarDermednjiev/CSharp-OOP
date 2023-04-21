﻿namespace _04._Pizza_Calories.IO
{
    using System;
    using Contracts;
    public class Writer : IWriter<string>
    {
        public void Write(string value)
        {
            Console.Write(value);
        }
        public void WriteLine(string value)
        {
            Console.WriteLine(value);
        }
    }
}
