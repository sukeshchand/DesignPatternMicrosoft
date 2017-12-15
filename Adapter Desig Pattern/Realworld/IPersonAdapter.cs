using System.Collections.Generic;

namespace BridgeTechWhizz
{
    partial class Program
    {
        public interface IPersonAdapter
        {
            List<PersonLocal> TransformData();
        }
    }

}
