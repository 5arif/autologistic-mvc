using System;

namespace AutoLogistic.Models.History
{
    public class RowHistory
    {
        public bool     IsDelete    { get; set; }
        public DateTime CreateDate  { get; set; }
        public DateTime DeleteDate  { get; set; }
        public DateTime ModifyDate  { get; set; }
        public int      ModifyCount { get; set; }
        public string   ModifyBy    { get; set; }
    }
}
