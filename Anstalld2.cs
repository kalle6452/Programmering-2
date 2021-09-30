class Anstalld1
{
    private string namn;
    private string personnr;
    private int manadslon;

    public string Namn
    {
        get
        {
            return namn;
        }
        set
        {
            namn = value;
        }
    }

    public string Personnr
    {
        get
        {
            return personnr;
        }
        set
        {
            personnr = value;
        }
    }

    public int Manadslon
    {
        get
        {
            return manadslon;
        }
        set
        {
            if (value < 0)
            {
                manadslon = 0;
            }
            else
            {
                manadslon = value;
            }
        }
    }

    public override string ToString()
    {
        return
        "\b Namn: " + namn +
        "\b Personnummer: " + personnr +
        "\b Månadslön: " + manadslon;
    }

    public Anstalld1(string newNamn, string newPersonnr, int newmanadslon)
    {
        Namn = newNamn;
        Personnr = newPersonnr;
        Manadslon = newmanadslon;
    }

    public Anstalld1()
    {
    }
}