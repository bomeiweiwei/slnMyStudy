using slnMyStudy.Common;
using slnMyStudy.Resource.App_GlobalResources;
using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace slnMyStudy.Models
{
    
    /// <summary>
    /// FileUpload_DB class
    /// </summary>
    [MetadataType(typeof(FileUpload_DBMD))]
    public partial class FileUpload_DB
    {
    
    	/// <summary>
    	/// FileUpload_DB Metadata class
    	/// </summary>
    	public class FileUpload_DBMD
    	{
    		    
    		/// <summary>
    		/// File Upload_ DB_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("FileUpload_DB_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int FileUpload_DB_id { get; set; }
    
    		    
    		/// <summary>
    		/// File Upload_time
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("FileUpload_time", typeof(testResource))]
    		public Nullable<System.DateTime> FileUpload_time { get; set; }
    
    		    
    		/// <summary>
    		/// test_id
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("test_id", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
    		public int test_id { get; set; }
    
    		    
    		/// <summary>
    		/// File Upload_ File Name
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("FileUpload_FileName", typeof(testResource))]
            [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string FileUpload_FileName { get; set; }
    
    		    
    		/// <summary>
    		/// File Upload_ Memo
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("FileUpload_Memo", typeof(testResource))]
            [MaxLength(250, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string FileUpload_Memo { get; set; }
    
    		    
    		/// <summary>
    		/// File Upload_ User
    		/// </summary>        
    	    [ResourceTool.LocalizedDisplayName("FileUpload_User", typeof(testResource))]
            [MaxLength(50, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(testResource))]
    		public string FileUpload_User { get; set; }
    
    		    
    	}
    }
    
}
