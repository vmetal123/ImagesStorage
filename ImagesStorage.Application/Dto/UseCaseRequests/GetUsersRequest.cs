using ImagesStorage.Application.Dto.UseCaseResponses;
using ImagesStorage.Application.Interfaces;

namespace ImagesStorage.Application.Dto.UseCaseRequests
{
    public class GetUsersRequest: IUseCaseRequest<GetUsersResponse>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string SearchTerm { get; set; } = null;

        public GetUsersRequest(int pageNumber, int pageSize, string searchTerm)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            SearchTerm = searchTerm;
        }
    }
}
