using System;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Army.Data
{
  class Program
    {
      static void Main(string[] args)
      {
      //var inputXml = System.IO.File.ReadAllText("death-guard.cat");
      //XmlDocument doc = new XmlDocument();
      //doc.LoadXml(inputXml);

      //string json = JsonConvert.SerializeXmlNode(doc);
      //json = json.Replace("@", string.Empty);
      //json = json.Replace("sharedSelectionEntries", "ArmyUnits");
      //json = json.Replace("selectionEntry", "Units");
      //json = json.Replace("sharedProfiles", "Weapons");

   


      //DiskSpaceInfo[] diskSpaceArray = jo.SelectToken("d", false).ToObject<DiskSpaceInfo[]>();

      //System.IO.File.WriteAllText("death-guard.json", json);
      var inputJson = System.IO.File.ReadAllText("death-guard.json");
      JObject rss = JObject.Parse(inputJson);
      Catalogue codex = rss.SelectToken("catalogue", false).ToObject<Catalogue>();
      Console.WriteLine(codex.authorName);
      Console.ReadLine();
    }
    }
}
