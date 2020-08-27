using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// test_talk class
    /// </summary>
    [MetadataType(typeof(test_talkMD))]
    public partial class test_talk
    {
    
    	/// <summary>
    	/// test_talk Metadata class
    	/// </summary>
    	public class test_talkMD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// test_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int test_id { get; set; }
    
    		    
    		/// <summary>
    		/// test_time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_time", typeof(testResource))]
    		public Nullable<System.DateTime> test_time { get; set; }
    
    		    
    		/// <summary>
    		/// article
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("article", typeof(testResource))]
    		public string article { get; set; }
    
    		    
    		/// <summary>
    		/// author
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("author", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string author { get; set; }
    
    		    
    		/// <summary>
    		/// email
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("email", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string email { get; set; }
    
    		    
    	}
    }
    
}
