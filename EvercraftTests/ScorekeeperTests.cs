using NUnit.Framework;
using Evercraft;

namespace EvercraftTests
{
	[TestFixture()]
	public class ScorekeeperTests
	{
		[TestCase(1)]
		[TestCase(2)]
		public void Damage(int pts)
		{
			// Arrange
			Scorekeeper s = new Scorekeeper();
			Character c = new Character();
			int preDamage = 5;
			c.HitPoints = preDamage;
			// Act
			s.Damage(character: c, points: pts);
			// Assert
			Assert.AreEqual(preDamage - pts, c.HitPoints);
		}

	}
}