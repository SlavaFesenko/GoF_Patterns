
using System.ComponentModel;
using System.Text;

namespace GoF_Patterns.Composite.OwnExample
{
    public static class CompositeUtils
    {
        public static string GetDepthSeparator(int depth, char sep = ' ')
        {
            StringBuilder sb = new StringBuilder();
            int sepTimes = 3;

            for (int i = 0; i < depth; i++)
            {
                for (int j = 0; j < sepTimes; j++)
                {
                    sb.Append(sep);
                }
            }

            return sb.ToString();
        }
    }
}
