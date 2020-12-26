namespace WCA_Abstract_12.Models
{
    public sealed class Bateri : Enstruman 
    {
        public string Deri { get; set; }

        public override string Sound() => "ba dum tss!";
    }

}
