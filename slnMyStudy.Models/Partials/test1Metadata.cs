using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// test1 class
    /// </summary>
    [MetadataType(typeof(test1MD))]
    public partial class test1
    {
    
    	/// <summary>
    	/// test1 Metadata class
    	/// </summary>
    	public class test1MD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// test
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string test { get; set; }
    
    		    
    		/// <summary>
    		/// time_st
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("time_st", typeof(testResource))]
            [MaxLength(8, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public byte[] time_st { get; set; }
    
    		    
    	}
    }
    
}
