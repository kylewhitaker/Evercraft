using NUnit.Framework;

[TestFixture]
public class AbilitiesTests
{
	[Test]
	public void Default()
	{
		Abilities a = new Abilities();
		Assert.AreEqual(10, a.Charisma);
	}
}