using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// Member class
    /// </summary>
    [MetadataType(typeof(MemberMD))]
    public partial class Member
    {
    
    	/// <summary>
    	/// Member Metadata class
    	/// </summary>
    	public class MemberMD
    	{
    		    
    		/// <summary>
    		/// Id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("Id", typeof(WebAPIResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(WebAPIResource))]
            [MaxLength(10, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(WebAPIResource))]
    		public string Id { get; set; }
    
    		    
    		/// <summary>
    		/// password
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("password", typeof(WebAPIResource))]
            [DataType(DataType.Password)]
            public string password { get; set; }
    
    		    
    		/// <summary>
    		/// memguid
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("memguid", typeof(WebAPIResource))]
    		public string memguid { get; set; }
    
    		    
    	}
    }
    
}
