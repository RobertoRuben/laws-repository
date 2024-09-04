namespace EntitiesLayer.Entities
{
    public class Law
    {
        public int CodLaw { set; get; }
        public int CodUser { set; get; }
        public int CodCategory { set; get; }
        public string LawNumber { set; get; }
        public string LawName { set; get; }
        public string LawSummary { set; get; }
        public string PublicationDate { set; get; }
        public int PageNumber { set; get; }
        public string PublicationMedium { set; get; }
        public string PublicationLink { set; get; }
        public string State { set; get; }
        public string PathArchive { set; get; }
    }
}