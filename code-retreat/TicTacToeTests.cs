using Xunit;

namespace code_retreat;

public class TicTacToeTests
{
    [Fact]
    public void ShouldResetBoard_WhenStartNewGame()
    {
        var game = new TicTacToe();
        
        game.StartNewGame();
        
        Assert.Equal("_________", game.GetBoard());
    }
    
    [Fact]
    public void ShouldPlaceMoveAtLocation_WhenAddMoveToBoardAtLocationCalled()
    {
        var game = new TicTacToe();
        
        game.StartNewGame();
        game.AddMoveToBoard(2, IsX: true);
        
        Assert.Equal((byte)2, byte.Parse(game.GetBoard().Substring(2,1)));
    }
}

public class TicTacToe
{
    private string _board;
    public void StartNewGame()
    {
        _board = "_________";
    }


    public string GetBoard()
    {
        return _board;
    }

    public void AddMoveToBoard(byte location, bool IsX)
    {
        IsX ? _board[location] = 'X' : _board[location] = 'O';
    }
}