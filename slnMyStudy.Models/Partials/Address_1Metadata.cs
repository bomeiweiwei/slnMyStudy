using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Address_1 class
    /// </summary>
    [MetadataType(typeof(Address_1MD))]
    public partial class Address_1
    {
    
    	/// <summary>
    	/// Address_1 Metadata class
    	/// </summary>
    	public class Address_1MD
    	{
    		    
    		/// <summary>
    		/// a1_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("a1_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int a1_id { get; set; }
    
    		    
    		/// <summary>
    		/// city_name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("city_name", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string city_name { get; set; }
    
    		    
    	}
    }
    
}
