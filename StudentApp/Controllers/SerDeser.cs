using System.Text.Json;

public class SerDeser
{
    public static string fileName = @"D:\A-dotnet\LabWork\StudentApp\custdata.json";

    public static List<Authentication> custData = new List<Authentication>();
    public static string StoreData(string email, string password, string firstName, string lastName)
    {
        custData.Add(new Authentication(email, password, firstName, lastName));
        var options = new JsonSerializerOptions { IncludeFields = true };
        var produtsJson = JsonSerializer.Serialize<List<Authentication>>(custData, options);
        System.IO.File.WriteAllText(fileName, produtsJson);
        return produtsJson;
    }

    public static List<Authentication> RetrieveData()
    {
        string jsonString = File.ReadAllText(fileName);
        List<Authentication> userData = JsonSerializer.Deserialize<List<Authentication>>(jsonString);
        return userData!;
    }
}