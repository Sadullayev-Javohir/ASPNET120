using Project3.Models;

namespace Project3.Services;

public class PortfolioService
{
  public PortfolioViewModel GetPortfolioData()
  {
    return new PortfolioViewModel
    {
      FullName = "Ali Valiyev",
      Bio = "Men ASP.NET Core o'rganayapman.",

      Skills = new List<Skill>
      {
        new Skill {Id = 1, Name = "C#", Level = "Intermediate"},
        new Skill {Id = 2, Name = "ASP.NET Core", Level = "Beginner"},
        new Skill {Id = 3, Name = "Sql", Level = "Junior"}
      },

      Projects = new List<Project>
      {
        new Project {Id = 1, Title = "Weather App", Description = "Ob-havo dasturi"},
        new Project {Id = 2, Title = "E-Commerce", Description = "Onlayn-do'kon prototipi"}
      }
    };
  }
}
