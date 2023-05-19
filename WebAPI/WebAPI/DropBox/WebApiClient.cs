using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DropBox
{
    public interface IWebApiClient
    {
        HttpResponseMessage Upload(string filePath, string dropBoxPath);
        HttpResponseMessage GetMetaData(string dropBoxPath);
        HttpResponseMessage Delete(string dropBoxPath);
        bool IfExist(string dropBoxFolder, string fileName);
    }
}
