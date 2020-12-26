namespace WCA_Abstract_12.Models
{
    public sealed class Gitar : Enstruman 
    {
        public string Pena { get; set; }
        public string Tel { get; set; }

        public override string Sound() => "gitar sesi";
    }

}
