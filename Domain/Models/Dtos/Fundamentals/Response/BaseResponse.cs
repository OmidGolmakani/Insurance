﻿namespace  Domain.Models.Dtos.Fundamentals.Response
{
    public class BaseResponse<TIdentity>
    {
        public virtual TIdentity Id { get; set; }
    }
}