using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// test_class class
    /// </summary>
    [MetadataType(typeof(test_classMD))]
    public partial class test_class
    {
    
    	/// <summary>
    	/// test_class Metadata class
    	/// </summary>
    	public class test_classMD
    	{
    		    
    		/// <summary>
    		/// test_class_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_class_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int test_class_id { get; set; }
    
    		    
    		/// <summary>
    		/// test_class1
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_class1", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string test_class1 { get; set; }
    
    		    
    		/// <summary>
    		/// test_class11
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_class11", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string test_class11 { get; set; }
    
    		    
    		/// <summary>
    		/// test_class2
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_class2", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string test_class2 { get; set; }
    
    		    
    	}
    }
    
}
