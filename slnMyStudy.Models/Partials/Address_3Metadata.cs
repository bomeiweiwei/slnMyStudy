using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Address_3 class
    /// </summary>
    [MetadataType(typeof(Address_3MD))]
    public partial class Address_3
    {
    
    	/// <summary>
    	/// Address_3 Metadata class
    	/// </summary>
    	public class Address_3MD
    	{
    		    
    		/// <summary>
    		/// a3_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("a3_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int a3_id { get; set; }
    
    		    
    		/// <summary>
    		/// a1_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("a1_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int a1_id { get; set; }
    
    		    
    		/// <summary>
    		/// a2_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("a2_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int a2_id { get; set; }
    
    		    
    		/// <summary>
    		/// street_name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("street_name", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string street_name { get; set; }
    
    		    
    	}
    }
    
}
