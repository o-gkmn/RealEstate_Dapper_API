using RealEstate_Dapper_API.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_API.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        void CreateTestimonial(CreateTestimonialDto createTestimonialDto);
        void DeleteTestimonial(int id);
        void UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto);
        Task<GetTestimonialDto> GetTestimonial(int id);
    }
}
