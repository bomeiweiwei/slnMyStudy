using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Calendar_Schedule class
    /// </summary>
    [MetadataType(typeof(Calendar_ScheduleMD))]
    public partial class Calendar_Schedule
    {
    
    	/// <summary>
    	/// Calendar_Schedule Metadata class
    	/// </summary>
    	public class Calendar_ScheduleMD
    	{
    		    
    		/// <summary>
    		/// CS_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CS_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int CS_id { get; set; }
    
    		    
    		/// <summary>
    		/// CS_time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CS_time", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public System.DateTime CS_time { get; set; }
    
    		    
    		/// <summary>
    		/// CS_title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CS_title", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string CS_title { get; set; }
    
    		    
    		/// <summary>
    		/// CS_summary
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("CS_summary", typeof(testResource))]
            [MaxLength(250, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string CS_summary { get; set; }
    
    		    
    	}
    }
    
}
