using Makerlab.Domain.Apparaten;

namespace Makerlab.Infrastructure;

public static class MainSeeder
{
    private static readonly Random Rnd = new(42);  

    public static void Seed(MakerLabDBContext db)
    {
        if (db.Apparaten.Any()) return;   

        db.Apparaten.AddRange(Maak(3, "Lasersnijder",   (naam, loc) => new Snijder(naam, loc)));
        db.Apparaten.AddRange(Maak(2, "3D-printer",     (naam, loc) => new Printer(naam, loc)));
        db.Apparaten.AddRange(Maak(4, "Soldeerstation", (naam, loc) => new Soldeerstation(naam, loc)));
        db.Apparaten.AddRange(Maak(2, "VR-set",         (naam, loc) => new VRSet(naam, loc)));

        db.SaveChanges();
    }

    private static IEnumerable<T> Maak<T>(int count, string genericName, Func<string, string, T> factory)
        where T : Apparaat
    {
        for (int i = 1; i <= count; i++)
            yield return factory($"{genericName} {i}", GenerateLocation());
    }

    private static string GenerateLocation()
    {
        string[] places = ["Werkplaats", "Lab", "Lokaal", "Werklokaal"];
        string[] suffixes = ["A", "B", "C", "1", "2", "3"];
        return $"{places[Rnd.Next(places.Length)]} {suffixes[Rnd.Next(suffixes.Length)]}";
    }
}