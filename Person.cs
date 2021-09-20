abstract class Person {
    public string Namn {set; get;}
    public string Personnr{set; get;}
public Person(string namn, string personnr) {
    Namn=namn;
    Personnr=personnr;
}

public override string ToString() {
    string output="";
    output+=Namn+" "+Personnr;
    return output;
}

}