using System;

namespace EntitiesLayer.DTOs
{
    public class LawDTO
    {
        public int  CodLaw { get; set; }
        public string LawNumber { get; set; }
        public string LawName { get; set; }
        public string LawCategory { get; set; }
        public string LawSummary { get; set; }
        public DateTime PublicationDate { get; set; }
        public int PageNumber { get; set; }
        public string PublicationMedium { get; set; }
        public string PublicationLink { get; set; }
        public string LawState { get; set; }
        public string PathDocument { get; set; }
        
    }
}