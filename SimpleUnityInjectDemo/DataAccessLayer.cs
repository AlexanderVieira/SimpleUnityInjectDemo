using System;

namespace SimpleUnityInjectDemo
{
    public class DataAccessLayer : IProduct
    {
        public string InsertData()
        {
            string value = "Dependency injection injected";
            Console.WriteLine(value);
            return value;
        }
    }
}
