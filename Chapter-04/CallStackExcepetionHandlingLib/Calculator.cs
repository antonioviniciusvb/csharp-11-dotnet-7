﻿using static System.Console;

namespace CallStackExcepetionHandlingLib
{
    public class Calculator
    {
        public static void Gamma() //public so it can be called from outside
        {
            WriteLine("In Gamma");
            Delta();
        }

        private static void Delta()
        {
            WriteLine("In Delta");
            File.OpenText("bad file path");
        }
    }
}