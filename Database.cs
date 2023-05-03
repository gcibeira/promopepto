using System.Text.Json;

class Database
{
    private string path;

    public Database(string path)
    {
        this.path = path;
    }

    public void Save<T>(List<T> data)
    {
        string json = JsonSerializer.Serialize(data);
        File.WriteAllText(path, json);
    }

    public List<T> Load<T>()
    {
        if (!File.Exists(path))
            return new List<T>();

        string json = File.ReadAllText(path);
        List<T>? data = JsonSerializer.Deserialize<List<T>>(json);
        data ??= new List<T>();
        return data;
    }
}