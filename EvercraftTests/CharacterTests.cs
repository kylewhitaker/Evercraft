using NUnit.Framework;
using Rhino.Mocks;

[TestFixture]
public class CharacterTests
{
	Character _c;

	[SetUp]
	public void Setup()
	{
		_c = new Character();
	}

	[Test]
	public void GetSetName()
	{
		_c.Name = "Kyle";
		Assert.AreEqual("Kyle", _c.Name);
	}

	[Test]
	public void GetSetAlignment()
	{
		_c.Alignment = Alignment.Good;
		Assert.AreEqual(Alignment.Good, _c.Alignment);
	}

	[Test]
	public void DefaultArmorClass()
	{
		Assert.AreEqual(10, _c.ArmorClass);
	}

	[Test]
	public void DefaultHitPoints()
	{
		Assert.AreEqual(5, _c.HitPoints);
	}

	[Test]
	public void Attack_RollDie()
	{
		var die = MockRepository.GenerateStub<IRollDice>();
		die.Stub(x => x.Roll()).Return(15);
		Assert.AreEqual(15, _c.Attack(die));
	}

	[TestCase(1, ExpectedResult = false)]
	[TestCase(0, ExpectedResult = true)]
	[TestCase(-1, ExpectedResult = true)]
	public bool IsDead(int hp)
	{
		_c.HitPoints = hp;
		return _c.IsDead();
	}

}
