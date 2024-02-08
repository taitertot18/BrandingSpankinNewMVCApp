namespace BrandingSpankinNewMVCApp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    //model for the logic of the calculator page
    public class HomeControllerModel
    {
        public double Hours { get; set; }
        public double HourlyCharge { get; set; }
        public double Total { get; set; }
    }
}
