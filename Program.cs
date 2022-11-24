internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Trace to file!");

        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        var streamWriter = File.CreateText(Path.Combine(folderPath, "appTrace.log"));
        var traceWriter = new System.Diagnostics.TextWriterTraceListener(streamWriter);
        System.Diagnostics.Trace.Listeners.Add(traceWriter);

        System.Diagnostics.Trace.AutoFlush = true;

        System.Diagnostics.Trace.WriteLine("This is a trace message.");
    }
}