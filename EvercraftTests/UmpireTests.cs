using NUnit.Framework;

[TestFixture]
public class UmpireTests
{
	Umpire _u;

	[TestFixtureSetUp]
	public void TFSetup()
	{
		_u = new Umpire();
	}

	[TestCase(15, 10, Result = true)]
	[TestCase(10, 10, Result = true)]
	[TestCase(8, 10, Result = false)]
	public bool AttackIsHit(int r, int ac)
	{
		return _u.AttackIsHit(roll: r, armorClass: ac);
	}

}