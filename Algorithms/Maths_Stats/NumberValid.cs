using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Maths_Stats
{
    public class NumberValid
    {
         enum STATE { START, INTEGER, DECIMAL, UNKNOWN, AFTERDECIMAL };

        static STATE getNextState(STATE currentState, char ch)
        {
            switch (currentState)
            {
                case STATE.START:
                case STATE.INTEGER:
                    if (ch == '.')
                    {
                        return STATE.DECIMAL;
                    }
                    else if (ch >= '0' && ch <= '9')
                    {
                        return STATE.INTEGER;
                    }
                    else
                    {
                        return STATE.UNKNOWN;
                    }
                case STATE.DECIMAL:
                    if (ch >= '0' && ch <= '9')
                    {
                        return STATE.AFTERDECIMAL;
                    }
                    else
                    {
                        return STATE.UNKNOWN;
                    }
                case STATE.AFTERDECIMAL:
                    if (ch >= '0' && ch <= '9')
                    {
                        return STATE.AFTERDECIMAL;
                    }
                    else
                    {
                        return STATE.UNKNOWN;
                    }
            }
            return STATE.UNKNOWN;
        }

        static bool isNumberValid(String s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            int i = 0;
            if (s[i] == '+' || s[i] == '-')
            {
                ++i;
            }

            STATE currentState = STATE.START;

            while (i < s.Length)
            {
                currentState = getNextState(currentState, s[i]);

                if (currentState == STATE.UNKNOWN)
                {
                    return false;
                }

                i = i + 1;
            }

            if (currentState == STATE.DECIMAL)
                return false;

            return true;
        }

        public static void Execute()
        {
            //Console.WriteLine("Is the number valid 4.325? " + isNumberValid("4.325"));
            Console.WriteLine("Is the number valid 1.1.1? " + isNumberValid("1.1.1"));
            Console.WriteLine("Is the number valid 222? " + isNumberValid("222"));
            Console.WriteLine("Is the number valid 22.? " + isNumberValid("22."));
            Console.WriteLine("Is the number valid 0.1? " + isNumberValid("0.1"));
            Console.WriteLine("Is the number valid 22.22.? " + isNumberValid("22.22."));
            Console.WriteLine("Is the number valid 1.? " + isNumberValid("1."));
        }
    }
}
