using NUnit.Framework;

[TestFixture]
public class AbilitiesTests
{
	[Test]
	public void DefaultCharisma()
	{
		Abilities a = new Abilities();
		Assert.AreEqual(10, a.Charisma);
	}

	[Test]
	public void DefaultDexterity()
	{
		Abilities a = new Abilities();
		Assert.AreEqual(10, a.Dexterity);
	}
}