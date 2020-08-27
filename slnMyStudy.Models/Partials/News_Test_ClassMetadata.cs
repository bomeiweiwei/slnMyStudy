using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// News_Test_Class class
    /// </summary>
    [MetadataType(typeof(News_Test_ClassMD))]
    public partial class News_Test_Class
    {
    
    	/// <summary>
    	/// News_Test_Class Metadata class
    	/// </summary>
    	public class News_Test_ClassMD
    	{
    		    
    		/// <summary>
    		/// Test_ Class_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Test_Class_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int Test_Class_id { get; set; }
    
    		    
    		/// <summary>
    		/// test_class
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_class", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string test_class { get; set; }
    
    		    
    		/// <summary>
    		/// test_class_1
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_class_1", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string test_class_1 { get; set; }
    
    		    
    		/// <summary>
    		/// test_class_2
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_class_2", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string test_class_2 { get; set; }
    
    		    
    	}
    }
    
}
