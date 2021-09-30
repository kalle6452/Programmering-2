class Anställd:Person {
    public int Månadslön{get; set;}//set;get; ingen skillnad.

    public Anställd(string namn, string personnr, int lön):base(namn,personnr){
        Månadslön=lön;
    }

    public override string ToString()
    {
        return (base.ToString()+" "+Månadslön);
    }
}