using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Address_2 class
    /// </summary>
    [MetadataType(typeof(Address_2MD))]
    public partial class Address_2
    {
    
    	/// <summary>
    	/// Address_2 Metadata class
    	/// </summary>
    	public class Address_2MD
    	{
    		    
    		/// <summary>
    		/// a2_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("a2_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int a2_id { get; set; }
    
    		    
    		/// <summary>
    		/// city_name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("city_name", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string city_name { get; set; }
    
    		    
    		/// <summary>
    		/// district_name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("district_name", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string district_name { get; set; }
    
    		    
    		/// <summary>
    		/// a1_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("a1_id", typeof(testResource))]
    		public Nullable<int> a1_id { get; set; }
    
    		    
    	}
    }
    
}
