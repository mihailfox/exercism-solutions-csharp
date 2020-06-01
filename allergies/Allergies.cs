using System;
using System.Collections.Generic;

[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly Allergen _mask;

    public Allergies(int mask)
    {
        _mask = (Allergen)mask;
    }

    public bool IsAllergicTo(Allergen allergen) => (allergen & _mask) == allergen;

    public Allergen[] List()
    {
        List<Allergen> allergenList = new List<Allergen>();

        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (IsAllergicTo(allergen))
            {
                allergenList.Add(allergen);
            }
        }

        return allergenList.ToArray();
    }
}