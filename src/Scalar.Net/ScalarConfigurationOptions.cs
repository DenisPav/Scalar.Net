namespace Scalar.Net;

/// <summary>
/// Represents Scalar.Net configuration options
/// </summary>
public class ScalarConfigurationOptions
{
    /// <summary>
    /// Scalar theme
    /// </summary>
    public string? Theme { get; set; }
    /// <summary>
    /// Layout - Classic, Modern
    /// </summary>
    public ScalarLayoutType? Layout { get; set; }
    /// <summary>
    /// Proxy
    /// </summary>
    public string? Proxy { get; set; }
    /// <summary>
    /// Is spec editable?
    /// </summary>
    public bool? IsEditable { get; set; }
    /// <summary>
    /// Show/Hide sidebar
    /// </summary>
    public bool? ShowSidebar { get; set; }
    /// <summary>
    /// Hide models
    /// </summary>
    public bool? HideModels { get; set; }
    /// <summary>
    /// Default dark mode
    /// </summary>
    public bool? DarkMode { get; set; }
    /// <summary>
    /// Char hotkey for search
    /// </summary>
    public char? SearchHotKey { get; set; }
    /// <summary>
    /// Additional metadata
    /// </summary>
    public object? MetaData { get; set; }
    /// <summary>
    /// Custom script location
    /// </summary>
    public string? Cdn { get; set; }
    
    /// <summary>
    /// Open api spec options
    /// </summary>
    public ScalarSpecConfigurationOptions? Spec { get; set; }
}

/// <summary>
/// Scalar layout type enum
/// </summary>
public enum ScalarLayoutType
{
    /// <summary>
    /// Classic layout
    /// </summary>
    Classic,
    /// <summary>
    /// Modern layout
    /// </summary>
    Modern
}

/// <summary>
/// Scalar open api spec configuration options
/// </summary>
public class ScalarSpecConfigurationOptions
{
    /// <summary>
    /// Spec contents
    /// </summary>
    public string? Content { get; set; }
    /// <summary>
    /// Url to open api spec
    /// </summary>
    public string? Url { get; set; }
}