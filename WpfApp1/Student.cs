namespace WpfApp1
{
  public class Student
  {
    public string Name { get; set; }
    public int ChineseScore { get; set; }
    public int MathScore { get; set; }
    public int SciencesScore { get; set; }
    public int Socialcore { get; set; }

    public int CalculateTotalScore()
    {
      return ChineseScore + MathScore + SciencesScore + Socialcore;
    }
  }
}
