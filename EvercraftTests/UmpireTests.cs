using NUnit.Framework;
using Evercraft;

namespace EvercraftTests
{
	[TestFixture()]
	public class UmpireTests
	{
		[Test()]
		public void AttackIsHit_RollBeatsArmorClass_True()
		{
			Umpire u = new Umpire();
			int roll = 15, armorClass = 10;
			Assert.AreEqual(true, u.AttackIsHit(roll, armorClass));
		}

		[Test()]
		public void AttackIsHit_RollLessThanArmorClass_False()
		{
			Umpire u = new Umpire();
			int roll = 8, armorClass = 10;
			Assert.AreEqual(false, u.AttackIsHit(roll, armorClass));
		}

		[Test()]
		public void AttackIsHit_RollEqualsArmorClass_True()
		{
			Umpire u = new Umpire();
			int roll = 10, armorClass = 10;
			Assert.AreEqual(true, u.AttackIsHit(roll, armorClass));
		}

	}
}