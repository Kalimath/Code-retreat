using Xunit;

namespace code_retreat;

public class TicTacToeTests
{
    [Fact]
    public void x()
    {
        var game = new TicTacToe();
        game.AllItemsInRowAreEquasl();
        Assert.True(game.HasWinner);
    }
}

public class TicTacToe
{
    public void AllItemsInRowAreEquasl()
    {
        HasWinner = true;
    }

    public bool HasWinner { get; set; }
}
