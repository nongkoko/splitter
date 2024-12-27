using jomiunsExtensions;

Dictionary<string, string> aDict = new();
if (args != null)
{
    var aaahaha = args.Select(oo => oo.toKeyValue<string, string>(" "));
    aDict = aaahaha.ToDictionary();
}

var hasil = Console.ReadLine();
aDict.TryGetValue("delimiter", out var tempDelimiter);
var charArray = tempDelimiter.otherwise(";").ToCharArray();
var infos = hasil?.Split(charArray) ?? [];
var total = string.Join(Environment.NewLine, infos);
Console.Write(total);