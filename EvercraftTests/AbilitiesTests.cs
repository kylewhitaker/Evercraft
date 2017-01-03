using System.Collections;
using NUnit.Framework;

[TestFixture]
public class AbilitiesTests
{
	[TestCaseSource("AbilitiesDefaults")]
	public void Default(int ability, int score)
	{
		Assert.AreEqual(ability, score);
	}

	private static IEnumerable AbilitiesDefaults
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

	[TestCaseSource(typeof(MyTestData), "AbilitiesRangeValues1To20")]
	public int SetValue_Charisma(int score)
	{
		Abilities ab = new Abilities();
		ab.Charisma = score;
		return ab.Charisma;
	}

	[TestCaseSource(typeof(MyTestData), "AbilitiesRangeValues1To20")]
	public int SetValue_Constitution(int score)
	{
		Abilities ab = new Abilities();
		ab.Constitution = score;
		return ab.Constitution;
	}

	[TestCaseSource(typeof(MyTestData), "AbilitiesRangeValues1To20")]
	public int SetValue_Dexterity(int score)
	{
		Abilities ab = new Abilities();
		ab.Dexterity = score;
		return ab.Dexterity;
	}

}

public class MyTestData
{
	private static readonly int MIN = Abilities.MIN;
	private static readonly int MAX = Abilities.MAX;

	public static IEnumerable AbilitiesRangeValues1To20
	{
		get
		{
			yield return new TestCaseData(MIN - 1).Returns(MIN);
			yield return new TestCaseData(5).Returns(5);
			yield return new TestCaseData(MAX + 1).Returns(MAX);
		}
	}
}