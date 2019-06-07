using System;
using Unity;

namespace SimpleUnityInjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando unity container
            UnityContainer IU = new UnityContainer();

            //Registrando um tipo
            IU.RegisterType<BusinessLayer>();
            IU.RegisterType<DataAccessLayer>();

            //Registrando um tipo com membros específicos para ser injetado
            IU.RegisterType<IProduct, DataAccessLayer>();

            BusinessLayer obj = IU.Resolve<BusinessLayer>();
            obj.Insert();
            Console.ReadLine();
        }
    }
}
