using System;
using System.IO;

namespace Space1
{
    public class TryCatchExept : Exception
    {
        public static Exception rangeEx = new FormatException("Пароль должен быть больше 5 символов");
        public static Exception myEx = new MyException("Слишком короткий пароль");
        public static Exception nullEx = new ArgumentNullException("Поле пусто");
        public static Exception directEx = new DirectoryNotFoundException("Папка не найдена");
        public static Exception timeOut = new TimeoutException("Время ожидания вышло");
        public static Exception[] exMass = new Exception[5];
        
        
        public static Exception TryCatchFinally()
        {
            exMass[1] = rangeEx;
            exMass[2] = myEx;
            exMass[3] = nullEx;
            exMass[4] = directEx;
            exMass[5] = timeOut;          
            foreach(Exception ex in exMass)
            {
                return ex;
            }
            return null;
        }
    }
}
