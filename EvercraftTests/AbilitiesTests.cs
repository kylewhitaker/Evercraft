using System.Collections;
using NUnit.Framework;

[TestFixture]
public class AbilitiesTests
{
	const int MIN = 1;
	const int MAX = 20;

	[TestCaseSource("AbilitiesDefaults")]
	public void Default(int ability, int score)
	{
		Assert.AreEqual(ability, score);
	}

	static IEnumerable AbilitiesDefaults
	{
		get
		{
			yield return new TestCaseData(new Abilities().Charisma, 10).SetName("Charisma");
			yield return new TestCaseData(new Abilities().Constitution, 10).SetName("Constitution");
			yield return new TestCaseData(new Abilities().Dexterity, 10).SetName("Dexterity");
			yield return new TestCaseData(new Abilities().Intelligence, 10).SetName("Intelligence");
			yield return new TestCaseData(new Abilities().Strength, 10).SetName("Strength");
			yield return new TestCaseData(new Abilities().Wisdom, 10).SetName("Wisdom");
		}
	}

	[TestCase(0, ExpectedResult = MIN)]
	[TestCase(5, ExpectedResult = 5)]
	[TestCase(21, ExpectedResult = MAX)]
	public int SetValueRange(int score)
	{
		Abilities ab = new Abilities();
		ab.Charisma = score;
		return ab.Charisma;
	}
}