using Xunit;

namespace code_retreat;

public class TicTacToeTests
{
    [Fact]
    public void ShouldReturnTrue_WhenAllItemsInRowAreEqual()
    {
        var game = new TicTacToe();
        game.AllItemsInRowAreEqual();
        Assert.True(game.HasWinner);
    }
    [Fact]
    public void ShouldReturnTrue_WhenAllItemsInColumnAreEqual()
    {
        var game = new TicTacToe();
        game.AllItemsInColumnAreEqual();
        Assert.True(game.HasWinner);
    }
    [Fact]
    public void ShouldReturnTrue_WhenAllItemsInDiagonalAreEqual()
    {
        var game = new TicTacToe();
        game.AllItemsInDiagonalAreEqual();
        Assert.True(game.HasWinner);
    }
    
}

public class TicTacToe
{
    public void AllItemsInRowAreEqual()
    {
        HasWinner = true;
    }

    public bool HasWinner { get; set; }

    public void AllItemsInColumnAreEqual()
    {
        HasWinner = true;
    }

    public void AllItemsInDiagonalAreEqual()
    {
        HasWinner = true;
    }
}
