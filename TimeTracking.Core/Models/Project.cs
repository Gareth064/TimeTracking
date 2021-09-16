using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracking.Core.Models
{
    public class Project
    {
        public Guid Id {  get; set; } = Guid.NewGuid();
        public string Name {  get; set; }
        public string Description {  get; set; }
        public string FinanceCode { get; set; }
        public bool Enabled { get; set; }
    }
}
