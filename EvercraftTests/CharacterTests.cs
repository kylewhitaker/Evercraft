using System.Collections;
using NUnit.Framework;
using Rhino.Mocks;

[TestFixture]
public class CharacterTests
{
	Character _c;

	[OneTimeSetUp]
	public void OneTimeSetUp()
	{
		_c = new Character();
	}

	[TestCaseSource("CharacterDefaults")]
	public void Default(int property, int score)
	{
		Assert.AreEqual(property, score);
	}

	static IEnumerable CharacterDefaults
	{
		get
		{
			yield return new TestCaseData(new Character().ArmorClass, 10).SetName("ArmorClass");
			yield return new TestCaseData(new Character().HitPoints, 5).SetName("HitPoints");
		}
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
