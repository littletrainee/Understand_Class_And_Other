namespace WpfApp1 {
  public class Student {
    // declare variable
    public string Name { get; set; }
    public int ChineseScore { get; set; }
    public int MathScore { get; set; }
    public int SciencesScore { get; set; }
    public int SocialScore { get; set; }

    // declare method
    public int CalculateTotalScore() {
      return ChineseScore + MathScore + SciencesScore + SocialScore;
    }
  }
}
