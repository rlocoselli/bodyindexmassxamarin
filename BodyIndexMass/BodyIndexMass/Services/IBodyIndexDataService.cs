using BodyIndexMass.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BodyIndexMass.Services
{
    interface IBodyIndexDataService
    {
        Task<List<BodyIndexMassEntity>> GetBodyAsync();
        Task<int> SaveBodyAsync(BodyIndexMassEntity body);
        Task<int> DeleteNoteAsync(BodyIndexMassEntity body);
    }
}
