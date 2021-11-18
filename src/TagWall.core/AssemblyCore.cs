using System.Reflection;

namespace TagWall.core
{
    public static class AssemblyCore
    {
        public static string GetAssemblyLocation()
        {
            return Assembly.GetExecutingAssembly().Location;
        }
    }
}
