using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Tr;

namespace TraceResultSaver
{
    public class JsonTraceResultSaver : ITraceResultSaver
    {
        public void Save(Stream output, IEnumerable<IThreadNode> traceResult)
        {
            using var writer = new Utf8JsonWriter(output);
            JsonSerializer.Serialize(writer, traceResult);
        }
    }
}
