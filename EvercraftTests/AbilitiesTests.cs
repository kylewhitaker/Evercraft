using System.Collections;
using NUnit.Framework;

[TestFixture]
public class AbilitiesTests
{
	
	Abilities _ab;
	
	[OneTimeSetUp]
	public void OneTimeSetUp()
	{
		_ab = new Abilities();
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

	[TestCaseSource("AbilitiesDefaults")]
	public void Default(int ability, int score)
	{
		Assert.AreEqual(ability, score);
	}

	[Test]
	public void SetAbility_BelowMin([ValueSource("AbilityProperties")] string name)
	{
		var prop = typeof(Abilities).GetProperty(name);
		prop.SetValue(_ab, Abilities.MIN - 1);
		Assert.AreEqual(Abilities.MIN, (int)prop.GetValue(_ab));
	}

	[Test, Combinatorial]
	public void SetAbility_WithinRange([Range(1, 20)] int val, 
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

	[Test, Sequential]
	public void Modify([Range(1, 20)] int ability, 
	                   [Values(-5,-4,-4,-3,-3,-2,-2,-1,-1,0,0,1,1,2,2,3,3,4,4,5)] int modifier)
	{
		Assert.AreEqual(modifier, new Abilities().Modify(ability));
	}

}