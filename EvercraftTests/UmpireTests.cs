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
	}
}