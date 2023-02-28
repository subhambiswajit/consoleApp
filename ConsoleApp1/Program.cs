
using JawsMako;
namespace Valkyrie.Conversion
{
    public static class Program
    {
        private static void Main()
        {
            using var mako = IJawsMako.create();
            IJawsMako.enableAllFeatures(mako);
        }
    }
}
