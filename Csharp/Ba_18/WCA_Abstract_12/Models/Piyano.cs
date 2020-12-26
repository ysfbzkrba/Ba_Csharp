namespace WCA_Abstract_12.Models
{
    public sealed class Piyano : Enstruman
    {
        public string TusTakimi { get; set; }
        public string Tel { get; internal set; }

        public override string Sound() => "dındın dındun";
    }

}
