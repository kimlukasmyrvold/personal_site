namespace Web.Models;

public class Platforms
{
    public string? Title { get; set; }
    public string? Link { get; set; }
}

public class Achievements
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool? Hidden { get; set; }
    public bool? Unlocked { get; set; }
}

public class GamesModel
{
    public string? Title { get; set; }
    public string? PlayTime { get; set; }
    public string? LastUpdate { get; set; }
    public string? Purchased { get; set; }
    public List<Platforms>? Platforms { get; set; }
    public string? Banner { get; set; }
    public List<Achievements>? Achievements { get; set; }
}

public enum SortOption
{
    Unlocked,
    Locked,
    NameAscending,
    NameDescending
}