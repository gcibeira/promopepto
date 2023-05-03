public class Logger
{
    private string path;

    public Logger(string logPath)
    {
        this.path = logPath;
    }
    public void Log(string logMessage)
    {
        try
        {
            using (StreamWriter txtWriter = File.AppendText(path))
            {
                txtWriter.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}\t{logMessage}");
            }
        }
        catch (Exception)
        {
            
        }
    }
}