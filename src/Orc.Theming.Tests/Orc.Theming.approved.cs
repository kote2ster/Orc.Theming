﻿[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v5.0", FrameworkDisplayName="")]
[assembly: System.Windows.Markup.XmlnsDefinition("http://schemas.wildgums.com/orc/theming", "Orc.Theming")]
[assembly: System.Windows.Markup.XmlnsDefinition("http://schemas.wildgums.com/orc/theming", "Orc.Theming.Views")]
[assembly: System.Windows.Markup.XmlnsPrefix("http://schemas.wildgums.com/orc/theming", "orctheming")]
[assembly: System.Windows.ThemeInfo(System.Windows.ResourceDictionaryLocation.None, System.Windows.ResourceDictionaryLocation.SourceAssembly)]
public static class LoadAssembliesOnStartup { }
public static class ModuleInitializer
{
    public static void Initialize() { }
}
namespace Orc.Theming
{
    public class AccentColorService : Orc.Theming.IAccentColorService
    {
        public AccentColorService() { }
        public event System.EventHandler<System.EventArgs> AccentColorChanged;
        public virtual System.Windows.Media.Color GetAccentColor() { }
        protected void RaiseAccentColorChanged() { }
        public virtual bool SetAccentColor(System.Windows.Media.Color color) { }
    }
    public static class AlphaBlendingHelper
    {
        public const byte FullyOpaqueAlpha = 255;
        public const byte FullyTransparentAlpha = 0;
        public static int ApplyFilter(int dstPixel) { }
        public static int ApplyFilter(int dstPixel, int depth) { }
        public static int BlendPixels(int dstPixel, int srcPixel) { }
    }
    public class AsterixAdorner : System.Windows.Documents.Adorner
    {
        public AsterixAdorner(System.Windows.UIElement adornedElement, System.Windows.Thickness padding) { }
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext) { }
    }
    public class BaseColorSchemeService : Orc.Theming.IBaseColorSchemeService
    {
        public BaseColorSchemeService() { }
        public event System.EventHandler<System.EventArgs> BaseColorSchemeChanged;
        public virtual System.Collections.Generic.IReadOnlyList<string> GetAvailableBaseColorSchemes() { }
        public string GetBaseColorScheme() { }
        public bool SetBaseColorScheme(string scheme) { }
    }
    public static class ColorExtensions
    {
        public static int AlphaBlend(this System.Windows.Media.Color source, int dest) { }
        public static System.Windows.Media.Color FindContrast(this System.Windows.Media.Color color) { }
        public static float GetPerceptiveLuminance(this System.Windows.Media.Color color) { }
        public static System.Windows.Media.Color GrayColor(this System.Windows.Media.Color color) { }
        public static System.Windows.Media.Color HSBToRGB(double h, double s, double b) { }
        public static System.Windows.Media.Color InterpolateToColor(this System.Windows.Media.Color color, float mix, System.Windows.Media.Color destColor) { }
        public static bool IsDarkColor(this System.Windows.Media.Color color) { }
        public static System.Windows.Media.Color MakeColorMoreSaturated(this System.Windows.Media.Color color, double coefficient) { }
        public static Orc.Theming.Coloring.ColorHsb RGBToHSB(int red, int green, int blue) { }
        public static System.Windows.Media.Color RemoveAlpha(this System.Windows.Media.Color foreground) { }
        public static System.Windows.Media.Color SetBrightness(this System.Windows.Media.Color color, float brightness) { }
        public static System.Windows.Media.Color ToColor(this int colorAsInt) { }
        public static double ToGrayScale(this System.Windows.Media.Color color) { }
        public static int ToInt(this System.Windows.Media.Color color, Orc.Theming.Coloring.ColorShade colorShade = 0) { }
        public static System.Windows.Media.SolidColorBrush ToSolidColorBrush(this System.Windows.Media.Color color, double opacity = 1) { }
        public static System.Windows.Media.Color[] TransformPalette(this System.Collections.Generic.IReadOnlyList<System.Windows.Media.Color> palette, int count) { }
    }
    public class Crc32 : System.Security.Cryptography.HashAlgorithm
    {
        public const uint DefaultPolynomial = 3988292384u;
        public const uint DefaultSeed = 4294967295u;
        public Crc32() { }
        public Crc32(uint polynomial, uint seed) { }
        public override int HashSize { get; }
        protected override void HashCore(byte[] array, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { }
        public override void Initialize() { }
        public static uint Compute(byte[] buffer) { }
        public static uint Compute(uint seed, byte[] buffer) { }
        public static uint Compute(uint polynomial, uint seed, byte[] buffer) { }
    }
    public class FontImage : Catel.Windows.Markup.UpdatableMarkupExtension
    {
        public FontImage() { }
        public FontImage(string itemName) { }
        public System.Windows.Media.Brush Brush { get; set; }
        public string BrushKey { get; set; }
        public string FontFamily { get; set; }
        [System.Windows.Markup.ConstructorArgument("itemName")]
        public string ItemName { get; set; }
        public static System.Windows.Media.Brush DefaultBrush { get; set; }
        public static string DefaultBrushKey { get; set; }
        public static string DefaultFontFamily { get; set; }
        protected virtual System.Windows.Media.Brush GetBrush() { }
        public System.Windows.Media.ImageSource GetImageSource() { }
        protected override void OnTargetObjectLoaded() { }
        protected override void OnTargetObjectUnloaded() { }
        protected override object ProvideDynamicValue(System.IServiceProvider serviceProvider) { }
        public static System.Windows.Media.FontFamily GetRegisteredFont(string name) { }
        public static System.Collections.Generic.IEnumerable<string> GetRegisteredFonts() { }
        public static void RegisterFont(string name, System.Windows.Media.FontFamily fontFamily) { }
    }
    public static class FrameworkElementExtensions
    {
        public static TBehavior AttachBehavior<TBehavior>(this System.Windows.FrameworkElement frameworkElement)
            where TBehavior : Microsoft.Xaml.Behaviors.Behavior { }
        public static void DetachBehavior<TBehavior>(this System.Windows.FrameworkElement frameworkElement)
            where TBehavior : Microsoft.Xaml.Behaviors.Behavior { }
    }
    public interface IAccentColorService
    {
        event System.EventHandler<System.EventArgs> AccentColorChanged;
        System.Windows.Media.Color GetAccentColor();
        bool SetAccentColor(System.Windows.Media.Color color);
    }
    public interface IBaseColorSchemeService
    {
        event System.EventHandler<System.EventArgs> BaseColorSchemeChanged;
        System.Collections.Generic.IReadOnlyList<string> GetAvailableBaseColorSchemes();
        string GetBaseColorScheme();
        bool SetBaseColorScheme(string scheme);
    }
    public interface IResourceDictionaryService
    {
        bool IsResourceDictionaryAvailable(string resourceDictionaryUri);
    }
    public interface IThemeService
    {
        Orc.Theming.ThemeInfo GetThemeInfo();
        bool ShouldCreateStyleForwarders();
    }
    public class LibraryThemeProvider : ControlzEx.Theming.LibraryThemeProvider
    {
        public LibraryThemeProvider() { }
        public override void FillColorSchemeValues(System.Collections.Generic.Dictionary<string, string> values, ControlzEx.Theming.RuntimeThemeColorValues colorValues) { }
    }
    public class MandatoryFieldBehavior : Catel.Windows.Interactivity.BehaviorBase<System.Windows.FrameworkElement>
    {
        public static readonly System.Windows.DependencyProperty IsMandatoryProperty;
        public static readonly System.Windows.DependencyProperty OffsetProperty;
        public MandatoryFieldBehavior() { }
        public static bool GetIsMandatory(System.Windows.DependencyObject element) { }
        public static System.Windows.Thickness GetOffset(System.Windows.DependencyObject element) { }
        public static void SetIsMandatory(System.Windows.DependencyObject element, bool value) { }
        public static void SetOffset(System.Windows.DependencyObject element, System.Windows.Thickness value) { }
    }
    public class Margin : System.Windows.DependencyObject
    {
        public static readonly System.Windows.DependencyProperty BottomProperty;
        public static readonly System.Windows.DependencyProperty LeftProperty;
        public static readonly System.Windows.DependencyProperty RightProperty;
        public static readonly System.Windows.DependencyProperty TopProperty;
        public Margin() { }
        public static double GetBottom(System.Windows.DependencyObject d) { }
        public static double GetLeft(System.Windows.DependencyObject d) { }
        public static double GetRight(System.Windows.DependencyObject d) { }
        public static double GetTop(System.Windows.DependencyObject d) { }
        public static void SetBottom(System.Windows.DependencyObject d, double value) { }
        public static void SetLeft(System.Windows.DependencyObject d, double value) { }
        public static void SetRight(System.Windows.DependencyObject d, double value) { }
        public static void SetTop(System.Windows.DependencyObject d, double value) { }
    }
    public class ResourceDictionaryService : Orc.Theming.IResourceDictionaryService
    {
        public ResourceDictionaryService() { }
        public virtual bool IsResourceDictionaryAvailable(string resourceDictionaryUri) { }
    }
    public static class ScreenHelper
    {
        public static System.Windows.Size GetDpi() { }
    }
    public static class StyleHelper
    {
        public static bool IsStyleForwardingEnabled { get; }
        public static void CreateStyleForwardersForDefaultStyles(string defaultPrefix = "Default") { }
        public static void CreateStyleForwardersForDefaultStyles(System.Windows.ResourceDictionary sourceResources, string defaultPrefix = "Default") { }
        public static void CreateStyleForwardersForDefaultStyles(System.Windows.ResourceDictionary sourceResources, System.Windows.ResourceDictionary targetResources, string defaultPrefix = "Default") { }
        public static void CreateStyleForwardersForDefaultStyles(System.Windows.ResourceDictionary rootResourceDictionary, System.Windows.ResourceDictionary sourceResources, System.Windows.ResourceDictionary targetResources, string defaultPrefix = "Default") { }
        public static void EnsureApplicationResourcesAndCreateStyleForwarders(System.Uri applicationResourceDictionary, string defaultPrefix = "Default") { }
    }
    public class ThemeColor : Catel.Windows.Markup.UpdatableMarkupExtension
    {
        public ThemeColor() { }
        public ThemeColor(Orc.Theming.ThemeColorStyle themeColorStyle) { }
        public string ResourceName { get; set; }
        public Orc.Theming.ThemeColorStyle ThemeColorStyle { get; set; }
        protected override void OnTargetObjectLoaded() { }
        protected override void OnTargetObjectUnloaded() { }
        protected override object ProvideDynamicValue(System.IServiceProvider serviceProvider) { }
    }
    public class ThemeColorBrush : Catel.Windows.Markup.UpdatableMarkupExtension
    {
        public ThemeColorBrush() { }
        public ThemeColorBrush(Orc.Theming.ThemeColorStyle themeColorStyle) { }
        public string ResourceName { get; set; }
        public Orc.Theming.ThemeColorStyle ThemeColorStyle { get; set; }
        protected override void OnTargetObjectLoaded() { }
        protected override void OnTargetObjectUnloaded() { }
        protected override object ProvideDynamicValue(System.IServiceProvider serviceProvider) { }
    }
    public enum ThemeColorStyle
    {
        AccentColor = 0,
        AccentColor80 = 1,
        AccentColor60 = 2,
        AccentColor40 = 3,
        AccentColor20 = 4,
        [System.Obsolete("Use `AccentColor80` instead. Will be removed in version 5.0.0.", true)]
        AccentColor1 = 1,
        [System.Obsolete("Use `AccentColor60` instead. Will be removed in version 5.0.0.", true)]
        AccentColor2 = 2,
        [System.Obsolete("Use `AccentColor40` instead. Will be removed in version 5.0.0.", true)]
        AccentColor3 = 3,
        [System.Obsolete("Use `AccentColor20` instead. Will be removed in version 5.0.0.", true)]
        AccentColor4 = 4,
        BorderColor = 5,
        BackgroundColor = 6,
        ForegroundColor = 7,
        HighlightColor = 8,
        Gray1 = 9,
        Gray2 = 10,
        Gray3 = 11,
        Gray4 = 12,
        Gray5 = 13,
        Gray6 = 14,
        Gray7 = 15,
        Gray8 = 16,
        Gray9 = 17,
        Gray10 = 18,
        Text = 19,
        DefaultBorder = 5,
        DefaultBackground = 6,
        DefaultForeground = 7,
        DefaultText = 19,
        CheckedBorder = 8,
        CheckedBackground = 4,
        CheckedForeground = 7,
        CheckedText = 19,
        CheckedMouseOverBorder = 2,
        CheckedMouseOverBackground = 4,
        CheckedMouseOverForeground = 7,
        CheckedMouseOverText = 19,
        MouseOverBorder = 3,
        MouseOverBackground = 4,
        MouseOverForeground = 7,
        MouseOverText = 19,
        PressedBorder = 2,
        PressedBackground = 3,
        PressedForeground = 7,
        PressedText = 19,
        DisabledBorder = 13,
        DisabledBackground = 3,
        DisabledForeground = 7,
        DisabledText = 19,
        HighlightedBorder = 2,
        HighlightedBackground = 3,
        HighlightedForeground = 7,
        HighlightedText = 19,
        SelectionActiveBorder = 1,
        SelectionActiveBackground = 2,
        SelectionActiveForeground = 7,
        SelectionActiveText = 19,
        SelectionInactiveBorder = 3,
        SelectionInactiveBackground = 4,
        SelectionInactiveForeground = 7,
        SelectionInactiveText = 19,
    }
    public class ThemeInfo
    {
        public ThemeInfo() { }
        public System.Windows.Media.Color AccentBaseColor { get; set; }
        public string BaseColorScheme { get; set; }
        public System.Windows.Media.Color HighlightColor { get; set; }
    }
    public class ThemeManager
    {
        public ThemeManager(ControlzEx.Theming.ThemeManager controlzThemeManager, Orc.Theming.IAccentColorService accentColorService, Orc.Theming.IBaseColorSchemeService baseColorSchemeService) { }
        public static Orc.Theming.ThemeManager Current { get; }
        public event System.EventHandler<System.EventArgs> ThemeChanged;
        public System.Windows.Media.SolidColorBrush GetAccentColorBrush() { }
        public System.Windows.Media.Color GetThemeColor(Orc.Theming.ThemeColorStyle colorStyle = 0) { }
        public System.Windows.Media.Color GetThemeColor(string resourceName) { }
        public System.Windows.Media.SolidColorBrush GetThemeColorBrush(Orc.Theming.ThemeColorStyle colorStyle = 0) { }
        public System.Windows.Media.SolidColorBrush GetThemeColorBrush(string resourceName) { }
        public virtual void SynchronizeTheme() { }
    }
    public class ThemeService : Orc.Theming.IThemeService
    {
        public ThemeService(Orc.Theming.IAccentColorService accentColorService, Orc.Theming.IBaseColorSchemeService baseColorSchemeService) { }
        public virtual Orc.Theming.ThemeInfo GetThemeInfo() { }
        public virtual bool ShouldCreateStyleForwarders() { }
    }
}
namespace Orc.Theming.Coloring
{
    public class ColorGenerator : Orc.Theming.Coloring.IColorGenerator
    {
        public const string DefaultFalseValue = "false";
        public const string DefaultNullValue = "null";
        public const string DefaultTrueValue = "true";
        public ColorGenerator() { }
        public ColorGenerator(string trueValue, string falseValue, string nullValue) { }
        protected virtual System.Windows.Media.Color ColorFromStringHash(string strValue, string salt) { }
        protected virtual string ConvertToStringValue(object value) { }
        public virtual System.Windows.Media.Color Generate(object value, string salt = null) { }
        protected virtual bool IsFalse(string strValue) { }
        protected virtual bool IsTrue(string strValue) { }
    }
    public struct ColorHsb
    {
        public static readonly Orc.Theming.Coloring.ColorHsb Empty;
        public ColorHsb(double h, double s, double b) { }
        public double Brightness { get; set; }
        public double Hue { get; set; }
        public double Saturation { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static bool operator !=(Orc.Theming.Coloring.ColorHsb item1, Orc.Theming.Coloring.ColorHsb item2) { }
        public static bool operator ==(Orc.Theming.Coloring.ColorHsb item1, Orc.Theming.Coloring.ColorHsb item2) { }
    }
    public enum ColorShade
    {
        Light = 0,
        Medium = 1,
        Dark = 2,
    }
    public interface IColorGenerator
    {
        System.Windows.Media.Color Generate(object value, string salt = null);
    }
    public static class IntColors
    {
        public static readonly int Black;
        public static readonly int Blue;
        public static readonly int DarkGray;
        public static readonly int Gold;
        public static readonly int LightGray;
        public static readonly int MediumGray;
        public static readonly int Red;
        public static readonly int SoftGray;
        public static readonly int TransparentSoftGray;
        public static readonly int White;
        public static readonly int Yellow;
    }
}
namespace Orc.Theming.Converters
{
    public class ColorToContrastColorValueConverter : Catel.MVVM.Converters.ValueConverterBase
    {
        public ColorToContrastColorValueConverter() { }
        protected override object Convert(object value, System.Type targetType, object parameter) { }
    }
    public class ColorToOpaqueColorConverter : Catel.MVVM.Converters.ValueConverterBase
    {
        public ColorToOpaqueColorConverter() { }
        protected override object Convert(object value, System.Type targetType, object parameter) { }
    }
}
namespace Orc.Theming.ViewModels
{
    public class AccentColorSwitcherViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.PropertyData SelectedAccentColorProperty;
        public AccentColorSwitcherViewModel(Orc.Theming.ThemeManager themeManager, Orc.Theming.IAccentColorService accentColorService) { }
        public System.Collections.Generic.List<System.Windows.Media.Color> AccentColors { get; }
        public System.Windows.Media.Color SelectedAccentColor { get; set; }
        protected override System.Threading.Tasks.Task CloseAsync() { }
        protected override System.Threading.Tasks.Task InitializeAsync() { }
    }
    public class BaseColorSchemeSwitcherViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.PropertyData SelectedBaseColorSchemeProperty;
        public BaseColorSchemeSwitcherViewModel(Orc.Theming.IBaseColorSchemeService baseColorSchemeService) { }
        public System.Collections.Generic.IReadOnlyList<string> BaseColorSchemes { get; }
        public string SelectedBaseColorScheme { get; set; }
        protected override System.Threading.Tasks.Task CloseAsync() { }
        protected override System.Threading.Tasks.Task InitializeAsync() { }
    }
    public class ThemeSwitcherViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.PropertyData SelectedAccentColorProperty;
        public static readonly Catel.Data.PropertyData SelectedBaseColorSchemeProperty;
        public ThemeSwitcherViewModel(Orc.Theming.IAccentColorService accentColorService, Orc.Theming.IBaseColorSchemeService baseColorSchemeService) { }
        public System.Collections.Generic.List<System.Windows.Media.Color> AccentColors { get; }
        public System.Collections.Generic.IReadOnlyList<string> BaseColorSchemes { get; }
        public System.Windows.Media.Color SelectedAccentColor { get; set; }
        public string SelectedBaseColorScheme { get; set; }
    }
}
namespace Orc.Theming.Views
{
    public class AccentColorSwitcherView : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public AccentColorSwitcherView() { }
        public void InitializeComponent() { }
    }
    public class BaseColorSchemeSwitcherView : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public BaseColorSchemeSwitcherView() { }
        public void InitializeComponent() { }
    }
    public class ThemeSwitcherView : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public ThemeSwitcherView() { }
        public void InitializeComponent() { }
    }
}