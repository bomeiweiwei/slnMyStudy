using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Vote_2 class
    /// </summary>
    [MetadataType(typeof(Vote_2MD))]
    public partial class Vote_2
    {
    
    	/// <summary>
    	/// Vote_2 Metadata class
    	/// </summary>
    	public class Vote_2MD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// vote_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_id", typeof(testResource))]
    		public Nullable<int> vote_id { get; set; }
    
    		    
    		/// <summary>
    		/// vote_date
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_date", typeof(testResource))]
    		public Nullable<System.DateTime> vote_date { get; set; }
    
    		    
    		/// <summary>
    		/// vote_to
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_to", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string vote_to { get; set; }
    
    		    
    		/// <summary>
    		/// vote_ip
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_ip", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string vote_ip { get; set; }
    
    		    
    	}
    }
    
}
