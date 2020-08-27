using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// student_department class
    /// </summary>
    [MetadataType(typeof(student_departmentMD))]
    public partial class student_department
    {
    
    	/// <summary>
    	/// student_department Metadata class
    	/// </summary>
    	public class student_departmentMD
    	{
    		    
    		/// <summary>
    		/// sd_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("sd_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int sd_id { get; set; }
    
    		    
    		/// <summary>
    		/// student_department1
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("student_department1", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string student_department1 { get; set; }
    
    		    
    		/// <summary>
    		/// department_leader
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("department_leader", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string department_leader { get; set; }
    
    		    
    	}
    }
    
}
