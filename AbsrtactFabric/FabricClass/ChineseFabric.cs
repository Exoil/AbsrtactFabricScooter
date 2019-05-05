using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbsrtactFabric.FabricClass.Components;

namespace AbsrtactFabric.FabricClass
{
    public class ChineseFabric : Fabric
    {
        public Break CreateBreak()
        {
            return new ChineseBreak();
        }

        public HandleBar CreateHandleBar()
        {
            return new ChineseHandleBar();
        }

        public Sticker CreateSticker()
        {
            return new ChineseSticker();
        }

        public Wheel CreateWheel()
        {
            return new ChineseWheel();
        }
    }
}
