﻿namespace ShaderGen
{
    public class RWStructuredBuffer<T> where T : struct
    {
        public T this[int index]
        {
            get => throw new ShaderBuiltinException();
            set => throw new ShaderBuiltinException();
        }
    }
}
