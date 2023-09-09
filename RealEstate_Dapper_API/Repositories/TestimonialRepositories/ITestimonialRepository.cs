using RealEstate_Dapper_UI.Dtos.TestimonialDtos;
using RealEstate_Dapper_UI.Dtos.WhoWeAreDtos;

namespace RealEstate_Dapper_UI.Repositories.TestimonialRepositories
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
