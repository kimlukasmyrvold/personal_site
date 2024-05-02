namespace Web.Models;

public class Certificate
{
    public string? Name { get; set; }
    public string? Url { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageAlt { get; set; }
    public string? Svg { get; set; }
}

public class Project
{
    public string? Name { get; set; }
    public string? Url { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageAlt { get; set; }
    public string? Svg { get; set; }
}

public class CodingLanguage
{
    public string? Name { get; set; }
    public string? SubName { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageAlt { get; set; }
    public string? Svg { get; set; }
    public List<Certificate>? Certificates { get; set; }
    public List<Project>? Projects { get; set; }
}