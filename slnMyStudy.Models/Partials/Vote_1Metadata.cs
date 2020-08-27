using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Vote_1 class
    /// </summary>
    [MetadataType(typeof(Vote_1MD))]
    public partial class Vote_1
    {
    
    	/// <summary>
    	/// Vote_1 Metadata class
    	/// </summary>
    	public class Vote_1MD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// vote_11
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_11", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int vote_11 { get; set; }
    
    		    
    		/// <summary>
    		/// vote_2
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_2", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int vote_2 { get; set; }
    
    		    
    		/// <summary>
    		/// vote_3
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_3", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int vote_3 { get; set; }
    
    		    
    		/// <summary>
    		/// vote_4
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_4", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int vote_4 { get; set; }
    
    		    
    		/// <summary>
    		/// vote_5
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_5", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int vote_5 { get; set; }
    
    		    
    		/// <summary>
    		/// vote_6
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("vote_6", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int vote_6 { get; set; }
    
    		    
    	}
    }
    
}
