﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplication4.Models;

namespace WebApplication4.Models
{
    public class ChiTietDangKy
    {
        [Required]
        public int MaDK { get; set; }
        public virtual DangKy DangKy { get; set; }

        [Required]
        [StringLength(6)]
        public string MaHP { get; set; }
        public virtual HocPhan HocPhan { get; set; }
    }
}
