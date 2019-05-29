using System.Collections.Generic;

namespace Army.Data
{
  public class Xml
  {
    public string version { get; set; }
    public string encoding { get; set; }
    public string standalone { get; set; }
  }

  public class Publication
  {
    public string id { get; set; }
    public string name { get; set; }
  }

  public class Publications
  {
    public List<Publication> publication { get; set; }
  }

  public class CharacteristicTypes
  {
    public object characteristicType { get; set; }
  }

  public class ProfileType
  {
    public string id { get; set; }
    public string name { get; set; }
    public CharacteristicTypes characteristicTypes { get; set; }
  }

  public class ProfileTypes
  {
    public List<ProfileType> profileType { get; set; }
  }

  public class CategoryEntry
  {
    public string id { get; set; }
    public string name { get; set; }
    public string hidden { get; set; }
  }

  public class CategoryEntries
  {
    public List<CategoryEntry> categoryEntry { get; set; }
  }

  public class CategoryLink
  {
    public string id { get; set; }
    public string name { get; set; }
    public string hidden { get; set; }
    public string targetId { get; set; }
    public string primary { get; set; }
  }

  public class CategoryLinks
  {
    public List<CategoryLink> categoryLink { get; set; }
  }

  public class EntryLink
  {
    public string id { get; set; }
    public string name { get; set; }
    public string hidden { get; set; }
    public string collective { get; set; }
    public string targetId { get; set; }
    public string type { get; set; }
    public CategoryLinks categoryLinks { get; set; }
  }

  public class EntryLinks
  {
    public List<EntryLink> entryLink { get; set; }
  }

  public class Rule
  {
    public string id { get; set; }
    public string name { get; set; }
    public string hidden { get; set; }
    public string description { get; set; }
  }

  public class Rules
  {
    public List<Rule> rule { get; set; }
  }

  public class InfoLink
  {
    public string id { get; set; }
    public string name { get; set; }
    public string hidden { get; set; }
    public string targetId { get; set; }
    public string type { get; set; }
  }

  public class InfoLinks
  {
    public InfoLink infoLink { get; set; }
  }

  public class Profiles
  {
    public object profile { get; set; }
  }

  public class InfoLinks2
  {
    public object infoLink { get; set; }
  }

  public class CategoryLinks2
  {
    public object categoryLink { get; set; }
  }

  public class EntryLinks2
  {
    public object entryLink { get; set; }
  }

  public class Cost
  {
    public string name { get; set; }
    public string typeId { get; set; }
    public string value { get; set; }
  }

  public class Costs
  {
    public List<Cost> cost { get; set; }
  }

  public class UnitsGroups
  {
    public object UnitsGroup { get; set; }
  }

  public class SelectionEntries
  {
    public object Units { get; set; }
  }

  public class Modifiers
  {
    public object modifier { get; set; }
  }

  public class Constraints
  {
    public object constraint { get; set; }
  }

  public class Unit
  {
    public string id { get; set; }
    public string name { get; set; }
    public string page { get; set; }
    public string hidden { get; set; }
    public string collective { get; set; }
    public string type { get; set; }
    public Profiles profiles { get; set; }
    public InfoLinks2 infoLinks { get; set; }
    public CategoryLinks2 categoryLinks { get; set; }
    public EntryLinks2 entryLinks { get; set; }
    public Costs costs { get; set; }
    public UnitsGroups UnitsGroups { get; set; }
    public SelectionEntries selectionEntries { get; set; }
    public Modifiers modifiers { get; set; }
    public Constraints constraints { get; set; }
    public string publicationId { get; set; }
  }

  public class ArmyUnits
  {
    public List<Unit> Units { get; set; }
  }

  public class Constraints2
  {
    public object constraint { get; set; }
  }

  public class UnitsGroups2
  {
    public object UnitsGroup { get; set; }
  }

  public class EntryLinks3
  {
    public object entryLink { get; set; }
  }

  public class Modifiers2
  {
    public object modifier { get; set; }
  }

  public class SelectionEntries2
  {
    public object Units { get; set; }
  }

  public class UnitsGroup
  {
    public string id { get; set; }
    public string name { get; set; }
    public string hidden { get; set; }
    public string collective { get; set; }
    public string defaultSelectionEntryId { get; set; }
    public Constraints2 constraints { get; set; }
    public UnitsGroups2 UnitsGroups { get; set; }
    public EntryLinks3 entryLinks { get; set; }
    public string publicationId { get; set; }
    public string page { get; set; }
    public Modifiers2 modifiers { get; set; }
    public SelectionEntries2 selectionEntries { get; set; }
  }

  public class SharedSelectionEntryGroups
  {
    public List<UnitsGroup> UnitsGroup { get; set; }
  }

  public class Rule2
  {
    public string id { get; set; }
    public string name { get; set; }
    public string hidden { get; set; }
    public string description { get; set; }
  }

  public class SharedRules
  {
    public Rule2 rule { get; set; }
  }

  public class Characteristics
  {
    public object characteristic { get; set; }
  }

  public class Modifier
  {
    public string type { get; set; }
    public string field { get; set; }
    public string value { get; set; }
  }

  public class Modifiers3
  {
    public Modifier modifier { get; set; }
  }

  public class Profile
  {
    public string id { get; set; }
    public string name { get; set; }
    public string hidden { get; set; }
    public string typeId { get; set; }
    public string typeName { get; set; }
    public Characteristics characteristics { get; set; }
    public Modifiers3 modifiers { get; set; }
  }

  public class Weapons
  {
    public List<Profile> profile { get; set; }
  }

  public class Catalogue
  {
    public string id { get; set; }
    public string name { get; set; }
    public string revision { get; set; }
    public string battleScribeVersion { get; set; }
    public string authorName { get; set; }
    public string authorContact { get; set; }
    public string authorUrl { get; set; }
    public string library { get; set; }
    public string gameSystemId { get; set; }
    public string gameSystemRevision { get; set; }
    public string xmlns { get; set; }
    public Publications publications { get; set; }
    public ProfileTypes profileTypes { get; set; }
    public CategoryEntries categoryEntries { get; set; }
    public EntryLinks entryLinks { get; set; }
    public Rules rules { get; set; }
    public InfoLinks infoLinks { get; set; }
    public ArmyUnits ArmyUnits { get; set; }
    public SharedSelectionEntryGroups sharedSelectionEntryGroups { get; set; }
    public SharedRules sharedRules { get; set; }
    public Weapons Weapons { get; set; }
  }

 }
