using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Question_D1 class
    /// </summary>
    [MetadataType(typeof(Question_D1MD))]
    public partial class Question_D1
    {
    
    	/// <summary>
    	/// Question_D1 Metadata class
    	/// </summary>
    	public class Question_D1MD
    	{
    		    
    		/// <summary>
    		/// D1_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("D1_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int D1_id { get; set; }
    
    		    
    		/// <summary>
    		/// M_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("M_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int M_id { get; set; }
    
    		    
    		/// <summary>
    		/// D1_title
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("D1_title", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string D1_title { get; set; }
    
    		    
    		/// <summary>
    		/// D1_summary
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("D1_summary", typeof(testResource))]
            [MaxLength(150, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string D1_summary { get; set; }
    
    		    
    		/// <summary>
    		/// D1_type
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("D1_type", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(2, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string D1_type { get; set; }
    
    		    
    		/// <summary>
    		/// D1_must Keyin
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("D1_mustKeyin", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string D1_mustKeyin { get; set; }
    
    		    
    	}
    }
    
}
