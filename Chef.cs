class Chef:Anställd {
public int rank {get;set;}
    public Chef(string namn, string personnr, int lön):base(namn,personnr,lön){
        
    }

    public override string ToString()
    {
        return (base.ToString()+" "+Månadslön);
    }
}
