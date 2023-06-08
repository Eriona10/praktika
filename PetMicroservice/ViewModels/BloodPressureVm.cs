namespace PetMicroservice.ViewModels
{
    public class BloodPressureVm
    {

        public int PetId { get; set; }
        public string SystolicValue { get; set; } = null!;
        public string DiastolicValue { get; set; } = null!;
        public DateTime? DateMeasured { get; set; }
    }
}
