namespace Matador_in_WPF.model;

public class Player
{
    private string _name;
    private int _playerNumber;
    private int _walletAmount;
    private int _position;
    private int _currentRoll;
    private bool _inJail;

    private Player(string name, int playerNumber, int walletAmount, int position, bool inJail, int currentRoll)
    {
        this._name = name;
        this._playerNumber = playerNumber;
        this._walletAmount = walletAmount;
        this._position = position;
        this._inJail = inJail;
        this._currentRoll = currentRoll;
    }
    
    
}