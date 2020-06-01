using System;

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
    public Allergies(int mask)
    {
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public Allergen[] List()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}