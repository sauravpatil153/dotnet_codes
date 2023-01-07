using System.Text.Json;

public class SerDeser{
    public static string fileName = @"D:\A-dotnet\LabWork\StudentApp\custdata.json";

    public static List<Authentication> custData = new List<Authentication>();
    public static string StoreData(string email, string password)
    {
        custData.Add(new Authentication(email,password));
        var options = new JsonSerializerOptions { IncludeFields = true };
        var produtsJson = JsonSerializer.Serialize<List<Authentication>>(custData, options);
        System.IO.File.WriteAllText(fileName,produtsJson);
        return produtsJson;
    }
}