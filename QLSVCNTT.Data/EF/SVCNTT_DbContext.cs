using Microsoft.EntityFrameworkCore;
using QLSVCNTT.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLSVCNTT.Data.EF
{
    public class SVCNTT_DbContext : DbContext
    {
        public SVCNTT_DbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
    }
}
