﻿namespace Web.Models;

public class Images
{
    public string? Alt { get; set; }
    public string? Src { get; set; }
}

public class ProjectsModel
{
    public string? Name { get; set; }
    public string? ShortDescription { get; set; }
    public string? Description { get; set; }
    public string? Website { get; set; }
    public string? Github { get; set; }
    public string? Visibility { get; set; }
    public List<string>? Frameworks { get; set; }
    public List<string>? Languages { get; set; }
    public List<Images>? Images { get; set; }
}

public enum VisibilityOption
{
    Visible,
    Hidden
}