using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IDataAccessRoom
    {
        void CreateDataBase(string database);
        void InsertRoom<T>(string collection, T room );
    }
}
