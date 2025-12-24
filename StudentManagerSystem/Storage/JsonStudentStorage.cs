using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using StudentManagerSystem.Models;


namespace StudentManagerSystem.Storage;

public class JsonStudentStorage
{
    private readonly string _path;
    
    public JsonStudentStorage(string path)
    {
        _path = path;
    }
    
    public void Save(Dictionary<string, Student> dict)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(_path)!);

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        
        File.WriteAllText(_path, JsonSerializer.Serialize(dict, options));
    }

    public Dictionary<string, Student> Load()
    {
        if (!File.Exists(_path))
        {
            return new Dictionary<string, Student>();
        }
        
        return JsonSerializer.Deserialize<Dictionary<string, Student>>(File.ReadAllText(_path)) ?? new Dictionary<string, Student>();
    }
}