using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class InspectionTypes
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string InspectionName { get; set; } = string.Empty;
    }
}