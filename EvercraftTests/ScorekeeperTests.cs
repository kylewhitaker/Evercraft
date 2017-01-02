using NUnit.Framework;
using Evercraft;

namespace EvercraftTests
{
	[TestFixture()]
	public class ScorekeeperTests
	{
		[Test()]
		public void Damage_OnePoint()
		{
			// Arrange
			Scorekeeper s = new Scorekeeper();
			Character c = new Character();
			int preDamage = c.HitPoints;
			// Act
			s.Damage(character: c, points: 1);
			// Assert
			Assert.AreEqual(preDamage - 1, c.HitPoints);
		}

		[Test()]
		public void Damage_TwoPoints()
		{
			// Arrange
			Scorekeeper s = new Scorekeeper();
			Character c = new Character();
			int preDamage = c.HitPoints;
			// Act
			s.Damage(character: c, points: 2);
			// Assert
			Assert.AreEqual(preDamage - 2, c.HitPoints);
		}
	}
}