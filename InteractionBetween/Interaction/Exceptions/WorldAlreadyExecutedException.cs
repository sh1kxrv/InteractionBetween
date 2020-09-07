using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Interaction.Exceptions
{
    public class WorldAlreadyExecutedException : Exception
    {
        public WorldAlreadyExecutedException(string a) : base(a)
        {

        }
    }
}
