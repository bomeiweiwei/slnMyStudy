using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// News_Test class
    /// </summary>
    [MetadataType(typeof(News_TestMD))]
    public partial class News_Test
    {
    
    	/// <summary>
    	/// News_Test Metadata class
    	/// </summary>
    	public class News_TestMD
    	{
    		    
    		/// <summary>
    		/// test_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int test_id { get; set; }
    
    		    
    		/// <summary>
    		/// test_guid
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_guid", typeof(testResource))]
    		public Nullable<System.Guid> test_guid { get; set; }
    
    		    
    		/// <summary>
    		/// test_time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_time", typeof(testResource))]
    		public Nullable<System.DateTime> test_time { get; set; }
    
    		    
    		/// <summary>
    		/// test_class
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_class", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string test_class { get; set; }
    
    		    
    		/// <summary>
    		/// title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("title", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string title { get; set; }
    
    		    
    		/// <summary>
    		/// summary
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("summary", typeof(testResource))]
            [MaxLength(250, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
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
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int hit_no { get; set; }
    
    		    
    		/// <summary>
    		/// get_no
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("get_no", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int get_no { get; set; }
    
    		    
    		/// <summary>
    		/// email_no
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("email_no", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int email_no { get; set; }
    
    		    
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
