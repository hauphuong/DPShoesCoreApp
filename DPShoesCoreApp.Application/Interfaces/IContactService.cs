﻿using DPShoesCoreApp.Application.ViewModels.Common;
using DPShoesCoreApp.Utilities.Dtos;
using System.Collections.Generic;

namespace DPShoesCoreApp.Application.Interfaces
{
    public interface IContactService
    {
        void Add(ContactViewModel contactVm);

        void Update(ContactViewModel contactVm);

        void Delete(string id);

        List<ContactViewModel> GetAll();

        PagedResult<ContactViewModel> GetAllPaging(string keyword, int page, int pageSize);

        ContactViewModel GetById(string id);

        void SaveChanges();
    }
}