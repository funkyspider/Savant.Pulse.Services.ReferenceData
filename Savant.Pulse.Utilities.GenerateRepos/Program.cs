using System;
using System.Linq;
using System.Reflection;

namespace Savant.Pulse.Utilities.GenerateRepos
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyName = "Savant.Pulse.DataModels.ReferenceData";
            var nameSpace = "Savant.Pulse.DataAccessLayer.ReferenceData.Models";
            var className = "ClassNameFilter";

            var asm = Assembly.Load(assemblyName);
            var classes = asm.GetTypes().Where(p =>
                p.Namespace == nameSpace
            ).ToList();


            foreach (var c in classes)
            {
                Console.WriteLine(c.Name);

            }

            Console.ReadKey();
        }
    }
}
