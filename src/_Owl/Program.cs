extern alias Lib1;
extern alias Lib2;
using System;
using SpaceOne=Lib1::Space;
using SpaceTwo=Lib2::Space;


namespace Owl
{
    class Program
    {
        static void Main(string[] args)
        {
            var owl = new SuperOwl();
            owl.IntegrateGlobe(new SpaceOne.Globe());
            owl.IntegrateGlobe(new SpaceTwo.Globe());
            
            
            Console.WriteLine(owl.GetGLobeColors());
        }
    }

    public class SuperOwl
    {
        private SpaceOne.Globe _firstGlobe;
        private SpaceTwo.Globe _secondGlobe;

        public void IntegrateGlobe(SpaceOne.Globe globe) => _firstGlobe = globe;

        public void IntegrateGlobe(SpaceTwo.Globe globe) => _secondGlobe = globe;

        public string GetGLobeColors() => $"First: {_firstGlobe.GetColor()}, Second: {_secondGlobe.GetColor()}";
    }
}