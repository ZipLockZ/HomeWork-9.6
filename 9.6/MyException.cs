﻿using System;

namespace Space1
{
    public class MyException : Exception
    {   
        public MyException (string message) : base (message) { }
        public static void PassCheck(string enterPass, string basePass)
        {

            if (enterPass == basePass)
            {
                
            }
            else throw new MyException("Неверный пароль");
        }
    }
}
