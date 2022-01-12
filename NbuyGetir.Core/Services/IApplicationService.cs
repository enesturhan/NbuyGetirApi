using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Services
{/// <summary>
/// Frontend tarafından gelen birw istedigin işlenip frontend tarfına bir sonucun donduuulmesi için yaptıl. Api de ınput model ve view model yerine artık dto terimini kullancağız.
/// 
/// </summary>
/// <typeparam name="TRequest">input model</typeparam>
/// <typeparam name="TResponseDto">view model</typeparam>
    public interface IApplicationService<TRequest,TResponseDto>
    {
        Task<TResponseDto> HandleAsync(TResponseDto dto);


    }
}
