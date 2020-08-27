using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// student_test class
    /// </summary>
    [MetadataType(typeof(student_testMD))]
    public partial class student_test
    {
    
    	/// <summary>
    	/// student_test Metadata class
    	/// </summary>
    	public class student_testMD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("name", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string name { get; set; }
    
    		    
    		/// <summary>
    		/// student_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("student_id", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string student_id { get; set; }
    
    		    
    		/// <summary>
    		/// city
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("city", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string city { get; set; }
    
    		    
    		/// <summary>
    		/// chinese
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("chinese", typeof(testResource))]
    		public Nullable<int> chinese { get; set; }
    
    		    
    		/// <summary>
    		/// math
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("math", typeof(testResource))]
    		public Nullable<int> math { get; set; }
    
    		    
    	}
    }
    
}
