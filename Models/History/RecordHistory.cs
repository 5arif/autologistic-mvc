using System;
using System.ComponentModel.DataAnnotations;

namespace AutoLogistic.Models.History
{
    public class RecordHistory
    {
        [Key]
        public Guid RecordHistoryId { get; set; }
        public Guid RecordId        { get; set; }
        public string OriginalData  { get; set; }
    }
}
