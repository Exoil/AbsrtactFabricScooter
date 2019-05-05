using AbsrtactFabric.FabricClass;
using AbsrtactFabric.FabricClass.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsrtactFabric
{
  
    class Program
    {
        static void Main(string[] args)
        {

            Client polishScooter = new Client(new PolishFabric());
            Client chineseScooter = new Client(new ChineseFabric());

            Console.WriteLine($"Polish Fabric: {Environment.NewLine}{polishScooter}{Environment.NewLine}Chinese Fabirc: {Environment.NewLine}{chineseScooter}");
            Console.ReadLine();
        }
    }
}
