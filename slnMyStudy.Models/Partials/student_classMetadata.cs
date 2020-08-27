using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// student_class class
    /// </summary>
    [MetadataType(typeof(student_classMD))]
    public partial class student_class
    {
    
    	/// <summary>
    	/// student_class Metadata class
    	/// </summary>
    	public class student_classMD
    	{
    		    
    		/// <summary>
    		/// student_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("student_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string student_id { get; set; }
    
    		    
    		/// <summary>
    		/// sd_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("sd_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int sd_id { get; set; }
    
    		    
    		/// <summary>
    		/// student_year
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("student_year", typeof(testResource))]
    		public Nullable<int> student_year { get; set; }
    
    		    
    		/// <summary>
    		/// student_class1
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("student_class1", typeof(testResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string student_class1 { get; set; }
    
    		    
    	}
    }
    
}
