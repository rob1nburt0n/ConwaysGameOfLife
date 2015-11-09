using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;

namespace ConwaysGameOfLifeTest

//Any live cell with fewer than two live neighbors dies, as if caused by under-population.
//Any live cell with two or three live neighbors lives on to the next generation.
//Any live cell with more than three live neighbors dies, as if by overcrowding.
//Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
{
    [TestClass]
    public class ConwaysTest
    {
        [TestMethod]
        public void StillLife1()
        {
            bool[,] stillLife = new bool[,] { { true, true }, { true, true } };
            Grid board = new Grid(stillLife);
            board.Tick();
            CollectionAssert.AreEqual(stillLife, board.getBoard());
        }

        [TestMethod]
        public void OscillatorTest()
        {
            bool[,] oscillator = new bool[,] { { false, false, false }, { true, true, true }, { false, false, false } };
            Grid board = new Grid(oscillator);
            board.Tick();
            bool[,] expected = new bool[,] { { false, true, false }, { false, true, false }, { false, true, false } };
            CollectionAssert.AreEqual(expected, board.getBoard());
        }
    }
}
