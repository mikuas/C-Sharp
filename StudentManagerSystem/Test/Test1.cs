using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;


namespace StudentManagerSystem.Test;

public class Template
{
    public required string Name { get; set; }
    public char Gender { get; set; }
    public int Age { get; set; }
}

public class Test1
{
    private Dictionary<string, Template> _dict = new Dictionary<string, Template>();
    
    public void Save()
    {
        
        _dict["0"] = new Template() { Name = "0", Gender = '男', Age = 20 };
        _dict["1"] = new Template() { Name = "1", Gender = '男', Age = 21 };
        _dict["2"] = new Template() { Name = "2", Gender = '女', Age = 24 };
        _dict["3"] = new Template() { Name = "3", Gender = '男', Age = 18 };
        _dict["4"] = new Template() { Name = "4", Gender = '女', Age = 22 };
        _dict["5"] = new Template() { Name = "5", Gender = '女', Age = 25 };
        
        string path = Path.Combine(AppContext.BaseDirectory, "data/test.json");
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        
        SaveToJson(path, _dict);
    }

    public void Load()
    {
        _dict = LoadFromJson(Path.Combine(AppContext.BaseDirectory, "data/test.json"));

        foreach (var item in _dict.Values)
        {
            Console.WriteLine(item);
        }
    }
    
    private void SaveToJson(string path, Dictionary<string, Template> template)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        string json = JsonSerializer.Serialize(template, options);
        File.WriteAllText(path, json);
    }

    private Dictionary<string, Template> LoadFromJson(string path)
    {
        if (!File.Exists(path))
        {
            return new Dictionary<string, Template>();
        }

        return JsonSerializer.Deserialize<Dictionary<string, Template>>(File.ReadAllText(path)) ??
               new Dictionary<string, Template>();
    }
}