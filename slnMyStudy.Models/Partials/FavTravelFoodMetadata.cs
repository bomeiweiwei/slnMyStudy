using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// FavTravelFood class
    /// </summary>
    [MetadataType(typeof(FavTravelFoodMD))]
    public partial class FavTravelFood
    {
    
    	/// <summary>
    	/// FavTravelFood Metadata class
    	/// </summary>
    	public class FavTravelFoodMD
    	{
    		    
    		/// <summary>
    		/// ID
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ID", typeof(WebAPIResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string ID { get; set; }
    
    		    
    		/// <summary>
    		/// Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Name", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string Name { get; set; }
    
    		    
    		/// <summary>
    		/// Address
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Address", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string Address { get; set; }
    
    		    
    		/// <summary>
    		/// Tel
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Tel", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string Tel { get; set; }
    
    		    
    		/// <summary>
    		/// Host Words
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("HostWords", typeof(WebAPIResource))]
            [MaxLength(200, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string HostWords { get; set; }
    
    		    
    		/// <summary>
    		/// Price
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Price", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string Price { get; set; }
    
    		    
    		/// <summary>
    		/// Open Hours
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("OpenHours", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string OpenHours { get; set; }
    
    		    
    		/// <summary>
    		/// Credit Card
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CreditCard", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string CreditCard { get; set; }
    
    		    
    		/// <summary>
    		/// Travel Card
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("TravelCard", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string TravelCard { get; set; }
    
    		    
    		/// <summary>
    		/// Traffic Guidelines
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("TrafficGuidelines", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string TrafficGuidelines { get; set; }
    
    		    
    		/// <summary>
    		/// Parking Lot
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ParkingLot", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string ParkingLot { get; set; }
    
    		    
    		/// <summary>
    		/// Url
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Url", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string Url { get; set; }
    
    		    
    		/// <summary>
    		/// Email
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Email", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string Email { get; set; }
    
    		    
    		/// <summary>
    		/// Blog Url
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("BlogUrl", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string BlogUrl { get; set; }
    
    		    
    		/// <summary>
    		/// Pet Notice
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("PetNotice", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string PetNotice { get; set; }
    
    		    
    		/// <summary>
    		/// Reminder
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Reminder", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string Reminder { get; set; }
    
    		    
    		/// <summary>
    		/// Food Months
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("FoodMonths", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string FoodMonths { get; set; }
    
    		    
    		/// <summary>
    		/// Food Capacity
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("FoodCapacity", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string FoodCapacity { get; set; }
    
    		    
    		/// <summary>
    		/// Food Feature
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("FoodFeature", typeof(WebAPIResource))]
    		public string FoodFeature { get; set; }
    
    		    
    		/// <summary>
    		/// City
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("City", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string City { get; set; }
    
    		    
    		/// <summary>
    		/// Town
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Town", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string Town { get; set; }
    
    		    
    		/// <summary>
    		/// Coordinate
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Coordinate", typeof(WebAPIResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string Coordinate { get; set; }
    
    		    
    		/// <summary>
    		/// Pic URL
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("PicURL", typeof(WebAPIResource))]
            [MaxLength(100, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string PicURL { get; set; }
    
    		    
    	}
    }
    
}
