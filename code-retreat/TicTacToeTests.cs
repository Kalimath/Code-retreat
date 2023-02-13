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
}

public class TicTacToe
{
    public void AllItemsInRowAreEqual()
    {
        HasWinner = true;
    }

    public bool HasWinner { get; set; }
}
