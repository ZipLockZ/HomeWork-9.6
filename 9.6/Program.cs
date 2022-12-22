namespace Space1
{
    class Program
    {
        static Exception ex;
        static void Main(string[] args)
        {
            TryCatchExept exeption = new TryCatchExept();
            try
            {
                Console.WriteLine("Введите пароль");
                string userPass = Console.ReadLine();

            }

            catch (Exception ex)
            {
                ex = TryCatchExept.TryCatchFinally();
            }
        }
    }
}
