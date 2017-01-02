using NUnit.Framework;

[TestFixture]
public class ScorekeeperTests
{
	Scorekeeper _s;
	Character _c;

	[OneTimeSetUp]
	public void OneTimeSetup()
	{
		_s = new Scorekeeper();
	}

	[SetUp]
	public void Setup()
	{
		_c = new Character();
	}

	[TestCase(1)]
	[TestCase(2)]
	public void Damage(int pts)
	{
		// Arrange
		int preDamage = _c.HitPoints;
		// Act
		_s.Damage(character: _c, points: pts);
		// Assert
		Assert.AreEqual(preDamage - pts, _c.HitPoints);
	}

}