using System.Collections.Generic;
using System.IO;
using Tr;

namespace TraceResultSaver
{
    public interface ITraceResultSaver
    {
        void Save(Stream output, IEnumerable<IThreadNode> traceResult);
    }
}
