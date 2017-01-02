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

		[TestCase(15,10)]
		[TestCase(10,10)]
		[TestCase(8,10)]
		public void AttackIsHit(int r, int ac)
		{
			Assert.AreEqual(r >= ac ? true : false, _u.AttackIsHit(roll: r, armorClass: ac));
		}

	}
}