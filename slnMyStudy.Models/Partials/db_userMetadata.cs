using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// db_user class
    /// </summary>
    [MetadataType(typeof(db_userMD))]
    public partial class db_user
    {
    
    	/// <summary>
    	/// db_user Metadata class
    	/// </summary>
    	public class db_userMD
    	{
    		    
    		/// <summary>
    		/// id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int id { get; set; }
    
    		    
    		/// <summary>
    		/// real_name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("real_name", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string real_name { get; set; }
    
    		    
    		/// <summary>
    		/// name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("name", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string name { get; set; }
    
    		    
    		/// <summary>
    		/// password
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("password", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(256, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string password { get; set; }
    
    		    
    		/// <summary>
    		/// sex
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("sex", typeof(testResource))]
            [MaxLength(2, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string sex { get; set; }
    
    		    
    		/// <summary>
    		/// email
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("email", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string email { get; set; }
    
    		    
    		/// <summary>
    		/// rank
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("rank", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int rank { get; set; }
    
    		    
    		/// <summary>
    		/// Update Right
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("UpdateRight", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string UpdateRight { get; set; }
    
    		    
    		/// <summary>
    		/// Delete Right
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("DeleteRight", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(1, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string DeleteRight { get; set; }
    
    		    
    	}
    }
    
}
