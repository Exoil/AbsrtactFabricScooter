using AbsrtactFabric.FabricClass;
using AbsrtactFabric.FabricClass.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsrtactFabric
{
    public class Client
    {

        public Wheel scooterWheel { get; set; }
        public Break scooterBreak { get; set; }
        public HandleBar scooterHandleBar { get; set; }
        public Sticker scooterSticker { get; set; }

        public Client()
        {

        }
        public Client(Fabric fabric)
        {
            scooterWheel = fabric.CreateWheel();
            scooterSticker = fabric.CreateSticker();
            scooterBreak = fabric.CreateBreak();
            scooterHandleBar = fabric.CreateHandleBar();

        }

        public override string ToString()
        {
            return $"Wheel: {scooterWheel.color} from: {scooterWheel.GetType()}{Environment.NewLine}" +
                $"Breaks: {scooterBreak.breaksLifeInMoths} from: {scooterBreak.GetType()}{Environment.NewLine}" +
                $"HandleBar: {scooterHandleBar.height} from: {scooterHandleBar.GetType()}{Environment.NewLine}" +
                $"Sticker: {scooterSticker.hologram} from: {scooterSticker.GetType()}{Environment.NewLine}" ;
        }
    }
}
