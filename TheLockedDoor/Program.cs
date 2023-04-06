// See https://aka.ms/new-console-template for more information

Door myDoor = new Door(State.open, 123);
myDoor.newPassword(123, 3030);
myDoor.newPassword(3030, 2020);

class Door
{
    private State _status;
    private int _password;

    public Door(State status, int password)
    {
        this._status = status;
        this._password = password;
    }

    public State ChangeStatus
    {
        get => this._status;
        set => this._status = value;
    }

    public int ChangePassword
    {
        get => this._password;
        set => this._password = value;
    }
    
    public State isUnlocked()
    {
        return this._status = State.locked;
    }

    public State IsLocked()
    {
        return this._status = State.open;
    }

    public State isOpen()
    {
        return this._status = State.closed;
    }

    public State isClosed()
    {
        return this._status = State.unlocked;
    }

    public void newPassword(int currentPassword, int password)
    {
        if(password > 1 && currentPassword == this._password)
        {
            this._password = password;
            Console.WriteLine($"New Password has been set {this._password}");
        }
        else
        {
            Console.WriteLine($"Current password es: {this._password}");
            Console.WriteLine("Current Password is Wrong");
            
        }

    }

    
}

enum State
{
    unlocked,
    locked,
    open,
    closed
}
