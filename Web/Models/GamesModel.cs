namespace Web.Models;

public class Platforms
{
    public string? Title { get; set; }
    public string? Link { get; set; }
}

public class Image
{
    public string? Url { get; set; }
    public string? Alt { get; set; }
}

public class Achievements
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool? Unlocked { get; set; }
}

public class GamesModel
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? PlayTime { get; set; }
    public string? Purchased { get; set; }
    public List<Platforms>? Platforms { get; set; }
    public Image? Banner { get; set; }
    public List<Image>? Media { get; set; }
    public List<Achievements>? Achievements { get; set; }
}