using NUnit.Framework;

[TestFixture]
public class UmpireTests
{
	Umpire _u;

	[OneTimeSetUp]
	public void OneTimeSetUp()
	{
		_u = new Umpire();
	}

	[TestCase(15, 10, ExpectedResult = true)]
	[TestCase(10, 10, ExpectedResult = true)]
	[TestCase(8, 10, ExpectedResult = false)]
	public bool AttackIsHit(int r, int ac)
	{
		return _u.AttackIsHit(roll: r, armorClass: ac);
	}

	[TestCase(20, ExpectedResult = true)]
	[TestCase(19, ExpectedResult = false)]
	public bool AttackIsCriticalHit(int roll)
	{
		return _u.AttackIsCriticalHit(roll);
	}

}