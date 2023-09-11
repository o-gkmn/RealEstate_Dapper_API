namespace RealEstate_Dapper_API.Dtos.TestimonialDtos
{
    public class GetTestimonialDto
    {
        public int TestimonialID { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }
    }
}
