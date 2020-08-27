using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// test_only class
    /// </summary>
    [MetadataType(typeof(test_onlyMD))]
    public partial class test_only
    {
    
    	/// <summary>
    	/// test_only Metadata class
    	/// </summary>
    	public class test_onlyMD
    	{
    		    
    		/// <summary>
    		/// test_no
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_no", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int test_no { get; set; }
    
    		    
    		/// <summary>
    		/// test_title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_title", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string test_title { get; set; }
    
    		    
    		/// <summary>
    		/// test_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public long test_id { get; set; }
    
    		    
    	}
    }
    
}
