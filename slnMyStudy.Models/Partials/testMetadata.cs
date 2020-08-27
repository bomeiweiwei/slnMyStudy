using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// test class
    /// </summary>
    [MetadataType(typeof(testMD))]
    public partial class test
    {
    
    	/// <summary>
    	/// test Metadata class
    	/// </summary>
    	public class testMD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// test_time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_time", typeof(testResource))]
    		public Nullable<System.DateTime> test_time { get; set; }
    
    		    
    		/// <summary>
    		/// @class
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("class", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string @class { get; set; }
    
    		    
    		/// <summary>
    		/// title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("title", typeof(testResource))]
            [MaxLength(120, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string title { get; set; }
    
    		    
    		/// <summary>
    		/// summary
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("summary", typeof(testResource))]
            [MaxLength(200, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string summary { get; set; }
    
    		    
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
    		/// hit_no
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("hit_no", typeof(testResource))]
    		public Nullable<int> hit_no { get; set; }
    
    		    
    		/// <summary>
    		/// get_no
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("get_no", typeof(testResource))]
    		public Nullable<int> get_no { get; set; }
    
    		    
    		/// <summary>
    		/// email_no
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("email_no", typeof(testResource))]
    		public Nullable<int> email_no { get; set; }
    
    		    
    		/// <summary>
    		/// approved
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("approved", typeof(testResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string approved { get; set; }
    
    		    
    	}
    }
    
}
