using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enaumInheratice
{
    class VolleyBall: BaseBall
    {
        // keep synced with base class!
        public new enum Sizes
        {
            Small = BaseBall.Sizes.Small,
            Medium = BaseBall.Sizes.Medium,
            Large = BaseBall.Sizes.Large,
            SmallMedium,
            MediumLarge,
            Ginormous
        }
    }
}
