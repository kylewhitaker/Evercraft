using System.Collections;
using NUnit.Framework;

[TestFixture]
public class AbilitiesTests_Defaults
{
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

	[TestCaseSource("AbilitiesDefaults")]
	public void Default(int ability, int score)
	{
		Assert.AreEqual(ability, score);
	}
}

[TestFixture]
public class AbilitiesTests_Properties
{
	Abilities _ab;

	private static IEnumerable AbilityProperties
	{
		get
		{
			yield return "Charisma";
			yield return "Constitution";
			yield return "Dexterity";
			yield return "Intelligence";
			yield return "Strength";
			yield return "Wisdom";
		}
	}

	[OneTimeSetUp]
	public void OneTimeSetUp()
	{
		_ab = new Abilities();
	}

	[Test]
	public void SetAbility_BelowMin([ValueSource("AbilityProperties")] string name)
	{
		var prop = typeof(Abilities).GetProperty(name);
		prop.SetValue(_ab, Abilities.MIN - 1);
		Assert.AreEqual(Abilities.MIN, (int)prop.GetValue(_ab));
	}

	[Test]
	public void SetAbility_WithinRange([Values(1, 3, 12, 20)] int val, 
	                                   [ValueSource("AbilityProperties")] string name)
	{
		var prop = typeof(Abilities).GetProperty(name);
		prop.SetValue(_ab, val);
		Assert.AreEqual(val, (int)prop.GetValue(_ab));
	}

	[Test]
	public void SetAbility_AboveMax([ValueSource("AbilityProperties")] string name)
	{
		var prop = typeof(Abilities).GetProperty(name);
		prop.SetValue(_ab, Abilities.MAX + 1);
		Assert.AreEqual(Abilities.MAX, (int)prop.GetValue(_ab));
	}
}