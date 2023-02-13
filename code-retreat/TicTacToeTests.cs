using Xunit;

namespace code_retreat;

public class TicTacToeTests
{
    [Fact]
    public void WhenWeStartAGame_TheBoardShouldBeEmpty()
    {
        var newGame = new TicTacToe();

        newGame.Start();

        Assert.Equal(BoardFactory.Create(),newGame.GetBoard());
    }
}

public class TicTacToe
{
    private char[][] Board { get; set; }

    public void Start() => Board = BoardFactory.Create();

    public char[][] GetBoard()
    {
        return Board;
    }
}

public static class BoardFactory
{
    public static char[][] Create()
    {
        return new[] { new char[3], new char[3], new char[3] };
    }
}