using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Drink_Order_M class
    /// </summary>
    [MetadataType(typeof(Drink_Order_MMD))]
    public partial class Drink_Order_M
    {
    
    	/// <summary>
    	/// Drink_Order_M Metadata class
    	/// </summary>
    	public class Drink_Order_MMD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// order_time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("order_time", typeof(testResource))]
    		public Nullable<System.DateTime> order_time { get; set; }
    
    		    
    		/// <summary>
    		/// user_name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("user_name", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string user_name { get; set; }
    
    		    
    		/// <summary>
    		/// user_phone
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("user_phone", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string user_phone { get; set; }
    
    		    
    		/// <summary>
    		/// memo
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("memo", typeof(testResource))]
            [MaxLength(150, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string memo { get; set; }
    
    		    
    		/// <summary>
    		/// have_paid
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("have_paid", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string have_paid { get; set; }
    
    		    
    	}
    }
    
}
