namespace WCA_Abstract_12.Models
{
    public sealed class Keman : Enstruman 
    {
        public string Tel { get; set; }
        public string Arse { get; set; }

        public override string Sound() => "gıy gıy";
    }

}
