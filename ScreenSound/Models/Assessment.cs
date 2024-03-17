namespace ScreenSound.Models;

internal class Assessment
{
	public Assessment(int score)
	{
		Score = score;
	}
    public int Score { get;}

	public static Assessment Parse(string texto)
	{
        int score = int.Parse(texto);
		return new Assessment (score);

    }
}