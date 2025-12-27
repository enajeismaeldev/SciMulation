using System.Drawing.Text;
using System.Globalization;

namespace SciMulation.Utils;

public readonly struct FontKey
{
    public FontWeight Weight { get; }
    public FontSlant Slant { get; }

    public FontKey(FontWeight weight, FontSlant slant)
    {
        Weight = weight;
        Slant = slant;
    }

    public override int GetHashCode() => ((int)Weight << 2) | (int)Slant;
}

public static class AppFonts
{
    private static PrivateFontCollection _collection;
    private static readonly Dictionary<FontKey, FontFamily> _families = new();

    public static void Initialize()
    {
        _collection = new PrivateFontCollection();

        Add(FontWeight.Regular, FontSlant.Regular, @"Assets\fonts\PPTelegraf-Regular.otf");
        Add(FontWeight.Ultrabold, FontSlant.Regular, @"Assets\fonts\PPTelegraf-Ultrabold.otf");
    }

    private static void Add(FontWeight weight, FontSlant slant, string file)
    {
        _collection.AddFontFile(file);

        FontFamily family = _collection.Families[_collection.Families.Length - 1];

        _families[new FontKey(weight, slant)] = family;
    }
    public static Font Get(
        float size,
        FontWeight weight = FontWeight.Regular,
        FontSlant slant = FontSlant.Regular)
    {
        var key = new FontKey(weight, slant);
        var family = _families[key];

        return new Font(family, size, FontStyle.Regular);
    }
}

public enum FontWeight
{
    Regular,
    Ultrabold
}

public enum FontSlant
{
    Regular
}

