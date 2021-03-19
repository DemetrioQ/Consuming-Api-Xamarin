using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingApiWithXamarin.Services
{
    public interface IAlertService
    {
        Task DisplayAlertAsync(string title, string description);
    }
}
