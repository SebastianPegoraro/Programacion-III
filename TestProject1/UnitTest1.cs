using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ScissorsWin()
        {
            Scissors scissors = new Scissors();
            Paper paper = new Paper();

            Assert.True(scissors.isWinner(paper));
        }

        [Fact]
        public void ScissorsLoose()
        {
            Scissors scissors = new Scissors();
            Rock rock = new Rock();

            Assert.False(scissors.isWinner(scissors));
            Assert.False(scissors.isWinner(rock));
        }

        [Fact]
        public void RockWin()
        {
            Rock rock = new Rock();
            Scissors scissors = new Scissors();

            Assert.True(rock.isWinner(scissors));
        }

        [Fact]
        public void RockLoose()
        {
            Paper paper = new Paper();
            Rock rock = new Rock();

            Assert.False(rock.isWinner(paper));
            Assert.False(rock.isWinner(rock));
        }

        [Fact]
        public void PaperWin()
        {
            Rock rock = new Rock();
            Paper paper = new Paper();

            Assert.True(paper.isWinner(rock));
        }

        [Fact]
        public void PaperLoose()
        {
            Scissors scissors = new Scissors();
            Paper paper = new Paper();

            Assert.False(paper.isWinner(scissors));
            Assert.False(paper.isWinner(paper));
        }
    }
}