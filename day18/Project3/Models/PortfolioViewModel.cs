namespace Project3.Models;

public class PortfolioViewModel
{
  public string FullName {get;set;} = string.Empty;
  public string Bio {get;set;} = string.Empty;
  public List<Skill> Skills {get;set;} = new();
  public List<Project> Projects {get;set;} = new();
}

