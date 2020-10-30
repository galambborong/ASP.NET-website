using System;
using System.Text.Json;

namespace PeterKeenan.Models
{
    public class EngravingWork
    {
        public string WorkTitle { get; set; }
        public string Composer { get; set; }
        public string Description { get; set; }
        public string Software { get; set; }
        public string For { get; set; }

        public override string ToString() => JsonSerializer.Serialize<EngravingWork>(this);
    }
}
