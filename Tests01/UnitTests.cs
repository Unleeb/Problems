using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem01;

namespace Tests01
{

	[TestClass]
	public class UnitTests
	{

		/// <summary>
		///   Base case
		/// </summary>
		[TestMethod]
		public void Problem01TestMethod1()
		{
			var problems = new Problems();
			Assert.AreEqual( 5, problems.Median( "1, 1, 3, 5, 8, 13, 21" ) );
		}

		/// <summary>
		///   Reverse case
		/// </summary>
		[TestMethod]
		public void Problem01TestMethod2()
		{
			var problems = new Problems();
			Assert.AreEqual( 8, problems.Median( "21, 13, 8, 17, 3, 1, 1" ) );
		}

		/// <summary>
		///   Simple auxilliary case
		/// </summary>
		[TestMethod]
		public void Problem01TestMethod3()
		{
			var problems = new Problems();
			Assert.AreEqual( 50, problems.Median( "100, 51, 99, 2, 50, 0, 1" ) );
		}

		/// <summary>
		///   Test many numbers
		/// </summary>
		[TestMethod]
		public void Problem01TestMethod4()
		{
			var problems = new Problems();
			Assert.AreEqual( 4857, problems.Median( "334,2241,5583,2196,4539,2117,2045,6904,5252,5239,4519,1765,8463,6496,3314,8392,3943,58,9482,7119,5987,5929,8258,7264,5306,4570,8514,2428,6346,4779,302,801,7514,5370,3609,1446,5729,5266,6804,8458,9482,7939,8927,3139,6154,4450,9929,2555,6647,4710,4857,488,5001,6057,6675,832,6129,987,5280,3662,588,1804,7143,7238,4845,6093,9861,9108,4176,1650,7382,3419,3107,1166,1000,6471,5584,1871,6568,415,4187,5189,3753,5366,9818,276,2377,7550,5408,3992,2526,2149,1946,286,6577,8697,8676,3695,223,4010,2068" ) );
		}

		/// <summary>
		///   Test all numbers equal
		/// </summary>
		[TestMethod]
		public void Problem01TestMethod5()
		{
			var problems = new Problems();
			Assert.AreEqual( 1, problems.Median( "1, 1, 1, 1, 1" ) );
		}

		/// <summary>
		///   Test even number count
		/// </summary>
		[TestMethod]
		public void Problem01TestMethod6()
		{
			var problems = new Problems();
			Assert.AreEqual( 5, problems.Median( "0, 2, 4, 6, 8, 10" ) );
		}

		/// <summary>
		///   Test large numbers
		/// </summary>
		[TestMethod]
		public void Problem01TestMethod7()
		{
			var problems = new Problems();
			Assert.AreEqual( 1147483646, problems.Median( "147483644, 147483645, 1147483647, 2147483647, 1147483646" ) );
		}

		/// <summary>
		///   Test invalid numbers
		/// </summary>
		[TestMethod]
		public void Problem01TestMethod8()
		{
			var problems = new Problems();
			Assert.AreEqual( 147483645, problems.Median( "47483642, 147483644, 47483643, 1147483647, 2147483647, 2147483649, 147483645, 1147483646" ) );
		}

		/// <summary>
		///   Test invalid input
		/// </summary>
		[TestMethod]
		public void Problem01TestMethod9()
		{
			var problems = new Problems();
			Assert.AreEqual( 7, problems.Median( "0, 2, some, 4, 6, 8, 10, 12, 14, word" ) );
		}

	}

}
