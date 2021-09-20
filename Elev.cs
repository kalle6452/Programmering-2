class Elev:Person {//: betyder arv
   public int Antagningsår{set;get;}
   public string Utbildningsprogram{set;get;}
   public Elev(string personnr, string namn, int år, string prog):base(personnr, namn) {
       Antagningsår=år;
       Utbildningsprogram=prog;
   }
   public override string ToString() {
string output=base.ToString();
output+=" "+Antagningsår+" "+Utbildningsprogram;
return output;
}
}