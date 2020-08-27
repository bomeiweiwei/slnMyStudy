using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Drink_Order_D class
    /// </summary>
    [MetadataType(typeof(Drink_Order_DMD))]
    public partial class Drink_Order_D
    {
    
    	/// <summary>
    	/// Drink_Order_D Metadata class
    	/// </summary>
    	public class Drink_Order_DMD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// order_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("order_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int order_id { get; set; }
    
    		    
    		/// <summary>
    		/// drink_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("drink_id", typeof(testResource))]
    		public Nullable<int> drink_id { get; set; }
    
    		    
    		/// <summary>
    		/// drink_name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("drink_name", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string drink_name { get; set; }
    
    		    
    		/// <summary>
    		/// ice_degree
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ice_degree", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string ice_degree { get; set; }
    
    		    
    		/// <summary>
    		/// sweet_degree
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("sweet_degree", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string sweet_degree { get; set; }
    
    		    
    		/// <summary>
    		/// drink_no
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("drink_no", typeof(testResource))]
    		public Nullable<int> drink_no { get; set; }
    
    		    
    		/// <summary>
    		/// meno
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("meno", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string meno { get; set; }
    
    		    
    		/// <summary>
    		/// approved
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("approved", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string approved { get; set; }
    
    		    
    	}
    }
    
}
