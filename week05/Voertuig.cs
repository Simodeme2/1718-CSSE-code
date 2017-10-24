public class Voertuig{

    string merk;

    string model;


    public Voertuig(string merk, aantalBanden)
    {
        this.aantalBanden = 0;
        this.merk = merk;
    }

    public string Merk { get => merk; set => merk = value; }
    public string Model { get => model; set => model = value; }
    
}