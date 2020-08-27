using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// test_ad class
    /// </summary>
    [MetadataType(typeof(test_adMD))]
    public partial class test_ad
    {
    
    	/// <summary>
    	/// test_ad Metadata class
    	/// </summary>
    	public class test_adMD
    	{
    		    
    		/// <summary>
    		/// ad_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ad_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int ad_id { get; set; }
    
    		    
    		/// <summary>
    		/// ad_time_start
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ad_time_start", typeof(testResource))]
    		public Nullable<System.DateTime> ad_time_start { get; set; }
    
    		    
    		/// <summary>
    		/// ad_time_end
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ad_time_end", typeof(testResource))]
    		public Nullable<System.DateTime> ad_time_end { get; set; }
    
    		    
    		/// <summary>
    		/// ad_images
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ad_images", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string ad_images { get; set; }
    
    		    
    		/// <summary>
    		/// ad_url
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("ad_url", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string ad_url { get; set; }
    
    		    
    	}
    }
    
}
