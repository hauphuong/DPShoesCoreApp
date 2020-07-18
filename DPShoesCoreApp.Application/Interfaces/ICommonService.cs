using DPShoesCoreApp.Application.ViewModels.Common;
using System.Collections.Generic;

namespace DPShoesCoreApp.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();

        List<SlideViewModel> GetSlides(string groupAlias);

        SystemConfigViewModel GetSystemConfig(string code);
    }
}