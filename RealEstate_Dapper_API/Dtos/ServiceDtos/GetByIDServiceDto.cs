﻿namespace RealEstate_Dapper_UI.Dtos.ServiceDtos
{
    public class GetByIDServiceDto
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public bool ServiceStatus { get; set; }
    }
}
