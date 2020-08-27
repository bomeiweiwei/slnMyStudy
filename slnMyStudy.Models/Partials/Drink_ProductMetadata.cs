using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Drink_Product class
    /// </summary>
    [MetadataType(typeof(Drink_ProductMD))]
    public partial class Drink_Product
    {
    
    	/// <summary>
    	/// Drink_Product Metadata class
    	/// </summary>
    	public class Drink_ProductMD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// drink_class
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("drink_class", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string drink_class { get; set; }
    
    		    
    		/// <summary>
    		/// drink_name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("drink_name", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string drink_name { get; set; }
    
    		    
    		/// <summary>
    		/// drink_price
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("drink_price", typeof(testResource))]
    		public Nullable<int> drink_price { get; set; }
    
    		    
    		/// <summary>
    		/// drink_cost
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("drink_cost", typeof(testResource))]
    		public Nullable<int> drink_cost { get; set; }
    
    		    
    	}
    }
    
}
