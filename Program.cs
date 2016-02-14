using System;
using Autofac;

namespace sample_AutofacAssemblyScanOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AutofacRegistration.Build();
            var thing = container.Resolve<IThing>();
            Console.WriteLine(thing.DoIt());
        }
    }
}
