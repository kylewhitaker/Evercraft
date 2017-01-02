using NUnit.Framework;
using Evercraft;

namespace EvercraftTests
{
	[TestFixture()]
	public class UmpireTests
	{
		Umpire _u;

		[TestFixtureSetUp()]
		public void Setup()
		{
			_u = new Umpire();
		}

		[Test()]
		public void AttackIsHit_RollBeatsArmorClass_True()
		{
			Assert.AreEqual(true, _u.AttackIsHit(roll: 15, armorClass: 10));
		}

		[Test()]
		public void AttackIsHit_RollLessThanArmorClass_False()
		{
			Assert.AreEqual(false, _u.AttackIsHit(roll: 8, armorClass: 10));
		}

		[Test()]
		public void AttackIsHit_RollEqualsArmorClass_True()
		{
			Assert.AreEqual(true, _u.AttackIsHit(roll: 10, armorClass: 10));
		}

	}
}