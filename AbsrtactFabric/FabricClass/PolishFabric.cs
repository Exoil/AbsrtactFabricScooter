using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbsrtactFabric.FabricClass.Components;

namespace AbsrtactFabric.FabricClass
{
    public class PolishFabric : Fabric
    {
        public Break CreateBreak()
        {
            return new PolishBreak();
        }

        public HandleBar CreateHandleBar()
        {
            return new PolishHandleBar();
        }

        public Sticker CreateSticker()
        {
            return new PolishSticker();
        }

        public Wheel CreateWheel()
        {
            return new PolishWheel();
        }
    }
}
