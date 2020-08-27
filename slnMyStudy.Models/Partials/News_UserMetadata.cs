using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// News_User class
    /// </summary>
    [MetadataType(typeof(News_UserMD))]
    public partial class News_User
    {
    
    	/// <summary>
    	/// News_User Metadata class
    	/// </summary>
    	public class News_UserMD
    	{
    		    
    		/// <summary>
    		/// User_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("User_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int User_id { get; set; }
    
    		    
    		/// <summary>
    		/// User_ Real_ Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("User_Real_Name", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string User_Real_Name { get; set; }
    
    		    
    		/// <summary>
    		/// User_ Account
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("User_Account", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string User_Account { get; set; }
    
    		    
    		/// <summary>
    		/// User_ Password
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("User_Password", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string User_Password { get; set; }
    
    		    
    		/// <summary>
    		/// User_ Rank
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("User_Rank", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int User_Rank { get; set; }
    
    		    
    		/// <summary>
    		/// User_email
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("User_email", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string User_email { get; set; }
    
    		    
    	}
    }
    
}
