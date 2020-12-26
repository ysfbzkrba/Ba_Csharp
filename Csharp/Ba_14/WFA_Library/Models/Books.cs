using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Library.Models
{
    class Books
    {
        public int Id { get; set; }
        public string BName { get; set; }
        public string Auth { get; set; }
        public string Publisher { get; set; }
        public int PubCount { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public double isbn { get; set; }
        public string isbntxt { get; set; }
        public override string ToString()
        {
            return $"{this.BName} - {this.Auth} / book id: {this.Id.ToString()}";
        }
    }
}
