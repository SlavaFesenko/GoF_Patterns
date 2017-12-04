using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_Patterns.State.OwnExample
{
    public class OeCrupier
    {
        public IDeckState State { get; set; }
        public int CardCount = 52;

        public OeCrupier(IDeckState ds)
        {
            State = ds;
        }

        public void GetCard()
        {
            State.GetCard(this);
        }
    }
}
