using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Question_M class
    /// </summary>
    [MetadataType(typeof(Question_MMD))]
    public partial class Question_M
    {
    
    	/// <summary>
    	/// Question_M Metadata class
    	/// </summary>
    	public class Question_MMD
    	{
    		    
    		/// <summary>
    		/// M_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("M_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int M_id { get; set; }
    
    		    
    		/// <summary>
    		/// M_title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("M_title", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(150, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string M_title { get; set; }
    
    		    
    		/// <summary>
    		/// start_time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("start_time", typeof(testResource))]
    		public Nullable<System.DateTime> start_time { get; set; }
    
    		    
    		/// <summary>
    		/// end_time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("end_time", typeof(testResource))]
    		public Nullable<System.DateTime> end_time { get; set; }
    
    		    
    		/// <summary>
    		/// M_summary
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("M_summary", typeof(testResource))]
            [MaxLength(250, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string M_summary { get; set; }
    
    		    
    		/// <summary>
    		/// M_enable
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("M_enable", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string M_enable { get; set; }
    
    		    
    	}
    }
    
}
