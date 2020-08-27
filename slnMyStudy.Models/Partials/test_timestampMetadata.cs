using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// test_timestamp class
    /// </summary>
    [MetadataType(typeof(test_timestampMD))]
    public partial class test_timestamp
    {
    
    	/// <summary>
    	/// test_timestamp Metadata class
    	/// </summary>
    	public class test_timestampMD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("title", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string title { get; set; }
    
    		    
    		/// <summary>
    		/// test_time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_time", typeof(testResource))]
    		public Nullable<System.DateTime> test_time { get; set; }
    
    		    
    		/// <summary>
    		/// test_ TS
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_TS", typeof(testResource))]
            [MaxLength(8, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public byte[] test_TS { get; set; }
    
    		    
    	}
    }
    
}
