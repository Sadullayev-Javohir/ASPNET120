using MyPortfolio.Models;

namespace MyPortfolio.Services;

public class PortfolioService
{
  public PortfolioViewModel GetPortfolioData()
  {
    return new PortfolioViewModel
    {
      FullName = "Ali Valiyev",
      Bio = "Men ASP.NET Core o'rganayotgan g'ayratli dasturchiman. 21-kuni loyihasini bajaryapman!",

      Skills = new List<Skill>
      {
        new Skill {Id = 1, Name = "C#", Level = "Intermediate"},
        new Skill {Id = 2, Name = "ASP.NET CORE", Level = "Beginner"},
        new Skill {Id = 3, Name = "SQL", Level = "Junior"}
      },

      Projects = new List<Project>
      {
        new Project {Id = 1, Title = "Weather App", Description = "Real vaqtli ob-havo dasturi", Url = "https://example.com/weather"},
        new Project {Id = 2, Title = "E-Commerce Store", Description = "Oddiy online do'kon prototipi", Url = "https://example.com/store"}
      }
    };
  }
}
