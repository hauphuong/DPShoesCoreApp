using AutoMapper;
using DPShoesCoreApp.Application.Interfaces;
using DPShoesCoreApp.Application.ViewModels.System;
using DPShoesCoreApp.Data.Entities;
using DPShoesCoreApp.Infrastructure.Interfaces;
using DPShoesCoreApp.Utilities.Dtos;
using System;
using System.Linq;

namespace DPShoesCoreApp.Application.Implementation
{
    public class AnnouncementService : IAnnouncementService
    {
        private IRepository<Announcement, string> _announcementRepository;
        private IRepository<AnnouncementUser, int> _announcementUserRepository;
        private readonly IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        public AnnouncementService(IRepository<Announcement, string> announcementRepository,
            IRepository<AnnouncementUser, int> announcementUserRepository,
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _announcementUserRepository = announcementUserRepository;
            this._announcementRepository = announcementRepository;
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public PagedResult<AnnouncementViewModel> GetAllUnReadPaging(Guid userId, int pageIndex, int pageSize)
        {
            var query = from x in _announcementRepository.FindAll()
                        join y in _announcementUserRepository.FindAll()
                            on x.Id equals y.AnnouncementId
                            into xy
                        from annonUser in xy.DefaultIfEmpty()
                        where annonUser.HasRead == false && (annonUser.UserId == null || annonUser.UserId == userId)
                        select x;
            int totalRow = query.Count();

            var model = _mapper.ProjectTo<AnnouncementViewModel>(
                query.OrderByDescending(x => x.DateCreated)
                .Skip(pageSize * (pageIndex - 1)).Take(pageSize))
                .ToList();

            var paginationSet = new PagedResult<AnnouncementViewModel>
            {
                Results = model,
                CurrentPage = pageIndex,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public bool MarkAsRead(Guid userId, string id)
        {
            bool result = false;
            var announ = _announcementUserRepository.FindSingle(x => x.AnnouncementId == id
                                                                               && x.UserId == userId);
            if (announ == null)
            {
                _announcementUserRepository.Add(new AnnouncementUser
                {
                    AnnouncementId = id,
                    UserId = userId,
                    HasRead = true
                });
                result = true;
            }
            else
            {
                if (announ.HasRead == false)
                {
                    announ.HasRead = true;
                    result = true;
                }
            }
            return result;
        }
    }
}