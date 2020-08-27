using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// News_Test_Talk class
    /// </summary>
    [MetadataType(typeof(News_Test_TalkMD))]
    public partial class News_Test_Talk
    {
    
    	/// <summary>
    	/// News_Test_Talk Metadata class
    	/// </summary>
    	public class News_Test_TalkMD
    	{
    		    
    		/// <summary>
    		/// test_talk_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_talk_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int test_talk_id { get; set; }
    
    		    
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
            [MaxLength(250, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
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
