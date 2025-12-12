namespace MyPortfolio.Models;

public class Skill
{
  public int Id {get;set;}
  public string Name {get;set;} = string.Empty;
  public string Level {get;set;} = string.Empty;
}

public class Project
{
  public int Id {get;set;}
  public string Title {get;set;} = string.Empty;
  public string Description {get;set;} = string.Empty;
  public string Url {get;set;} = "#";
}

public class PortfolioViewModel
{
  public string FullName {get;set;} = string.Empty;
  public string Bio {get;set;} = string.Empty;
  public List<Skill> Skills {get;set;} = new();
  public List<Project> Projects {get;set;} = new();
}
