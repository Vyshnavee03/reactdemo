using System.Collections.Generic;

namespace dotnetdemo.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
