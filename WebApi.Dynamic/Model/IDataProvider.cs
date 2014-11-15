﻿using System.Collections.Generic;

namespace FluentWebApi.Model
{
    public interface IDataProvider<out T, in TKey>
        where T : class, IApiModel<TKey>
    {
        IEnumerable<T> Get();
        
        T GetByKey(TKey key);
    }
}