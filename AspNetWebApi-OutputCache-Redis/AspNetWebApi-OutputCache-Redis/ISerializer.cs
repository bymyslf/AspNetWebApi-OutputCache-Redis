﻿namespace WebApi.OutputCache.Core.Cache.Redis
{
    public interface ISerializer
    {
        string Serialize<T>(T value);

        T Deserialize<T>(string objectString);
    }
}