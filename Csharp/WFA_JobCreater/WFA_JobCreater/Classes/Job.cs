using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_JobCreater.Classes
{
    class Job
    {
        public Job()
        {

        }
        
        
        public string Employer      { get; set; }
        public string JobType       { get; set; }
        public string City          { get; set; }
        public string District      { get; set; }
        public string Neighbor      { get; set; }
        public string Street        { get; set; }
        public string Pafta         { get; set; }
        public string Block         { get; set; }
        public string Plot          { get; set; }
        public string BuildingType  { get; set; }
        public string BuildingClass { get; set; }
        public int StoriesUpper     { get; set; }
        public int StoriesLower     { get; set; }
        public int Pay              { get; set; }
        public DateTime OTT         { get; set; }
        public DateTime JobInit     { get; set; }

    }
}
