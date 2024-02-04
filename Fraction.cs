namespace OverloadIndexerExtensionMehods;

struct Fraction
{
    private char _hamarich;
    public char Hamarich
    {
        get => _hamarich;

        set
        {
            _hamarich = value;
        }
    }

    private char _haytarar;
    public char Haytarar
    {
        get => _haytarar;

        set
        {
            if (_haytarar > 0)
            {
                _haytarar = value;
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }

    }

    public Fraction(char _hamarich,char _haytarar)
    {
       this.Haytarar = _haytarar;
        this.Hamarich = _hamarich;
    }
}
