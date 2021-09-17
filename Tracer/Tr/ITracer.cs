using System.Collections.Generic;

namespace Tr
{
    public interface ITracer
    {
        void StartTrace();

        void StopTrace();

        IEnumerable<IThreadNode> GetResult();
    }
}
