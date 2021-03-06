namespace Allergies
{
  public class Allergen
  {
    public string AName { get;  set; }
    public int AScore { get; set; }

    public Allergen(string aName, int aScore)
    {
      AName = aName;
      AScore = aScore;
    }
    public string GetAllergenName()
    {
      return aName;
    }
    public bool IncludedAllergens(int aScore)
    {
      return (aScore <= intAScore);
    }
  }
}