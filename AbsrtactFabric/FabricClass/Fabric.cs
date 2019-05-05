using AbsrtactFabric.FabricClass.Components;

namespace AbsrtactFabric.FabricClass
{
    public interface Fabric
    {
        Wheel CreateWheel();
        HandleBar CreateHandleBar();
        Break CreateBreak();
        Sticker CreateSticker();

      
    }
}
