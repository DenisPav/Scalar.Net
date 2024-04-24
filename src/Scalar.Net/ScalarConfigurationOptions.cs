namespace Scalar.Net;

public class ScalarConfigurationOptions
{
    public string? Theme { get; set; }
    public ScalarLayoutType? Layout { get; set; }
    public string? Proxy { get; set; }
    public bool? IsEditable { get; set; }
    public bool? ShowSidebar { get; set; }
    public bool? HideModels { get; set; }
    public bool? DarkMode { get; set; }
    public char? SearchHotKey { get; set; }
    public object? MetaData { get; set; }
    
    public ScalarSpecConfigurationOptions? Spec { get; set; }
}

public enum ScalarLayoutType
{
    Classic,
    Modern
}

public class ScalarSpecConfigurationOptions
{
    public string? Content { get; set; }
    public string? Url { get; set; }
}