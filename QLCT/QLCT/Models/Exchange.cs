using Newtonsoft.Json;
using QLCT.Models;
using System;

namespace QLCT 
{
    public class Exchange 
    {
        public string _id { get; set; }
        public bool tienMat {get; set;}

        public string loaiTraoDoi {get;set;}

        public string chiTiet {get;set;}

        public string soTienGiaoDich {get; set;}
        
    }
}